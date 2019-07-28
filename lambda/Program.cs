//https://www.dotnetperls.com/lambda
using System;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Use implicitly-typed lambda expression.
            // ... Assign it to a Func instance.
            //
            Func<int, int> func1 = x => x + 1;

            // Func is a delegate (pointer) to a method, that takes zero, one or more input parameters, 
            // and returns a value (or reference).
            // Func<TParameter(s), TOutput>
            // Func<T1, T2, ..., Tn, Tr> represents a function, that takes (T1, T2, ..., Tn) arguments and returns Tr.
            // int => parameter type, string => return type
            Func<int, string> funcIntToString = x => "To string is " + x.ToString();
            //
            // Use lambda expression with statement body.
            //
            Func<int, int> func2 = x => { return x + 1; };
            //
            // Use formal parameters with expression body.
            //
            Func<int, int> func3 = (int x) => x + 1;
            //
            // Use parameters with a statement body.
            //
            Func<int, int> func4 = (int x) => { return x + 1; };
            //
            // Use multiple parameters.
            //
            Func<int, int, int> func5 = (x, y) => x * y;
            //
            // Use no parameters in a lambda expression.
            //
            Action func6 = () => Console.WriteLine();
            //
            // Use delegate method expression.
            //
            Func<int, int> func7 = delegate (int x) { return x + 1; };
            //
            // Use delegate expression with no parameter list.
            //
            Func<int> func8 = delegate { return 1 + 1; };
            //
            // Invoke each of the lambda expressions and delegates we created.
            // ... The methods above are executed.
            //
            Console.WriteLine(func1.Invoke(1));
            Console.WriteLine(func2.Invoke(1));
            Console.WriteLine(func3.Invoke(1));
            Console.WriteLine(func4.Invoke(1));
            Console.WriteLine(func5.Invoke(2, 2));
            func6.Invoke();
            Console.WriteLine(func7.Invoke(1));
            Console.WriteLine(func8.Invoke());
            Console.WriteLine(funcIntToString.Invoke(23));
        }
    }

    public class Prova<T>
    {
        public Prova(Func<T, T> cloningFunction);
    }
}
