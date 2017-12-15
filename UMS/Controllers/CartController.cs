using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using UMS.Models;
using UMS.Core.Interfaces;
using UMS.Entity;
using UMS.Data;

namespace UMS.Controllers
{
    public class CartController : Controller
    {
        public IOrdersService ordersService;
        // GET: Cart

        [HttpGet]
        public ActionResult PlaceOrder()
        {
            return View();
        }
        [HttpPost]
        public string PlaceOrder(string mycart)
        {
            double totalInvoicePrice = 0;
            dynamic jsonDe = JsonConvert.DeserializeObject(mycart);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            List<JsonData> data = ser.Deserialize<List<JsonData>>(mycart);

            Orders order = new Orders();
            foreach (var item in data)
            {
                totalInvoicePrice += (Int32.Parse(item.price) * Int32.Parse(item.quantity));
            }
            Invoice invoice = new Invoice();
            invoice.totalPrice = totalInvoicePrice;
            invoice.status = 1;
            invoice.promoId = null;
            invoice.uid = "1";
            
            InvoiceRepository invoicerepo = new InvoiceRepository();
            invoicerepo.Insert(invoice);

            OrdersRepository orderrepo = new OrdersRepository();
            
            foreach (var item in data)
            {
                order.itemid = Int32.Parse(item.itemID);
                order.itemQuantity = Int32.Parse(item.quantity);
                order.totalPrice = (Int32.Parse(item.price) * Int32.Parse(item.quantity));
                order.itemType = 1;
                order.invoiceid = invoice.Id;
                orderrepo.Insert(order);
            }


            return mycart;
        }

    }
}