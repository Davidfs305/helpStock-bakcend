using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpStockApp.Domain.Validatio
{
    public class DomainExceptionValidatio : Exception
    {
        public DomainExceptionValidatio(string error) :base(error) 
        { }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExceptionValidatio(error);
        }
    }
}
