#pragma checksum "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\IdentityUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c5e1ea682907fdd3f3f9e4bee051ac2e01ad8c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GroceryStore.Pages.Admin.Pages_Admin_IdentityUsers), @"mvc.1.0.razor-page", @"/Pages/Admin/IdentityUsers.cshtml")]
namespace GroceryStore.Pages.Admin
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
#line 2 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\_ViewImports.cshtml"
using GroceryStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\_ViewImports.cshtml"
using GroceryStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c5e1ea682907fdd3f3f9e4bee051ac2e01ad8c6", @"/Pages/Admin/IdentityUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19526ddf2d85cef2b9dc6fb5fd53cd76de927821", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_IdentityUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"bg-primary text-white text-center p-2\">Admin User</h3>\r\n\r\n<table class=\"table table-sm table-striped table-bordered\">\r\n    <tbody>\r\n        <tr><th>User</th><td>");
#nullable restore
#line 10 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\IdentityUsers.cshtml"
                        Write(Model.AdminUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Email</th><td>");
#nullable restore
#line 11 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\IdentityUsers.cshtml"
                         Write(Model.AdminUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Phone</th><td>");
#nullable restore
#line 12 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\IdentityUsers.cshtml"
                         Write(Model.AdminUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\IdentityUsers.cshtml"
           

    [Authorize]
    public class IdentityUsersModel : PageModel
    {
        private UserManager<IdentityUser> userManager;

        public IdentityUsersModel(UserManager<IdentityUser> mgr)
        {
            userManager = mgr;
        }

        public IdentityUser AdminUser { get; set; }

        public async Task OnGetAsync()
        {
            AdminUser = await userManager.FindByNameAsync("Admin");
        }
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityUsersModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel>)PageContext?.ViewData;
        public IdentityUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
