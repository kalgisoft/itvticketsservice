#pragma checksum "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe517a07255f4de0b6f971889d2b6aba74b0e33c"
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
#line 1 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class AddTicketComponent : Index
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-12");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mb-4");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><div style=\"float:left\"><i class=\"fas fa-plus-square mr-1\"></i>\r\n                Add ticket\r\n            </div></div>\r\n\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "class", "form-Ticket form-horizontal");
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                                             OnMySubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                                                                _ticketService.TickettoInsert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((AddTicket) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "label");
                __builder2.AddAttribute(15, "class", "text-danger");
                __builder2.AddContent(16, 
#nullable restore
#line 16 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                            error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-row");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-4");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label class=\"small mb-1\" for=\"inputClient\">Client</label>\r\n                            ");
                __builder2.OpenElement(25, "select");
                __builder2.AddAttribute(26, "class", "form-control selectpicker");
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                                  BuildUserPlants

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 24 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                 if (users != null)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(28, "option");
                __builder2.AddAttribute(29, "value", "-1");
                __builder2.AddContent(30, "--select client--");
                __builder2.CloseElement();
#nullable restore
#line 27 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                     foreach (var user in users)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "option");
                __builder2.AddAttribute(32, "value", 
#nullable restore
#line 29 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                        user.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(33, 
#nullable restore
#line 29 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                  user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 30 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __Blazor.ItvTicketsService.Client.Pages.AddTicketComponent.TypeInference.CreateValidationMessage_0(__builder2, 35, 36, 
#nullable restore
#line 33 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                      () => _ticketService.TickettoInsert.ClientId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-md-4");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label class=\"small mb-1\" for=\"inputCompanyName\">Select Plant</label>\r\n                            ");
                __builder2.OpenElement(43, "select");
                __builder2.AddAttribute(44, "class", "form-control selectpicker");
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 40 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                                  BuildPlantDevices

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 41 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                 if (userPlants != null)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(46, "option");
                __builder2.AddAttribute(47, "value", "-1");
                __builder2.AddContent(48, "--select plant--");
                __builder2.CloseElement();
#nullable restore
#line 44 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                     foreach (var idpl in userPlants)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 46 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                        idpl

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 47 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                             if (dictPlants.ContainsKey(idpl))
                                                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(51, 
#nullable restore
#line 48 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                 dictPlants[idpl]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 50 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-md-4");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label class=\"small mb-1\" for=\"inputDevice\">Device</label>\r\n                            ");
                __builder2.OpenElement(58, "select");
                __builder2.AddAttribute(59, "class", "form-control selectpicker");
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                             _ticketService.TickettoInsert.DeviceId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _ticketService.TickettoInsert.DeviceId = __value, _ticketService.TickettoInsert.DeviceId));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 60 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                 if (plantDevices != null)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(62, "option");
                __builder2.AddAttribute(63, "value", "-1");
                __builder2.AddContent(64, "--select device--");
                __builder2.CloseElement();
#nullable restore
#line 63 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                     foreach (var dv in plantDevices)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(65, "option");
                __builder2.AddAttribute(66, "value", 
#nullable restore
#line 65 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                        dv.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(67, 
#nullable restore
#line 65 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                dv.Code

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 66 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                            ");
                __Blazor.ItvTicketsService.Client.Pages.AddTicketComponent.TypeInference.CreateValidationMessage_1(__builder2, 69, 70, 
#nullable restore
#line 69 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                      () => _ticketService.TickettoInsert.DeviceId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n\r\n\r\n                    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-md-4");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "<label class=\"small mb-1\" for=\"inputReason\">Reason</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(77);
                __builder2.AddAttribute(78, "id", "inputReason");
                __builder2.AddAttribute(79, "class", "form-control");
                __builder2.AddAttribute(80, "autofocus", true);
                __builder2.AddAttribute(81, "placeholder", "Reason");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                                                          _ticketService.TickettoInsert.Reason

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _ticketService.TickettoInsert.Reason = __value, _ticketService.TickettoInsert.Reason))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _ticketService.TickettoInsert.Reason));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __Blazor.ItvTicketsService.Client.Pages.AddTicketComponent.TypeInference.CreateValidationMessage_2(__builder2, 86, 87, 
#nullable restore
#line 79 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
                                                      () => _ticketService.TickettoInsert.Reason

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(89, "<div class=\"col-md-4\"><div class=\"form-group d-flex align-items-center justify-content-between mt-4 mb-0\"><button class=\"btn btn-primary\" type=\"submit\">Create Ticket</button></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\AddTicketComponent.razor"
       

    [Parameter]
    public EventCallback<bool> OnRefreshParent { get; set; }

    async Task OnMySubmit()
    {

        //per refresh
        await OnRefreshParent.InvokeAsync(true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService _ticketService { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.AddTicketComponent
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
    }
}
#pragma warning restore 1591