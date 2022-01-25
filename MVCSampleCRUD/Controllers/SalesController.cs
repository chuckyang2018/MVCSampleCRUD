using Sample.SalesService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleCRUD.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesService _salesService;

        public SalesController(ISalesService salesService)
        {
            _salesService = salesService ?? throw new ArgumentNullException("salesService");
        }

        // GET: Sales
        public ActionResult Index()
        {
            var salesPersonList = _salesService.SalesBusiness.GetSalesPerson();

            return View();
        }
    }
}