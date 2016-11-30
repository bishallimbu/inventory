﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    
    #line 1 "..\..\Views\Tasks\Adjustment\New.cshtml"
    using Frapid.ApplicationState.Cache;
    
    #line default
    #line hidden
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.Mapper.Decorators;
    using Frapid.WebsiteBuilder;
    using MixERP.Inventory;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Adjustment/New.cshtml")]
    public partial class _Views_Tasks_Adjustment_New_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Adjustment_New_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Tasks\Adjustment\New.cshtml"
  
    ViewBag.Title = "Inventory";
    Layout = ViewBag.InventoryLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"ui attached segment\"");

WriteLiteral(" style=\"min-height: 100%;padding:3em;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Inventory Adjustments</div>\r\n\r\n        <div");

WriteLiteral(" class=\"ui form segment\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"fields\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"ValueDateInputText\"");

WriteLiteral(">Value Date</label>\r\n                    <input");

WriteLiteral(" id=\"ValueDateInputText\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"BookDateInputText\"");

WriteLiteral(">Book Date</label>\r\n                    <input");

WriteLiteral(" id=\"BookDateInputText\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"ReferenceNumberInputText\"");

WriteLiteral(">Reference Number</label>\r\n                    <input");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"three wide field\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"StoreSelect\"");

WriteLiteral(">Select Store</label>\r\n                    <select");

WriteLiteral(" id=\"StoreSelect\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral("></select>\r\n                    <input");

WriteLiteral(" id=\"StoreHidden\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(">\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"ShowButton\"");

WriteLiteral(">Show Items</label>\r\n                    <input");

WriteLiteral(" value=\"Show\"");

WriteLiteral(" id=\"ShowButton\"");

WriteLiteral(" class=\"ui small positive button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <table");

WriteLiteral(" id=\"ClosingInventoryGrid\"");

WriteLiteral(" class=\"ui collapsing table form segment\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>Item Id</th>
                    <th>Item Code</th>
                    <th>Item Name</th>
                    <th>Unit Id</th>
                    <th>Unit Name</th>
                    <th>Quantity</th>
                    <th>Actual</th>
                    <th>Difference</th>
                </tr>
            </thead>
            <tbody></tbody>
        </table>
        <div");

WriteLiteral(" id=\"ErrorDiv\"");

WriteLiteral(" class=\"big error vpad16\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"ui form\"");

WriteLiteral(" style=\"width: 300px;\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"StatementReferenceTextArea\"");

WriteLiteral(">Statement Reference</label>\r\n                <textarea");

WriteLiteral(" id=\"StatementReferenceTextArea\"");

WriteLiteral(" rows=\"4\"");

WriteLiteral("></textarea>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"ErrorLabel\"");

WriteLiteral(" class=\"big error vpad16\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"ui buttons\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" id=\"SaveButton\"");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n                    Save\r\n                </button>\r\n                <a");

WriteLiteral(" href=\"/dashboard/inventory/tasks/inventory-adjustments\"");

WriteLiteral(" class=\"ui blue button\"");

WriteLiteral(">Back</a>\r\n            </div>\r\n\r\n        </div>\r\n        <script>\r\n            va" +
"r showButotn = $(\"#ShowButton\");\r\n            var storeHidden = $(\"#StoreHidden\"" +
");\r\n            var storeSelect = $(\"#StoreSelect\");\r\n            var closingInv" +
"entoryGrid = $(\"#ClosingInventoryGrid\");\r\n            var actualInputText = $(\"." +
"actual\");\r\n            var differenceInputText = $(\".difference\");\r\n            " +
"var saveButton = $(\"#SaveButton\");\r\n            var referenceNumberInputText = $" +
"(\"#ReferenceNumberInputText\");\r\n            var statementReferenceTextArea = $(\"" +
"#StatementReferenceTextArea\");\r\n            var valueDateInputText = $(\"#ValueDa" +
"teInputText\");\r\n            var bookDateInputText = $(\"#BookDateInputText\");\r\n  " +
"          var errorLabel = $(\"#ErrorLabel\");\r\n\r\n            $(\".dropdown\").dropd" +
"own();\r\n\r\n            function loadStores() {\r\n                window.displayFie" +
"ldBinder($(\"#StoreSelect\"), \"/api/forms/inventory/stores/display-fields\", true);" +
"\r\n            };\r\n\r\n            loadStores();\r\n\r\n            function displayClo" +
"singInventory(model) {\r\n                function getCell(text) {\r\n              " +
"      var cell = $(\"<td />\");\r\n                    cell.html(text);\r\n\r\n         " +
"           return cell;\r\n                };\r\n\r\n                var tabIndex = 0;" +
"\r\n                var totalRows = model.length;\r\n\r\n                $.each(model," +
" function () {\r\n                    var row = $(\"<tr />\");\r\n                    " +
"tabIndex++;\r\n\r\n                    row.append(getCell(this.ItemId));\r\n          " +
"          row.append(getCell(this.ItemCode));\r\n                    row.append(ge" +
"tCell(this.ItemName));\r\n                    row.append(getCell(this.UnitId));\r\n " +
"                   row.append(getCell(this.UnitName));\r\n                    row." +
"append(getCell(this.Quantity));\r\n\r\n                    row.append(getCell(\"<inpu" +
"t type=\'text\' tabindex=\'\" + tabIndex + \"\' class=\'integer actual\' />\"));\r\n       " +
"             row.append(getCell(\"<input type=\'text\' tabindex=\'\" + (tabIndex + to" +
"talRows) + \"\' class=\'integer difference\' />\"));\r\n\r\n\r\n                    closing" +
"InventoryGrid.append(row);\r\n                });\r\n            };\r\n\r\n            f" +
"unction initializeCalculator() {\r\n                $(\"input.actual\").blur(functio" +
"n () {\r\n                    var quantity = window.parseInt2($(this).parent().par" +
"ent().find(\"td:nth-last-child(3)\").html());\r\n                    var actual = ($" +
"(this).val());\r\n\r\n                    if (window.isNullOrWhiteSpace(actual)) {\r\n" +
"                        $(this).val(quantity);\r\n                        actual =" +
" quantity;\r\n                    }\r\n\r\n                    if (window.parseInt2(ac" +
"tual) > quantity) {\r\n                        window.makeDirty($(this).parent());" +
"\r\n                        return;\r\n                    };\r\n\r\n                   " +
" window.removeDirty($(this).parent());\r\n\r\n                    $(this).parent().p" +
"arent().find(\"td:nth-last-child(1) input\").val(quantity - actual);\r\n            " +
"    });\r\n\r\n                $(\"input.difference\").blur(function () {\r\n           " +
"         var quantity = window.parseInt2($(this).parent().parent().find(\"td:nth-" +
"last-child(3)\").html());\r\n                    var difference = window.parseInt2(" +
"$(this).val());\r\n\r\n                    if (difference > quantity) {\r\n           " +
"             window.makeDirty($(this).parent());\r\n                        return" +
";\r\n                    };\r\n\r\n                    window.removeDirty($(this).pare" +
"nt());\r\n\r\n                    $(this).parent().parent().find(\"td:nth-last-child(" +
"2) input\").val(quantity - difference);\r\n                });\r\n            };\r\n\r\n " +
"           $(\"#ShowButton\").unbind(\"click\").bind(\"click\", function () {\r\n       " +
"         function request(storeId) {\r\n                    var url = \"/dashboard/" +
"inventory/tasks/inventory-adjustments/closing/{storeId}\";\r\n                    u" +
"rl = url.replace(\"{storeId}\", storeId);\r\n                    return window.getAj" +
"axRequest(url);\r\n                };\r\n\r\n                var storeId = parseInt(st" +
"oreSelect.val());\r\n\r\n                if (!storeId) {\r\n                    window" +
".displayMessage(\"Please select a store!\");\r\n                    return;\r\n       " +
"         };\r\n\r\n                var ajax = request(storeId);\r\n\r\n                a" +
"jax.success(function (response) {\r\n                    displayClosingInventory(r" +
"esponse);\r\n                    initializeCalculator();\r\n                });\r\n\r\n " +
"               ajax.fail(function (xhr) {\r\n                    alert(JSON.string" +
"ify(xhr));\r\n                });\r\n            });\r\n        </script>\r\n        <sc" +
"ript");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            saveButton.click(function () {\r\n                function request(m" +
"odel) {\r\n                    var url = \"/dashboard/inventory/tasks/inventory-adj" +
"ustments\";\r\n                    var data = JSON.stringify(model);\r\n\r\n           " +
"         alert(data);\r\n\r\n                    return window.getAjaxRequest(url, \"" +
"POST\", data);\r\n                };\r\n\r\n                function getModel() {\r\n    " +
"                function getDetails() {\r\n                        var model = [];" +
"\r\n\r\n                        closingInventoryGrid.find(\"tbody tr\").each(function " +
"() {\r\n                            var itemCode = $(this).find(\"td:nth-child(2)\")" +
".html();\r\n                            var quantity = window.parseInt2($(this).fi" +
"nd(\"td:nth-child(8)\").find(\"input\").val());\r\n                            var uni" +
"tName = $(this).find(\"td:nth-child(5)\").html();\r\n\r\n                            i" +
"f (quantity) {\r\n                                model.push(\r\n                   " +
"                 {\r\n                                        TransactionType: \"Cr" +
"\",\r\n                                        ItemCode: itemCode,\r\n               " +
"                         Quantity: quantity,\r\n                                  " +
"      UnitName: unitName\r\n                                    }\r\n               " +
"                 );\r\n                            };\r\n                        });" +
"\r\n\r\n                        return model;\r\n                    };\r\n\r\n           " +
"         var storeId = parseInt(storeSelect.val());\r\n                    var val" +
"ueDate = window.parseLocalizedDate(valueDateInputText.val());\r\n                 " +
"   var bookDate = window.parseLocalizedDate(bookDateInputText.val());\r\n         " +
"           var referenceNumber = referenceNumberInputText.val();\r\n              " +
"      var statementReference = statementReferenceTextArea.val();\r\n\r\n            " +
"        if (!storeId) {\r\n                        window.makeDirty(storeSelect);\r" +
"\n                        errorLabel.html(\"Invalid store!\");\r\n                   " +
"     return null;\r\n                    };\r\n\r\n                    if (!window.isD" +
"ate(valueDate)) {\r\n                        window.makeDirty(valueDateInputText);" +
"\r\n                        errorLabel.html(\"Invalid date!\");\r\n                   " +
"     return null;\r\n                    };\r\n\r\n                    if (!window.isD" +
"ate(bookDate)) {\r\n                        window.makeDirty(bookDateInputText);\r\n" +
"                        errorLabel.html(\"Invalid date!\");\r\n                     " +
"   return null;\r\n                    };\r\n\r\n\r\n                    return {\r\n     " +
"                   StoreId: storeId,\r\n                        ValueDate: valueDa" +
"te,\r\n                        BookDate: bookDate,\r\n                        Refere" +
"nceNumber: referenceNumber,\r\n                        StatementReference: stateme" +
"ntReference,\r\n                        Details: getDetails()\r\n                   " +
" };\r\n                };\r\n\r\n                var model = getModel();\r\n            " +
"    if (!model) {\r\n                    return;\r\n                };\r\n\r\n          " +
"      var ajax = request(model);\r\n\r\n                ajax.success(function(respon" +
"se) {\r\n                    var tranId = response;\r\n\r\n                    if (tra" +
"nId) {\r\n                        window.location = \"/dashboard/inventory/tasks/ad" +
"justments/checklist/\" + tranId;\r\n                    };\r\n                });\r\n\r\n" +
"                ajax.fail(function (xhr) {\r\n                    alert(JSON.strin" +
"gify(xhr));\r\n                });\r\n            });\r\n\r\n            window.override" +
"Path = \"/dashboard/inventory/tasks/inventory-adjustments\";\r\n        </script>\r\n\r" +
"\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
