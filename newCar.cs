using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum colors { red, blue, yelow }
    public class newCar
    {
       public string Compeny { get; set; }
       public int CarId { get; set; }
       public DateTime entryTime { get; set; }
       public colors color { get; set; } 
      public string getData()
        {
        return $"compeny:{Compeny}\ncarID:{CarId}\nentry time:{entryTime}\ncolor:{color}";
        }
    }

