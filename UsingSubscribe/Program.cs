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
using System.Text;

#endregion

namespace UsingSubscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            // make an array of numbers
            var numbers = new int[] {1, 2, 3};
            // make an observeable sequence out of those numbers
            var observable = numbers.ToObservable();
            // use the ObservableExtensions.Subscribe to start the callbacks
            observable.Subscribe(Console.WriteLine);
        }
    }
}
