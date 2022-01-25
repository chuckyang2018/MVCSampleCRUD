using System.Collections.Generic;
using System.Linq;
using Entities.Sample.Entities;

namespace Sample.SalesService.DAL
{
    internal sealed class SalesRepository : ISalesRepository
    {
        /// <summary>
        /// Get sales person
        /// </summary>
        /// <returns></returns>
        public List<SalesPerson> GetSalesPerson()
        {
            using (var db = new AdventureWorks2019Entities())
            {
                return db.SalesPerson.ToList();
            }
        }
    }
}
