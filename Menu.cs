using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Menu
{
 public void MyMenu()
    {
     Console.WriteLine("hello,please select one of the next options");
     Console.WriteLine("a:to get ditels");
     Console.WriteLine("b:to get in the henion");
     Console.WriteLine("c:to get out of the henion");
     Console.WriteLine("d:to get the presents carrs");
        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine(information.getData());
                break;
            case "b":
                newCar MyCarr = new newCar();
                Console.WriteLine("please type your car compeny");
                MyCarr.Compeny = Console.ReadLine();
                Console.WriteLine("please type your car id");
                MyCarr.CarId = int.Parse(Console.ReadLine());
                Console.WriteLine("please type your car color");
                MyCarr.color = (colors)Enum.Parse(typeof(colors), Console.ReadLine());
                MyCarr.entryTime = DateTime.Now;
                bool tmp1 = cstomersList.AddCarr(MyCarr);
                if (tmp1)
                {
                    Console.WriteLine("The process ended successfully\nWelcome");   
                }
                else{Console.WriteLine("Sorry the parking lot is full");}
                break;
            case "c":
                Console.WriteLine("type car id");
                int tmp = cstomersList.Pymant(int.Parse(Console.ReadLine()));
                if(!(tmp==-1))
                {
                    Console.WriteLine($"please pay {tmp} dolars");
                }
                else
                { Console.WriteLine("ther is no car weith that id"); }
                break;
            case "d":
                cstomersList.showList();
                break;
            default:
                Console.WriteLine("there was a problem");
                break;
        }
        Console.WriteLine("===========================");
        MyMenu();
    }
}

