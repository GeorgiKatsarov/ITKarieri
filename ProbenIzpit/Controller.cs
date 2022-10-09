using ShoppingSystem;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Controller
{
    private List<Product> products;
    private List<Receipt> receipts;
    public Controller()
    {
        products = new List<Product>();
        receipts = new List<Receipt>();
    }

    public string ProcessProductCommand(List<string> args)
    {
        PhysicalProduct physicalProduct = new PhysicalProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
        products.Add(physicalProduct);
	return $"The current customer has bought {args[0]}.";
    }

    public string ProcessServiceCommand(List<string> args)
    {
        ServiceProduct ServiceProduct = new ServiceProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
        products.Add(ServiceProduct);
        return $"The current customer has applied for {args[0]} service.";
    }

    public string ProcessCheckoutCommand(List<string> args)
    {
        Receipt receipt = new Receipt(args[0]);
        receipts.Add(receipt);
        foreach (var item in products)
        {
            receipt.AddProduct(item);
        }
        
        
	return $"Customer checked out for a total of ${receipt.GetPriceAll():f2}.";
    }

    public string ProcessInfoCommand(List<string> args)
    {
        string parameter = args[0];
        double finalPrice = 0;
        int count  = 0;
        if (parameter.Equals("Customer"))
        {
            string g = "";
            foreach (var item in products)
            {
                count++;
                finalPrice+=item.Price;
            }
            if (receipts.Count == 0)
            {
                g = "Receipts: No receipts";
            }
            return $"Current customer has: Products:\n {count} Total Bill: ${finalPrice:f2} \n {g}";

        }
        else if (parameter.Equals("Shop"))
        {
            StringBuilder s = new StringBuilder();
            foreach (var item in receipts)
            {
                 s.AppendLine(item.ToString());
            }
            return s.ToString();
        }
        return null;
    }

    public string ProcessEndCommand()
    {
     int countReceipts = receipts.Count;
        return $"Total customers today: {countReceipts}";
    }

}
