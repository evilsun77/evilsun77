
using System;
using System.Collections.Generic;
using System.Text;

namespace adress
{
    class adress
    {
        public string city;
        public string street;
        public int number;
        public adress()
        {
            city = "";
            street = "";
            number = 0;
        }
        public void ShowCity()
        {
            Console.WriteLine("The current adress in {0}", city);
        }
        public void ShowStreet()
        {
            Console.WriteLine("The current adress on {0}", street);
        }
        public void ShowNumber()
        {
            Console.WriteLine("The current number of house is {0}", number);
        }
        public string CITY
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string STREET
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int NUMBER
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }

        }
    }

}

