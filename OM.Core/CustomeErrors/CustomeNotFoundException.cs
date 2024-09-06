using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Core.CustomeErrors
{
    public class CustomeNotFoundException : Exception
    {
        public CustomeNotFoundException(string strMessage) : base(strMessage)
        {
        }
    }
}
