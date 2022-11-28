namespace SampleCodes
{
    using System;
    using System.Collections.Generic;

    public class Calculator 
    {
        private readonly IDictionary<Type, IOperation> calculateFunctions;

        public Calculator(IDictionary<Type, IOperation> calculateFunctions)
        {
            this.calculateFunctions = calculateFunctions;
        }

        public double Do<T>(params double[] values)
        {
            if (values.Length < 2)
            {
                throw new MissingOperatorsException();
            }
            var function = this.calculateFunctions[typeof(T)];

            double result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result = function.Operation(result, values[1]);
            }

            return result;
        }
    }
}
