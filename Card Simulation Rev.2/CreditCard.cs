using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Card_Simulation_Rev._2
{
    internal class CreditCard
    {

        public string cardNumber { get; set; }


        public int CVC { get; set; }



        public byte terminationMonth { get; set; }





        public int terminationYear { get; set; }


        public string cardholderNameAndSurname { get; set; }

        public string bankName { get; set; }


        public int cardBalance { get; set; }



        public int balanceChange(int  cardBalance)
        {

            Console.WriteLine("Press A for increment balance and B for deduct");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.WriteLine("Enter amount of money increment");

            startincrement:
                try

                {

                    int moneyPlus = Int32.Parse(Console.ReadLine());
                    cardBalance += moneyPlus;
                    Console.WriteLine($"Your new balance is {cardBalance}");
                    return cardBalance;
                   

                }

                catch

                {


                    Console.WriteLine("Wrong input");
                    goto startincrement;
                }


                

            }

            else if (Console.ReadKey().Key != ConsoleKey.B)

                Console.WriteLine("Enter amount of money decrement");
            startdecrement:
            try

            {

                int moneyMinus = Int32.Parse(Console.ReadLine());
                cardBalance -= moneyMinus;
                Console.WriteLine($"Your new balance is {cardBalance}");
                return cardBalance; 

            }

            catch

            {


                Console.WriteLine("Wrong input");
                goto startdecrement;
            }





           
        }

        public override string ToString()
        {
           
            string message =($" Card number: {cardNumber}\n CVC: {CVC}\n Termination date {terminationMonth}/ {terminationYear}\n Cardholder:{cardholderNameAndSurname}\n BankName: {bankName}\n Card Balance: {cardBalance}\n");
            Console.WriteLine( message);
            return message;
        }
        







    }

}
