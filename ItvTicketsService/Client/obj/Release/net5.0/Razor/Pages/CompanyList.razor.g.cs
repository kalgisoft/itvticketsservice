#pragma checksum "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f0be97c4edcd31ffd97f35ef764fcb8f1ec229"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/companylist")]
    public partial class CompanyList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align:center\">Company List</h1>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudDialog>(1);
            __builder.AddAttribute(2, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
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
#line 11 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(8);
                    __builder3.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
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
#line 16 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
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
#line 19 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
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
#line 27 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
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
            __builder.AddAttribute(40, "Href", "/companyaddedit/0");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Add a Company");
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
#line 52 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
             if (companies == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<p style=\"text-align:center\"><img src=\"../images/loader.gif\"></p>");
#nullable restore
#line 55 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __Blazor.ItvTicketsService.Client.Pages.CompanyList.TypeInference.CreateMudTable_0(__builder, 54, 55, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                  companies

#line default
#line hidden
#nullable disable
            , 56, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 57, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                                      Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 58, 
#nullable restore
#line 58 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
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
                    __builder3.AddContent(74, "Street Address");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, "City");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(80);
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(82, "State");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(84);
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(86, "Zip Code");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(88);
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Email");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(92);
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(94, "Phone");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(96);
                __builder2.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(98, "Ticket Amount");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(100);
                __builder2.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(102, "Delete");
                }
                ));
                __builder2.CloseComponent();
            }
            , 103, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(104);
                __builder2.AddAttribute(105, "DataLabel", "Edit");
                __builder2.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(107, "a");
                    __builder3.AddAttribute(108, "href", "companyaddedit/" + (
#nullable restore
#line 74 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                     context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenComponent<MudBlazor.MudIcon>(109);
                    __builder3.AddAttribute(110, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                Icons.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(111, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 75 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                                          Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "Title", "Edit");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(114);
                __builder2.AddAttribute(115, "DataLabel", "Id");
                __builder2.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(117, 
#nullable restore
#line 78 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                               context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(118, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(119);
                __builder2.AddAttribute(120, "DataLabel", "Name");
                __builder2.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(122, 
#nullable restore
#line 79 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                 context.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(124);
                __builder2.AddAttribute(125, "DataLabel", "Street Address");
                __builder2.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(127, 
#nullable restore
#line 80 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                           context.StreetAddress

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(129);
                __builder2.AddAttribute(130, "DataLabel", "City");
                __builder2.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(132, 
#nullable restore
#line 81 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                 context.City

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(133, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(134);
                __builder2.AddAttribute(135, "DataLabel", "State");
                __builder2.AddAttribute(136, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(137, 
#nullable restore
#line 82 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                  context.State

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(139);
                __builder2.AddAttribute(140, "DataLabel", "Zip Code");
                __builder2.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(142, 
#nullable restore
#line 83 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                     context.ZipCode

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(143, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(144);
                __builder2.AddAttribute(145, "DataLabel", "Email");
                __builder2.AddAttribute(146, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(147, 
#nullable restore
#line 84 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                  context.Email

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(148, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(149);
                __builder2.AddAttribute(150, "DataLabel", "Phone");
                __builder2.AddAttribute(151, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(152, 
#nullable restore
#line 85 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                  context.Phone

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(153, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(154);
                __builder2.AddAttribute(155, "DataLabel", "Ticket Amount");
                __builder2.AddAttribute(156, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(157, 
#nullable restore
#line 86 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                          context.TicketAmount

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(158, "\r\n                        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(159);
                __builder2.AddAttribute(160, "DataLabel", "Delete");
                __builder2.AddAttribute(161, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(162);
                    __builder3.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                       () => Delete(context.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(164, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
                                                                                         Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(165, "aria-label", "delete");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 92 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n\r\n        ");
            __builder.AddMarkupContent(167, "<div class=\"row g-5\"><p></p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Pages\CompanyList.razor"
       

    // Create an empty list, named companies, of empty Company objects.
    List<Company> companies;
    private bool visible = false;
    private string error = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        //Populate the list of company objects from the Company table.
        companies = await CompanyService.GetCompanyList();
    }

    //Executes if user confirms the deletion.
    protected async Task Delete(int id)
    {
        var parameters = new DialogParameters();
        parameters.Add("ContentText", $"Do you really want to delete company id={ id }? This process cannot be undone.");
        parameters.Add("ButtonText", "Delete");
        parameters.Add("Color", Color.Error);

        var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<ItvModalDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            try
            {
                await CompanyService.CompanyDelete(id);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService CompanyService { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.CompanyList
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