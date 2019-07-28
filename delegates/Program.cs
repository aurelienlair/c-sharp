using System;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "will", "lukas", "dustin", "mike" };
            data = SortingAlgorithms.ComputeArrayWithoutDelegate(data, SortingTypes.BubbleSort);
            foreach (var item in data)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("");

            // delegate method
            SortingMethod sortingMethod = new SortingMethod(SortingAlgorithms.QuickSort);
            data = SortingAlgorithms.ComputeArrayWithDelegates(data, sortingMethod);

            // is the same as 
            // data = SortingAlgorithms.ComputeArrayWithDelegates(
            //     data, 
            //     new SortingMethod(SortingAlgorithms.QuickSort)
            // );
            foreach (var item in data)
            {
                Console.WriteLine(item.ToString());
            }

            // Action is a delegate (pointer) to a method, that takes zero, one or more input parameters, 
            // but does not return anything.
            Action<string> myAction = new Action<string>((userName) => {
                Console.WriteLine("Hello " + userName);
            });

            myAction(Console.ReadLine());
        }
    }
}
