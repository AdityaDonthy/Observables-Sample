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

#endregion

namespace UsingStartWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var observable = (new int[] {1, 2, 3}).ToObservable();
            var a = observable.StartWith(5, 6, 7);
            a.Run(Console.WriteLine);
        }
    }
}
