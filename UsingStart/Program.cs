#region PluralsightExerciseExample
// Copyright Pluralsight LLC 2011
// 
// This example is for the exclusive use of subscribers to a Pluralsight On Demand!
// subscription that includes example code.
// 
// Please do not post these examples or pass them around.
// 
// This code is meant to be used for training purposes only.
// 
// No representations are made as to its usefullness or correctness.
// 
// This code may not be used in any applications or production code.
// 
// Thank You!
#endregion

#region

using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;

#endregion

namespace UsingStart
{
    class Program
    {
        static int Slow(int number)
        {
            Console.WriteLine("Snoooooooooooooze");
            Thread.Sleep(300);
            return number;
        }
        static void Main(string[] args)
        {
            // make an observable list of values
            var query = (from number in Enumerable.Range(0, 10) select Slow(number));
            var observable = query.ToObservable(Scheduler.NewThread);
            // use Start to produce list of values
            // rather than calling delegate for each value
            var listOfValues = observable.Start();
            Console.WriteLine("Started");
            // iterating list of returned values by Start blocks until list is complete););
            foreach (var item in listOfValues)
            {
                  Console.WriteLine(item);
            }
        }
    }
}
