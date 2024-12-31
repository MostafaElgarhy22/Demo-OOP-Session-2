namespace Demo_OOP_Session_2
{
    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {


            Point p1;

            // p1 is a variable of type Point
            // ClR will allocate memory for p1 in the stack

            p1 = new Point(10, 20);

        
            Console.WriteLine(p1);
        }
    }
}
