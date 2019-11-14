using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD()
            : base("chaineDeConnexion")
        {

        }
        //public DbSet <Categorie> Categories { get; set; }
        //public DbSet<Chaton> Chatons { get; set; }

        //public DbSet<Proprio> Proprios { get; set; }

    }
}
