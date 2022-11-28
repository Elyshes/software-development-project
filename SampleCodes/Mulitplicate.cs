// --------------------------------------------------------------------------------------------------------------------
// <copyright company="KARL STORZ GmbH and Co. KG">
// (c) 2013 KARL STORZ GmbH and Co. KG.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace SampleCodes
{
    public class Mulitplicate : IOperation
    {
        public double Operation(double left, double right)
        {
            return left * right;
        }
    }
}