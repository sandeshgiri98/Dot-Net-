using SWSCBasic;
using System;
using System.Diagnostics.CodeAnalysis;


namespace swscbasic
{
    
  
    
    class Rectangle
    {
        int length;
        int breadth;
        /*
         constructor  used to initialize the value of instant variable.
         by default  we have one constructor on program default const.
         constructor name is same as class.
            */

        public Rectangle()
        {
            Console.WriteLine("this is default constructor");
        }
        public Rectangle( int length , int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        /*
         method : use to provide the service.
         method without parameter and return type.
        */
        public void ract()
        {
            Console.WriteLine("this is method without parameter and return type");
        }
        // method without return type
        public void calcArea()
        {
            int area = this.length * this.breadth;
            Console.WriteLine("area is " + area);
        }
        //method with return type.
        public int calcPeri()
        {
            int peri = 2 * (this.length + this.breadth);
            return (peri);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
           // basic oops.
            Rectangle r1 = new Rectangle(); // call default constructor
            Rectangle r2 = new Rectangle(2, 3); // call parameterize constructor
            // calling first mehtod
            r1.ract();
            // calling second mehtod
            r2.calcArea();

            // calling this method
            int perimeter = r2.calcPeri();
            Console.WriteLine("perimeter is " + perimeter);
            

            Console.WriteLine("..............method overloading");
            Calculation c1 = new Calculation();
            c1.Calc();
            c1.Calc(12, 2);
            c1.Calc(2.4, 5.3);
            int finalresult = c1.Calc(2, 3, 4);
            Console.WriteLine("result is:" + finalresult);
           

            Console.WriteLine("..... accessing properties---");
            Box B1 = new Box();
            B1.Length = 2.02;// setting  value for length.
            B1.Breadth = 3.03;// setting value for breadth.
            B1.Height = 4.23;// setting value for height.
            

            //calculating volume of box..
            double Volume = B1.Length * B1.Breadth * B1.Height;
            Console.WriteLine("Volume is :" + Volume);
          

            AreaofCircle a1 = new AreaofCircle();
            a1.Radious = 2.01;
            double Area = 3.143 * a1.Radious * a1.Radious;
            Console.WriteLine("Area of circle is: " + Area);
           

    

            // inheritance
            Console.WriteLine("--single level inheritance---");
            Student s1 = new Student();
            // using parent properties.
            s1.setPerson( 12,"ram", "Male", 20);
            s1.displayPerson();
            // for student
            s1.setStudent("Bca", "A+");
            s1.displayStudent();

            // using teacher class 
            Teacher t1 = new Teacher();
            t1.setPerson(2, "aa", "male", 30);
            t1.displayPerson();
            // using own perporties.
            t1.setTeacher("Account", "teacher");
            t1.displayTeacher();

            //multilevel inheritance
            Console.WriteLine("---example on multilevel inheritance---");

            ElectricCar e1 = new ElectricCar();

            // using grandparent(vechile) properties.
            e1.setVehicle(12, "2822", "Hoda");
            e1.displayVehicle();

            // using parent properties (car)
            e1.setCar("auto", "1200");
            e1.displayCar();

            // using own

            car ca = new car();
            ca.setVehicle(2, "3030", "Santro");
            ca.displayVehicle();
            ca.setCar("manual", "280");
            ca.displayCar();

            // calling supperclass constructor from sub-class.
            Console.WriteLine("-- Example on calling default constructor inheritance---");
            Bike bi = new Bike(); // Default constructor called..

            Console.WriteLine("--example on calling parameterized constructor of supperclass");
            Bike Bi2 = new Bike("12","120",1,"2020", "apache");
            Bi2.DisplayVechiles();
            Bi2.DisplayBike();

            Console.WriteLine("--example of method overriding---");
            // creating object of child class

            Solution S1 = new Solution();
            S1.calcs1(10, 20);
            S1.calcs2(5, 5, 7);

            //abstract class
            Console.WriteLine("--- example of abstract class ---");

            Solution2 Solu2 = new Solution2(10, 20, 30, 40);
            Solu2.calcSum();
            Solu2.calcDiff(30, 50);
            Solu2.calcMulti();

            //interface  example
            Console.WriteLine("-- example of interface---");
            Interface1 I1 = new Interface1();
            I1.sum(10, 5);// calculation1 method.
            int mul1 = I1.mul(20, 30); // calculation1 method
            Console.WriteLine("multiply is " +mul1);
            I1.mul(6, 2); // calculation2 method
            I1.findeven(12);// calculation2 interface's classs.

            //operator overloading
            Console.WriteLine("--exmaple on operator overloading--");
            Boxes box1 = new Boxes();
            Boxes box2 = new Boxes();
            box1.setBoxes(30, 40, 50);
            box2.setBoxes(60, 70, 80);
            box1.calVolume();
            box2.calVolume();


            //calling operator overloading
            Boxes box3 = box1 + box2;
            box3.calVolume();

            // dynamic binding example
            Console.WriteLine("--Dynamic binding example--");
            Teachers tel1 = new Teachers();
            //calling dynamic properties
            tel1.Id = 1;
            tel1.Name = "ram";
            tel1.Department = "IT";
            tel1.Specialization = "Programming";
            //Calling dynamic method
            dynamic id = tel1.displayId();
            dynamic name= tel1.displayName();
            dynamic department = tel1.displayDepartment();
            dynamic specialization = tel1.displaySpecialization();
            Console.WriteLine("id is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Department is " + department);
            Console.WriteLine("Specialization is " + specialization);


            //struct example
            Console.WriteLine("--struct exampel--");
            //creating strict variable
            Employees emp1 = new Employees(1, "Sam", "management", "30000");
            //creating another obj of employee and assigning to first obj
            Employees emp2 = new Employees(2, "Hari", "IT", "4000");
            emp2 = emp1;
            emp2.displatEmpolyees();
            emp2.name = "Sandesh";
            Console.WriteLine("After changing name is "+emp1.name);
            Console.ReadKey();


            //creating example on Array !!!!!!!!!!!!!!!!!!!
            ArrayDemo ad = new ArrayDemo();
            ad.accessArray();
        }
    }
}

