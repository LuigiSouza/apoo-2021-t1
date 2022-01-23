using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apoo_2021_t1.src.Models
{
    public class Item
    {
        private int id;
        private string name;
        private float value;
        public Item(string name, float value, int id)
        {
            this.id = id;
            this.name = name;
            this.value = value;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public float getValue() { return value; }
    }
}
