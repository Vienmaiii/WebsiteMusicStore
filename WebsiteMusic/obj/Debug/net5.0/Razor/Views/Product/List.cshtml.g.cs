#pragma checksum "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d306400b10764525060d479d6b7727ea1373cad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\_ViewImports.cshtml"
using WebsiteMusic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\_ViewImports.cshtml"
using WebsiteMusic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d306400b10764525060d479d6b7727ea1373cad", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e3ae7b18774b1e0084b3e7f2660042c815074b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<WebsiteMusic.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#?sort=p.sort_order&amp;order=ASC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#?sort=p.price&amp;order=ASC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#?sort=p.price&amp;order=DESC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default fancybox-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
  
    Category category = ViewBag.CurrentCat;
    ViewData["TiTle"] = category.Title + " " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<div class=\"main\">\r\n    <div class=\"container\">\r\n        <ul class=\"breadcrumb\">\r\n            <li><a href=\"index.html\">Home</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 503, 0);
            EndWriteAttribute();
            WriteLiteral(@">Store</a></li>
            <li class=""active"">Danh sách sản phẩm</li>
        </ul>
        <!-- BEGIN SIDEBAR & CONTENT -->
        <div class=""row margin-bottom-40"">
            <!-- BEGIN SIDEBAR -->
            <div class=""sidebar col-md-3 col-sm-5"">
                <ul class=""list-group margin-bottom-25 sidebar-menu"">
                    <li class=""list-group-item clearfix dropdown active"">
                        <a href=""javascript:void(0);"" class=""collapsed"">
                            <i class=""fa fa-angle-right""></i>
                            Guitar

                        </a>
                        <ul class=""dropdown-menu"" style=""display:block;"">
                            <li class=""list-group-item dropdown clearfix active"">
                                <a href=""javascript:void(0);"" class=""collapsed""><i class=""fa fa-angle-right""></i> Guitar thùng </a>
                                <ul class=""dropdown-menu"" style=""display:block;"">
                                    ");
            WriteLiteral(@"<li class=""list-group-item dropdown clearfix"">
                                        <a href=""javascript:void(0);""><i class=""fa fa-angle-right""></i> Guitar Classic </a>
                                    </li>
                                    <li class=""list-group-item dropdown clearfix"">
                                        <a href=""javascript:void(0);""><i class=""fa fa-angle-right""></i> Guitar Acoustic </a>
                                    </li>
                                </ul>
                            </li>
                            <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Guitar điện</a></li>
                        </ul>
                    </li>
                    <li class=""list-group-item clearfix dropdown active"">
                        <a href=""javascript:void(0);"" class=""collapsed"">
                            <i class=""fa fa-angle-right""></i>
                            Piano

                        </a>
                       ");
            WriteLiteral(@" <ul class=""dropdown-menu"" style=""display:block;"">

                            <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Piano Cơ</a></li>
                            <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Piano điện</a></li>
                        </ul>
                    </li>
                    <li class=""list-group-item clearfix dropdown active"">
                        <a href=""javascript:void(0);"" class=""collapsed"">
                            <i class=""fa fa-angle-right""></i>
                            Phụ kiện

                        </a>
                        <ul class=""dropdown-menu"" style=""display:block;"">
                            <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Phụ kiện Guitar</a></li>
                            <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Phụ kiện Piano</a></li>
                            <li><a href=""shop-product-list.html""><i ");
            WriteLiteral(@"class=""fa fa-angle-right""></i> Khác</a></li>
                        </ul>
                    </li>
                    <li class=""list-group-item clearfix dropdown active"">
                        <a href=""javascript:void(0);"" class=""collapsed"">
                            <i class=""fa fa-angle-right""></i>
                            Trống

                        </a>
                    </li>
                </ul>

                <div class=""sidebar-filter margin-bottom-25"">
                    <h2>Tìm kiếm theo giá tiền</h2>
                    <div class=""checkbox-list"">
                        <label><input type=""checkbox""> 0 - 1.000.000</label>
                        <label><input type=""checkbox""> 1.000.000 - 5.000.000</label>
                        <label><input type=""checkbox""> Hơn 5.000.000 </label>
                    </div>


                    <div id=""slider-range""></div>
                </div>


            </div>
            <!-- END SIDEBAR -->
            <!--");
            WriteLiteral(@" BEGIN CONTENT -->
            <div class=""col-md-9 col-sm-7"">
                <div class=""row list-view-sorting clearfix"">
                    <div class=""col-md-2 col-sm-2 list-view"">
                        <a href=""javascript:;""><i class=""fa fa-th-large""></i></a>
                        <a href=""javascript:;""><i class=""fa fa-th-list""></i></a>
                    </div>
                    <div class=""col-md-10 col-sm-10"">
                        <div class=""pull-right"">
                            <label class=""control-label"">Sort&nbsp;By:</label>
                            <select class=""form-control input-sm"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d306400b10764525060d479d6b7727ea1373cad12627", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d306400b10764525060d479d6b7727ea1373cad13903", async() => {
                WriteLiteral("Giá (Thấp &gt; Cao)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d306400b10764525060d479d6b7727ea1373cad15108", async() => {
                WriteLiteral("Giá (Cao &gt; Thấp)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </select>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- BEGIN PRODUCT LIST -->\r\n                <div class=\"row product-list\">\r\n");
#nullable restore
#line 114 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {
                        foreach (var item in Model)
                        {
                            if (@item.UnitsInStock.Value > 0)
                            {
                                string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                                    <div class=\"product-item\">\r\n                                        <div class=\"pi-img-wrapper\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d306400b10764525060d479d6b7727ea1373cad17318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6397, "~/images/products/", 6397, 18, true);
#nullable restore
#line 124 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 6415, item.Thumb, 6415, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 124 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 6456, item.Title, 6456, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <div>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d306400b10764525060d479d6b7727ea1373cad19453", async() => {
                WriteLiteral("Zoom");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6579, "~/images/products/", 6579, 18, true);
#nullable restore
#line 126 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 6597, item.Thumb, 6597, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6710, "\"", 6721, 1);
#nullable restore
#line 127 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
WriteAttributeValue("", 6717, url, 6717, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default fancybox-fast-view\">View</a>\r\n                                            </div>\r\n                                        </div>\r\n                                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 6922, "\"", 6933, 1);
#nullable restore
#line 130 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
WriteAttributeValue("", 6929, url, 6929, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 130 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
                                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                        <div class=\"pi-price\">");
#nullable restore
#line 131 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
                                                         Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</div>\r\n");
            WriteLiteral("                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 138 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
                <!-- END CONTENT -->
            </div>
            <!-- END SIDEBAR & CONTENT -->
            <div class=""pagination-area pt-10"">
                <ul class=""pagination justify-content-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d306400b10764525060d479d6b7727ea1373cad23359", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 149 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 149 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Alias", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\List.cshtml"
                                                                                                                                                                       WriteLiteral(category.Alias);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Alias", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<WebsiteMusic.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591