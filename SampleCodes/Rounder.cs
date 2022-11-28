// --------------------------------------------------------------------------------------------------------------------
// <copyright company="KARL STORZ GmbH and Co. KG">
// (c) 2013 KARL STORZ GmbH and Co. KG.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace SampleCodes
{
    using System;

    public class Rounder : IOperation
    {
        private readonly IOperation operation;

        public Rounder(IOperation operation)
        {
            this.operation = operation;
        }

        public double Operation(double left, double right)
        {
            return Math.Round(operation.Operation(left, right));
        }
    }
}