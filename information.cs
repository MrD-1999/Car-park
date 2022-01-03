using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   static  class information
{
    private static string city = "gerusalem" ;
    private static string street = "ben chion";
    private static int hauseName = 14;
    private static int compenyNume = 315246553;
    public static int content = 100;
    private static double price = 120;
    public static string City { get { return city; } set { city = value; } }
    public static string Street { get { return street; } set { street = value; } }
    public static int HauseName { get { return hauseName; } set { hauseName = value; } }
    public static int CompenNume { get { return compenyNume; } set { compenyNume = value; } }
    public static int Content { get { return content; } set { content = value; } }
    public static double Price { get { return price; } set { price = value; } }

    public static string getData() { return string.Format("city:{0}\nstreet:{1}\nhauseName:{2}\n" +
        "compenyNume:{3}\ncontent:{4}\nprice:{5}",City,Street,HauseName,
        CompenNume,Content,Price); }


}

