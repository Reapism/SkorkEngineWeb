using System;

namespace SkorkEngine.exception {

    /// <summary>
    /// The root exception class for the <see cref="SkorkEngine"/>.
    /// <para>All other Skork exceptions are derived from this class.</para>
    /// </summary>
    public class SkorkException : Exception {

        private string exceptionMsg;

        /// <summary>
        /// Construct a throwable <see cref="SkorkException"/>.
        /// <para>The root level skork exception.</para>
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkException(string msg) {
            this.exceptionMsg = msg;
        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return this.exceptionMsg;
        }

    }
}
