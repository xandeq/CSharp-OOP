using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItemRepository
    {
        /// <summary>
        /// Retrieve one Order Item.
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Retrieve a list of Order Item`.
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the current Order Item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
