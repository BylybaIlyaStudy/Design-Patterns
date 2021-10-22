using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;

            IValidator moreThenTenAndMoreThenFive = new MoreThenFiveValidator()
            {
                NextValidator = new MoreThenTenValidator()
            };

            IValidator moreThenTenAndLessThenTen = new MoreThenTenValidator()
            {
                NextValidator = new LessThenTenValidator()
            };

            Console.WriteLine(moreThenTenAndLessThenTen.Validate(x));
            Console.WriteLine(moreThenTenAndMoreThenFive.Validate(x));
        }
    }
}
