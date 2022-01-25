using Entities.Sample.Entities;
using System.Collections.Generic;

namespace Sample.SalesService.DAL
{
    internal interface ISalesRepository
    {
        List<SalesPerson> GetSalesPerson();
    }
}
