using ShoppingCartFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ShoppingCartFinalAPI.Controllers
{
    public class OrderController : ApiController
    {
        Connection c = new Connection();
        Order orderp = new Order();
        [HttpGet]
        public void  OrderDetail([FromUri]int[] ItemId,[FromUri]string total)
        {
           c.OrderData(ItemId,total); 
        }

    
        [HttpGet]
        public List<Order> orderpage()
        {
           
            return c.OrderPage(orderp.id);
        }


    }
}
