#pragma checksum "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d269ead96029ce6a01b545b4ded3c3a8c8a2e45f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/devicelist")]
    public partial class DeviceList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align:center\">Device List</h1>\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudDialog>(1);
            __builder.AddAttribute(2, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                            visible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IsVisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => visible = __value, visible))));
            __builder.AddAttribute(4, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(5);
                __builder2.AddAttribute(6, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(8);
                    __builder3.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                            Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Class", "mr-3");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, " Error\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(12, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(13, "p");
                __builder2.AddContent(14, 
#nullable restore
#line 17 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
            error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(15, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(16);
                __builder2.AddAttribute(17, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 20 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                                           Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "Class", "px-10");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(22, "Close");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "container");
            __builder.OpenElement(26, "main");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row g-5");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, 
#nullable restore
#line 28 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row g-5");
            __builder.OpenElement(34, "p");
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "id", "search-add");
            __builder.OpenElement(37, "tr");
            __builder.OpenElement(38, "td");
            __builder.OpenComponent<MudBlazor.MudLink>(39);
            __builder.AddAttribute(40, "Href", "/deviceaddedit/0");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Add a Device");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n                    ");
            __builder.OpenElement(44, "tr");
            __builder.OpenElement(45, "td");
            __builder.OpenComponent<MudBlazor.MudLink>(46);
            __builder.AddAttribute(47, "Href", "/");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(49, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row g-5");
#nullable restore
#line 52 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
             if (devices == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<p style=\"text-align:center\"><img src=\"../images/loader.gif\"></p>");
#nullable restore
#line 55 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __Blazor.ItvTicketsService.Client.Pages.DeviceList.TypeInference.CreateMudTable_0(__builder, 54, 55, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                  devices

#line default
#line hidden
#nullable disable
            , 56, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                  true

#line default
#line hidden
#nullable disable
            , 57, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                                    Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 58, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                                                            false

#line default
#line hidden
#nullable disable
            , 59, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(60);
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(62, "Edit");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, "Id");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(68);
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(70, "Code");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(72);
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(74, "Type");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, "Info");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(80);
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(82, "Plant Owner");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(84);
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(86, "Line Num");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(88);
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Contractor Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(92);
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(94, "Delete");
                }
                ));
                __builder2.CloseComponent();
            }
            , 95, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(96);
                __builder2.AddAttribute(97, "DataLabel", "Edit");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(99, "a");
                    __builder3.AddAttribute(100, "href", "deviceaddedit/" + (
#nullable restore
#line 72 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                    context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenComponent<MudBlazor.MudIcon>(101);
                    __builder3.AddAttribute(102, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                Icons.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 73 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                                          Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "Title", "Edit");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(106);
                __builder2.AddAttribute(107, "DataLabel", "Id");
                __builder2.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(109, 
#nullable restore
#line 76 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                               context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(111);
                __builder2.AddAttribute(112, "DataLabel", "Code");
                __builder2.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(114, 
#nullable restore
#line 77 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                 context.Code

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(116);
                __builder2.AddAttribute(117, "DataLabel", "Type");
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(119, 
#nullable restore
#line 78 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                 context.Type

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(121);
                __builder2.AddAttribute(122, "DataLabel", "Info");
                __builder2.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(124, 
#nullable restore
#line 79 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                 context.Info

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(126);
                __builder2.AddAttribute(127, "DataLabel", "Plant Owner");
                __builder2.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 81 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                             if (@dictPlants.ContainsKey(context.PlantId))
                                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(129, 
#nullable restore
#line 82 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                 dictPlants[context.PlantId]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(131);
                __builder2.AddAttribute(132, "DataLabel", "Line Num");
                __builder2.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(134, 
#nullable restore
#line 84 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                     context.NumLinea

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(135, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(136);
                __builder2.AddAttribute(137, "DataLabel", "Contractor");
                __builder2.AddAttribute(138, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 86 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                             if (dictContractors.ContainsKey(context.IdContractor))
                                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(139, 
#nullable restore
#line 87 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                 dictContractors[context.IdContractor]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(140, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(141);
                __builder2.AddAttribute(142, "DataLabel", "Delete");
                __builder2.AddAttribute(143, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(144);
                    __builder3.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                       () => Delete(context.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(146, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
                                                                                         Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(147, "aria-label", "delete");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 94 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n\r\n        ");
            __builder.AddMarkupContent(149, "<div class=\"row g-5\"><p></p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 185 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\DeviceList.razor"
       
    Dictionary<int, string> dictPlants = new Dictionary<int, string>();
    Dictionary<int, string> dictContractors = new Dictionary<int, string>();

    List<Device> devices;
    List<Contractor> contractors;

    private bool visible = false;
    private string error = string.Empty;


    protected override async Task OnInitializedAsync()
    {
        //Populate the list of devices objects from the Devices table.
        devices = await DeviceService.GetDeviceList();
        contractors = await ContractorsService.GetContractorsList();

        //in futuro si puo fare una vista sul database...
        foreach (var dev in devices)
        {
            if (dev.PlantId != 0)
            {
                var cmp = await PlantService.Plant_GetOne(dev.PlantId);

                if (!dictPlants.ContainsKey(dev.PlantId))
                    dictPlants.Add(dev.PlantId, cmp.Name);
            }
        }

        dictContractors = contractors.Distinct().ToDictionary(x => x.Id, x => x.Name);
    }

    //Executes if user confirms the deletion.
    protected async Task Delete(int id)
    {
        var parameters = new DialogParameters();
        parameters.Add("ContentText", $"Do you really want to delete device id={ id }? This process cannot be undone.");
        parameters.Add("ButtonText", "Delete");
        parameters.Add("Color", Color.Error);

        var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<ItvModalDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            try
            {
                await DeviceService.DeviceDelete(id);

                //reload
                await OnInitializedAsync();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                OpenDialog();
            }
        }
    }

    private void OpenDialog() => visible = true;

    void Submit()
    {
        error = string.Empty;
        visible = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDeviceService DeviceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContractorsService ContractorsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService PlantService { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.DeviceList
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
