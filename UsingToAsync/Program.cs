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

namespace UsingToAsync
{
    class Program
    {



        static void Main(string[] args)
        {
            var stest = "";
            // delegate is executed asynchronously on thread pool
            var asyncFunction = Observable.ToAsync(
                () => { 
                Thread.Sleep(1000);
                throw new Exception("mfasd");
            } );

            // executing function produces an observable
            var observable = asyncFunction();
            //Console.ReadKey();
            // we can subscribe to observable
            observable.Subscribe(e => Console.WriteLine(e), 
               e => Console.WriteLine(e.Message), () => Console.WriteLine("I'm done"));
            Console.WriteLine(stest);
        }
    }
}
