using Entities.Sample.Entities;
using Sample.SalesService.DAL;
using System;
using System.Collections.Generic;

namespace Sample.SalesService.BLL
{
    internal sealed class SalesBusiness : ISalesBusiness
    {
        private readonly ISalesRepository _salesRepository;

        public SalesBusiness(ISalesRepository salesRepository)
        {
            this._salesRepository = salesRepository ?? throw new ArgumentNullException("salesRepository");
        }

        public List<SalesPerson> GetSalesPerson()
        {
            return _salesRepository.GetSalesPerson();
        }
    }
}
