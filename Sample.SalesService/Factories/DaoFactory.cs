using Sample.SalesService.BLL;
using Sample.SalesService.DAL;

namespace Sample.SalesService.Factories
{
    internal static class DaoFactory
    {
        public static ISalesRepository GetSalesRepository()
        {
            return new SalesRepository();
        }
    }
}
