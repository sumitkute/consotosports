using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contoso.Apps.SportsLeague.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Apps.SportsLeague.Data.Models;
using Newtonsoft.Json;

namespace Contoso.Apps.SportsLeague.Web.Helpers.Tests
{
    [TestClass()]
    public class AzureQueueHelperTests
    {
        [TestMethod()]
        public void QueueReceiptRequestTest()
        {
            ProductContext _db = new ProductContext();
            var myCurrentOrder = _db.Orders
                                 .Include("OrderDetails")
                                 .Include("OrderDetails.Product")
                                 .Single(o => o.OrderId == 2);

            String jsonOrder = JsonConvert.SerializeObject(myCurrentOrder,Formatting.Indented,
                new JsonSerializerSettings{ ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            // Queue up a receipt generation request, asynchronously.
            //await new AzureQueueHelper().QueueReceiptRequest(myCurrentOrder);

            Assert.Fail();
        }
    }
}