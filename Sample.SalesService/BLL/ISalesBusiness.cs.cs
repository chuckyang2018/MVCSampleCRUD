using Entities.Sample.Entities;
using System.Collections.Generic;

namespace Sample.SalesService.BLL
{
    public interface ISalesBusiness
    {
        List<SalesPerson> GetSalesPerson();
    }
}
