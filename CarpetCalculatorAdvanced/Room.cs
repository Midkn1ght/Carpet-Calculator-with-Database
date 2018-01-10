using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorAdvanced
{
    public class Room
    {
        //declare data members
        private int lengthFt,
            lengthIn,
            widthFt,
            widthIn;

        private string name,
            location;

        //Properties to get and set private data members

        public int LengthFt
        {
            get
            {
                return lengthFt;
            }
            set
            {
                lengthFt = value;
            }
        }

        public int LengthIn
        {
            get
            {
                return lengthIn;
            }
            set
            {
                lengthIn = value;
            }
        }

        public int WidthFt
        {
            get
            {
                return widthFt;
            }
            set
            {
                widthFt = value;
            }
        }

        public int WidthIn
        {
            get
            {
                return widthIn;
            }
            set
            {
                widthIn = value;
            }

        }

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

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }


        //Constructors for room
        public Room()
        {
            //default constructor
        }

        public Room(int lFt, int lIn, int wFt, int wIn)
        {
            lengthFt = lFt;
            lengthIn = lIn;
            widthFt = wFt;
            widthIn = wIn;
            name = "Unknown";
            location = "Unknown";


        }

        public Room(int lFt, int lIn, int wFt, int wIn, string nm, string loc)
        {
            lengthFt = lFt;
            lengthIn = lIn;
            widthFt = wFt;
            widthIn = wIn;
            name = nm;
            location = loc;
        }


        //Instance Methods
        public double CalculateArea()
        {
            const int INCHES_TO_FEET = 12,
                SQ_FT_PER_SQ_YD = 9;
            double length,
                width,
                areaSqFt;


            length = lengthFt + ((double)lengthIn / INCHES_TO_FEET);
            width = widthFt + ((double)widthIn / INCHES_TO_FEET);

            areaSqFt = length * width;

            return areaSqFt / SQ_FT_PER_SQ_YD;



        }


        //Override ToString

        public override string ToString()
        {
            return "Room Name: " + name +
                "\nRoom Location: " + location +
                "\nRoom Area: " + CalculateArea().ToString("N2") + " Sq. Yds.";


        }




    }//End of class
}//End of namespace
