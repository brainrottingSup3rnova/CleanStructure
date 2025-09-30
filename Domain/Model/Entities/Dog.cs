using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Dog: Animal
    {
        private string _chewingToy;
        public string ChewingToy
        {
            get { return _chewingToy; }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Non può essere solo spazi bianchi");
                _chewingToy = value;
            }
        }
        public Dog(string chewingToy,string name, List<VeterinaryVisit> visits = null) : base(name, visits) 
        {
            ChewingToy = chewingToy;
        }
    }
}
