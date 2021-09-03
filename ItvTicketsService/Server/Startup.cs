using ItvTicketsService.Shared.Models;
using ItvTicketsService.Server.Data;
using ItvTicketsService.Server.Logging;
using ItvTicketsService.Server.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using ItvTicketsService.Server.Services;
using ItvTicketsService.Server.Logics;

namespace ItvTicketsService.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUserStore<ApplicationUser>, UserStore>();
            services.AddTransient<IRoleStore<ApplicationRole>, RoleStore>();
            services.AddTransient<ITicketsStore<Tickets>, TicketsStore>();
            services.AddTransient<ICompanyStore<Company>, CompanyStore>();
            services.AddTransient<IPlantStore<Plant>, PlantStore>();
            services.AddTransient<IDeviceStore<Device>, DeviceStore>();
            services.AddTransient<IDeviceInfoStore<DeviceInfo>, DeviceInfoStore>();
            services.AddTransient<IUserInfoStore<UserInfo>, UserInfoStore>();
            services.AddTransient<IContractorsStore<Contractor>, ContractorsStore>();
            services.AddTransient<ILogStore<Log>, LogStore>();

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = false;
                options.Events.OnRedirectToLogin = context =>
                {
                    context.Response.StatusCode = 401;
                    return Task.CompletedTask;
                };
            });

            //services.AddControllers().AddNewtonsoftJson();
            //string conn = Configuration.GetValue<string>("AzureConnectionString");
            string conn = Configuration.GetConnectionString("AzureConnectionString");

            //services.AddSingleton(x => new BlobServiceClient(conn));
            //services.AddSingleton<IBlobService, BlobService>();

            services.AddScoped(_ => {
                return new BlobServiceClient(conn);
            });
            services.AddScoped<IFileManagerLogic, FileManagerLogic>();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var serviceProvider = app.ApplicationServices.CreateScope().ServiceProvider;
            var appDBContext = serviceProvider.GetRequiredService<ILogStore<Log>>();
            loggerFactory.AddProvider(new ApplicationLoggerProvider(appDBContext));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
