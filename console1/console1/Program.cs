using System;
using System.Threading.Channels;
using console1;
//public class Program
//{
//static void Main(string[] args)

//{

//public class Program
//{
//  static void Main(string[] args)
//{
//        int num1 = 10;
//        int num2 = 20;
//        int sum = num1 + num2;

//        Console.WriteLine($"sum of {num1} + {num2} = {sum} ");
//    }
//}

//using System;
//public class Program
//{
//    static void Main(string[] args)
//    {
//        //        int a1 = 10;
//        int b2 = 20;
//        int product = a1 * b2;
//        Console.WriteLine($"product of  {a1} * {b2} = {product} ");
//    }
//}
//2nd
//using System;
//public class Program
//{
//static void Main(string[]args)
//        //    {  
//                int num1 = 30;
//                int num2 = 20;
//                int substraction = num1 - num2;
//           Console.WriteLine($"product of  {num1} - {num2} =  {substraction} ");
//            }
//         }

//        //3rd
//        using System;   

//        public class Program
//        {
//            static void Main(string[] args)
//            {
//                int num1 = 10;
//                int num2 = 20;
//                int num3 = 30;
//                int sum = num1 + num2 + num3;
//                double average = sum / 3.0;
//                Console.WriteLine($"Average={average}");
//    }
//}
//4th
//        using System;

//        public class Program
//{
//    static void Main(string[] args)
//    {

//        int length = 10;
//        int width = 10;


//        int area = length * width;


//        Console.WriteLine($"Area of the rectangle = {area}");
//    }
//}


//6th
//using System;

//public class Program
//{
//    static void Main(string[] args)
//    {

//        int side = 10;

//        int perimeter = 4 * side;

//        Console.WriteLine($"Perimeter of the square = {perimeter}");
//    }
//}

//using System;
//public class Program
//{
//    static void Main()
//    {
//        int a = 10;
//        int b = 20;

//        Console.WriteLine($" Before swap:{a},b ={b}");

//        int product = a;
//        a = b;
//        b = product;
//        Console.WriteLine($"After swap: a ={a}; b ={b}");

// }
//}
//using System;

//class CircleDetails
//{
//    static void Main()
//    {
//        Console.Write("Enter radius: ");
//        double r = Convert.ToDouble(Console.ReadLine());

//        double diameter = 2 * r;
//        double circumference = 2 * Math.PI * r;
//        double area = Math.PI * r * r;

//        Console.WriteLine("Diameter = " + diameter);
//        Console.WriteLine("Circumference = " + circumference);
//        Console.WriteLine("Area = " + area);
//    }
//}

//using System;

//class ConvertLength
//{
//    static void Main()
//    {
//        Console.Write("Enter length in centimeters: ");
//        double cm = Convert.ToDouble(Console.ReadLine());

//        double meter = cm / 100;
//        double kilometer = cm / 100000;

//        Console.WriteLine("Length in meter = " + meter);
//        Console.WriteLine("Length in kilometer = " + kilometer);
//    }
//}
//using System;




//int amount = 1888;
//int note;
//if (amount >= 500) ;
//{
//    note = amount / 500;
//    amount = amount % 500;
//    Console.WriteLine("500: " + note); 
//}
//if (amount >= 300)
//{
//    note = amount / 300;
//    amount = amount % 300;
//    Console.WriteLine("300:" + note); 
//}

//if (amount >= 200)
//{
//    note = amount / 200;
//    amount = amount % 200;
//    Console.WriteLine("200:" + note);
//}

//if (amount >= 100)
//{
//    note = amount / 100;
//    amount = amount % 100;
//    Console.WriteLine("100:" + note);
//}
//if (amount >= 50)
//{
//    note = amount / 50;
//    amount = amount % 50;
//    Console.WriteLine("50:" + note);
//}
//if (amount >= 10)
//{
//    note = amount / 10;
//    amount = amount % 10;
//    Console.WriteLine("10:" + note);
//}
//if (amount >= 10)
//{
//    note = amount / 10;
//    amount = amount % 10;
//    Console.WriteLine("10:" + note);
//}

//if (amount >= 1)
//{
//    note = amount / 1;
//    amount = amount % 1;
//    Console.WriteLine("1:" + note);
//}


//Write a C program to find the maximum between two numbers.

//class Program
//{   // static void Main()
//{
//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine("Maximum number is: " + a);
//}
//else if (b > a)
//{
//    Console.WriteLine("Maximum number is: " + b);
//}
//else
//{
//    Console.WriteLine("Both numbers are equal.");
//}
// Write a C program to find a maximum between three numbers. 

//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter third number: ");
//int c = Convert.ToInt32(Console.ReadLine());

//if (a >= b && a >= c)
//{
// Console.WriteLine("Maximum number is: " + a);
//}
//else if (b >= a && b >= c)
//{
//Console.WriteLine("Maximum number is: " + b);
//}
//else
//{
//Console.WriteLine("Maximum number is: " + c);
//}

// Write a C program to check whether a number is negative, positive or zero.

//Console.Write("Enter a number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("The number is positive.");
//}
//else if (number < 0)
//{
//    Console.WriteLine("The number is negative.");
//}
//else
//{
//    Console.WriteLine("The number is zero.");
//}

//Write a C program to check whether a number is divisible by 5 and 11 or not.

//        Console.Write("Enter a number: ");
//        int number = Convert.ToInt32(Console.ReadLine());

//        if (number % 5 == 0 && number % 11 == 0)
//{
//    Console.WriteLine(number + " is divisible by both 5 and 11.");
//}
//else
//{
//    Console.WriteLine(number + " is not divisible by both 5 and 11.");

//}
//}
//}

////    Write a C program to check whether a number is even or odd.
// Console.Write("Enter a number: ");
//    int number = Convert.ToInt32(Console.ReadLine());

//    if (number % 2 == 0)
//    {
//        Console.WriteLine(number + " is even.");
//    }
//    else
//    {
//        Console.WriteLine(number + " is odd.");
//    }

// Write a C program to check whether a year is a leap year or not.

//    Console.Write("Enter a year: ");
//    int year = Convert.ToInt32(Console.ReadLine());

//    //this is year leap year condition//
//    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
//    {
//        Console.WriteLine(year + " is a leap year.");
//    }
//    else
//    {
//        Console.WriteLine(year + " is not a leap year.");
//    }
//    Write a C program to check whether a character is in the alphabet or not

//Console.Write("Enter a character: ");
//    char ch = Convert.ToChar(Console.ReadLine());
//          //this is condition//
//    if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
//    {
//        Console.WriteLine(ch + " is an alphabet.");
//    }
//    else
//    {
//        Console.WriteLine(ch + " is not an alphabet.");
//    }
//Write a C program to input any alphabet and check whether it is vowel or consonant.
//??????????????????????????????????????????????????????????????????????????????????//

//  Write a C program to input any character and check whether it is alphabet, digit or special character.
//Console.Write("Enter a character: ");
//     char ch = Convert.ToChar(Console.ReadLine());

//     if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
//     {m
//         Console.WriteLine(ch + " is an alphabet.");
//     }
//     else if (ch >= '0' && ch <= '9')
//     {
//         Console.WriteLine(ch + " is a digit.");
//     }
//     else
//     {
//         Console.WriteLine(ch + " is a special character.");
//     }
//   Write a C program to check whether a character is uppercase or lowercase alphabet.

//    Console.Write("Enter a character: ");
//    char ch = Convert.ToChar(Console.ReadLine());

//    if (ch >= 'A' && ch <= 'Z')
//    {
//        Console.WriteLine(ch + " is an uppercase alphabet.");
//    }
//    else if (ch >= 'a' && ch <= 'z')
//    {
//        Console.WriteLine(ch + " is a lowercase alphabet.");
//    }
//    else
//    {
//        Console.WriteLine(ch + " is not an alphabet.");
//    }
//  write  a C program to input week number and print week day.
//???????????????????????????????????????????????????//
//   Write a C program to input month number and print number of days in that month.
//Write a C program to input angles of a triangle and check whether triangle is valid or not.//

//Console.Write("Enter first angle: ");
//int angle1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second angle: ");
//int angle2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter third angle: ");
//int angle3 = Convert.ToInt32(Console.ReadLine());

//int sum = angle1 + angle2 + angle3;

//// Triangle is valid if sum of angles = 180 and each angle > 0
//if (sum == 180 && angle1 > 0 && angle2 > 0 && angle3 > 0)
//{
//    Console.WriteLine("Triangle is valid.");
//}
//else
//{
//    Console.WriteLine("Triangle is not valid.");
//}
//Console.Write("Enter first side: ");
//double side1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter second side: ");
//double side2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter third side: ");
//double side3 = Convert.ToDouble(Console.ReadLine());

//// Triangle is valid if sum of any two sides > third side
//if (side1 + side2 > side3 &&
//    side2 + side3 > side1 &&
//    side1 + side3 > side2)
//{
//    Console.WriteLine("Triangle is valid.");
//}
//else
//{
//    Console.WriteLine("Triangle is not valid.");
//}
//   Write a C program to check whether the triangle is equilateral, isosceles or scalene triangle.
//   scanf(
//Console.Write("Enter first side: ");
//double side1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter second side: ");
//double side2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter third side: ");
//double side3 = Convert.ToDouble(Console.ReadLine());
//if (side1 + side2 > side3 &&
//    side2 + side3 > side1 &&
//    side1 + side3 > side2)
//{
//    if (side1 == side2 && side2 == side3)
//    {
//        Console.WriteLine("Triangle is equilateral.");
//    }
//    else if (side1 == side2 || side2 == side3 || side1 == side3)
//    {
//        Console.WriteLine("Triangle is isosceles.");
//    }
//    else
//    {
//        Console.WriteLine("Triangle is scalene.");
//    }
//}
//else
//{
//    Console.WriteLine("Not a valid triangle.");
//}
////////////////////////////////////////////////////

//        Console.Write("Enter marks in Physics: ");
//double physics = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks in Chemistry: ");
//double chemistry = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks in Biology: ");
//double biology = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks in Mathematics: ");
//double maths = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks in Computer: ");
//double computer = Convert.ToDouble(Console.ReadLine());

//double total = physics + chemistry + biology + maths + computer;
//double percentage = (total / 500) * 100;

//Console.WriteLine("Percentage: " + percentage + "%");

//if (percentage >= 90)
//{
//    Console.WriteLine("Grade: A");
//}
//else if (percentage >= 80)
//{
//    Console.WriteLine("Grade: B");
//}
//else if (percentage >= 70)
//{
//    Console.WriteLine("Grade: C");
//}
//else if (percentage >= 60)
//{
//    Console.WriteLine("Grade: D");
//}
//else if (percentage >= 40)
//{  
//    Console.WriteLine("Grade: E");
//}
//else
//{
//    Console.WriteLine("Grade: F");
//}
//            }
//}


//Console.WriteLine("Enter number");
//int week_number = int.Parse(Console.ReadLine());
//switch(week_number) {
//    case 1: Console.WriteLine("monday");
//        break;
//    case 2: Console.WriteLine("tusday");
//        break;
//    case 3: Console.WriteLine("wenesday");
//        break;
//    case 4: Console.WriteLine("thursday");
//        break;
//        case 5: Console.WriteLine("friday");
//        break;
//        case 6: Console.WriteLine("saturday");
//        break;
//        case 7: Console.WriteLine("sunday");
//        break;
//        default : Console.WriteLine("unknown");
//        break;
//}



// internal class program
//{ 
//    static void Main(string[] args) {

//      program op = new program();
//        op.add();
//        op.sub();
//        op.mul();
//        op.div();
//}
//}
/////////////////////////////////////////
//    public class Employee
//    {
//        public int id = 101;
//        public string name = "Mahi";
//        public decimal salary = 30000;

//        public decimal IncrementSalary(double per)
//        {
//            salary = salary + (salary * (decimal)(per / 100));
//            return salary;
//        }

//        public void DisplayEmployeeDetails()
//        {
//            Console.WriteLine($"Employee Id: {id}");
//            Console.WriteLine($"Employee Name: {name}");
//            Console.WriteLine($"Employee Salary: {salary}");
//            Console.WriteLine("----------------------------");
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            Employee emp2 = new Employee();

//            emp.DisplayEmployeeDetails();
//            emp2.DisplayEmployeeDetails();

//            emp2.id = 102; 
//            emp2.name = "Ravi";
//            emp2.salary = 60000;

//            emp2.DisplayEmployeeDetails();
//            emp.DisplayEmployeeDetails();

//            emp.IncrementSalary(10);
//            emp.DisplayEmployeeDetails();
//        }
//}

///////////////////////////////////////////

//using System;

//class Person
//{
//    public string fullName;
//    public int age;
//    public string phone;

//    public void PrintInfo()
//    {
//        Console.WriteLine(fullName);
//        Console.WriteLine(age);
//        Console.WriteLine(phone);
//    }
//}

//class Student
//{
//    public string studentName;
//    public int studentAge;
//    public int rollNumber;

//    public void PrintInfo()
//    {
//        Console.WriteLine(studentName);
//        Console.WriteLine(studentAge);
//        Console.WriteLine(rollNumber);
//    }
//}

//class College
//{
//    public string name;
//    public string location;
//    public int collegeCode;

//    public void PrintInfo()
//    {
//        Console.WriteLine(name);
//        Console.WriteLine(location);
//        Console.WriteLine(collegeCode);
//    }
//}

//class Watch
//{
//    public string company;
//    public int cost;

//    public void PrintInfo()
//    {
//        Console.WriteLine(company);
//        Console.WriteLine(cost);
//    }
//}

//class Mobile
//{
//    public string brandName;
//    public int amount;
//    public int memory;

//    public void PrintInfo()
//    {
//        Console.WriteLine(brandName);
//        Console.WriteLine(amount);
//        Console.WriteLine(memory);
//    }
//}

//class Laptop
//{
//    public string brand;
//    public int price;
//    public int ramSize;

//    public void PrintInfo()
//    {
//        Console.WriteLine(brand);
//        Console.WriteLine(price);
//        Console.WriteLine(ramSize);
//    }
//}

//class Table
//{
//    public string type;
//    public int price;
//    public int length;
//    public int width;

//    public void PrintInfo()
//    {
//        Console.WriteLine(type);
//        Console.WriteLine(price);
//        Console.WriteLine(length);
//        Console.WriteLine(width);
//    }
//}

//class Product
//{
//    public string name;
//    public int id;
//    public decimal price;

//    public void PrintInfo()
//    {
//        Console.WriteLine(name);
//        Console.WriteLine(id);
//        Console.WriteLine(price);
//    }
//}

//class Customer
//{
//    public string name;
//    public int id;
//    public long mobile;

//    public void PrintInfo()
//    {
//        Console.WriteLine(name);
//        Console.WriteLine(id);
//        Console.WriteLine(mobile);
//    }
//}

//class Invoice
//{
//    public int number;
//    public decimal totalAmount;

//    public void PrintInfo()
//    {
//        Console.WriteLine(number);
//        Console.WriteLine(totalAmount);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person();
//        p.fullName = "Yogesh";
//        p.age = 24;
//        p.phone = "9699282032";
//        p.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Student s = new Student();
//        s.studentName = "Rahul";
//        s.studentAge = 20;
//        s.rollNumber = 101;
//        s.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        College c = new College();
//        c.name = "ABC College";
//        c.location = "Delhi";
//        c.collegeCode = 1234;
//        c.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Watch w = new Watch();
//        w.company = "Titan";
//        w.cost = 5000;
//        w.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Mobile m = new Mobile();
//        m.brandName = "Samsung";
//        m.amount = 20000;
//        m.memory = 128;
//        m.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Laptop l = new Laptop();
//        l.brand = "HP";
//        l.price = 60000;
//        l.ramSize = 16;
//        l.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Table t = new Table();
//        t.type = "Wood";
//        t.price = 3000;
//        t.length = 5;
//        t.width = 3;
//        t.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Product pr = new Product();
//        pr.name = "Mouse";
//        pr.id = 501;
//        pr.price = 599.99m;
//        pr.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Customer cust = new Customer();
//        cust.name = "Amit";
//        cust.id = 1001;
//        cust.mobile = 9876543210;
//        cust.PrintInfo();

//        Console.WriteLine("------------------------------------------------");

//        Invoice inv = new Invoice();
//        inv.number = 9001;
//        inv.totalAmount = 1500.50m;
//        inv.PrintInfo();
//    }
//}
///////////////////////////////////////////////////////////

//class Program
//{
//    static void Main(string[] args)
//    {
//        EmployeeGetSet e1 = new EmployeeGetSet();
//        e1.DisplayEmployee();
//        Console.WriteLine(e1.IsPermanent());

//        Console.WriteLine("----------------------------");

//        EmployeeGetSet e2 = new EmployeeGetSet(2, "Amit", 18000);
//        e2.DisplayEmployee();
//        Console.WriteLine(e2.IsPermanent());

//        Console.WriteLine("----------------------------");

//        Console.WriteLine(e2);
//    }
//}
//////////////////////////////////////////

//class student
//{
//    private int _id;
//    private string _name;

//    public int id
//    {
//        set
//        {
//            this._id = value;
//        }
//        get
//        {
//            return this._id;
//        }
//    }
//        public string name
//    {
//        set
//        {
//            this._name = value;
//        }
//        get
//        {
//            return this._name;
//        }
//    }
//    }
//class program
//{
//    static void Main(string[] args)
//    {
//        student s = new student();
//        s.id = 101;
//        s.name = "ram";
//        Console.WriteLine(s.name);
//        Console.WriteLine(s.id);

//class program
//{
//    int id;
//    string name;
//    public program(int id, string name)
//    {
//        this.id = id;
//        this.name = name;
//    }
//    public int Getid()
//    {
//        return this.id;

//    }
//    public string Getname()
//    {
//        return this.name;

//    }


//    static void Main(string[] args)
//    {
//        program p = new program(101, "ram");
//        program p1 = new program(102, "shyam");
//        Console.WriteLine(" id is {0}",p.id);
//        Console.WriteLine("name is {0}",p.name);
//        Console.WriteLine("-------------------");
//        Console.WriteLine("id is {0}",p1.id);
//        Console.WriteLine("name is  {0}",p1.name);
////////////////////overloading//////////////////////////////
class program
{ 
    public program()
    {
        Console.WriteLine("default constructor");
    }
    public program(int a,int b )
    {
        Console.WriteLine("para with 2 constructor",( a+b));
    }
    public program(int a , int b , int c)
    {
        Console.WriteLine("para with 3 constructor ",(a+b+c));
    }
    class car
    {
        int id;
        string name;
        public car()
        {
            id = 101;
            name = "bmw";
        }
        Console.WriteLine("car id is {0} ",id);
    }
    static void Main(string[] args)
    {      program p = new program();
        program p1 = new program(10,20);
        program p2 = new program(10, 20,10);
    }
}

