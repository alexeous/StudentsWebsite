using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Registration
{

    [Serializable]
    public class InvalidSecretWordException : Exception
    {
        public InvalidSecretWordException() { }
        public InvalidSecretWordException(string message) : base(message) { }
        public InvalidSecretWordException(string message, Exception inner) : base(message, inner) { }
        protected InvalidSecretWordException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
