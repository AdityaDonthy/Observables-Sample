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
using System.Concurrency;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

#endregion

namespace UsingRun
{
    class Program
    {
        static void Main(string[] args)
        {
            // make an array of numbers
            var numbers = from number in Enumerable.Range(1, 10) select number;
            // make an observeable sequence out of those numbers
            var observable = numbers.ToObservable(Scheduler.NewThread);
            // use the ObservableExtensions.Subscribe to start the callbacks
            // notice that when Subscribe is changed to run, the instruction blocks 
            // until the entire observable sequence has been processed
            observable.Run(Console.WriteLine);
            Console.WriteLine("Done");

        }
    }
}
