using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit2._15._10._2022
{
    public class Controller
    {
        List<Store> stores = new List<Store>() ;
        List<Product> products = new List<Product>() ;
        public string CreateStore(List<string> args)
        {
            
            Store store = new Store(args[1], args[2]);
            stores.Add(store);
            return $"Store {args[1]} was successfully registerd in the system!";
            
        }

        public string ReceiveProduct(List<string> args)
        {

            if (args[1].Equals("Food"))
            {
                Food product = new Food(args[2], int.Parse(args[3]), double.Parse(args[4]), double.Parse(args[5]));
                foreach (var item in stores)
                {
                    if (item.Name.Equals(args[6]))
                    {
                        if (item.ReceiveProduct(product))
                        {
                            return $"Product {args[2]} was successfully delivered to {args[6]}!";
                        }
                    }
                }
            }
            else if (args[1].Equals("Drink"))
            {
                 Drink product = new Drink(args[2], int.Parse(args[3]), double.Parse(args[4]), double.Parse(args[5]));
                foreach (var item in stores)
                {
                    if (item.Name.Equals(args[6]))
                    {
                        if (item.ReceiveProduct(product))
                        {
                            return $"Product {args[2]} was successfully delivered to {args[6]}!";
                        }
                    }
                }
            }
            
            
            return "Invalid command";
        }

        public string SellProduct(List<string> args)
        {
            foreach (var item in stores)
            {
                if (item.Name.Equals(args[3]))
                {
                    if (item.SellProduct(args[1], int.Parse(args[2])))
                    {
                        return $"Product {args[1]} was successfully bought from {args[3]}!";
                    }
                    
                }
            }
            return "Invalid command";
        }

        public string StoreInfo(List<string> args)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in stores)
            {
                if (item.Name.Equals(args[1]))
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public string Shutdown()
        {
            double rev = 0;
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Stores: {stores.Count()}");
            foreach (var item in stores)
            {
                rev += item.GetRevenue();
                builder.AppendLine(item.ToString());
            }
            stores.Sort();
            stores.Reverse();
            return builder.ToString();
        }

    }
}
