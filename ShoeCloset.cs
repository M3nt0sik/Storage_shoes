using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storage_shoes
{
    class ShoeCloset
    {
        private readonly  List<Shoe> shoes = new List<Shoe>();
        public void PrintShoes()
        {
            if(shoes.Count == 0) 
            {
                Console.WriteLine("\nSchowet na buty jest pusty.");
            }
            else
            {
                Console.WriteLine("\nSchowet na buty zawiera:");
                int i = 1;
                foreach (Shoe shoe in shoes)
                {
                    Console.WriteLine($"Para numer {i++}: {shoe.Description}");
                }
            }
        }

        public void AddShoe()
        {
            Console.WriteLine("\nDodaj parę butów.");
            for(int i = 0; i<6; i++)
            {
                Console.WriteLine($"Wcisnij {i}: aby dodac {(EStyle)i}.");
            }
            Console.Write("Podaj fason: ");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.Write("\nPodaj kolor: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((EStyle)style, color);
                shoes.Add(shoe);
            }
        }
        public void RemoveShoe()
        {
            Console.WriteLine("\nWcisnij ktory numer chcesz usunac: ");
            if( int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) && (shoeNumber >=1) && (shoeNumber <= shoes.Count))
            {
                Console.WriteLine($"\nUsuwanie pary {shoes[shoeNumber - 1].Description}");
                shoes.RemoveAt(shoeNumber - 1);
            }
        }
    }
}
