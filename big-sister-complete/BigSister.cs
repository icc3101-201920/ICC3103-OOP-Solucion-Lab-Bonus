using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace big_sister_complete
{
    public class BigSister
    {
        public void OnProductAdded(object source, AddedProductEventArgs e)
        {
            foreach (Product p in e.ShopList)
            {
                if (p.Name.Equals(e.Product.Name))
                {
                    if (p.Stock < 1)
                    {
                        e.Cart.Products.Remove(e.Product);
                        e.Product.Stock++;
                        Console.Clear();
                        Console.WriteLine("No Matias! Malo!\nBigGrumpySister devuelve el/la " + p.Name + " que Matias queria...\n");
                    }
                    else
                    {
                        p.Stock--;
                    }
                }
            }
                
            
            Console.WriteLine("\n\nPresiona ENTER para volver al supermercado...");
            ConsoleKeyInfo response = Console.ReadKey(true);
            while (response.Key != ConsoleKey.Enter)
            {
                response = Console.ReadKey(true);
            }
        }

        public bool OnPaying(object source, PayingEventArgs e)
        {
            foreach (Product p in e.ShopList)
            {
                if (p.Stock > 0)
                {
                    Console.Clear();
                    Console.WriteLine("No Matias! Malo! Debemos terminar toda la lista\n Matias, no se pudo ir...\n");
                    Console.WriteLine("\n\nPresiona ENTER para volver al supermercado...");
                    ConsoleKeyInfo response = Console.ReadKey(true);
                    while (response.Key != ConsoleKey.Enter)
                    {
                        response = Console.ReadKey(true);
                    }
                    return false;
                }
            }
            return true;
        }
    }
}
