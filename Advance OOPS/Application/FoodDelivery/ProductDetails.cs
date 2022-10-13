using System;

namespace FoodDelivery
{
    public class ProductDetails
    {
        private static int s_foodID =100;
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public int PricePerQuantity { get; set; }

        public ProductDetails(string foodName, int pricePerQuantity){
            s_foodID++;
            FoodID ="FID"+s_foodID;
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
        }
        
        public ProductDetails(string data){
            string[] value = data.Split(',');
            s_foodID = int.Parse(value[0].Remove(0,3));
            FoodID =value[0];
            FoodName = value[1];
            PricePerQuantity = int.Parse(value[2]);
        }

    }
}