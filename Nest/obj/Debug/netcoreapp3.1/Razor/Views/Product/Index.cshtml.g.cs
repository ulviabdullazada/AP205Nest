#pragma checksum "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f791d1f1cd49962e35411c4ffa49c83634ee3c4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\_ViewImports.cshtml"
using Nest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\_ViewImports.cshtml"
using Nest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\_ViewImports.cshtml"
using Nest.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f791d1f1cd49962e35411c4ffa49c83634ee3c4d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f179a24b854245fd9fc1b0f7015f87d38712ba87", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n    <style>\r\n        .product-img .default-img, .product-img .hover-img{\r\n            width:190px;\r\n            height:190px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<div class=\"container mt-30\">\r\n    <div class=\"row flex-row-reverse\">\r\n        <div class=\"col-lg-4-5\">\r\n            <div class=\"row product-grid\">\r\n                ");
#nullable restore
#line 17 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
           Write(await Component.InvokeAsync("Product",new {page=(ViewBag.Page==null?1: ViewBag.Page) }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                <!--end product card-->\r\n            </div>\r\n");
            WriteLiteral(@"            <!--product grid-->
            
            <!--End Deals-->
        </div>
        <div class=""col-lg-1-5 primary-sidebar sticky-sidebar"">
            <div class=""sidebar-widget widget-category-2 mb-30"">
                <h5 class=""section-title style-1 mb-30"">Category</h5>
                <ul>
");
#nullable restore
#line 33 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
                     foreach (Category item in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"category-filter\" data-id=\"");
#nullable restore
#line 35 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <a> <img");
            BeginWriteAttribute("src", " src=\"", 1388, "\"", 1421, 2);
            WriteAttributeValue("", 1394, "assets/imgs/shop/", 1394, 17, true);
#nullable restore
#line 36 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
WriteAttributeValue("", 1411, item.Logo, 1411, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1422, "\"", 1428, 0);
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 36 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span class=\"count\">");
#nullable restore
#line 36 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
                                                                                                             Write(item.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n");
#nullable restore
#line 38 "C:\Users\ULVI\Desktop\AP205 Backend\Nest\Nest\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <!-- Fillter By Price -->
            <div class=""sidebar-widget price_range range mb-30"">
                <h5 class=""section-title style-1 mb-30"">Fill by price</h5>
                <div class=""price-filter"">
                    <div class=""price-filter-inner"">
                        <div id=""slider-range"" class=""mb-20""></div>
                        <div class=""d-flex justify-content-between"">
                            <div class=""caption"">From: <strong id=""slider-range-value1"" class=""text-brand""></strong></div>
                            <div class=""caption"">To: <strong id=""slider-range-value2"" class=""text-brand""></strong></div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Product sidebar Widget -->
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).on(""click"", ""#btnLoadMore"", function () {
            let skip = $("".product-grid"").children().length;
            let prodCount = $(""#proCount"").val();
            $.ajax({
                url: ""/Product/LoadMore"",
                method: 'GET',
                data: {
                    skip: skip
                },
                success: function (res) {
                    $("".product-grid"").append(res);
                    if ($("".product-grid"").children().length >= prodCount) {
                        $(""#btnLoadMore"").remove();
                    }
                }
            })
        })
        $(document).on(""click"", "".category-filter"", function () {
            let id = $(this).attr(""data-id"");
            $.ajax({
                url: ""/Product/CategoryFilter"",
                method: 'GET',
                data: {
                    CategoryId: id
                },
                success: function (res) {
                   ");
                WriteLiteral(@" $("".product-grid"").html(res);
                    //if ($("".product-grid"").children().length >= prodCount) {
                    //    $(""#btnLoadMore"").remove();
                    //}
                }
            })
        })
    </script>
    <!--<script>
        $(""#btnLoadMore"").click(function () {
            $.ajax({
                url: '/Product/LoadMore',
                method: 'GET',
                success: function (res) {
                    for (var i = 0; i < res.length; i++) {
                        var text;
                        if (res.stockCount == 0) {
                            text = '<span class=""hot"">Bitdi</span>'
                        }
                        $("".product-grid"").append(
                            `<div class=""col-lg-1-5 col-md-4 col-12 col-sm-6"">
                            <div class=""product-cart-wrap mb-30"">
                                <div class=""product-img-action-wrap"">
                                    <div class=""prod");
                WriteLiteral(@"uct-img product-img-zoom"">
                                        <a href=""shop-product-right.html"">
                                            <img class=""default-img"" width=""190"" src=""assets/imgs/shop/"" alt="""" />
                                            <img class=""hover-img"" width=""190"" src=""assets/imgs/shop/"" alt="""" />
                                        </a>
                                    </div>
                                    <div class=""product-action-1"">
                                        <a aria-label=""Add To Wishlist"" class=""action-btn"" href=""shop-wishlist.html""><i class=""fi-rs-heart""></i></a>
                                        <a aria-label=""Quick view"" class=""action-btn"" data-bs-toggle=""modal"" data-bs-target=""#quickViewModal""><i class=""fi-rs-eye""></i></a>
                                    </div>
                                    <div class=""product-badges product-badges-position product-badges-mrg"">
                                        ${text}
       ");
                WriteLiteral(@"                             </div>
                                </div>
                                <div class=""product-content-wrap"">
                                    <div class=""product-category"">
                                        <a href=""shop-grid-right.html"">${res[i].name}</a>
                                    </div>
                                    <h2><a asp-action=""Details"" asp-route-id=""${res[i].id}"">${res[i].name}</a></h2>
                                    <div class=""product-rate-cover"">
                                        <div class=""product-rate d-inline-block"">
                                            <div class=""product-rating"" style=""width: ${res[i].raiting * 20}%""></div>
                                        </div>
                                        <span class=""font-small ml-5 text-muted""> ${res[i].raiting}</span>
                                    </div>-->
");
                WriteLiteral("                                    <!--<div class=\"product-card-bottom\">\r\n                                        <div class=\"product-price\">\r\n                                            <span>${res[i].price}</span>-->\r\n");
                WriteLiteral(@"                                        <!--</div>
                                        <div class=""add-cart"">
                                            <a class=""add"" href=""shop-cart.html""><i class=""fi-rs-shopping-cart mr-5""></i>Add </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>`
                        )
                    }
                    
                }
            });
        })
    </script>-->
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
