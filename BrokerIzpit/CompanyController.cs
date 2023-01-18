using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public class CompanyController
    {
        List<Company> CompanyList = new List<Company>();
         
        public string CreateCompany(List<string> args)
        {
            Company company = new Company(args[1]);
            CompanyList.Add(company);
            return "";
        }

        public string RegisterBuilding(List<string> args)
        {
            if (args[1].Equals("Residence"))
            {
                Residence building = new Residence(args[2], args[3], int.Parse(args[4]), double.Parse(args[5]));

                foreach (var item in CompanyList)
                {
                    if (item.Name.Equals(args[6]))
                    {
                        item.Buildings.Add(building);
                    }
                }
            }
            else if (args[1].Equals("Hotel"))
            {
                Hotel building = new Hotel(args[2], args[3], int.Parse(args[4]), double.Parse(args[5]));
                foreach (var item in CompanyList)
                {
                    if (item.Name.Equals(args[6]))
                    {
                        item.Buildings.Add(building);
                    }
                }
            }
            else if (args[1].Equals("Business"))
            {
                Business building = new Business(args[2], args[3], int.Parse(args[4]), double.Parse(args[5]));
                foreach (var item in CompanyList)
                {
                    if (item.Name.Equals(args[6]))
                    {
                        item.Buildings.Add(building);
                    }
                }
            }
            return "";
        }

        public string RegisterBroker(List<string> args)
        {
            Broker broker = new Broker(args[1], int.Parse(args[2]), args[3]);
            foreach (var item in CompanyList)
            {
                if (item.Name.Equals(args[4]))
                {
                    item.Brokers.Add(broker);
                }
            }
            return "";

        }

        public string RentBuilding(List<string> args)
        {
            foreach (var item in CompanyList)
            {
                if (item.Name.Equals(args[1]))
                {  
                   foreach (var building in item.Buildings)
                        {
                            if (building.Name.Equals(args[2]))
                            {
                              foreach (var broker in item.Brokers)
                              {
                                if (broker.Name.Equals(args[3]))
                                {
                                    broker.ReceiveBonus(building);
                                }
                              }
                            }
                        }
                    
               
            }
            return "";

        }

        public string CompanyInfo(List<string> args)
        {
            return "";

        }

        public string Shutdown()
        {
            return "";

        }

    }
}
