using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoEntiyFrameWork
{
    class ContextoMinhaAULA : DbContext
    {
        public ContextoMinhaAULA() : base("Contexto")
        {


        }

        public DbSet<Datas> Datas { get; set; }
    }
}
