
namespace _5_практическая
{
    internal class Program
    {
        static void Main()
        {

            tort cake = new tort();


            int position = 1;


            ConsoleKey key = Console.ReadKey().Key;
            Console.Clear();


            cake.Zakaz();

          

            position = cake.Arrow;
            if (key == ConsoleKey.Enter)
            {

                Console.Clear();

                if (position == 5)
                {
                    Console.Clear();
                    cake.Output_Pod_Menu(cake.Tort());
                }



                if (position == 6)
                {
                    Console.Clear();
                    cake.Output_Pod_Menu(cake.Razmer());

                }



                if (position == 7)
                {
                    Console.Clear();

                    cake.Output_Pod_Menu(cake.Vkus());
                }


                if (position == 6)
                {
                    Console.Clear();
                    
                    cake.Output_Pod_Menu(cake.Korzh());
                }



                if (position == 7)
                {
                    Console.Clear();
                    
                    cake.Output_Pod_Menu(cake.Glasur());
                }


                if (position == 8)
                {
                    Console.Clear();
                    
                    cake.Output_Pod_Menu(cake.Dekor());
                }

                if (position == 9)
                {
                    Console.Clear();
                    Console.WriteLine("cggасибо за заказ");
                    Console.WriteLine("нажать Esc для нового заказа");
                    cake.Save();

                if (key == ConsoleKey.Escape)
                {
                   cake.Zakaz();
                   cake.Sborka();
                }


                }

            }
        }
    }
}