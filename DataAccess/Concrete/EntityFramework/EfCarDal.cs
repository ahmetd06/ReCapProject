using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:ICarDal
    {
        public EfCarDal()
        {
        }

        public void Add(Car entity)
        {
            using(ReCapProjectContext context= new ReCapProjectContext())
            {
                var addedEntity = context.Entry(entity); //gelen parametredeki özelliklerde olan nesneyi eşleştir
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }                  
        }

        public void Delete(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var deletedEntity = context.Entry(entity); //gelen parametredeki özelliklerde olan nesneyi eşleştir
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using(ReCapProjectContext context = new ReCapProjectContext())
            {
                var updatedEntity = context.Entry(entity); //gelen parametredeki özelliklerde olan nesneyi eşleştir
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
