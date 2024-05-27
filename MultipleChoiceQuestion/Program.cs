using System;

namespace MultipleChoiceQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            string answear1;
            string answear2;
            string answear3;

            Console.WriteLine("What is C#?");
            Console.WriteLine("A) A program.");
            Console.WriteLine("B) A religion.");
            Console.WriteLine("C)A programming language.");
            answear1 = Console.ReadLine();
            answear1 = answear1.ToUpper();

            if (answear1 == "C")
                Console.WriteLine("Correct answear!");
            else
                Console.WriteLine("C# is a programming language.");


            Console.WriteLine("What is better to use for a text ?");
            Console.WriteLine("A) An integer.");
            Console.WriteLine("B) A string.");
            Console.WriteLine("C) A float.");
            answear2 = Console.ReadLine();
            answear2 = answear2.ToUpper();

            if (answear2=="B")
                Console.WriteLine("Correct answear!");
            else
                Console.WriteLine("Sorry but you need a string for introducting text.");

            Console.WriteLine("How do you note a comment in C#?");
            Console.WriteLine("A) /* */");
            Console.WriteLine("B) ||");
            Console.WriteLine("C) //");
            answear3 = Console.ReadLine();
            answear3 = answear3.ToUpper();

            if (answear3 == "A" || answear3 == "C")
                Console.WriteLine("Correct answear!");
            else
                Console.WriteLine("The correct answear is either /* */ for more lines of comments , or // for only one comment line.");


            Console.ReadLine();
        }
    }
}
