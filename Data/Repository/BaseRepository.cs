using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<M> where M : Base
    {
        public void Create(M model)
        {
            using (var context = new MassaContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        }
        public List<M> Read()
        {
            List<M> lista = new List<M>();
            using(var context = new MassaContext())
            {
                lista = context.Set<M>().ToList();
            }
            return lista;
        }
        public M Read(int id)
        {
            M model = Activator.CreateInstance<M>();
            using (var context = new MassaContext())
            {
                model = context.Set<M>().Find(id);
            }
            return model;
        }
        public void Update(M model)
        {
            using(var context = new MassaContext())
            {
                context.Entry<M>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(M model)
        {
            using (var context = new MassaContext())
            {
                context.Entry<M>(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
