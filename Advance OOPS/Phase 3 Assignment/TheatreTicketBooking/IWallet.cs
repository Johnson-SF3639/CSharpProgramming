
namespace TheatreTicketBooking
{
    /// <summary>
    /// IWallet Interface
    /// </summary>
    public interface IWallet
    {
        /// <summary>
        /// Property WalletBalance
        /// </summary>
        /// <value></value>
        double WalletBalance  { get; set; }
        /// <summary>
        /// RechargeWallet Method
        /// </summary>
        /// <param name="amount"></param>
        void RechargeWallet(double amount);

    }
}