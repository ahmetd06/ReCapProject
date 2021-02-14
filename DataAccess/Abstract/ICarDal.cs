using System;
using System.Collections.Generic;
using Entities;
namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(int id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
