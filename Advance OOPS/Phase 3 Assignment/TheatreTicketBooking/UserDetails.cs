using System;

namespace TheatreTicketBooking
{
    /// <summary>
    /// UseDetails class
    /// </summary>
    public class UserDetails : PersonalDetails,IWallet
    {
        /// <summary>
        /// private field
        /// </summary>
        private static int s_userId =1000;
        /// <summary>
        /// UserId property
        /// </summary>
        /// <value></value>
        public string  UserId { get; set; }
        /// <summary>
        /// WalletBalance property
        /// </summary>
        /// <value></value>
        public double WalletBalance { get ; set; }

        /// <summary>
        /// UserDetails constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phoneNubmer"></param>
        /// <param name="walletBalance"></param>
        /// <returns></returns>
        public UserDetails(string name, int age, long phoneNubmer, double walletBalance) : base(name, age, phoneNubmer){
            s_userId++;
            UserId = "UID"+s_userId;
            WalletBalance = walletBalance;
        }
        /// <summary>
        /// Next UserDetails constructor
        /// </summary>
        /// <param name="data"></param>
        public UserDetails(string data){
            string[] value = data.Split(',');
            s_userId = int.Parse(value[0].Remove(0,3));
            UserId = value[0];
            Name = value[1];
            Age = int.Parse(value[2]);
            PhoneNumber = long.Parse(value[3]);
            WalletBalance = double.Parse(value[4]);
        }

        public void RechargeWallet( double amount)
        {
            WalletBalance += amount;            
            Console.WriteLine($"Your Current Balance is : {WalletBalance} ");
            
        }
    }
}