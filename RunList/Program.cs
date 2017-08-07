using System;
using System.Collections.Generic;
using System.Concurrency;
using System.Linq;
using System.Text;
using System.Threading;

namespace RunList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = from number in Enumerable.Range(1, 10) select number;
            // make an observeable sequence out of those numbers
            var observable = numbers.ToObservable();
            // use the ObservableExtensions.Subscribe to start the callbacks
            // notice that when Subscribe is changed to run, the instruction blocks 
            // until the entire observable sequence has been processed
            observable.Subscribe(Console.WriteLine);
            Console.WriteLine("Done");

        }
    }
}
