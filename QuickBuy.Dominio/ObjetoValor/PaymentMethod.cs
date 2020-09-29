using QuickBuy.Dominio.Enums;

namespace QuickBuy.Dominio.ObjetoValor
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool isBillet
        {
            get { return Id == (int)PaymentMethodEnum.Billet;  }
        }
        public bool isCreditCard
        {
            get { return Id == (int)PaymentMethodEnum.CreditCard; }
        }
        public bool isUndenifed
        {
            get { return Id == (int)PaymentMethodEnum.Undenifed; }
        }
        public bool isDeposit
        {
            get { return Id == (int)PaymentMethodEnum.Deposit; }
        }
    }
}
