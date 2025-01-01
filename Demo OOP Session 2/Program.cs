using Demo_OOP_Session_2.Encapsulation;

namespace Demo_OOP_Session_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Id = 1;
            car.Model = "BMW";
            car.Speed = 200;
            Console.WriteLine(car);



            
        }
    }

    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            #region Struct

            //Point p1;

            //// p1 is a variable of type Point
            //// ClR will allocate memory for p1 in the stack

            //p1 = new Point(10, 20);


            //Console.WriteLine(p1);
            #endregion

            #region Encapsulation
            //Employee employee = new Employee(4, "Mostafa", 10_000);

            //employee.SetId(9999);
            //employee.Name = "Mostafa";


            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.GetId());


            //PhoneBook note = new PhoneBook(10);
            //  note.AddPerson(0, "Mostafa", 0100);
            //  note.AddPerson(1, "Ahmed", 0101);
            //  note.AddPerson(2, "Ali", 0102);
            //  note.AddPerson(3, "Mohamed", 0103)
            #endregion



            Car c1 = new Car(1);

            c1 = new Car(2, "BMW");

            Console.WriteLine(c1);
            Console.WriteLine("***************");


        }
    }
}
