using System;
// dynamic binding : it is a feature of C# that allow properties and method to check in ryn time not in
//compile time. for this "dynamic" keyword is ysed
//code, methods are check in run time only (when program is executed)

namespace SWSCBasic
{
    class Teachers
    {
        // private int id;
        // private string name;
        // private string department;
        // private string specialization;
        //creating dynamic properties

        public dynamic Id { get; set; }
        public dynamic Name { get; set; }
        public dynamic Department { get; set; }
        public dynamic Specialization { get; set; }

        //dynamic method 
        public dynamic displayName()
        {
            return this.Name;
        }
        public dynamic displayId()
        {
            return this.Id;
        }
        public dynamic displaySpecialization() 
        {
            return this.Specialization;
        }
        public  dynamic displayDepartment()
        {
            return this.Department;
        }
    }
}
