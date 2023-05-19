using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Card_Simulation_Rev._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreditCard card1 = new CreditCard();




            Console.WriteLine("Enter card number");

            card1.cardNumber = Console.ReadLine();

            // SIMPLIFIED 
            //try
            //{

            //    start:
            //    card1.cardNumber = Console.ReadLine();

            //    string cardPatternMasterCard = @"^(?:2131|1800|35\d{3})\d{11}$";
            //    string cardPatternVisa = @"^(?: 4[0 - 9]{ 12} (?:[0 - 9]{ 3})?| 5[1 - 5][0 - 9]{ 14})$";


            //    Match matchMaster = Regex.Match(card1.cardNumber, cardPatternMasterCard);
            //    Match matchVisa = Regex.Match(card1.cardNumber, cardPatternVisa);


            //    if (matchMaster.Success || matchVisa.Success)
            //    {
            //        Console.WriteLine("Card is true");

            //    }

            //    else
            //    {

            //        Console.WriteLine("Card number is no valid, type again ");
            //        goto start;
            //    }
            //}

            //catch
            //{

            //    Console.WriteLine("");
            //}

            Console.Clear();


            Console.WriteLine("Enter CVC (3 digits only) ");
            startCVC:
            try
            {   
                card1.CVC = Convert.ToInt32(Console.ReadLine());

            }

            catch
            {

                Console.WriteLine("Numbers only");
                goto startCVC;

            }


            if (card1.CVC < 1000 && card1.CVC > 99)
                {
                    Console.WriteLine("CVC correct");
                }
                else
                {
                    Console.WriteLine("Incorrect CVC, type again");
                    goto startCVC;

                }



            Console.Clear();



            Console.WriteLine("Enter card  termination month");

            startMonth:
            try
            {
                card1.terminationMonth = Convert.ToByte(Console.ReadLine());
            }


            catch
            {

                Console.WriteLine(" Month is not correct, try again");
                goto startMonth;

            }

            if (card1.terminationMonth > 0 && card1.terminationMonth <= 12)
            {
                Console.WriteLine(" Month is correct");


            }

            else
            {
                Console.WriteLine(" Month is not correct, try again");
                goto startMonth;

            }



            Console.Clear();


            Console.WriteLine("Enter card  termination year");


            startYear:
            try
            {

                card1.terminationYear = Convert.ToInt32(Console.ReadLine());

            }

            catch
            {


                Console.WriteLine(" Year is not correct, try again");
                goto startYear;
            }

            if (card1.terminationYear >= DateTime.Now.Year)
            {
                Console.WriteLine("Year is correct");
            }


            else
            {
                Console.WriteLine(" Year is not correct, try again");
                goto startYear;

            }
            Console.Clear();
            Console.WriteLine("Enter card holder name");

            card1.cardholderNameAndSurname = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Enter bank name");

            card1.bankName = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Set initial balance");

            startBalance:
            try
            {

                card1.cardBalance = Convert.ToInt32(Console.ReadLine());
               

            }

            catch
            {
                Console.WriteLine("Only numbers");
                goto startBalance;

            }



            Console.Clear();


            MenuStart:
            Console.WriteLine("1. See card info");
            Console.WriteLine("2. Change balance of card");

           int key= Int32.Parse(Console.ReadLine());

            switch (key)


            {
                case 1:

                    card1.ToString();

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                    goto MenuStart;

                case 2:
                    card1.cardBalance= card1.balanceChange(card1.cardBalance);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                    goto MenuStart;





            }



        }
    }
}