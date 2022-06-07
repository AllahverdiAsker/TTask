using System;


namespace TTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            MMarket market = new MMarket();
            string option;
            
            do
            {
                Console.WriteLine("1. Product Elave Et");
                Console.WriteLine("2. Product Sat");
                Console.WriteLine("3. Productlara bax");
                Console.WriteLine("4. Cix");
                Console.WriteLine("\n Emeliyyati secin ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        try
                        {
                            Product product = AddProductFromConsole();
                            MMarket market = new MMarket();
                        }
                        catch(FilledException exp)
                        {
                            Console.WriteLine(exp.message);
                        }
                        catch (ProductWithNoException exp)
                        {
                            Console.WriteLine(exp.message);
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine("No info problem");
                        }
                        

                        break;
                    case "2":
                        Console.WriteLine("Product Satilir");
                        break;
                        
                    case "3":
                        Console.WriteLine("Productlara Baxilir");
                        break;
                    case "4":
                        Console.WriteLine("Sistemden Cixis");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz");
                        break;
                }


            } while (option != "4");


            static Product AddProductFromConsole()
            {
                
                    Console.WriteLine("Product Elave Et");
                    string no = Console.ReadLine();

                Console.WriteLine("Product Name Elave Et");
                string name  = Console.ReadLine();


                string n;
                int count;
                do
                {
                    Console.WriteLine("Product Sayini Daxil Et");

                    n = Console.ReadLine();
                } while (!int.TryParse(no, out count) || count<0);

                string pricee;
                double price;
                do
                {
                    Console.WriteLine("Product Qiymetini Daxil Et");

                    pricee = Console.ReadLine();
                } while (!double.TryParse(no, out price) || price < 0);

                Product product = new Product
                {
                    Name = name,
                    No = no,
                    Count = count,
                    Price = price

                };

                return product;
        }

        }
    }
}
