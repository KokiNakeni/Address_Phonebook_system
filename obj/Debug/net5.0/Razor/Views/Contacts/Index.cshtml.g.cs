#pragma checksum "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc2a78f004d47231e1438e0f97cb525b92662108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\_ViewImports.cshtml"
using ContactsAddressManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\_ViewImports.cshtml"
using ContactsAddressManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc2a78f004d47231e1438e0f97cb525b92662108", @"/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cccd7f632de3dc39644c77b0ced427f0c0d2ffee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactsAddressManagement.Models.Contact>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Index</h2>

<p>
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
        Create New Contact
    </button>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 23 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CellphoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactAddress.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactAddress.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactAddress.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactAddress.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactAddress.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem  => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CellphoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactAddress.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactAddress.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactAddress.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactAddress.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactAddress.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc2a78f004d47231e1438e0f97cb525b9266210812005", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc2a78f004d47231e1438e0f97cb525b9266210814183", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc2a78f004d47231e1438e0f97cb525b9266210816367", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 98 "C:\Users\User\Documents\Project Space\ContactsAddressManagement\Views\Contacts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">New Contact Details</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc2a78f004d47231e1438e0f97cb525b9266210819370", async() => {
                WriteLiteral(@"

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">First name:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">Surname:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">Date Of Birth:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">Cellphone Number:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">Street Name:</label>
            <input type=""text"" class=");
                WriteLiteral(@"""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">City:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">State:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">Country:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>

          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">ZipCode:</label>
            <input type=""text"" class=""form-control"" id=""recipient-name"">
          </div>
         
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"" onclick=""submitNewContact()"">Submit Contact Details</button>
      </div>
    </div>
  </div>
</div>

<script>
     
</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactsAddressManagement.Models.Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591