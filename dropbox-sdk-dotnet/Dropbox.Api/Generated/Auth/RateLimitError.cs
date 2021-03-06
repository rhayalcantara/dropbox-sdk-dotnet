// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Auth
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Error occurred because the app is being rate limited.</para>
    /// </summary>
    public class RateLimitError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RateLimitError> Encoder = new RateLimitErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RateLimitError> Decoder = new RateLimitErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RateLimitError" /> class.</para>
        /// </summary>
        /// <param name="reason">The reason why the app is being rate limited.</param>
        /// <param name="retryAfter">The number of seconds that the app should wait before
        /// making another request.</param>
        public RateLimitError(RateLimitReason reason,
                              ulong retryAfter = 1)
        {
            if (reason == null)
            {
                throw new sys.ArgumentNullException("reason");
            }

            this.Reason = reason;
            this.RetryAfter = retryAfter;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RateLimitError" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RateLimitError()
        {
            this.RetryAfter = 1;
        }

        /// <summary>
        /// <para>The reason why the app is being rate limited.</para>
        /// </summary>
        public RateLimitReason Reason { get; protected set; }

        /// <summary>
        /// <para>The number of seconds that the app should wait before making another
        /// request.</para>
        /// </summary>
        public ulong RetryAfter { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RateLimitError" />.</para>
        /// </summary>
        private class RateLimitErrorEncoder : enc.StructEncoder<RateLimitError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RateLimitError value, enc.IJsonWriter writer)
            {
                WriteProperty("reason", value.Reason, writer, global::Dropbox.Api.Auth.RateLimitReason.Encoder);
                WriteProperty("retry_after", value.RetryAfter, writer, enc.UInt64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RateLimitError" />.</para>
        /// </summary>
        private class RateLimitErrorDecoder : enc.StructDecoder<RateLimitError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RateLimitError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RateLimitError Create()
            {
                return new RateLimitError();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RateLimitError value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "reason":
                        value.Reason = global::Dropbox.Api.Auth.RateLimitReason.Decoder.Decode(reader);
                        break;
                    case "retry_after":
                        value.RetryAfter = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
