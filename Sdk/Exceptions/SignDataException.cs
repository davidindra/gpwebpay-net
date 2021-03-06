﻿using System;

namespace GPWebpayNet.Sdk.Exceptions
{
    /// <summary>
    /// Invalid sign data exception.
    /// </summary>
    /// <seealso cref="GPWebpayNet.Sdk.Exceptions.GPWebpayNetException" />
    public class SignDataException : GPWebpayNetException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignDataException"/> class.
        /// </summary>
        public SignDataException() : this(string.Empty, null)
        {
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignDataException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public SignDataException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}