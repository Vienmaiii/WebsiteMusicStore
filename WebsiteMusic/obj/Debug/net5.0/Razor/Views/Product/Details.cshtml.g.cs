#pragma checksum "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b38e26a3b615bd609c9f2dcc2fd6bdf16f563be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b38e26a3b615bd609c9f2dcc2fd6bdf16f563be", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e3ae7b18774b1e0084b3e7f2660042c815074b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteMusic.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Product> lsProducts = ViewBag.SanPham;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main"">
    <div class=""container"">
        <!-- BEGIN SIDEBAR & CONTENT -->
        <div class=""row margin-bottom-40"">
            <!-- BEGIN CONTENT -->
            <div class=""col-md-9 col-sm-7"">
                <div class=""product-page"">
                    <div class=""row"">
                        <div class=""col-md-6 col-sm-6"">
                            <div class=""product-main-image"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b38e26a3b615bd609c9f2dcc2fd6bdf16f563be4419", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 639, "~/images/products/", 639, 18, true);
#nullable restore
#line 18 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 657, Model.Thumb, 657, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 699, Model.Title, 699, 12, false);

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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6 col-sm-6\">\r\n                            <h1 class=\"title\">");
#nullable restore
#line 22 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml"
                                         Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <div class=\"price-availability-block clearfix\">\r\n                                <div class=\"price\">\r\n                                    <span>");
#nullable restore
#line 25 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml"
                                     Write(Model.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"description\">\r\n                                <p>\r\n                                    ");
#nullable restore
#line 31 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml"
                               Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""product-page-cart"">
                                <div class=""product-quantity"">
                                    <input id=""txtsoLuong"" name=""txtsoLuong"" type=""text"" value=""1"" readonly class=""form-control input-sm"">
                                </div>
                                <div class=""add-to-cart"">
");
            WriteLiteral("                                    <a class=\"btn btn-custom-size lg-size btn-primary btn-secondary-hover rounded-0\" href=\"javascript:void(0)\">Thêm vào giỏ hàng</a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b38e26a3b615bd609c9f2dcc2fd6bdf16f563be8542", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 41 "C:\Users\Admon\source\repos\WebsiteMusic\WebsiteMusic\Views\Product\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                </div>

                            </div>

                            <ul class=""social-icons"">
                                <li><a class=""facebook"" data-original-title=""facebook"" href=""javascript:;""></a></li>
                                <li><a class=""twitter"" data-original-title=""twitter"" href=""javascript:;""></a></li>
                                <li><a class=""googleplus"" data-original-title=""googleplus"" href=""javascript:;""></a></li>
                                <li><a class=""evernote"" data-original-title=""evernote"" href=""javascript:;""></a></li>
                                <li><a class=""tumblr"" data-original-title=""tumblr"" href=""javascript:;""></a></li>
                            </ul>
                        </div>

                        <!--<div class=""product-page-content"">
                            <ul id=""myTab"" class=""nav nav-tabs"">
                                <li><a href=""#Description"" data-toggle=""tab"">Description</a></li>
            WriteLiteral(@"
                                <li><a href=""#Information"" data-toggle=""tab"">Information</a></li>
                                <li class=""active""><a href=""#Reviews"" data-toggle=""tab"">Reviews (2)</a></li>
                            </ul>
                            <div id=""myTabContent"" class=""tab-content"">
                                <div class=""tab-pane fade"" id=""Description"">
                                    <p>Lorem ipsum dolor ut sit ame dolore  adipiscing elit, sed sit nonumy nibh sed euismod laoreet dolore magna aliquarm erat sit volutpat Nostrud duis molestie at dolore. Lorem ipsum dolor ut sit ame dolore  adipiscing elit, sed sit nonumy nibh sed euismod laoreet dolore magna aliquarm erat sit volutpat Nostrud duis molestie at dolore. Lorem ipsum dolor ut sit ame dolore  adipiscing elit, sed sit nonumy nibh sed euismod laoreet dolore magna aliquarm erat sit volutpat Nostrud duis molestie at dolore. </p>
                                </div>
                                <div class");
            WriteLiteral(@"=""tab-pane fade"" id=""Information"">
                                    <table class=""datasheet"">
                                        <tr>
                                            <th colspan=""2"">Additional features</th>
                                        </tr>
                                        <tr>
                                            <td class=""datasheet-features-type"">Value 1</td>
                                            <td>21 cm</td>
                                        </tr>
                                        <tr>
                                            <td class=""datasheet-features-type"">Value 2</td>
                                            <td>700 gr.</td>
                                        </tr>
                                        <tr>
                                            <td class=""datasheet-features-type"">Value 3</td>
                                            <td>10 person</td>
                                        </tr>
            WriteLiteral(@"
                                        <tr>
                                            <td class=""datasheet-features-type"">Value 4</td>
                                            <td>14 cm</td>
                                        </tr>
                                        <tr>
                                            <td class=""datasheet-features-type"">Value 5</td>
                                            <td>plastic</td>
                                        </tr>
                                    </table>
                                </div>
                                <div class=""tab-pane fade in active"" id=""Reviews"">-->
                                    <!--<p>There are no reviews for this product.</p>-->
                                    <!--<div class=""review-item clearfix"">
                                        <div class=""review-item-submitted"">
                                            <strong>Bob</strong>
                                            <");
            WriteLiteral(@"em>30/12/2013 - 07:37</em>
                                            <div class=""rateit"" data-rateit-value=""5"" data-rateit-ispreset=""true"" data-rateit-readonly=""true""></div>
                                        </div>
                                        <div class=""review-item-content"">
                                            <p>Sed velit quam, auctor id semper a, hendrerit eget justo. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Duis vel arcu pulvinar dolor tempus feugiat id in orci. Phasellus sed erat leo. Donec luctus, justo eget ultricies tristique, enim mauris bibendum orci, a sodales lectus purus ut lorem.</p>
                                        </div>
                                    </div>
                                    <div class=""review-item clearfix"">
                                        <div class=""review-item-submitted"">
                                            <strong>Mary</strong>
                                 ");
            WriteLiteral(@"           <em>13/12/2013 - 17:49</em>
                                            <div class=""rateit"" data-rateit-value=""2.5"" data-rateit-ispreset=""true"" data-rateit-readonly=""true""></div>
                                        </div>
                                        <div class=""review-item-content"">
                                            <p>Sed velit quam, auctor id semper a, hendrerit eget justo. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Duis vel arcu pulvinar dolor tempus feugiat id in orci. Phasellus sed erat leo. Donec luctus, justo eget ultricies tristique, enim mauris bibendum orci, a sodales lectus purus ut lorem.</p>
                                        </div>
                                    </div>-->

                                    <!-- BEGIN FORM-->
                                    <!--<form action=""#"" class=""reviews-form"" role=""form"">
                                        <h2>Write a review</h2>
                 ");
            WriteLiteral(@"                       <div class=""form-group"">
                                            <label for=""name"">Name <span class=""require"">*</span></label>
                                            <input type=""text"" class=""form-control"" id=""name"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""email"">Email</label>
                                            <input type=""text"" class=""form-control"" id=""email"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""review"">Review <span class=""require"">*</span></label>
                                            <textarea class=""form-control"" rows=""8"" id=""review""></textarea>
                                        </div>
                                        <div class=""form-group"">
                                   ");
            WriteLiteral(@"         <label for=""email"">Rating</label>
                                            <input type=""range"" value=""4"" step=""0.25"" id=""backing5"">
                                            <div class=""rateit"" data-rateit-backingfld=""#backing5"" data-rateit-resetable=""false"" data-rateit-ispreset=""true"" data-rateit-min=""0"" data-rateit-max=""5"">
                                            </div>
                                        </div>
                                        <div class=""padding-top-20"">
                                            <button type=""submit"" class=""btn btn-primary"">Send</button>
                                        </div>
                                    </form>-->
                                    <!-- END FORM-->
                                <!--</div>
                            </div>
                        </div>-->

                        <div class=""sticker sticker-sale""></div>
                    </div>
                </div>
            </div>
            WriteLiteral("\n            <!-- END CONTENT -->\r\n        </div>\r\n        <!-- END SIDEBAR & CONTENT -->\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(function () {
                $("".add-to-cart"").click(function () {
                    var productid = $('#ProductId').val();
                    var soLuong = $('#txtsoLuong').val();
                    $.ajax({
                        url: '/api/cart/add',
                        type: ""POST"",
                        dataType: ""JSON"",
                        data: {
                            productID: productid,
                            amount: soLuong
                        },
                        success: function (response) {
                            if (response.result == 'Redirect') {
                                window.location = response.url;
                            }
                            else {
                                loadHeaderCart(); //Add Product success
                                location.reload();
                            }
                            console.lo");
                WriteLiteral(@"g(response); // log to the console to see whether it worked
                        },
                        error: function (error) {
                            alert(""There was an error posting the data to the server: "" + error.responseText);
                        }
                    });
                });

                //$("".removecart"").click(function () {
                //    var productid = $(this).attr(""data-productid"");
                //    $.ajax({
                //        url: ""api/cart/remove"",
                //        type: ""POST"",
                //        dataType: ""JSON"",
                //        data: { productID: productid },
                //        success: function (result) {
                //            if (result.success) {
                //                loadHeaderCart();//Reload lai gio hang
                //                location.reload();
                //            }
                //        },
                //        error: function ");
                WriteLiteral(@"(rs) {
                //            alert(""Remove Cart Error !"")
                //        }
                //    });
                //});
            });
            function loadHeaderCart() {
                $('#miniCart').load(""/AjaxContent/HeaderCart"");
                $('#numberCart').load(""/AjaxContent/NumberCart"");
            }
        });
    </script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteMusic.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591