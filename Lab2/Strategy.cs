using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
   public  interface IOZUType
    {
        string OZU();
    }

    public class DDR4OZU : IOZUType
    {
        public string OZU()
        {
            return "DDR4";
        }
    }

    public class DDR3OZU : IOZUType
    {
        public string OZU()
        {
            return "DDR3";
        }
    }
}
