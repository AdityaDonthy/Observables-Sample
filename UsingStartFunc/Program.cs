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
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;

#endregion

namespace UsingStartFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "same";
            Console.WriteLine("Started as {0}", test);
            // this turn the function into an observable
            // that will run on a thread pool thread
            // notice that it updates the local variable test
            //  after it pauses for a second.
            var observable = Observable.Start(() =>
                                                  {
                                                  Console.WriteLine("snoooooooze");
                                                  Thread.Sleep(1000);
                                                  test = "different";
                                                  return new Unit();
                                              });
            // the function runs asynchronously but Run blocks
            // until it is completed. It produces an observable
            // sequence with a single System.Unit value in it
            observable.Run(e => Console.WriteLine(e));
            Console.WriteLine("test finished as {0}", test);


        }
    }
}
