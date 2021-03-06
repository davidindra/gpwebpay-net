﻿using System.Security.Cryptography.X509Certificates;

namespace GPWebpayNet.Sdk.Services
{
    /// <summary>
    /// Encding service interface.
    /// </summary>
    public interface IEncodingService
    {
        /// <summary>
        /// Signs the data (creates a digest).
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="privateCertificateFile">The certificate file.</param>
        /// <param name="privateCertificatePassword">The certificate password.</param>
        /// <param name="encoding">The encoding.</param>
        /// <param name="keyStorageFlags">The key storage flags.</param>
        /// <returns>Signed mesage data (digest).</returns>
        string SignData(
            string message,
            string privateCertificateFile,
            string privateCertificatePassword,
            int encoding = Encoding.DefaultEncoding,
            X509KeyStorageFlags keyStorageFlags = Encoding.DefaultKeyStorageFlags);

        /// <summary>
        /// Signs the data (creates a digest).
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="privateCertificate">The private certificate.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>Signed mesage data (digest).</returns>
        string SignData(
            string message,
            X509Certificate2 privateCertificate,
            int encoding = Encoding.DefaultEncoding);

        /// <summary>
        /// Validates the digest.
        /// </summary>
        /// <param name="digest">The digest.</param>
        /// <param name="message">The message.</param>
        /// <param name="publicCertificateFile">The public certificate file.</param>
        /// <param name="password">The password.</param>
        /// <param name="encoding">The encoding.</param>
        /// <param name="keyStorageFlags">The key storage flags.</param>
        /// <returns>Validation result.</returns>
        bool ValidateDigest(
            string digest,
            string message,
            string publicCertificateFile,
            string password,
            int encoding = Encoding.DefaultEncoding,
            X509KeyStorageFlags keyStorageFlags = Encoding.DefaultKeyStorageFlags);

        /// <summary>
        /// Validates the digest.
        /// </summary>
        /// <param name="digest">The digest.</param>
        /// <param name="message">The message.</param>
        /// <param name="publicCertificate">The private certificate.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>Validation result.</returns>
        bool ValidateDigest(
            string digest,
            string message,
            X509Certificate2 publicCertificate,
            int encoding = Encoding.DefaultEncoding);
    }
}