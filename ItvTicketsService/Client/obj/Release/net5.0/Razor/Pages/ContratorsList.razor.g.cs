#pragma checksum "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3c1d83890b1c9adca82d50461e5f72d7fe5dc14"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/contractorslist")]
    public partial class ContratorsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align:center\">Contractors List</h1>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudDialog>(1);
            __builder.AddAttribute(2, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
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
#line 10 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(8);
                    __builder3.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                            Icons.Material.Filled.Error

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
#line 15 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
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
#line 18 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 18 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
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
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "container");
            __builder.OpenElement(26, "main");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row g-5");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, 
#nullable restore
#line 27 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
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
            __builder.AddAttribute(40, "Href", "/contractorsaddedit/0");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Add a Contractor");
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
#line 51 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
             if (contractors == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<p style=\"text-align:center\"><img src=\"../images/loader.gif\"></p>");
#nullable restore
#line 54 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __Blazor.ItvTicketsService.Client.Pages.ContratorsList.TypeInference.CreateMudTable_0(__builder, 54, 55, 
#nullable restore
#line 57 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                  contractors

#line default
#line hidden
#nullable disable
            , 56, 
#nullable restore
#line 57 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                      true

#line default
#line hidden
#nullable disable
            , 57, 
#nullable restore
#line 57 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                                        Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 58, 
#nullable restore
#line 57 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
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
                    __builder3.AddContent(70, "Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(72);
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(74, "Delete");
                }
                ));
                __builder2.CloseComponent();
            }
            , 75, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(76);
                __builder2.AddAttribute(77, "DataLabel", "Edit");
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(79, "a");
                    __builder3.AddAttribute(80, "href", "contractorsaddedit/" + (
#nullable restore
#line 66 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                         context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenComponent<MudBlazor.MudIcon>(81);
                    __builder3.AddAttribute(82, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                Icons.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 67 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                                          Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "Title", "Edit");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(86);
                __builder2.AddAttribute(87, "DataLabel", "Id");
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(89, 
#nullable restore
#line 70 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                               context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(91);
                __builder2.AddAttribute(92, "DataLabel", "Name");
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(94, 
#nullable restore
#line 71 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                 context.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(96);
                __builder2.AddAttribute(97, "DataLabel", "Delete");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(99);
                    __builder3.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                       () => Delete(context.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
                                                                                         Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "aria-label", "delete");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 77 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n        ");
            __builder.AddMarkupContent(104, "<div class=\"row g-5\"><p></p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 154 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\ContratorsList.razor"
       
    private bool visible = false;
    private string error = string.Empty;

    // Create an empty list, named plants, of empty Plant objects.
    List<Contractor> contractors;

    protected override async Task OnInitializedAsync()
    {
        //Populate the list of contractors objects from the contractors table.
        contractors = await ContractorsService.GetContractorsList();
    }

    //Executes if user confirms the deletion.
    protected async Task Delete(int id)
    {
        var parameters = new DialogParameters();
        parameters.Add("ContentText", $"Do you really want to delete contractor id={ id }? This process cannot be undone.");
        parameters.Add("ButtonText", "Delete");
        parameters.Add("Color", Color.Error);

        var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<ItvModalDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            try
            {
                var res = await ContractorsService.ContractorsDelete(id);

                if (res.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    error = await res.Content.ReadAsStringAsync();
                    OpenDialog();
                }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContractorsService ContractorsService { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.ContratorsList
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