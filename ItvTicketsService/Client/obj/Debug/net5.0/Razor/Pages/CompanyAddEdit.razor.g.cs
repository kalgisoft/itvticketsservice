#pragma checksum "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c951ca8f6a8895b32d844162a588d764a436a9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/companyaddedit/{Id:int}")]
    public partial class CompanyAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "text-align:center");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
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
#line 7 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                  company

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                           CompanySave

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
                __builder2.AddMarkupContent(13, "<div class=\"col-2\"><label for=\"Name\">Name:</label></div>\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "id", "Name");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                        company.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.Name = __value, company.Name))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row");
                __builder2.AddMarkupContent(25, "<div class=\"col-2\"><label for=\"Name\">Street Adress:</label></div>\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "id", "Street");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                        company.StreetAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.StreetAddress = __value, company.StreetAddress))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.StreetAddress));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "row");
                __builder2.AddMarkupContent(37, "<div class=\"col-2\"><label for=\"Name\">City:</label></div>\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "id", "City");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                        company.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.City = __value, company.City))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row");
                __builder2.AddMarkupContent(49, "<div class=\"col-2\"><label for=\"Name\">State:</label></div>\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "id", "State");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                        company.State

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.State = __value, company.State))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.State));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "row");
                __builder2.AddMarkupContent(61, "<div class=\"col-2\"><label for=\"Name\">Zip Code:</label></div>\r\n            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "id", "ZipCode");
                __builder2.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                        company.ZipCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.ZipCode = __value, company.ZipCode))));
                __builder2.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.ZipCode));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "row");
                __builder2.AddMarkupContent(73, "<div class=\"col-2\"><label for=\"Name\">Email:</label></div>\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "id", "Email");
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                        company.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.Email = __value, company.Email))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "row");
                __builder2.AddMarkupContent(85, "<div class=\"col-2\"><label for=\"Name\">Phone:</label></div>\r\n            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "id", "Phone");
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                        company.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.Phone = __value, company.Phone))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.Phone));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "row");
                __builder2.AddMarkupContent(97, "<div class=\"col-2\"><label for=\"Name\">Ticket Amount:</label></div>\r\n            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "col-4");
                __Blazor.ItvTicketsService.Client.Pages.CompanyAddEdit.TypeInference.CreateInputNumber_0(__builder2, 100, 101, "form-control", 102, "TicketAmount", 103, 
#nullable restore
#line 77 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                          company.TicketAmount

#line default
#line hidden
#nullable disable
                , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.TicketAmount = __value, company.TicketAmount)), 105, () => company.TicketAmount);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n\r\n        ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "row");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "col-12 errormsg");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(111);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(113);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n\r\n        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "row");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "col-12 buttons");
                __builder2.OpenElement(119, "button");
                __builder2.AddAttribute(120, "class", "btn btn-primary");
                __builder2.AddAttribute(121, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 90 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                                            CompanySave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(122, 
#nullable restore
#line 90 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                                                          buttontext

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                ");
                __builder2.OpenElement(124, "button");
                __builder2.AddAttribute(125, "class", "btn btn-secondary");
                __builder2.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
                                                             Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(127, "Cancel");
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
#line 173 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\CompanyAddEdit.razor"
       
    // Create a new, empty Company object
    Company company = new Company();

    [Parameter]
    public int Id { get; set; }

    // Set default page title and button text
    public string pagetitle = "Add a Company";
    public string buttontext = "Add";

    //Executes on page open, set defaults on page.
    protected override async Task OnInitializedAsync()
    {
        // ============ If the passed-in Id is zero, assume new Company.
        if (Id == 0)
        {
            // Use this block to set for defaults (optional)
        }
        else
        {
            company = await CompanyService.Company_GetOne(Id);
            // Change page title and button text since this is an edit.
            pagetitle = "Edit Company";
            buttontext = "Update";
        }
    }
    // Executes OnValidSubmit of EditForm above.
    protected async Task CompanySave()
    {
        if (company.Id == 0)
        {
            // Insert if Id is zero.
            await CompanyService.CompanyInsert(company);
        }
        else
        {
            // Update if Id not 0
            await CompanyService.CompanyUpdate(company);
        }
        NavigationManager.NavigateTo("/companylist");
    }

    //Executes if user clicks the Cancel button.
    protected void Cancel()
    {
        NavigationManager.NavigateTo("/companylist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService CompanyService { get; set; }
    }
}
namespace __Blazor.ItvTicketsService.Client.Pages.CompanyAddEdit
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
