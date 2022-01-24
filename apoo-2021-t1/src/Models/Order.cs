using System.Collections.Generic;
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.Models
{
    public class Order
    {
        private int user_id;
        private int id;

        public IDictionary<int, myTuple<Item, int>> items;

        public string status = "Pendente";
        public bool finished = false;
        public Order(int id, int user_id)
        {
            this.id = id;
            this.user_id = user_id;
            this.items = new Dictionary<int, myTuple<Item, int>>();
        }

        public int getId()
        {
            return this.id;
        }
        public int getUserId()
        {
            return this.user_id;
        }
        public string getStatus()
        {
            return this.status;
        }

        public void addItem(int id, myTuple<Item, int> item)
        {
            this.items.Add(id, item);
        }

        public float getTotalPrice()
        {
            float total = 0;
            foreach (myTuple<Item, int> item in items.Values)
                total += item.Item1.getValue() * item.Item2;
            return total;
        }

        public int getTotalCount()
        {
            int total = 0;
            foreach (myTuple<Item, int> item in items.Values)
                total += item.Item2;
            return total;
        }
    }
}
