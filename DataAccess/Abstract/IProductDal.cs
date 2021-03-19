using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interfacein operasyonlari public, kendisi degil
    //DAL : Data access layer
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
