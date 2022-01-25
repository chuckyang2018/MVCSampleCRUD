using Sample.SalesService.BLL;

namespace Sample.SalesService.Services
{
    public interface ISalesService
    {
        ISalesBusiness SalesBusiness { get; }
    }
}
