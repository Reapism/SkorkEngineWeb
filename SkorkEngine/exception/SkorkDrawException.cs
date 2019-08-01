namespace SkorkEngine.exception {
    /// <summary>
    /// The <see cref="SkorkDrawException"/> class.
    /// <para>Thrown when an error occurs in drawing
    /// the grid.</para>
    /// </summary>
    public class SkorkDrawException : SkorkException {

        /// <summary>
        /// Construct a throwable <see cref="SkorkDrawException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkDrawException(string msg) : base(msg) {

        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return base.ToString();
        }
    }
}
