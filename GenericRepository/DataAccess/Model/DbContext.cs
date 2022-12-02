using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;

namespace DataAccess.Model
{
    public class DbContext: DbContext
    {
        public DbContext()
            : base("name=FoodContextDb")
        {

        }
        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodType> FoodTypes { get; set; }
    }
}
