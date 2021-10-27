using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Node n1 = new Node(new Person("Jose",72));
            Node n2 = new Node(new Person("Miguel",14));
            Node n3 = new Node(new Person("Alva",32));
            Node n4 = new Node(new Person("Lucas",25));
            Node n5 = new Node(new Person("Gonzalo",30));
            Node n6 = new Node(new Person("Laura",45));
            Node n7 = new Node(new Person("Catalina",16));
            Node n8 = new Node(new Person("Luis",21));


            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            Console.WriteLine(Convert.ToString(n1.GetAgeTotal()));
            Console.WriteLine(n1.GetLongestName());
            Console.WriteLine(Convert.ToString(n1.GetOldSonAge()));
            // visitar el árbol aquí
        }
    }
}
