using System;

namespace Practice2
{
	public  class Persons
	{
        static Persons()
        {
            Console.WriteLine("static constructor working");
        }

        public Persons()
        {
            Console.WriteLine("non static constructro working");
        }
		public static int Age { get; set; }

        public static void ShowText()
        {
            Console.WriteLine("Text");
        }

        public static void Test()
        {
            Console.WriteLine("Salam");
        }
    }

	
}

