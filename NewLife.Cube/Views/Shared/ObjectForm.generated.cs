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
    
    #line 1 "..\..\Views\Shared\ObjectForm.cshtml"
    using System.ComponentModel;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 2 "..\..\Views\Shared\ObjectForm.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
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
    using NewLife.Cube;
    
    #line 3 "..\..\Views\Shared\ObjectForm.cshtml"
    using NewLife.Reflection;
    
    #line default
    #line hidden
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ObjectForm.cshtml")]
    public partial class _Views_Shared_ObjectForm_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_ObjectForm_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\ObjectForm.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var Obj = Model as Object;
    var pis = ViewBag.Properties as IEnumerable<PropertyInfo>;

    var bs = this.Bootstrap();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..\Views\Shared\ObjectForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\ObjectForm.cshtml"
             using (Html.BeginForm())
            {
                
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\ObjectForm.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\ObjectForm.cshtml"
                                        
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\ObjectForm.cshtml"
           Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\ObjectForm.cshtml"
                                             
                foreach (var pi in pis)
                {
                    var name = pi.Name;
                    var dis = pi.GetDisplayName();
                    var des = pi.GetDescription();
                    if (dis.IsNullOrEmpty() && !des.IsNullOrEmpty()) { dis = des; des = null; }
                    if (!dis.IsNullOrEmpty() && des.IsNullOrEmpty() && dis.Contains("。"))
                    {
                        des = dis.Substring("。");
                        dis = dis.Substring(null, "。");
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1077), Tuple.Create("\"", 1132)
, Tuple.Create(Tuple.Create("", 1085), Tuple.Create("form-group", 1085), true)
, Tuple.Create(Tuple.Create(" ", 1095), Tuple.Create("col-sm-12", 1096), true)
, Tuple.Create(Tuple.Create(" ", 1105), Tuple.Create("col-md-", 1106), true)
            
            #line 30 "..\..\Views\Shared\ObjectForm.cshtml"
, Tuple.Create(Tuple.Create("", 1113), Tuple.Create<System.Object, System.Int32>(bs.GetGroupWidth()
            
            #line default
            #line hidden
, 1113), false)
);

WriteLiteral(">\r\n                        <label");

WriteAttribute("class", Tuple.Create(" class=\"", 1166), Tuple.Create("\"", 1234)
, Tuple.Create(Tuple.Create("", 1174), Tuple.Create("control-label", 1174), true)
, Tuple.Create(Tuple.Create(" ", 1187), Tuple.Create("col-xs-2", 1188), true)
, Tuple.Create(Tuple.Create(" ", 1196), Tuple.Create("col-md-", 1197), true)
            
            #line 31 "..\..\Views\Shared\ObjectForm.cshtml"
, Tuple.Create(Tuple.Create("", 1204), Tuple.Create<System.Object, System.Int32>(bs.LabelWidth
            
            #line default
            #line hidden
, 1204), false)
, Tuple.Create(Tuple.Create(" ", 1218), Tuple.Create("no-padding-left", 1219), true)
);

WriteAttribute("for", Tuple.Create(" for=\"", 1235), Tuple.Create("\"", 1249)
            
            #line 31 "..\..\Views\Shared\ObjectForm.cshtml"
                         , Tuple.Create(Tuple.Create("", 1241), Tuple.Create<System.Object, System.Int32>(pi.Name
            
            #line default
            #line hidden
, 1241), false)
);

WriteLiteral(">");

            
            #line 31 "..\..\Views\Shared\ObjectForm.cshtml"
                                                                                                               Write(dis ?? pi.Name);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                        <div");

WriteLiteral(" class=\"input-group col-xs-10 col-md-5\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 33 "..\..\Views\Shared\ObjectForm.cshtml"
                       Write(Html.ForEditor(pi.Name, Obj.GetValue(pi), pi.PropertyType));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 34 "..\..\Views\Shared\ObjectForm.cshtml"
                       Write(Html.ValidationMessage(pi.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <span");

WriteLiteral(" class=\"hidden-xs col-md-4\"");

WriteLiteral(">&nbsp; ");

            
            #line 36 "..\..\Views\Shared\ObjectForm.cshtml"
                                                           Write(des);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n");

            
            #line 38 "..\..\Views\Shared\ObjectForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"clearfix form-actions col-sm-12 col-md-12\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-xs-4 col-sm-5 col-md-5\"");

WriteLiteral("></label>\r\n                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-save\"");

WriteLiteral("></i><strong>保存</strong></button>\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></i><strong>取消</strong></button>\r\n                </div>\r\n");

            
            #line 44 "..\..\Views\Shared\ObjectForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
