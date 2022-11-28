namespace SampleCodeRunner
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using SampleCodes;

    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<Type, IOperation> operations = new Dictionary<Type, IOperation>();
            operations[typeof(Add)] = new Rounder(new Add());
            operations[typeof(Mulitplicate)] = new Rounder(new Mulitplicate());
            var calculator = new Calculator(operations);

            Console.WriteLine(calculator.Do<Add>(5.5, 5, 5));

            Console.WriteLine(calculator.Do<Mulitplicate>(5.6, 5, 5));

            Console.ReadKey();
        }
    }
}
