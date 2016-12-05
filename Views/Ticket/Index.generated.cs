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
    
    #line 1 "..\..\Views\Ticket\Index.cshtml"
    using Frapid.ApplicationState.Cache;
    
    #line default
    #line hidden
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    
    #line 2 "..\..\Views\Ticket\Index.cshtml"
    using Frapid.Framework.Extensions;
    
    #line default
    #line hidden
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.Sales;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Ticket/Index.cshtml")]
    public partial class _Views_Ticket_Index_cshtml : System.Web.Mvc.WebViewPage<MixERP.Sales.ViewModels.TicketViewModel>
    {
        public _Views_Ticket_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Ticket\Index.cshtml"
  
    ViewBag.Title = "Sales Entries";
    string logo = AppUsers.GetCurrent().Logo.Or("/Static/images/logo.png");
    var appUser = AppUsers.GetCurrent();
    string currenySymbol = appUser.CurrencySymbol;
    decimal taxableTotal = Model.Details.Where(x => x.IsTaxableItem).Sum(x => x.Price*x.Quantity - x.Discount);
    decimal taxTotal = Model.Details.Where(x => x.IsTaxableItem).Sum(x => x.Tax);
    decimal taxRate = 0;

    if (taxableTotal > 0)
    {
        taxRate = taxTotal/taxableTotal*100;
    }

    decimal nonTaxableTotal = Model.Details.Where(x => !x.IsTaxableItem).Sum(x => x.Price*x.Quantity - x.Discount);
    decimal totalBeforeDisount = nonTaxableTotal + taxableTotal + taxTotal;
    decimal grandTotal = totalBeforeDisount - Model.View.Discount;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\n    html, body, table {\r\n        font-family: Consolas, \"Courier New\"," +
" monospace;\r\n        font-size: 12px;\r\n        text-align: center;\r\n        text" +
"-transform: uppercase;\r\n    }\r\n\r\n    table {\r\n        border-collapse: collapse;" +
"\r\n        text-align: left;\r\n        width: 100%;\r\n    }\r\n\r\n    table th, table " +
"td {\r\n        border-bottom: 1px solid #ddd;\r\n        padding: 0.2em;\r\n    }\r\n\r\n" +
"\r\n    .right { text-align: right; }\r\n\r\n    .logo img { height: 40px; }\r\n\r\n    .c" +
"oupon.header {\r\n        font-size: 1.4em;\r\n        padding: 1em;\r\n    }\r\n\r\n    ." +
"transaction.items { padding-bottom: 1em; }\r\n\r\n    .transaction.items .info, .cou" +
"pon .info { display: flex; }\r\n\r\n    .transaction.items .info .name {\r\n        fo" +
"nt-weight: bold;\r\n        text-align: left;\r\n        width: 120px;\r\n    }\r\n\r\n   " +
" .transaction.items .info .name:after { content: \":\"; }\r\n\r\n    .coupons .coupon " +
"{\r\n        display: flex;\r\n        margin: 0 auto;\r\n        padding: 1em;\r\n    }" +
"\r\n\r\n    .coupons .coupon .qrcode { width: 80px; }\r\n\r\n    .coupons .coupon .descr" +
"iption {\r\n        padding-left: 1em;\r\n        text-align: left;\r\n    }\r\n\r\n    .c" +
"oupons .coupon .description .title:not(.sub) {\r\n        font-size: 1.2em;\r\n     " +
"   font-weight: bold;\r\n    }\r\n\r\n    .coupons .coupon .description .sub.title {\r\n" +
"        font-size: 1.1em;\r\n        font-weight: bold;\r\n    }\r\n\r\n    .coupons .co" +
"upon .description .info .name {\r\n        font-size: 0.87em;\r\n        font-weight" +
": bold;\r\n        padding-right: 1em;\r\n    }\r\n</style>\r\n<script");

WriteLiteral(" src=\"/Scripts/jquery-2.2.4.min.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery.qrcode/1.0/jquery.qrcode.min." +
"js\"");

WriteLiteral("></script>\r\n<div");

WriteLiteral(" class=\"ticket\"");

WriteLiteral(">\r\n<div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n<div");

WriteLiteral(" class=\"logo\"");

WriteLiteral(">\r\n    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2638), Tuple.Create("\"", 2649)
            
            #line 98 "..\..\Views\Ticket\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2644), Tuple.Create<System.Object, System.Int32>(logo
            
            #line default
            #line hidden
, 2644), false)
);

WriteLiteral("/>\r\n</div>\r\n<div");

WriteLiteral(" class=\"company name\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Ticket\Index.cshtml"
                     Write(appUser.OfficeName);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"address\"");

WriteLiteral(">\r\n");

            
            #line 102 "..\..\Views\Ticket\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 102 "..\..\Views\Ticket\Index.cshtml"
     if (!string.IsNullOrWhiteSpace(appUser.AddressLine1))
    {
        
            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Ticket\Index.cshtml"
   Write(appUser.AddressLine1);

            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Ticket\Index.cshtml"
                             
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 106 "..\..\Views\Ticket\Index.cshtml"
     if (!string.IsNullOrWhiteSpace(appUser.AddressLine2))
    {
        
            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\Ticket\Index.cshtml"
   Write(appUser.AddressLine2);

            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\Ticket\Index.cshtml"
                             
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 111 "..\..\Views\Ticket\Index.cshtml"
Write(appUser.Street);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 111 "..\..\Views\Ticket\Index.cshtml"
                Write(appUser.City);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 111 "..\..\Views\Ticket\Index.cshtml"
                              Write(appUser.State);

            
            #line default
            #line hidden
WriteLiteral("\r\n    <br/>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"coupon header\"");

WriteLiteral(">Sales Receipt</div>\r\n\r\n<div");

WriteLiteral(" class=\"transaction items\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Invoice Number</div>\r\n        <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">#");

            
            #line 120 "..\..\Views\Ticket\Index.cshtml"
                       Write(Model.View.InvoiceNumber);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Tran Code</div>\r\n        <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">#");

            
            #line 124 "..\..\Views\Ticket\Index.cshtml"
                       Write(Model.View.TransactionMasterId);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 124 "..\..\Views\Ticket\Index.cshtml"
                                                       Write(Model.View.TransactionCode);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Tran Date</div>\r\n        <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 128 "..\..\Views\Ticket\Index.cshtml"
                      Write(Model.View.ValueDate.ToString("d"));

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 128 "..\..\Views\Ticket\Index.cshtml"
                                                           Write(Model.View.TransactionTs);

            
            #line default
            #line hidden
WriteLiteral(")</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Customer</div>\r\n        <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">#");

            
            #line 132 "..\..\Views\Ticket\Index.cshtml"
                       Write(Model.View.CustomerId);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 132 "..\..\Views\Ticket\Index.cshtml"
                                               Write(Model.View.CustomerName);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Posted By</div>\r\n        <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 136 "..\..\Views\Ticket\Index.cshtml"
                      Write(Model.View.PostedBy);

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 136 "..\..\Views\Ticket\Index.cshtml"
                                            Write(Model.View.CounterName);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 136 "..\..\Views\Ticket\Index.cshtml"
                                                                    Write(Model.View.StoreName);

            
            #line default
            #line hidden
WriteLiteral(")</div>\r\n    </div>\r\n");

            
            #line 138 "..\..\Views\Ticket\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 138 "..\..\Views\Ticket\Index.cshtml"
     if (Model.View.PaymentTermId > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Payment Term</div>\r\n            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 142 "..\..\Views\Ticket\Index.cshtml"
                          Write(Model.View.PaymentTermName);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n");

            
            #line 144 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 145 "..\..\Views\Ticket\Index.cshtml"
     if (Model.View.CheckAmount > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Check</div>\r\n            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">Check #");

            
            #line 149 "..\..\Views\Ticket\Index.cshtml"
                                 Write(Model.View.CheckNumber);

            
            #line default
            #line hidden
WriteLiteral(" dated ");

            
            #line 149 "..\..\Views\Ticket\Index.cshtml"
                                                               Write(Model.View.CheckDate.ToString("D"));

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 149 "..\..\Views\Ticket\Index.cshtml"
                                                                                                    Write(Model.View.CheckBankName);

            
            #line default
            #line hidden
WriteLiteral(") </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Check Amount</div>\r\n            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">Check #");

            
            #line 153 "..\..\Views\Ticket\Index.cshtml"
                                 Write(Model.View.CheckAmount);

            
            #line default
            #line hidden
WriteLiteral(" </div>\r\n        </div>\r\n");

            
            #line 155 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 156 "..\..\Views\Ticket\Index.cshtml"
     if (Model.View.GiftCardId > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Gift Card #</div>\r\n            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 160 "..\..\Views\Ticket\Index.cshtml"
                          Write(Model.View.GiftCardNumber);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n");

            
            #line 162 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 163 "..\..\Views\Ticket\Index.cshtml"
     if (Model.View.RewardPoints > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Reward Points</div>\r\n            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 167 "..\..\Views\Ticket\Index.cshtml"
                          Write(Model.View.RewardPoints.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n");

            
            #line 169 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n<table>\r\n    <thead>\r\n    <tr>\r\n        <th>Description</th>\r\n        <" +
"th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Amount</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 180 "..\..\Views\Ticket\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 180 "..\..\Views\Ticket\Index.cshtml"
     foreach (var item in Model.Details)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <td>\r\n                <div");

WriteLiteral(" class=\"item info\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 185 "..\..\Views\Ticket\Index.cshtml"
               Write(item.ItemName);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 187 "..\..\Views\Ticket\Index.cshtml"
               Write(item.Quantity);

            
            #line default
            #line hidden
            
            #line 187 "..\..\Views\Ticket\Index.cshtml"
                             Write(item.UnitCode);

            
            #line default
            #line hidden
WriteLiteral(" x ");

            
            #line 187 "..\..\Views\Ticket\Index.cshtml"
                                              Write(item.Price.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral(" = ");

            
            #line 187 "..\..\Views\Ticket\Index.cshtml"
                                                                           Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 187 "..\..\Views\Ticket\Index.cshtml"
                                                                                          Write((item.Quantity*item.Price).ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 189 "..\..\Views\Ticket\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 189 "..\..\Views\Ticket\Index.cshtml"
                 if (item.Discount > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"discount info\"");

WriteLiteral(">\r\n                        Less ");

            
            #line 192 "..\..\Views\Ticket\Index.cshtml"
                        Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 192 "..\..\Views\Ticket\Index.cshtml"
                                      Write(item.Discount.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 192 "..\..\Views\Ticket\Index.cshtml"
                                                                      Write((item.Discount*100/(item.Amount + item.Discount)).ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("%)\r\n                    </div>\r\n");

            
            #line 194 "..\..\Views\Ticket\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n            <td");

WriteLiteral(" class=\"right\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 197 "..\..\Views\Ticket\Index.cshtml"
           Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 197 "..\..\Views\Ticket\Index.cshtml"
                          Write(item.Amount.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");

            
            #line 200 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n    <tfoot>\r\n");

            
            #line 203 "..\..\Views\Ticket\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 203 "..\..\Views\Ticket\Index.cshtml"
     if (taxableTotal > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Sub Total</th>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 207 "..\..\Views\Ticket\Index.cshtml"
                         Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 207 "..\..\Views\Ticket\Index.cshtml"
                                       Write(taxableTotal.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n");

            
            #line 209 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 210 "..\..\Views\Ticket\Index.cshtml"
     if (taxTotal > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Tax (");

            
            #line 213 "..\..\Views\Ticket\Index.cshtml"
                              Write(taxRate.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("%)</th>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 214 "..\..\Views\Ticket\Index.cshtml"
                         Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 214 "..\..\Views\Ticket\Index.cshtml"
                                       Write(taxTotal.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n");

            
            #line 216 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 218 "..\..\Views\Ticket\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 218 "..\..\Views\Ticket\Index.cshtml"
     if (nonTaxableTotal > 0 && nonTaxableTotal != grandTotal)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Non Taxable Sales</th>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 222 "..\..\Views\Ticket\Index.cshtml"
                         Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 222 "..\..\Views\Ticket\Index.cshtml"
                                       Write(nonTaxableTotal.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n");

            
            #line 224 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 226 "..\..\Views\Ticket\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 226 "..\..\Views\Ticket\Index.cshtml"
     if (Model.View.Discount > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Total</th>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 230 "..\..\Views\Ticket\Index.cshtml"
                         Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 230 "..\..\Views\Ticket\Index.cshtml"
                                        Write(totalBeforeDisount.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n");

WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">\r\n                Discount\r\n                (");

            
            #line 235 "..\..\Views\Ticket\Index.cshtml"
             Write((Model.View.Discount*100/totalBeforeDisount).ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("%)\r\n            </th>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 237 "..\..\Views\Ticket\Index.cshtml"
                         Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 237 "..\..\Views\Ticket\Index.cshtml"
                                       Write(Model.View.Discount.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n");

            
            #line 239 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <tr>\r\n        <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Grand Total</th>\r\n        <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 244 "..\..\Views\Ticket\Index.cshtml"
                     Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 244 "..\..\Views\Ticket\Index.cshtml"
                                    Write(grandTotal.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n    </tr>\r\n");

            
            #line 246 "..\..\Views\Ticket\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 246 "..\..\Views\Ticket\Index.cshtml"
     if (Model.View.Tender > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Tender</th>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 250 "..\..\Views\Ticket\Index.cshtml"
                         Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 250 "..\..\Views\Ticket\Index.cshtml"
                                       Write(Model.View.Tender.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n");

WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">Change</th>\r\n            <th");

WriteLiteral(" class=\"right\"");

WriteLiteral(">");

            
            #line 254 "..\..\Views\Ticket\Index.cshtml"
                         Write(currenySymbol);

            
            #line default
            #line hidden
            
            #line 254 "..\..\Views\Ticket\Index.cshtml"
                                       Write(Model.View.Change.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n");

            
            #line 256 "..\..\Views\Ticket\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    </tfoot>\r\n</table>\r\n\r\n");

            
            #line 260 "..\..\Views\Ticket\Index.cshtml"
 if (Model.DiscountCoupons.Any())
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"discount coupons\"");

WriteLiteral(">\r\n");

            
            #line 263 "..\..\Views\Ticket\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 263 "..\..\Views\Ticket\Index.cshtml"
         foreach (var coupon in Model.DiscountCoupons)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"coupon\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"qrcode\"");

WriteLiteral(" data-coupon=\"");

            
            #line 266 "..\..\Views\Ticket\Index.cshtml"
                                            Write(coupon.CouponCode);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"title\"");

WriteLiteral(">");

            
            #line 268 "..\..\Views\Ticket\Index.cshtml"
                                  Write(coupon.CouponName);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"sub title\"");

WriteLiteral(">");

            
            #line 269 "..\..\Views\Ticket\Index.cshtml"
                                      Write(coupon.DiscountRate);

            
            #line default
            #line hidden
            
            #line 269 "..\..\Views\Ticket\Index.cshtml"
                                                           Write(coupon.IsPercentage ? "%" : "");

            
            #line default
            #line hidden
WriteLiteral(" off</div>\r\n\r\n");

            
            #line 271 "..\..\Views\Ticket\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 271 "..\..\Views\Ticket\Index.cshtml"
                     if (coupon.MinimumPurchaseAmount > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Minimum purchase amount</div>\r\n                            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 275 "..\..\Views\Ticket\Index.cshtml"
                                          Write(coupon.MinimumPurchaseAmount);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n");

            
            #line 277 "..\..\Views\Ticket\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 278 "..\..\Views\Ticket\Index.cshtml"
                     if (coupon.MaximumPurchaseAmount > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Maximum purchase amount</div>\r\n                            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 282 "..\..\Views\Ticket\Index.cshtml"
                                          Write(coupon.MaximumPurchaseAmount);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n");

            
            #line 284 "..\..\Views\Ticket\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 285 "..\..\Views\Ticket\Index.cshtml"
                     if (coupon.BeginsFrom != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Effective From</div>\r\n                            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 289 "..\..\Views\Ticket\Index.cshtml"
                                          Write(coupon.BeginsFrom.Value.ToString("d"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n");

            
            #line 291 "..\..\Views\Ticket\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 292 "..\..\Views\Ticket\Index.cshtml"
                     if (coupon.ExpiresOn != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Effective From</div>\r\n                            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 296 "..\..\Views\Ticket\Index.cshtml"
                                          Write(coupon.ExpiresOn.Value.ToString("d"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n");

            
            #line 298 "..\..\Views\Ticket\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 299 "..\..\Views\Ticket\Index.cshtml"
                     if (coupon.MaximumUsage != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"info\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"name\"");

WriteLiteral(">Total Usage</div>\r\n                            <div");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 303 "..\..\Views\Ticket\Index.cshtml"
                                          Write(coupon.MaximumUsage.Value);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n");

            
            #line 305 "..\..\Views\Ticket\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");

            
            #line 308 "..\..\Views\Ticket\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 310 "..\..\Views\Ticket\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n</div>\r\n\r\n<script>\r\n    $(\".qrcode\").each(function() {\r\n        const el " +
"= $(this);\r\n        const coupon = el.attr(\"data-coupon\");\r\n\r\n        el.qrcode(" +
"{ width: 80, height: 80, text: coupon });\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591
