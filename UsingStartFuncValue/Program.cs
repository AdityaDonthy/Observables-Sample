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
using System.Reactive.Linq;
using System.Threading;

#endregion

namespace UsingStartFuncValue
{
    class Program
    {
        static int MyThread()
        {
            return Thread.CurrentThread.ManagedThreadId;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Application thread {0}", Thread.CurrentThread.ManagedThreadId);
            // executes MyThread but returns an observable sequence
            var observable = Observable.Start<int>(MyThread);
            // The sequence always has a single value in it
            Console.WriteLine("Function Thread {0}", observable.First());
        }
    }
}
