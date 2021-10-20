using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var legacyString = new LegacyString();
            legacyString.ChangeString("World!".ToCharArray());

            var newString = new NewString
            {
                String = "Hello"
            };
            newString.Append(new NewString{String = " "});

            var adapter = new Adapter(legacyString);
            newString.Append(adapter);

            Console.WriteLine(newString.String);
        }
    }
}
