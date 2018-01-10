using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorAdvanced
{
    public class Carpet
    {
        //Declare Data Members
        private string name,
            quality;
        private double price;

        //Create properties to get and set the data members

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Quality
        {
            get 
            {
                return quality;
            }
            set
            {
                quality = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


        //Constructors

        public Carpet()
        {
            //default constructor
        }

        public Carpet(string carpetName, string carpetQuality, double carpetPrice)
        {
            name = carpetName;
            quality = carpetQuality;
            price = carpetPrice;
        }


        //Override ToString()
        public override string ToString()
        {
            return "Carpet Name: " + name +
                "\nCarpet Quality: " + quality +
                "\nCarpet Price: " + price.ToString("C");
        }

        //No instance methods
    }//End of class
}//End of namespace
