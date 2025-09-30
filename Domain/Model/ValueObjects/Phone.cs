using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.ValueObjects
{
    public record Phone
    {
        public string value
        {
            get;
        }
        //in italia tutti i numeri di telefono iniziano con +39 3..
        public Phone(string value)
        {
            if(value.Length > 10 || value.StartsWith("+393") == false)
                throw new ArgumentException("Numero di telefono non valido");
            this.value = value;
        }
    }
}
