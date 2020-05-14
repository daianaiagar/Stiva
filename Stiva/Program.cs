using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            // Introduce un element in stiva
            st.Push(1);
            st.Push(2);
            st.Push(3);

            // Elimina un element din stiva
            int v = st.Pop();

            st.Push(4);

            // Intoarce elementul din varful stivei fara a-l elimina
            Console.WriteLine(st.Peek());

            // Intoarce numarul de elemente din stiva
            Console.WriteLine(st.Count);

            // Intoarce numarul maxim de elemente pe care le putem introduce in stiva
            Console.WriteLine(st.Capacity);

            st.Pop();
            st.Pop();

            int value;
            bool result = st.TryPeek(out value);

            st.Pop();

            Console.WriteLine(st.IsEmpty);
            Console.WriteLine(st.IsFull);
            // instructiunea va lansa exceptie
            try
            {
                st.Pop();
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

