#pragma checksum "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462610a63021976fd66b0eebff863092d43cab0c"
// <auto-generated/>
#pragma warning disable 1591
namespace ItvTicketsService.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/useraddeditplants/{Id:int}")]
    public partial class UserAddEditPlants : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "text-align:center");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                               pagetitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-2");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control selectpicker");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                             selPlant

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selPlant = __value, selPlant));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(14, "option");
            __builder.AddContent(15, "--select plant--");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                 if (plants != null)
                {
                    foreach (var pl in plants)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 19 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                        pl.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, 
#nullable restore
#line 19 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                pl.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-4");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                       AddSelection

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Add Plant");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n    <br>\r\n    <br>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(27);
            __builder.AddAttribute(28, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 33 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                      user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 33 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                            Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(30, "class", "form-inline");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "row");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-12 errormsg");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(38);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-12 buttons");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "class", "btn btn-primary");
                __builder2.AddAttribute(46, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 43 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                            Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, 
#nullable restore
#line 43 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                                   buttontext

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-secondary");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                             Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "id", "list");
#nullable restore
#line 54 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
     if (plants == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<p style=\"text-align:center\"><img src=\"../images/loader.gif\"></p>");
#nullable restore
#line 59 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __Blazor.ItvTicketsService.Client.Pages.UserAddEditPlants.TypeInference.CreateMudTable_0(__builder, 57, 58, 
#nullable restore
#line 62 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                          tmpUserPlants

#line default
#line hidden
#nullable disable
            , 59, 
#nullable restore
#line 62 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                true

#line default
#line hidden
#nullable disable
            , 60, 
#nullable restore
#line 62 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                                  Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 61, 
#nullable restore
#line 62 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                                                          false

#line default
#line hidden
#nullable disable
            , 62, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(63);
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(65, "Id");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudTh>(67);
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, "Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudTh>(71);
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(73, "Delete");
                }
                ));
                __builder2.CloseComponent();
            }
            , 74, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(75);
                __builder2.AddAttribute(76, "DataLabel", "Id");
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, 
#nullable restore
#line 69 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                       context

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudTd>(80);
                __builder2.AddAttribute(81, "DataLabel", "Name");
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 71 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                     if (@dictPlants.ContainsKey(context))
                        

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(83, 
#nullable restore
#line 72 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                         dictPlants[context]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudTd>(85);
                __builder2.AddAttribute(86, "DataLabel", "Delete");
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(88);
                    __builder3.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                               () => RemovePlant(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
                                                                                   Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "aria-label", "Remove");
                    __builder3.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(93, "Remove");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 109 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\UserAddEditPlants.razor"
       
    UserInfo user = new UserInfo();
    int selPlant;
    List<Plant> plants;

    public Dictionary<int, string> dictPlants = new Dictionary<int, string>();

    HashSet<int> tmpUserPlants = new HashSet<int>();

    [Parameter]
    public int Id { get; set; }

    // Set default page title and button text
    public string pagetitle = "Change User Plants";
    public string buttontext = "Change";

    //Executes on page open, set defaults on page.
    protected override async Task OnInitializedAsync()
    {
        plants = await _plantService.GetPlantList();
        dictPlants = plants.Distinct().ToDictionary(x => x.Id, x => x.Name);

        // ============ If the passed-in Id is zero, assume new Plant.
        if (Id == 0)
        {
            // Use this block to set for defaults (optional)
        }
        else
        {
            user = await _userInfoService.UserInfo_GetOne(Id);

            foreach (int plid in user.Plants)
            {
                tmpUserPlants.Add(plid);
            }

            // Change page title and button text since this is an edit.
            pagetitle = $"Change {user.UserName} Plants";
            buttontext = "Save";
        }
    }

    // Executes OnValidSubmit of EditForm above.
    protected async Task Save()
    {
        //remove client plants from table
        await _userInfoService.UserInfo_DeleteAll(Id);


        //add user plants to table
        foreach (var itm in tmpUserPlants)
        {
            await _userInfoService.UserInfo_Upsert(Id, itm);
        }

        NavigationManager.NavigateTo("/userlist");
    }

    //Executes if user clicks the Cancel button.
    protected void Cancel()
    {
        NavigationManager.NavigateTo("/userlist");
    }

    protected void AddSelection()
    {
        tmpUserPlants.Add(selPlant);

        //aggiornare
        StateHasChanged();
    }

    protected void RemovePlant(int id)
    {
        tmpUserPlants.Remove(id);

        //aggiornare
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService _plantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserInfoService _userInfoService { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.UserAddEditPlants
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "Loading", __arg3);
        __builder.AddAttribute(__seq4, "HeaderContent", __arg4);
        __builder.AddAttribute(__seq5, "RowTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591