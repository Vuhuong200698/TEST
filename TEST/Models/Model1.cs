using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TEST.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=LTQLDBContext")
        {
        }
        public virtual DbSet<Persons> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
