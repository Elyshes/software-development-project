// --------------------------------------------------------------------------------------------------------------------
// <copyright company="KARL STORZ GmbH and Co. KG">
// (c) 2013 KARL STORZ GmbH and Co. KG.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace SampleCodes
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Thrown if invalid number of operators.
    /// </summary>
    [Serializable]
    public class MissingOperatorsException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingOperatorsException"/> class.
        /// </summary>
        public MissingOperatorsException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingOperatorsException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message of the exception
        /// </param>
        public MissingOperatorsException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingOperatorsException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message which describes the error.
        /// </param>
        /// <param name="innerException">
        /// The exception which wrapped by this exception
        /// </param>
        public MissingOperatorsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingOperatorsException"/> class.
        /// </summary>
        /// <param name="info">
        /// The info.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        protected MissingOperatorsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
