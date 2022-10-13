
namespace FoodDelivery
{
    public interface IBalance
    {
        public double  WalletBalance { get; set; }
        void WalletRecharge();
    }
}