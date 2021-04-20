using System;

namespace adress
{
    class Program
    {
        static void Main(string[] args)
        {
            adress adress1 = new adress();
            adress1.CITY = Polotsk;
            adress1.STREET = Oktabrkskaya street;
            adress1.NUMBER = 49;
            adress1.ShowCity();
            adress1.ShowStreet();
            adress1.ShowNumber();

        }
    }
}