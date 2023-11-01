using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Data
{
    public class Context : DbContext
    {
        public Context() : base("dbTareaEntities")
        {
        }

        public DbSet<Pedidos> Pedido { get; set; }
    }
}
