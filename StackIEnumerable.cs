class StackPushPop
    {

        public class Stack<T> : IEnumerable<T>
        {
            T[] values = new T[100];
            int top = 0;


            public void Push(T t)
            {
                values[top++] = t;
            }


            public T Pop()
            {
                return values[--top];
            }



            public IEnumerator<T> GetEnumerator()
            {
                for (int i = top; i >=0 ; i--)
                {
                    yield return values[i];
                }  
            }



            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }



            public IEnumerable<T> TopToBottom
            {
                get
                {
                    return this;
                }
            }

           


            public IEnumerable<T> BottomToTop
            {
                get
                {
                    for (int i = 0; i < top; i++)
                    {
                        yield return values[i];
                    }
                }
            }



            public IEnumerable<T> TopN(int n)
            {
                int j = n >= top ? 0 : top - n;
                for (int i = top; --i >= j;)
                {
                    yield return values[i];
                }
            }
        }



        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            Console.WriteLine("Enter the Values:");
            for (int i = 0; i < 10; i++)
            {
                int value = int.Parse(Console.ReadLine());

                s.Push(value);
            }
            foreach (int n in s)
            {
                Console.Write("{0}", n);
            }



            Console.WriteLine();
            foreach (int n in s.TopToBottom)
            {
                Console.WriteLine("{0}", n);
            }


            Console.WriteLine();
            foreach (int n in s.BottomToTop)
            {
                Console.WriteLine("{0}", n);
            }


            Console.WriteLine();
            foreach (int n in s.TopN(7))
            {
                Console.WriteLine("{0}", n);
            }

            Console.ReadKey();
            



        }
    }