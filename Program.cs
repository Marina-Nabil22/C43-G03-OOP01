namespace OOP1
{
    #region Q1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion

    #region Q2
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //}
    #endregion


    #region Q3
    enum Season
    {
        spring,
        summer,
        autumn,
        winter
    }
    #endregion

    #region Q5
    enum Colors
    {
        red,
        green,
        blue
    }
    #endregion

    #region Q6

    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
          X= x;
          Y= y;
        }
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

    }
    #endregion

    #region Q7
    struct Person
    {
        public string Name { get; set; }
        public double Age { get; set; }

        public Person(string name, double age)
        {
            Name = name;
            Age = age;
        }

    }
    #endregion

    #region Q8

    struct Rectangle
    {
        private double width;
        private double height;

        
        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Width cannot be negative.");
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine("Height cannot be negative.");
            }
        }
        public double Area
        {
            get
            {
                return width * height;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle Width = {Width}, Rectangle Height = {Height}");
            Console.WriteLine($"Area of Rectangle: {Area}");
        }
    }


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (var i in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] persons =
            //{
            //    new Person("Marina", 20),
            //    new Person("Fatma", 21),
            //    new Person("Mariam" , 22)
            //};

            //foreach (var i in persons)
            //{
            //    Console.WriteLine($"Name:{i.Name} , Age:{i.Age}");
            //}

            #endregion

            #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter Season Name");
            //string input = Console.ReadLine();



            //if (Enum.TryParse(input!.ToLower(), true, out Season season)) 
            //{

            //    if (season == Season.spring)
            //        Console.WriteLine("Range is March to May");
            //    else if (season == Season.summer)
            //        Console.WriteLine("Range is June to August");
            //    else if (season == Season.autumn)
            //        Console.WriteLine("Range is September to November");
            //    else if (season == Season.winter)
            //        Console.WriteLine("Range is December to February");
            //}
            //else
            //{
            //    Console.WriteLine("Enter Corrcet Season");
            //}



            #endregion

            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not. 
            //Console.WriteLine("Enter Color");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input!.ToLower(), out Colors c))
            //{
            //    Console.WriteLine("Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine("Not Primary");
            //}

            #endregion

            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter coordinates for the first point:");
            //double x1 = ReadDouble("X1: ");
            //double y1 = ReadDouble("Y1: ");

            //Console.WriteLine("Enter coordinates for the second point:");
            //double x2 = ReadDouble("X2: ");
            //double y2 = ReadDouble("Y2: ");

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);


            //double distance = Point.Distance(p1, p2);
            //Console.WriteLine($"The distance is = {distance}");
            //Console.ReadLine();

            //static double ReadDouble(string s)
            //{
            //    double result;
            //    bool flag;
            //    do
            //    {
            //        Console.Write(s);
            //        string input = Console.ReadLine();
            //        flag = double.TryParse(input, out result);

            //        if (!flag)
            //        {
            //            Console.WriteLine("enter a number");
            //        }
            //    } while (!flag);

            //    return result;
            //}
            #endregion

            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# prog

            //Person[] Persons = new Person[3];
            //for (int i = 0; i < Persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter Name of Person {i + 1}");
            //    string name = Console.ReadLine();
            //    Console.WriteLine($"Enter Age of Person {i + 1}");
            //    double age;
            //    bool flag;
            //    do
            //    {
            //        string input = Console.ReadLine();
            //        flag = double.TryParse(input, out age);

            //    } while (!flag|| age<=0);
            //    Persons[i] = new Person { Name = name!, Age = age };
            //}

            //Person oldest = Persons[0];
            //foreach (Person person in Persons)
            //{
            //    if (person.Age > oldest.Age)
            //    {
            //        oldest = person;
            //    }
            //}

            //Console.WriteLine($"The Oldest Person is {oldest.Name} ");

            #endregion

            #region 8.Create a struct named Rectangle that represents a rectangle with the following fields:

            //Rectangle r1 = new Rectangle();

            
            //Console.WriteLine("Enter width:");

            //r1.Width = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter height:");
            //r1.Height = double.Parse(Console.ReadLine());

            
            //r1.DisplayInfo();
            //Console.ReadLine();

            #endregion
        }
    }
}