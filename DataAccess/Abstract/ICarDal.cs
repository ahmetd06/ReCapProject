using System;
using System.Collections.Generic;
using Entities;
namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        //bu şekilde Car sınıfı için yapılandırmış olduk
    }
}
