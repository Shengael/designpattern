using System.Collections.Generic;
using System.Linq;

namespace _05.ESGI.DesignPattern.Strategy
{
    
    public class CreditCard: IPayement
    {
        public string Pay(int amount)
        {
            return $"{amount} has been charged to my credit card";
        }
    }

    public class Paypal: IPayement
    {
        public string Pay(int amount){
            return $"{amount} has been charged to my paypal account";
        }
    }
    
    public interface IPayement
    {
        string Pay(int amount);
    }

    public class ShoppingCard
    {
        private int amount = 0;
        public void AddItem(string element, int price)
        {
            amount += price;
        }

        public string Pay(IPayement strategy)
        {
            return strategy.Pay(amount);
        }
    }
   
}
