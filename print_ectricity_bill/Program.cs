using System.Runtime.ConstrainedExecution;

namespace print_ectricity_bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String customer_id, customer_name;
            double units_consumed,surcharge_amount;
            surcharge_amount= 15/100;

            Console.WriteLine("Enter Your ID ");
            customer_id= Console.ReadLine();
            Console.WriteLine("Enter Your  Name ");
            customer_name = Console.ReadLine();
          
            Console.WriteLine("Enter units Consumed");
            units_consumed = Convert.ToInt32(Console.ReadLine());

            if(units_consumed>=100 & units_consumed<199)
            {
                Console.WriteLine("Customer IDNO                    :" + customer_id);
                Console.WriteLine("Customer Name                    :" + customer_name);
                Console.WriteLine("Units Consumed                   :" + units_consumed);
                Console.WriteLine("Amount per unit                  :R 1.20 ");
                Console.WriteLine("Amount Due                       : R" + units_consumed * 1.20);
                Console.WriteLine("Surcharge Amount                   :" +"R"+surcharge_amount);
                Console.WriteLine("Net Amount paid by the customer  :R " + units_consumed * 1.20 + surcharge_amount);
            }
            else if(units_consumed>=200 & units_consumed<400)
            {
                Console.WriteLine("Customer IDNO                    :" + customer_id);
                Console.WriteLine("Customer Name                    :" + customer_name);
                Console.WriteLine("Units Consumed                   :" + units_consumed);
                Console.WriteLine("Amount per unit                  :R 1.50 ");
                Console.WriteLine("Amount Due                       : R" + units_consumed * 1.50);
                Console.WriteLine("Suchage Amount                   :" + "R" + 0);
                Console.WriteLine("Net Amount paid by the customer  :R " + units_consumed * 1.50 + 0);
            }
            else if (units_consumed >= 400 & units_consumed <600)
            {
                Console.WriteLine("Customer IDNO                    :" + customer_id);
                Console.WriteLine("Customer Name                    :" + customer_name);
                Console.WriteLine("Units Consumed                   :" + units_consumed);
                Console.WriteLine("Amount per unit                  :R 1.50 ");
                Console.WriteLine("Amount Due                       : R" + units_consumed * 1.80);
                Console.WriteLine("Suchage Amount                   :" + "R"+ 15/100*);
                Console.WriteLine("Net Amount paid by the customer  :R " + units_consumed * 1.80 + 40);
            }
            else if (units_consumed < 600)
            {
                Console.WriteLine("Customer IDNO                    :" + customer_id);
                Console.WriteLine("Customer Name                    :" + customer_name);
                Console.WriteLine("Units Consumed                   :" + units_consumed);
                Console.WriteLine("Amount per unit                  :R 2.0 ");
                Console.WriteLine("Amount Due                       : R" + units_consumed * 2.0);
                Console.WriteLine("Suchage Amount                   :" + "R" + );
                Console.WriteLine("Net Amount paid by the customer  :R " + units_consumed * 2.0 + 0);
            }



        }
    }
}