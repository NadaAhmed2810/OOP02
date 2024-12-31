using OOP02.Encapsulation;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            ///stander for structure 
            ///value type 
            ///struct always use to  make data type 
            ///class can by data type or just container[static class] all method like math class
            ///size small like bool , int ,char 
            ///data access faster than class because i was stack
            ///Declare object with type point 
            /// CLR will Allocate 8 bytes in stack
            ///new with struct just choose constructor to initialize the attribute



            //Point p01;
            //p01.x = 5;
            //p01.y = 3;
            //Console.WriteLine(p01.x);
            //Console.WriteLine(p01.y);
            //p01=new Point(0,0)
            //Console.WriteLine(P01.ToString());  
            //Console.WriteLine(P01);
            #endregion
            #region Encapsulation
            ////if i want not change after this make init .net5 
            //Employee employee = new Employee(1000, "Ahmed Nasr", 10_000)
            //{
            //    Name = "Ahmed Sayed"
            //};
            ////employee.Id = 5000;//Set id through the field itself
            ////Console.WriteLine(employee.Id);//Get id throungh the field itself 
            //employee.SetId(2002);
            //Console.WriteLine(employee.GetId());
            ////employee.Name = "Nada Ahmed";
            //Console.WriteLine(employee.Name);
            #endregion
            #region Indexer
            //string Name = "Ahmed";
            //char[] Name = { 'A', 'h', 'm', 'e', 'd' }
            //PhoneBook note = new PhoneBook(10);
            //note.AddPerson(0, "Ahmed", 1111);
            //note.AddPerson(1, "Nada", 2222);
            //note.AddPerson(2, "Noura", 3333);
            //note.AddPerson(3, "Nour", 4444);
            ////note.SetNumber("Ahmed", 5555);
            ////Console.WriteLine(note.GetNumber("Ahmed"));
            //note["Ahmed"] = 7777;
            //Console.WriteLine(note["Ahmed"]);
            //for (int i = 0; i < note.Size; i++)
            //{
            //    Console.WriteLine(note[i]);
            //}
            #endregion
        }
    }
}
