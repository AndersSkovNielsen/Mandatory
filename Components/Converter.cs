using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    //Navngiv projekt og klasse anderledes (fx. Components namespace != Components class)
    public class Converter
    {
        public static double ToGrams(double ounces)
        {
            return ounces * 28.34952;
        }

        public static double ToOunces(double grams)
        {
            return grams * 0.03527396195;
        }
    }
}
