using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public static class cstomersList
{
    static newCar[] MyList = new newCar[information.content];
    public static void showList()
    {
        int CurrentQuantity = 0;
        for (int i = 0; i < MyList.Length; i++)
        {
            if (!(MyList[i]==null))
            {
                CurrentQuantity++;
                Console.WriteLine(MyList[i].getData());
            }
        }
        Console.WriteLine($"Number of vehicles in the parking lot now:{CurrentQuantity}");
    }
    public static bool AddCarr(newCar MyCarr)
    {
        for (int i = 0; i < MyList.Length; i++)
        {
            if (MyList[i]==null)
            {
                MyList[i] = MyCarr;
                return true;
            }
        }
        return false;
    }
    public static bool DelitCarr(int i)
    {
            MyList[i] = null ;
            return true;
    }

    public static int find(int id)
    {
        for (int i = 0; i < MyList.Length; i++)
        { 
            if (MyList[i].CarId == id)
            {
                return i;
            }
        }     
        return -1;
    }

    public static int Pymant(int i)
    {
        int tmp = find(i);
        if (tmp == -1) return -1;
        DateTime exitTime = DateTime.Now;
        TimeSpan ts = exitTime.Subtract(MyList[tmp].entryTime);
        int minutes = ts.Minutes;
        int pay = (minutes % 60 == 0) ? (ts.Hours) : (ts.Hours) + 1;
        cstomersList.DelitCarr(tmp);
        return pay*(Convert.ToInt32(information.Price));
    }
}

