namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01
            #region Q1:Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];
            //people[0] = new Person("Nada", 20);
            //people[1] = new Person("Noura", 20);
            //people[2] = new Person("Nour", 19);
            //Console.WriteLine("Data of all persons:");
            //foreach (Person person in people)
            //    Console.WriteLine(person.ToString());

            #endregion
            #region Q2:Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //double x;
            //bool f = false;
            //do
            //{
            //    Console.Write("Enter the x of the first point: ");
            //    f = double.TryParse(Console.ReadLine(), out x);
            //} while (!f);

            //double y;
            //f = false;
            //do
            //{
            //    Console.Write("Enter the y of the first point: ");
            //    f = double.TryParse(Console.ReadLine(), out y);
            //} while (!f);

            //Point P01 = new Point(x, y);

            //f = false;
            //do
            //{
            //    Console.Write("Enter the x of the second point: ");
            //    f = double.TryParse(Console.ReadLine(), out x);
            //} while (!f);

            //f = false;
            //do
            //{
            //    Console.Write("Enter the y of the second point: ");
            //    f = double.TryParse(Console.ReadLine(), out y);
            //} while (!f);
            //Point P02 = new Point(x, y);
            //double distance = Point.CalcDictince(P02, P01);

            //Console.WriteLine($"The distance between the two points is: {distance:F2}");

            #endregion
            #region Q3:Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    int age;
            //    bool f = false;
            //    do
            //    {
            //        Console.Write("Age: ");
            //        f = int.TryParse(Console.ReadLine(), out age);
            //    } while (!f);
            //    people[i] = new Person(name, age);

            //    Console.WriteLine();  
            //}
            //Array.Sort(people, (p1, p2) => p2.Age.CompareTo(p1.Age));
            //Console.WriteLine($"Oldest Person\n{people[0].ToString()}");
            #endregion
            #endregion
            #region part02
            #region Part02
            #region Q3:Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

            //Employee[] Arr = new Employee[3];
            //Arr[0] = new Employee(101, "Nada", 9500,(Gender)1, Security.DBA,new HireDate(15, 6, 2018));
            //Arr[1] = new Employee(102, "Noura",10000, (Gender)1,Security.Guest, new HireDate(10, 3, 2020));
            //Arr[2] = new Employee(103, "Nour", 5000, (Gender)1, (Security)15, new HireDate(5, 9, 2017));


            //Console.WriteLine("Original Employee List:");
            //foreach (Employee emp in Arr)
            //{
            //    Console.WriteLine(emp.ToString());
            //    Console.WriteLine();
            //} 
            #endregion
    
            #endregion
            #endregion
        }
    }
}
