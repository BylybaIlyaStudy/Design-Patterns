using Factory_Method.Factory;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            new CarFactory().Print(100, 10);
        }
    }
}
