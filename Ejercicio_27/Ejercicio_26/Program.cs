using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Realizar el ejercicio anterior pero esta vez con las siguientes colecciones: Pilas, Colas y Listas

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";

            //Pilas();
            // Colas();
            Listas();

            Console.ReadKey();
        }

        #region Pilas
        public static void Pilas()
        {
            // lo último que entra es lo primero que sale LIFO
            Stack<int> pilaRandom = new Stack<int>();
            Random r = new Random();

            for (int i = 0; i < 20; i++) // cargo stack
            {
                int random = r.Next(-1000, 1001);
                while (random == 0)
                {
                    random = r.Next(-1000, 1001);
                }
                pilaRandom.Push(random);
            }

            Console.WriteLine("Stack completo:\n");
            foreach (int num in pilaRandom)
            {
                Console.WriteLine($"{num}\n");
            }

            Console.WriteLine("\n\nSolo positivos creciente:\n");
            Stack<int> tmpStack = SortStack(pilaRandom, 1);
            foreach (int num in tmpStack)
            {
                if (num > 0)
                {
                    Console.WriteLine($"{num}\n");
                }
            }

            Console.WriteLine("\n\nSolo negativos decreciente:\n");
            tmpStack = SortStack(pilaRandom, 0); 
            foreach (int num in tmpStack)
            {
                if (num < 0)
                {
                    Console.WriteLine($"{num}\n");
                }
            }
        }

        private static Stack<int> SortStack(Stack<int> input, int orden) // 1 creciente, 0 decreciente
        {
            Stack<int> tmpStack = new Stack<int>();
            // copiar input:
            Stack<int> copyPilaInput = new Stack<int>(new Stack<int>(input));

            while (copyPilaInput.Count > 0) // mientras tenga algo adentro
            {
                // Sacar el 1er elemento
                int tmp = copyPilaInput.Pop();

                // Mientras tmpStack no este vacio y su 1er elem sea menor/mayor al 1ro del input
                if (orden == 1)
                {
                    while (tmpStack.Count > 0 && tmpStack.Peek() < tmp)
                    {
                        // Pop del stack temporario y pushear al stack del input
                        copyPilaInput.Push(tmpStack.Pop());
                    }
                }
                else
                {
                    while (tmpStack.Count > 0 && tmpStack.Peek() > tmp)
                    {
                        // Pop del stack temporario y pushear al stack del input
                        copyPilaInput.Push(tmpStack.Pop());
                    }
                }

                // pushear temp en el stack temporario
                tmpStack.Push(tmp);
            }

            return tmpStack;
        }
        #endregion

        #region Colas
        public static void Colas()
        {
            //FIFO primero en entrar primero en salir
            Queue<int> colaRandom = new Queue<int>();
            Random r = new Random();

            for (int i = 0; i < 20; i++) // cargo queue
            {
                int random = r.Next(-1000, 1001);
                while (random == 0)
                {
                    random = r.Next(-1000, 1001);
                }
                colaRandom.Enqueue(random);
            }

            Console.WriteLine("Queue completo:\n");
            foreach (int num in colaRandom)
            {
                Console.WriteLine($"{num}\n");
            }


            Console.WriteLine("\n\nSolo positivos creciente:\n");
            Queue<int> tmpQueue = SortQueue(colaRandom);
            foreach (int num in tmpQueue)
            {
                if (num > 0)
                {
                    Console.WriteLine($"{num}\n");
                }
            }

            Console.WriteLine("\n\nSolo negativos decreciente:\n");
            tmpQueue = ReverseQueue(tmpQueue);
            foreach (int num in tmpQueue)
            {
                if (num < 0)
                {
                    Console.WriteLine($"{num}\n");
                }
            }

        }

        private static Queue<int> SortQueue(Queue<int> input) // 1 creciente, 0 decreciente
        {
            Queue<int> q2 = new Queue<int>();
            foreach (int i in input.OrderBy(x => x))
            {
                q2.Enqueue(i);
            }

            return q2;
        }
        public static Queue<int> ReverseQueue(Queue<int> input)
        {
            Stack<int> tmpStack = new Stack<int>();
            Queue<int> tmpQueue = new Queue<int>(input); // copia

            while (tmpQueue.Count > 0)
            {
                tmpStack.Push(tmpQueue.Dequeue());
            }

            return new Queue<int>(tmpStack.ToArray());
        }

        #endregion

        #region Listas
        public static void Listas()
        {
            List<int> listaRandom = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 20; i++) // cargo stack
            {
                int random = r.Next(-1000, 1001);
                while (random == 0)
                {
                    random = r.Next(-1000, 1001);
                }
                listaRandom.Add(random);
            }

            Console.WriteLine("Stack completo:\n");
            foreach (int num in listaRandom)
            {
                Console.WriteLine($"{num}\n");
            }

            Console.WriteLine("\n\nSolo positivos creciente:\n");
            listaRandom.Sort(CompareInt);
            foreach (int num in listaRandom)
            {
                if (num > 0)
                {
                    Console.WriteLine($"{num}\n");
                }
            }

            Console.WriteLine("\n\nSolo negativos decreciente:\n");
            listaRandom.Reverse();
            foreach (int num in listaRandom)
            {
                if (num < 0)
                {
                    Console.WriteLine($"{num}\n");
                }
            }

        }

        private static int CompareInt(int x, int y)
        {
            if (x > y)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
