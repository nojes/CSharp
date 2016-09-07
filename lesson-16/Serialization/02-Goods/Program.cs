using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nojes.Managers;

namespace _02_Goods
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog c = new Catalog();
            DataManager dm = new DataManager();

            DialogManager m = new DialogManager("Goods Market", new string[] {
                "List",
                "Add",
                "Exit"
            });
            do
            {
                m.Welcome();

                dm.Load();
                c.Products = dm.Products;
               
                m.InputChoise();

                switch (m.Choise)
                {
                    case 1:
                        {
                            c.ConsoleWrite();
                        }
                        break;

                    case 2:
                        {
                            try
                            {
                                Product p = new Product();
                                Console.WriteLine("Input data:");

                                Console.Write("Waybill: ");
                                p.Waybill = Convert.ToString(Console.ReadLine());

                                Console.Write("Title: ");
                                p.Title = Convert.ToString(Console.ReadLine());

                                p.CreatedAt = DateTime.Now;

                                Console.WriteLine("Quantity: ");
                                p.Quantity = Convert.ToUInt32(Console.ReadLine());

                                c.AddProduct(p);
                                dm.Upload(c.Products);

                                Console.WriteLine("OK!");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("[ERROR]: {0}", ex.Message);
                            }
                        }
                        break;

                    case 3:
                        { }
                        break;

                    default:
                        { }
                        break;
                }
            } while (!m.isExit());

            m.Exit();

            //Product p = new Product("WB8468468468", "title", DateTime.Now, 5);
            //p.ConsoleWrite();
        }
    }
}
