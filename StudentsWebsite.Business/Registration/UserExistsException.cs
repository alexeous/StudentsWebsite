using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Registration
{

    [Serializable]
    public class UserExistsException : Exception
    {
        public UserExistsException() { }
        public UserExistsException(string message) : base(message) { }
        public UserExistsException(string message, Exception inner) : base(message, inner) { }
        protected UserExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
