using System;



namespace _5_практическая
{
    internal class tort
    {
        private int cto;
        private string zakaz;

        public void Zakaz()
        {
            Console.WriteLine("вы в магазине ABOBA, ваш заказ??77?");
            Console.WriteLine("Выберете торт");
            Console.WriteLine(" ");
            Console.WriteLine("======================");
            Console.WriteLine(" ");
            Console.WriteLine("   форма");
            Console.WriteLine("   размер");
            Console.WriteLine("   вкус");
            Console.WriteLine("   количество");
            Console.WriteLine("   глазурь");
            Console.WriteLine("   декор");
            Console.WriteLine("  Заказ завершен");
            Console.WriteLine(" ");
            Console.WriteLine("======================");
            Console.WriteLine("Цена: " + cto);
            Console.WriteLine("Ваш заказ: " + zakaz);
        }

        public List<PodMenu> Tort()
        {


            PodMenu treu = new PodMenu();
            PodMenu kroog = new PodMenu();
            PodMenu kvadrat = new PodMenu();

            treu.title = "тругольник";
            treu.price = 200;
            

            kroog.title = "круг";
            kroog.price = 200;
           
            kvadrat.title = "квадрат";
            kvadrat.price = 200;




            List<PodMenu> tort = new()
            {
                treu,
                kroog,
                kvadrat
            };

              return tort;
        }




        public List<PodMenu> Razmer()
        {
            PodMenu bol = new();
            PodMenu sred = new();
            PodMenu mal = new();


            bol.title = "большой";
            bol.price = 600;
             

            sred.title = "средний";
            sred.price = 400;
             

            mal.title = "маленький";
            mal.price = 200;

            List<PodMenu> razmer = new()
            {
                bol,
                sred,
                mal
            };

            return razmer;
        }



        public List<PodMenu> Vkus()
        {
            PodMenu sho = new();
            PodMenu klub = new();
            PodMenu cher = new();



            sho.title = "малиновыйй";
            sho.price = 2500;
           

            klub.title = "клубничный";
            klub.price = 1500;
            

            cher.title = "чепничный";
            cher.price = 1000;

            List<PodMenu> vkus = new()
            {
                sho,
                klub,
                cher
            };

            return vkus;
        }




        public List<PodMenu> Korzh()
        {
            PodMenu one = new();
            PodMenu two = new();
            PodMenu three = new();


            one.title = "1";
            one.price = 2000;
            

            two.title = "2";
            two.price = 3000;
         

            three.title = "3";
            three.price = 4000;

            List<PodMenu> korzh = new()
            {
                one,
                two,
                three
            };

            return korzh;
        }



        public List<PodMenu> Glasur()
        {
            PodMenu shoko = new();
            PodMenu milk = new();
            PodMenu vanil = new();


            shoko.title = "шоколадная";
            shoko.price = 1050;
         
            

            milk.title = "молочная";
            milk.price = 2050;
       


            vanil.title = "Безе";
            vanil.price = 3500;

            List<PodMenu> glasur = new()
            {
                shoko,
                milk,
                vanil
            };

            return glasur;
        }
        public List<PodMenu> Dekor()
        {
            PodMenu wildberiesssss = new();
            PodMenu zhe = new();
            PodMenu no = new();


            wildberiesssss.title = "ягоды";
            wildberiesssss.price = 5685743;
            

            zhe.title = "по вашему желанию";
            zhe.price = 25635400;
           

            no.title = "не придумали пока";
            no.price = 334567800;

            List<PodMenu> dekor= new()
            {
                wildberiesssss,
                zhe,
                no
            };

            return dekor;
        }




        public void Output_Pod_Menu(List<PodMenu> List)              
        {

            int position = 1;

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();


               position = Arrow;

                foreach (PodMenu Podmenu in List)                                      

                {                    
                    Console.WriteLine(Podmenu.title);
                    Console.WriteLine( Podmenu.price);
                }

              

                if (key == ConsoleKey.Enter)
                {
                    cto += List[position].price;                  
                    zakaz += List[position].title;   
                    
                    break;
                }

                if (key == ConsoleKey.Escape)
                {
                    Zakaz();
                }


            }
        }
        public int Arrow
        {
            get                              //не может найти пути возвращения кода...
            {
                int posi = 1;

                ConsoleKeyInfo key = Console.ReadKey();




                while (key.Key != ConsoleKey.Enter)
                {
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        posi--;
                        return posi;
                    }

                    if (key.Key == ConsoleKey.DownArrow)
                    {

                        posi++;
                        return posi;
                    }


                    Console.SetCursorPosition(0, posi);
                    Console.WriteLine("=>");
                    return posi;
                }
            }
        }

        public void Sborka()
        {
            zakaz = "";
            cto = 0;
        }

        public void Save()
        {
            File.AppendAllText("C:\\Users\\Светлана\\Desktop\\cake_story.txt", cto.ToString());
            File.AppendAllText("C:\\Users\\Светлана\\Desktop\\cake_story.txt", zakaz.ToString());
        }

    }


}
