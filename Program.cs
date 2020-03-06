using System;

namespace Inverse_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            int charCount = helloWorld.Length;
            char [] caracteresHelloWorld = new char [charCount];

            //caracteresHelloWorld[0]

            //Console.WriteLine(helloWorld);

            //Console.WriteLine(helloWorld.Substring(0, 5));

            //Console.WriteLine(helloWorld[0]);

            for (int i = 0; i < charCount; i++){
                Console.WriteLine(helloWorld[i]);

                caracteresHelloWorld[i] = helloWorld[i];
            }

            Console.WriteLine(caracteresHelloWorld);
        }
    }
}
