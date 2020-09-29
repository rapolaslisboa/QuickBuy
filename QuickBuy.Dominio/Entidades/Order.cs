using QuickBuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryForecastDate { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Number { get; set;  }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido ou muitos items de pedido
        /// </summary>
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
