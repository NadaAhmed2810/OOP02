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
            #region
            //if i want not change after this make init .net5 
            Employee employee = new Employee(1000, "Ahmed Nasr", 10_000)
            {
                Name = "Ahmed Sayed"
            };
            //employee.Id = 5000;//Set id through the field itself
            //Console.WriteLine(employee.Id);//Get id throungh the field itself 
            employee.SetId(2002);
            Console.WriteLine(employee.GetId());
            //employee.Name = "Nada Ahmed";
            Console.WriteLine(employee.Name);
            #endregion
        }
    }
}
