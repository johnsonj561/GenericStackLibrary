using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackLibrary {
    /// <summary>
    /// Testing GenericStack Object
    /// </summary>
    class Program {
        static void Main(string[] args) {


            //create a stack of type double
            GenericStack<double> dStack = new GenericStack<double>();

            //populate stack with random doubles between 0 and 100 and print
            Random rand = new Random();
            for (int i = 0; i < 50; i++) {
                dStack.push(Math.Round((rand.NextDouble()*100), 2));
            }
            dStack.print();

            //testing peek/pop functions on doubles
            Console.WriteLine("\nPeeking at top element " + dStack.peek());
            Console.WriteLine("\nPopping all nodes off stack");
            while(!dStack.isEmpty()) {
                Console.WriteLine(dStack.pop());
            }



            //create a stack of type char
            GenericStack<char> cStack = new GenericStack<char>();
            //populate stack with random characters
            for(int i = 0; i < 50; i++) {
                cStack.push((char)(65 + (rand.Next(0, 25))));
            }
            cStack.print();

            //testing peek/pop functions on character stack
            Console.WriteLine("\nPeeking at top element " + cStack.peek());
            Console.WriteLine("\nPopping all nodes off stack");
            while(!cStack.isEmpty()){
                Console.WriteLine(cStack.pop());
            }

           
            //create a stack of type String
            GenericStack<string> sStack = new GenericStack<string>();
            //populate stack with strings
            sStack.push("1st element of stack");
            sStack.push("These are numbes 44.44");
            sStack.push("Third!!!");
            sStack.push("4443.22");
            sStack.push("Justin Johnson");
            sStack.push("Is practicing");
            sStack.push("With C#");
            sStack.push("Data Structures");
            sStack.print();

            //testing peek/pop functions on string stack
            Console.WriteLine("\nPeeking at top element " + sStack.peek());
            Console.WriteLine("\nPopping all nodes off stack");
            while (!sStack.isEmpty()) {
                Console.WriteLine(sStack.pop());
            }

            //terminate
            Console.WriteLine("\nEnter any key to terminate...");
            Console.ReadKey();

        }
    }
}
