using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase, ILoggable
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {

        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public string Log() => $"{OrderItemId}: PurchasePrice: {PurchasePrice} Quantity: {Quantity} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validates the Order Item
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (OrderItemId <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}
