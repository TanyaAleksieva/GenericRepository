using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Post
    {
        private int id;
        private string name;

        public int Id { get; set; }
        public string Name { get; set; }
        public int FoodTypeId { get; set; }
        public Post foodType { get; set; }
    }
}
