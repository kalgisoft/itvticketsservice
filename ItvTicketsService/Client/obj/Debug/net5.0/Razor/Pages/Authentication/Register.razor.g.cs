#pragma checksum "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "591583d4332aedfb9638731ebbd21237635d5e81"
// <auto-generated/>
#pragma warning disable 1591
namespace ItvTicketsService.Client.Pages.Authentication
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Register) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "col-lg-7");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "card shadow-lg border-0 rounded-lg mt-5");
                __builder2.AddMarkupContent(7, "<div class=\"card-header\"><h3 class=\"text-center font-weight-light my-2\">Create Account</h3></div>\r\n                ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
                __builder2.AddAttribute(11, "class", "form-register form-horizontal");
                __builder2.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                                                   OnSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                                                                    registerRequest

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n                        ");
                    __builder3.OpenElement(17, "label");
                    __builder3.AddAttribute(18, "class", "text-danger");
                    __builder3.AddContent(19, 
#nullable restore
#line 15 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                    error

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n\r\n                        ");
                    __builder3.OpenElement(21, "div");
                    __builder3.AddAttribute(22, "class", "form-group");
                    __builder3.AddMarkupContent(23, "<label class=\"small mb-1\" for=\"inputEmailAddress\">User Name</label>\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                    __builder3.AddAttribute(25, "id", "inputUsername");
                    __builder3.AddAttribute(26, "class", "form-control py-4");
                    __builder3.AddAttribute(27, "placeholder", "User name");
                    __builder3.AddAttribute(28, "autofocus", true);
                    __builder3.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                                                                                                    registerRequest.UserName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerRequest.UserName = __value, registerRequest.UserName))));
                    __builder3.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerRequest.UserName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n                            ");
                    __Blazor.ItvTicketsService.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_0(__builder3, 33, 34, 
#nullable restore
#line 20 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                      () => registerRequest.UserName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n                        ");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "class", "form-row");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "col-md-6");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "form-group");
                    __builder3.AddMarkupContent(42, "<label class=\"small mb-1\" for=\"inputPassword\">Password</label>\r\n                                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                    __builder3.AddAttribute(44, "type", "password");
                    __builder3.AddAttribute(45, "id", "inputPassword");
                    __builder3.AddAttribute(46, "class", "form-control py-4");
                    __builder3.AddAttribute(47, "placeholder", "Password");
                    __builder3.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                                                                                                                 registerRequest.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerRequest.Password = __value, registerRequest.Password))));
                    __builder3.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerRequest.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n                                    ");
                    __Blazor.ItvTicketsService.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_1(__builder3, 52, 53, 
#nullable restore
#line 27 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                              () => registerRequest.Password

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n                            ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-6");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "class", "form-group");
                    __builder3.AddMarkupContent(59, "<label class=\"small mb-1\" for=\"inputPasswordConfirm\">Password Confirmation</label>\r\n                                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                    __builder3.AddAttribute(61, "type", "password");
                    __builder3.AddAttribute(62, "id", "inputPasswordConfirm");
                    __builder3.AddAttribute(63, "class", "form-control py-4");
                    __builder3.AddAttribute(64, "placeholder", "Password Confirmation");
                    __builder3.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                                                                                                                                     registerRequest.PasswordConfirm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerRequest.PasswordConfirm = __value, registerRequest.PasswordConfirm))));
                    __builder3.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerRequest.PasswordConfirm));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n                                    ");
                    __Blazor.ItvTicketsService.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_2(__builder3, 69, 70, 
#nullable restore
#line 34 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                              () => registerRequest.PasswordConfirm

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n                        ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "form-group");
#nullable restore
#line 39 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                             if (plants != null)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(74, "select");
                    __builder3.AddAttribute(75, "class", "form-control selectpicker");
                    __builder3.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                                                 registerRequest.PlantId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerRequest.PlantId = __value, registerRequest.PlantId));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.OpenElement(78, "option");
                    __builder3.AddContent(79, "--select plant--");
                    __builder3.CloseElement();
#nullable restore
#line 43 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                     foreach (var pl in plants)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(80, "option");
                    __builder3.AddAttribute(81, "value", 
#nullable restore
#line 45 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                        pl.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(82, 
#nullable restore
#line 45 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                                pl.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 46 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __Blazor.ItvTicketsService.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_3(__builder3, 83, 84, 
#nullable restore
#line 49 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                                                          () => registerRequest.PlantId

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 50 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(86, "<div class=\"form-group mt-4 mb-0\"><button class=\"btn btn-primary btn-block\" type=\"submit\">Create account</button></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                ");
                __builder2.AddMarkupContent(88, "<div class=\"card-footer text-center\"><div class=\"small\"><a href=\"/\">Back to tickets history</a></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Authentication\Register.razor"
       
    // Create an empty list, named plants, of empty Plant objects.
    List<Plant> plants;

    /// <summary>
    /// registration model
    /// </summary>
    RegisterRequest registerRequest { get; set; } = new RegisterRequest();
    string error { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //Populate the list of plant objects from the Plant table.
        plants = await PlantService.GetPlantList();
    }

    /// <summary>
    /// Valdiates user and register new user. takes user details as input.
    /// </summary>
    /// <returns></returns>
    async Task OnSubmit()
    {
        try
        {
            await authStateProvider.Register(registerRequest);
            error = "User registered successfully.";
            navigationManager.NavigateTo("/register");
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService PlantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.Authentication.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
