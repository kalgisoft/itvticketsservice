#pragma checksum "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb970e817fbda4f67ac94492bb726e5e8dbfba4d"
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
    public partial class AddTicketComponentClient : Index
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mb-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "class", "form-Ticket form-horizontal");
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 77 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                                                             OnMySubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 77 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                                                                                _ticketService.TickettoInsert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((AddTicket) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n                ");
                __builder2.OpenElement(13, "label");
                __builder2.AddAttribute(14, "class", "text-danger");
                __builder2.AddContent(15, 
#nullable restore
#line 80 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                            error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "row");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-10");
                __builder2.AddMarkupContent(21, "<label class=\"small mb-1 col-10\" for=\"inputReason\">Reason</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "inputReason");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "autofocus", true);
                __builder2.AddAttribute(26, "placeholder", "Reason");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                                                      _ticketService.TickettoInsert.Reason

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _ticketService.TickettoInsert.Reason = __value, _ticketService.TickettoInsert.Reason))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _ticketService.TickettoInsert.Reason));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __Blazor.ItvTicketsService.Client.Pages.AddTicketComponentClient.TypeInference.CreateValidationMessage_0(__builder2, 31, 32, 
#nullable restore
#line 86 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                  () => _ticketService.TickettoInsert.Reason

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "row");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-10");
                __builder2.AddMarkupContent(38, "<label class=\"small mb-1 col-10\" for=\"inputPlantName\">Select Plant</label>\r\n                        ");
                __builder2.OpenElement(39, "select");
                __builder2.AddAttribute(40, "class", "form-control selectpicker");
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                                              BuildPlantDevices

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 94 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                             if (plants != null)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(42, "option");
                __builder2.AddAttribute(43, "value", "-1");
                __builder2.AddContent(44, "--select plant--");
                __builder2.CloseElement();
#nullable restore
#line 97 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                 foreach (var pl in plants)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(45, "option");
                __builder2.AddAttribute(46, "value", 
#nullable restore
#line 99 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                    pl.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(47, 
#nullable restore
#line 99 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                            pl.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 100 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "row");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-10");
                __builder2.AddMarkupContent(53, "<label class=\"small mb-1 col-10\" for=\"inputDeviceName\">Select Device</label>\r\n                        ");
                __builder2.OpenElement(54, "select");
                __builder2.AddAttribute(55, "class", "form-control selectpicker");
                __builder2.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 109 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                                         _ticketService.TickettoInsert.DeviceId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _ticketService.TickettoInsert.DeviceId = __value, _ticketService.TickettoInsert.DeviceId));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 110 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                             if (plantDevices != null)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(58, "option");
                __builder2.AddAttribute(59, "value", "-1");
                __builder2.AddContent(60, "--select device--");
                __builder2.CloseElement();
#nullable restore
#line 113 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                 foreach (var dvc in plantDevices)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(61, "option");
                __builder2.AddAttribute(62, "value", 
#nullable restore
#line 115 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                    dvc.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(63, 
#nullable restore
#line 115 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                             dvc.Code

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 116 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __Blazor.ItvTicketsService.Client.Pages.AddTicketComponentClient.TypeInference.CreateValidationMessage_1(__builder2, 65, 66, 
#nullable restore
#line 119 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
                                                  () => _ticketService.TickettoInsert.DeviceId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n                ");
                __builder2.AddMarkupContent(68, "<div class=\"row\"><div class=\"col-4\"><div class=\"form-group d-flex align-items-center justify-content-between mt-4 mb-0\"><button class=\"btn btn-primary\" type=\"submit\">Create Ticket</button></div></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\AddTicketComponentClient.razor"
       

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
namespace __Blazor.ItvTicketsService.Client.Pages.AddTicketComponentClient
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
    }
}
#pragma warning restore 1591
