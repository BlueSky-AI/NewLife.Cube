﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Views\Shared\_Layout.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Layout.cshtml"
  
    var title = ViewBag.Title + "";
    if (title != "" && !title.Contains(" - "))
    {
        title += " - " + NewLife.Common.SysConfig.Current.DisplayName;
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(" />\r\n    ");

WriteLiteral("\r\n    <title>");

            
            #line 16 "..\..\Views\Shared\_Layout.cshtml"
      Write(title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 497), Tuple.Create("\"", 517)
, Tuple.Create(Tuple.Create("", 504), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 504), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n\r\n    <!-- 页面内联样式 -->\r\n");

WriteLiteral("    ");

            
            #line 20 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("css", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 656), Tuple.Create("\"", 706)
, Tuple.Create(Tuple.Create("", 663), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/bootstrap.min-4.4.1.css")
, 663), false)
);

WriteLiteral(" />\r\n    ");

WriteLiteral("\r\n</head>\r\n<body>\r\n    ");

WriteLiteral("\r\n\r\n    ");

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 29 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");

WriteLiteral("\r\n\r\n    ");

WriteLiteral("\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 990), Tuple.Create("\"", 1028)
, Tuple.Create(Tuple.Create("", 996), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-3.4.1.min.js")
, 996), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1052), Tuple.Create("\"", 1107)
, Tuple.Create(Tuple.Create("", 1058), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/bootstrap.bundle.min-4.4.1.js")
, 1058), false)
);

WriteLiteral("></script>\r\n    ");

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 37 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
