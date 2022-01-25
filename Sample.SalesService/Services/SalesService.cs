using Sample.SalesService.BLL;
using System;

namespace Sample.SalesService.Services
{
    internal sealed class SalesService : ISalesService
    {
        private ISalesBusiness salesBusiness { get; }

        public SalesService(ISalesBusiness salesBusiness)
        {
            this.salesBusiness = salesBusiness ?? throw new ArgumentNullException("salesBusiness");
        }

        public ISalesBusiness SalesBusiness
        {
            get { return this.salesBusiness; }
        }
    }
}
