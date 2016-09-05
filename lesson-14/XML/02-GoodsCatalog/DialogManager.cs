using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nojes.Managers
{
    class DialogManager
    {
        string title;
        string[] menu_items;
        int choice;
        string ans;

        /// <summary>
        ///     Initializes a new instance of the DialogManager with title, menu items.
        /// </summary>
        /// <param name="title"> Title of dialog </param>
        /// <param name="menu_items">  </param>
        public DialogManager(string title, string[] menu_items)
        {
            this.title = title;
            this.menu_items = menu_items;
        }

        // Getters & Setters
        public int Choise
        {
            get { return choice; }
        }

        /// <summary>
        ///     Display passed symbol at console width. (Border)
        /// </summary>
        /// <param name="symbol"> Border symbol </param>
        void printBorder(char symbol = '-')
        {
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        /// <summary>
        ///     Format string to center of console.
        /// </summary>
        /// <param name="s"> Source string </param>
        /// <returns> Returns formated string. </returns>
        static public string ToCenter(string s)
        {
            int margin = (Console.WindowWidth - s.Length) / 2;
            string sMargin = "";
            for (int i = 0; i < margin; i++)
            {
                sMargin += " ";
            }
            return (sMargin + s);
        }

        /// <summary>
        ///     Makes pure console.
        /// </summary>
        public void Clear()
        {
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        ///     Display menu items (actions) to console.
        /// </summary>
        public void printMenuItems()
        {
            for (int i = 0; i < menu_items.Length; i++)
            {
                Console.WriteLine(" <{0}> - {1}.", (i + 1), menu_items[i]);
            }
        }

        public void Welcome()
        {
            Clear();

            this.printBorder();
            Console.WriteLine("{0}", ToCenter(title));
            this.printBorder();
            Console.ForegroundColor = ConsoleColor.Yellow;

            this.printMenuItems();
        }

        /// <summary>
        ///     Display exit message and waiting for press any key.
        /// </summary>
        public void Exit()
        {
            Console.WriteLine("\n [INFO]: Программа завершена. Нажмите любую клавишу для выхода ...");
            Console.ReadKey();
        }

        /// <summary>
        ///     Checks choise.
        /// </summary>
        /// <returns> Returns boolean </returns>
        public bool isExit()
        {
            if (choice == menu_items.Length)
            {
                return true;
            }
            else
            {
                Console.ReadKey();
            }
            return false;
        }

        /// <summary>
        ///     Setting choise of action from console.
        /// </summary>
        public void InputChoise()
        {
            Console.Write("  -> ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [ERROR]: {0}", err.Message);
            }
            finally
            {
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}