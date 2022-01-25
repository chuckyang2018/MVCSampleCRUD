using Sample.SalesService.BLL;
using Sample.SalesService.Services;

namespace Sample.SalesService.Factories
{
    public static class SalesServiceFactory
    {
        public static ISalesService GetSalesService()
        {
            return new Services.SalesService(GetSalesBusiness());
        }

        internal static ISalesBusiness GetSalesBusiness()
        {
            return new SalesBusiness(DaoFactory.GetSalesRepository());
        }
    }
}
