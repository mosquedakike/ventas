// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ventas.Components.Sales
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Ventas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Ventas.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Ventas.Components.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\enriq\source\repos\Ventas\Ventas\_Imports.razor"
using Ventas.Pages.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\enriq\source\repos\Ventas\Ventas\Components\Sales\CreateSaleComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\Ventas\Ventas\Components\Sales\CreateSaleComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateSaleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\enriq\source\repos\Ventas\Ventas\Components\Sales\CreateSaleComponent.razor"
       
    SaleEntity oSale = new SaleEntity();
    ProductEntity oProduct = new ProductEntity();

    List<ProductEntity> products = new List<ProductEntity>();
    List<EmployeeEntity> employees = new List<EmployeeEntity>();

    protected override async Task OnInitializedAsync()
    {
        products = B_Product.ProductList();
        employees = B_Employee.EmployeeList();
    }

    private void SaveSale()
    {
        oSale.ProductId = 1;
        oSale.SaleDateUser = DateTime.Now;
        oSale.SaleDate = DateTime.Now;
        B_Sale.CreateSale(oSale);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
