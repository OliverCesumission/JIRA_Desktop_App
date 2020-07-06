using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST_API_CALL
{
    public class csUserCredential
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        private csUserCredential() { }

        public static readonly csUserCredential Instance = new csUserCredential();

    }
}
