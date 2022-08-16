using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpemployee
{
    public class Employee
    {

        //created 2 variable one is string and othe one int type
        //making it as null value by defualt


        string name = string.Empty;
        string department = string.Empty;
        //Nullable<int> EmployeepId = null;

        //end of variables

        //here we use the above values and created property injection 
        ///////////////   property injection   ////////////////
        public string employeename { get; set; }
        public string employeedepartment { get; set; }
        
      ////////////////  End of property injection   //////////////////
        

        


        // lets create the constructors
        //creating a constructor with no parameter
        public Employee()
        {
            //an empty constuctor we didn't pass any parameters here
        }

        // constructor with ome parameter
        public Employee(string empname)
        {
            name = empname;
        }

        //constructor with two parameter
        //one is "string" another one is "int" 
        public Employee(string empname,string empdep)
        {
            name = empname;
            department = empdep;
        }
        /////////////////////////////////////////////   END OF CONSTRUCTORS   ////////////////////////////////////////////////////
        
        // lets create some methods here

        //Here we created the show() method to print the value along with naming
        public void show()
        {
            Console.WriteLine( "Employee Name:-> " +name + "Employee Department:-> " + department );
        }

          /// Here we concatinating the values
          ///Only returns string value but the employee id is int
        public string showcasevalue()
        {
            string showvalue = name + "" + department;
            return showvalue;
        }

       /*public int showcasevalue()
        {
            int showup = 
        }*/

       
        /// we reused the above methods for display the values of Property injection
        public void show(string employeename, string employeedepartment)
        {
            Console.WriteLine("Employee Name:->" + employeename + "Employee Department:->" + employeedepartment);
        }

        public string showcasevalue(string employeename, string employeedepartment)
        {
            string showvalue = employeename + "" + employeedepartment;
            return showvalue;
        }
    }
}
