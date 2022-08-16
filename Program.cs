
/*CSharpemployee.Employee obj = new CSharpemployee.Employee();
obj.show();
string val = obj.showcasevalue();
Console.WriteLine(val);


CSharpemployee.Employee obj1 = new CSharpemployee.Employee("Abhishek");
obj.show();
string val1 = obj1.showcasevalue();
Console.WriteLine(val1);


CSharpemployee.Employee obj2 = new CSharpemployee.Employee("Abhishek",2);
obj.show();
string val2 = obj2.showcasevalue();
Console.WriteLine(val2);*/


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//here we are using "using" keyword with namespace for future use to simplify the constructor declaration
using CSharpemployee;


/////////////without using namespace
//declare without passing any parameters
Employee obj = new Employee();
obj.show();
string val = obj.showcasevalue();
Console.WriteLine(val);


/////////////without using namespace
//declare without passing any parameters
Employee obj1 = new Employee("Abhishek");      //here we passed the values inside the constructor so it is known as constructor injection
obj1.show();
string val1 = obj1.showcasevalue();
Console.WriteLine(val1);


/////////////without using namespace
//declare without passing any parameters
Employee obj2 = new Employee("Abhishek","IT");
obj2.show();
string val2 = obj2.showcasevalue();
Console.WriteLine(val2);

//////////////////////////////////////////////// End of constructor injection //////////////////////////////////////////

Employee obj3 = new Employee();
/////////// property injection ////////////////
obj3.employeename = "Adarsh";
obj3.employeedepartment = "dev";
/////////  end of property injection //////////
obj3.show();
string val3 = obj3.showcasevalue();
Console.WriteLine(val3);



//////////// Methdod injection ///////////
Employee obj4 = new Employee();
obj.show("Adarsh","Div");                           //here we injected the values inside the show and as well as in showcasevalue method
string val4 = obj4.showcasevalue("Adarsh","Div");
Console.WriteLine(val4);
/////////// Methdo injection ends up here ///