using Storage_shoes;

internal class Program
{  
    static ShoeCloset shoeCloset = new ShoeCloset();
    private static void Main(string[] args)
    {
        while (true)
        {
            shoeCloset.PrintShoes();
            Console.WriteLine("\nWcisnij 'd' aby dodac, lub 'u', aby usunac buty: ");
            char key = Console.ReadKey().KeyChar;

            switch (key)
            {
                case 'd':
                case 'D':
                    shoeCloset.AddShoe();
                    break;
                case 'u':
                case 'U':
                    shoeCloset.RemoveShoe();
                    break;
                default:
                    return;
            }
        }
    }
}