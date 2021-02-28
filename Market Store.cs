using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    class Program
    {
        static void Main(string[] args)
        {
             

            try
            {
                BronzeCard Bronze_Card = new BronzeCard("Nikola", 0);
                Bronze_Card.Discount_calculations(150);
               

                SilverCard Silver_Card = new SilverCard("Viktor", 600);
                Silver_Card.Discount_calculations(850);

                GoldCard Gold_Card = new GoldCard("Dimitar", 1500);
                Gold_Card.Discount_calculations(1300);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0} thrown.", e.GetType().FullName);
                Console.WriteLine("Message:\n\"{0}\"", e.Message);
            }

                        

            Console.ReadKey();
        }//Main
    }

    public interface IDiscount_Card
    {
        void Discount_calculations(double valueOfPurchase);

    }



    public class BronzeCard : IDiscount_Card
    {
        private string owner_name;
        private double turnoverLastMonth;
        private double discountRate;
        

        public BronzeCard() { }


        public BronzeCard(string owner_name, double turnoverLastMonth)
        {
            Owner_Name = owner_name;
            TurnoverLastMonth = turnoverLastMonth;
        }

        
         
        public void Discount_calculations(double valueOfPurchase)
        {
           
            if (TurnoverLastMonth < 100)
            {
                DiscountRate = 0;
            }
            else if (TurnoverLastMonth >= 100 && TurnoverLastMonth <= 300)//=
            {
                DiscountRate = 1;
            }
            else { DiscountRate = 2.5; }



            try
            {
                double discount = ((valueOfPurchase * discountRate) / 100);               
                double total = valueOfPurchase - discount;

                Console.WriteLine("Bronze");
                Console.WriteLine("Purchase value: ${0:F2}", valueOfPurchase);
                Console.WriteLine("Discount rate: {0:F2}", discountRate + "%");
                Console.WriteLine("Discount: ${0:F2}", discount);
                Console.WriteLine("Total: ${0:F2}", total);
                Console.WriteLine();
                Console.WriteLine();

            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }

        }


        public string Owner_Name
        {
            get { return owner_name; }
            set
            {
                if (value == null) { throw new ArgumentNullException("ArgumentNullException..."); }
                else { owner_name = value; }
            }
        }

        public double TurnoverLastMonth
        {
            get { return turnoverLastMonth; }
            set { turnoverLastMonth = value; }
        }

        public double DiscountRate
        {
            get { return discountRate; }
            set { discountRate = value; }//
        }


    }



    public class SilverCard : IDiscount_Card
    {
        private string owner_name;
        private double turnoverLastMonth;
        private double discountRate;


        public SilverCard() { }


        public SilverCard(string owner_name, double turnoverLastMonth)
        {
            Owner_Name = owner_name;
            TurnoverLastMonth = turnoverLastMonth;

        }

                 


        //override
        public void Discount_calculations(double valueOfPurchase)
        {


            if (TurnoverLastMonth <= 300)
            {
                DiscountRate = 2;
            }
            else 
            {
                DiscountRate = 3.5;
            }

            try
            {
                double discount = ((valueOfPurchase * discountRate) / 100);
                double total = valueOfPurchase - discount;

                Console.WriteLine("Silver");
                Console.WriteLine("Purchase value: ${0:F2}", valueOfPurchase);
                Console.WriteLine("Discount rate: {0:F2}", discountRate + "%");
                Console.WriteLine("Discount: ${0:F2}", discount);
                Console.WriteLine("Total: ${0:F2}", total);
                Console.WriteLine();
                Console.WriteLine();
            }

            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }

        }


        public string Owner_Name
        {
            get { return owner_name; }
            set
            {
                if (value == null) { throw new ArgumentNullException("ArgumentNullException..."); }
                else { owner_name = value; }
            }
        }

        public double TurnoverLastMonth
        {
            get { return turnoverLastMonth; }
            set { turnoverLastMonth = value; }
        }

        public double DiscountRate
        {
            get { return discountRate; }
            set { discountRate = value; }
        }

    }










    public class GoldCard : IDiscount_Card
    {
        string owner_name;
        double turnoverLastMonth;
        double discountRate;
         

        public GoldCard() { }

        public GoldCard(string owner_name, double turnoverLastMonth)
        {
            Owner_Name = owner_name;
            TurnoverLastMonth = turnoverLastMonth;
        }
         

         

        //override
        public void Discount_calculations(double valueOfPurchase)
        {
           
            if (TurnoverLastMonth < 100)
            {
                DiscountRate = 2;
            }
            else  
            {
                DiscountRate = 2;
                DiscountRate += (Math.Floor((TurnoverLastMonth) / 100));
                if (DiscountRate > 10)
                {
                    DiscountRate = 10;
                }
            }

                         


            try
            {

                double discount = ((valueOfPurchase * discountRate) / 100);
                double total = valueOfPurchase - discount;

                Console.WriteLine("Gold");
                Console.WriteLine("Purchase value: ${0:F2}", valueOfPurchase);
                Console.WriteLine("Discount rate: {0:F2}", discountRate + "%");
                Console.WriteLine("Discount: ${0:F2}", discount);
                Console.WriteLine("Total: ${0:F2}", total);
                Console.WriteLine();
            }

            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            


        }


        public string Owner_Name
        {
            get { return owner_name; }
            set
            {
                if (value == null) { throw new ArgumentNullException("ArgumentNullException..."); }
                else { owner_name = value; }
            }
        }

        public double TurnoverLastMonth
        {
            get { return turnoverLastMonth; }
            set { turnoverLastMonth = value; }
        }

        public double DiscountRate
        {
            get { return discountRate; }
            set { discountRate = value; }
        }


    }//






}
