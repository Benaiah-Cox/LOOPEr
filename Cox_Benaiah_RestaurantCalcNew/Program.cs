using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cox_Benaiah_RestaurantCalcNew
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Bill;
            decimal Bill2;
            decimal Bill3;

            // Benaiah cox june 27th 2018
            //strings creating the bill quantity in order to convert to a number along with the prompt
            Console.WriteLine("Please enter the price of the first bill and press enter");
            String bill1 = Console.ReadLine();
            while (! decimal.TryParse(bill1 ,out Bill))
            {
                Console.WriteLine("please enter a number");
                bill1 = Console.ReadLine();
            }
            Console.WriteLine("Please enter the second of the bills and press enter");
            string bill2 = Console.ReadLine();

            while (!decimal.TryParse(bill2, out Bill2))
            {
                Console.WriteLine("please enter a number");
                bill2 = Console.ReadLine();
            }

            Console.WriteLine("Please enter the 3rd prices of the bills and press enter");
            String bill3 = Console.ReadLine();
            while (!decimal.TryParse(bill3, out Bill3))
            {
                Console.WriteLine("please enter a number");
                bill3 = Console.ReadLine();
            }
            decimal perc1;
            decimal perc2;
            decimal perc3;

            //strings creating percentages to be converted along with a prompt
            Console.WriteLine("Please enter the % for the first tip  to be added to the bill");
          
            String p1 = Console.ReadLine();
            
            while (!decimal.TryParse(p1, out perc1))
            {
                {
                    Console.WriteLine("please enter a number");
                   p1 = Console.ReadLine();
                }
            }
            perc1 = perc1 / 100;

            Console.WriteLine("Please enter the % for the second tip  to be added to the bill");
            String p2 = Console.ReadLine();
            while (!decimal.TryParse(p2, out perc2))
            {
                {
                    Console.WriteLine("please enter a number");
                    p2 = Console.ReadLine();
                }
            }
            perc2 = perc2 / 100;

           
            Console.WriteLine("Please enter the % for the third tip  to be added to the bill");
            String p3 = Console.ReadLine();
            while (!decimal.TryParse(p3, out perc3))
            {
                {
                    Console.WriteLine("please enter a number");
                    p3 = Console.ReadLine();
                }
            }
            perc3 = perc3 / 100;


            //the  numbers being actively converted to a decimal because its a number



            ///disolay of the tip amount to be  added to the bill
            Console.WriteLine("Tip1=" + (perc1 * Bill));
            Console.WriteLine("Tip2=" + perc2 * Bill2);
            Console.WriteLine("Tip3=" + perc3 * Bill3);
            Console.WriteLine("The total tip =" +((perc1 * Bill) + (perc3 * Bill3 ) + (perc2 * Bill2)));


            //display of the bill outputs.
            Console.WriteLine("Bill1 =" + (perc1 * Bill + Bill));
            Console.WriteLine("Bill2 =" + (perc2 * Bill2 + Bill2));
            Console.WriteLine("Bill3 =" + (perc1 * Bill3 + Bill3));
            Console.WriteLine("If one person was paying the bill would be" + ((perc1 * Bill + Bill) + (perc2 * Bill + Bill) + (perc1 * Bill + Bill)) + " ");
            Console.WriteLine("If they were splitting the bill evenly each person would pay" + ((perc1 * Bill + Bill) + (perc2 * Bill + Bill) + (perc1 * Bill + Bill) / 3 ) + " ");
            /// to cheack I used the number 150 with a tip percentage of 10 and the tip amount was 15.00. Total 
        }
    }
}


