using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nojes.Managers;

namespace _02_GoodsCatalog
{ 
    /// <TODO>
    ///     <1> Goods list
    ///     <2> Add
    ///     <3> Edit
    ///         <1> Edit price
    ///         <2> Edit count
    ///     <4> Remove
    ///     <5> Search
    ///         <1> by 'Category'
    ///         <2> by 'Name'
    ///         <3> by 'Price' range
    ///         
    /// </TODO>
    class Program
    {
        static void Main(string[] args)
        {
            Catalog c = new Catalog();
            c.Init();

            DialogManager m = new DialogManager("Goods Catalog", new string[] {
                "List",
                "Update",
                "Add",
                "Exit"
            });
            do
            {
                m.Welcome();
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
                            c.Update();
                        }
                        break;

                    case 3:
                        {
                            try
                            {
                                Product p = new Product();
                                Console.WriteLine("Input data:");

                                Console.WriteLine("category:");
                                p.Category = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("name:");
                                p.Name = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("vendor:");
                                p.Vendor = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("price:");
                                p.Price = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("quantity:");
                                p.Quantity = Convert.ToUInt32(Console.ReadLine());

                                c.AddProduct(p);
                                c.Update();

                                Console.WriteLine("OK!");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("[ERROR]: {0}", ex.Message);
                            }
                        }
                        break;

                    case 4:
                        { }
                        break;

                    default:
                        { }
                        break;
                }
            } while (!m.isExit());

            m.Exit();
        }
    }
}
