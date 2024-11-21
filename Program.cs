using System;

namespace BasicPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            var posManager = new POSManager<decimal, string>();

            while (true)
            {
                Console.WriteLine("\n=== Simple POS System ===");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                        Console.Write("Enter product price: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal addPrice))
                        {
                            Console.Write("Enter product name: ");
                            string addName = Console.ReadLine();
                            posManager.Create(addPrice, addName);
                        }
                        else
                        {
                            Console.WriteLine("Invalid price format. Please enter a valid number.");
                        }
                        break;

                    case "2": 
                        posManager.Read();
                        break;

                    case "3": 
                        Console.Write("Enter product price to update: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal updatePrice))
                        {
                            Console.Write("Enter new product name: ");
                            string updateName = Console.ReadLine();
                            posManager.Update(updatePrice, updateName);
                        }
                        else
                        {
                            Console.WriteLine("Invalid price format. Please enter a valid number.");
                        }
                        break;

                    case "4": 
                        Console.Write("Enter product price to delete: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal deletePrice))
                        {
                            posManager.Delete(deletePrice);
                        }
                        else
                        {
                            Console.WriteLine("Invalid price format. Please enter a valid number.");
                        }
                        break;

                    case "5": 
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}