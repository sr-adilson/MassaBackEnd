using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MassaContext : DbContext
    {
        public DbSet<Massa> Massa { get; set; }
        public MassaContext() : base("Data Source = 192.168.0.124; Initial Catalog = MassaBackEnd; Persist Security Info=True;User ID = RodBank; Password=zero1234@")
        {

        }
    }
}
