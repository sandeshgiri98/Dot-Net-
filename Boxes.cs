using System;
using System.ComponentModel.DataAnnotations;
// Operator Overloading : it is a way to allow operator to perform speprate operation i.e. + sign perform addition
// when inputs are integer and it also perform concatenation (join) if inputs are string 
//operator that can be overloaded are arithmetic operator like +,-,*,/,% comparision operator >,<,
//&&//
//these operator cannot be overloaded like assignment +=,-=
// =,?

namespace SWSCBasic
{
     class Boxes
    {
        private int length;
        private int breadth;
        private int height;
        public void setBoxes(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }
        //method that calculatees volume
        public void calVolume()
        {
            Console.WriteLine("volume is " + (length * breadth * height));
        }
        // overloading operator
        public static Boxes operator +(Boxes b1, Boxes b2)
        {
            Boxes b3 = new Boxes();
            b3.length = b1.length + b2.length;
            b3.breadth = b1.breadth + b2.breadth;
            b3.height = b1.height + b2.height;
            return b3; //return type is class so object should be written.

        }
        //overloading == operator (comparision operator)
        public static bool operator ==(Boxes b1, Boxes b2)
        {

            return (b1.length == b2.length && b1.breadth == b2.breadth && b1.height == b2.height); 
            
        }
        public static bool operator != (Boxes b1, Boxes b2)
        {

            return (b1.length != b2.length && b1.breadth != b2.breadth && b1.height != b2.height);
        }
    }
}
