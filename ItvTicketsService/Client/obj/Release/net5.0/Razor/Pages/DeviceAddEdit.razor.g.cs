#pragma checksum "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc5a179f66bdfc48134ded471fd1a5823b2bbc7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/deviceaddedit/{Id:int}")]
    public partial class DeviceAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "text-align:center");
            __builder.AddContent(2, 
#nullable restore
#line 7 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                               pagetitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                  device

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                          Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "class", "form-inline");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row");
                __builder2.AddMarkupContent(13, "<div class=\"col-2\"><label for=\"Code\">Code:</label></div>\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "id", "Code");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                        device.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => device.Code = __value, device.Code))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => device.Code));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row");
                __builder2.AddMarkupContent(25, "<div class=\"col-2\"><label for=\"Type\">Type:</label></div>\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "id", "Type");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                        device.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => device.Type = __value, device.Type))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => device.Type));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "row");
                __builder2.AddMarkupContent(37, "<div class=\"col-2\"><label for=\"Info\">Info:</label></div>\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "id", "Info");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                        device.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => device.Info = __value, device.Info))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => device.Info));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row");
                __builder2.AddMarkupContent(49, "<div class=\"col-2\"><label for=\"Id\">Plant Owner:</label></div>\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-4");
                __builder2.OpenElement(52, "select");
                __builder2.AddAttribute(53, "class", "form-control selectpicker");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                                 device.PlantId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => device.PlantId = __value, device.PlantId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(56, "option");
                __builder2.AddContent(57, "--select plant--");
                __builder2.CloseElement();
#nullable restore
#line 46 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                     foreach (var cmp in plants)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(58, "option");
                __builder2.AddAttribute(59, "value", 
#nullable restore
#line 48 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                        cmp.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(60, 
#nullable restore
#line 48 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                 cmp.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 49 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "row");
                __builder2.AddMarkupContent(64, "<div class=\"col-2\"><label for=\"Type\">Line:</label></div>\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-4");
                __Blazor.ItvTicketsService.Client.Pages.DeviceAddEdit.TypeInference.CreateInputNumber_0(__builder2, 67, 68, "form-control", 69, "Type", 70, 
#nullable restore
#line 59 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                          device.NumLinea

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => device.NumLinea = __value, device.NumLinea)), 72, () => device.NumLinea);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n\r\n        ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "row");
                __builder2.AddMarkupContent(76, "<div class=\"col-2\"><label for=\"Id\">Device Contractor:</label></div>\r\n            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-4");
                __builder2.OpenElement(79, "select");
                __builder2.AddAttribute(80, "class", "form-control selectpicker");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                                 device.IdContractor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => device.IdContractor = __value, device.IdContractor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(83, "option");
                __builder2.AddContent(84, "--select contractor--");
                __builder2.CloseElement();
#nullable restore
#line 70 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                     foreach (var cntr in contractors)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(85, "option");
                __builder2.AddAttribute(86, "value", 
#nullable restore
#line 72 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                        cntr.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(87, 
#nullable restore
#line 72 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                  cntr.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 73 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "row");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-12 errormsg");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(93);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(95);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "row");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-12 buttons");
                __builder2.OpenElement(101, "button");
                __builder2.AddAttribute(102, "class", "btn btn-primary");
                __builder2.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                           DevInfo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(104, "Device Info");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col-12 buttons");
                __builder2.OpenElement(108, "button");
                __builder2.AddAttribute(109, "class", "btn btn-primary");
                __builder2.AddAttribute(110, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 92 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                            Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(111, 
#nullable restore
#line 92 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                                   buttontext

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenElement(113, "button");
                __builder2.AddAttribute(114, "class", "btn btn-secondary");
                __builder2.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
                                                             Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(116, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceAddEdit.razor"
       
    List<Plant> plants = new List<Plant>();
    List<Contractor> contractors = new List<Contractor>();

    // Create a new, empty Device object
    Device device = new Device();

    [Parameter]
    public int Id { get; set; }

    // Set default page title and button text
    public string pagetitle = "Add a Device";
    public string buttontext = "Add";

    //Executes on page open, set defaults on page.
    protected override async Task OnInitializedAsync()
    {
        plants = await PlantService.GetPlantList();
        contractors = await ContractorsService.GetContractorsList();

        // ============ If the passed-in Id is zero, assume new Plant.
        if (Id == 0)
        {
            // Use this block to set for defaults (optional)
        }
        else
        {
            device = await DeviceService.Device_GetOne(Id);
            // Change page title and button text since this is an edit.
            pagetitle = "Edit Device";
            buttontext = "Update";
        }
    }

    // Executes OnValidSubmit of EditForm above.
    protected async Task Save()
    {
        if (device.Id == 0)
        {
            // Insert if Id is zero.

            //valore di defalt, ci deve sempre essere
            device.IdContractor = 1;

            await DeviceService.DeviceInsert(device);
        }
        else
        {
            // Update if Id not 0
            await DeviceService.DeviceUpdate(device);
        }
        NavigationManager.NavigateTo("/devicelist");
    }

    //Executes if user clicks the Cancel button.
    protected void Cancel()
    {
        NavigationManager.NavigateTo("/devicelist");
    }

    // Executes OnValidSubmit of EditForm above.
    protected void DevInfo()
    {
        NavigationManager.NavigateTo("/deviceinfoaddedit/" + device.Code);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContractorsService ContractorsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService PlantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDeviceService DeviceService { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.DeviceAddEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
