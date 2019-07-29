using System;

namespace SkorkEngine.exception {
    public class SkorkException : Exception {

        private string exceptionMsg;
        public SkorkException(string msg) {
            this.exceptionMsg = msg;
        }

        public override string ToString() {
            return this.exceptionMsg;
        }

    }
}
