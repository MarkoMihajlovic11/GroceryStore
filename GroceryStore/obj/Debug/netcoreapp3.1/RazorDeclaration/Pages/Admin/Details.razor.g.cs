// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GroceryStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\_Imports.razor"
using GroceryStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\marko\Desktop\IspitRoncevic\GroceryStore\Pages\Admin\Details.razor"
       
    [Inject]
    public IStoreRepository Repository { get; set; }
    [Parameter]
    public long Id { get; set; }
    public Product Product { get; set; }
    protected override void OnParametersSet()
    {
        Product = Repository.GetProducts().FirstOrDefault(p => p.ProductID == Id);
    }
    public string EditUrl => $"/admin/products/edit/{Product.ProductID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
