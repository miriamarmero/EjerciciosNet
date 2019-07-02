using System;

namespace _1_Bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 year = Convert.ToInt16(args[0]);
            bool result = isBisiesto(year);
            if (result){
                Console.WriteLine(year + " Es bisiesto");
            } else {
                Console.WriteLine(year + " No es bisiesto");                
            }
        }

        static bool isBisiesto(Int32 year)
        {
            if((year % 400) == 0){
                return true;
            } else {
                return false;
            }
        }
    }
}
