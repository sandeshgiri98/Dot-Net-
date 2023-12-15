using System;
//struct is like a class but it is a value time only i.e. it is not a refrence type like a class
//it means that it inly stores value not address. Struct can have constructed properties, method like a class.


namespace SWSCBasic
{
     struct Employees
    {
        //instance variable
        int id;
        public string name;
        string department;
        string salary;
        //constructor
        public Employees(int id, string name, string department, string salary)
        {
            this.id = id;
            this.name = name;   
            this.department = department;   
            this.salary = salary;   
        }
        //method
        public void displatEmpolyees()
        {
            Console.WriteLine("id is "+this.id);
            Console.WriteLine("name is " + this.name);
            Console.WriteLine("department is " + this.name);
            Console.WriteLine("salary is " + this.salary);
        }

    }
}
