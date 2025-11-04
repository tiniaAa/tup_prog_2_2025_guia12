using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class FormatoDniNoValidoException:ApplicationException
    {
        public FormatoDniNoValidoException() : base() { }
        public FormatoDniNoValidoException(string message) : base(message) { }
       
    
    }
}
