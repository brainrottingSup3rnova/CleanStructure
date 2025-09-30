using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class VeterinaryVisit
    {
        Animal _animalVisited;
        public Animal AnimalVisited
        {
            get
            {
                return _animalVisited;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("L'animale visitato non può essere nullo");
                _animalVisited = value;
            }
        }

        Veterinary _veterinary;
        public Veterinary Veterinary
        {
            get
            {
                return _veterinary;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Il veterinario non può essere nullo");
                _veterinary = value;
            }
        }

        DateTime _visitDate;
        public DateTime VisitDate
        {
            get
            {
                return _visitDate;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La data della visita non può essere nel futuro");
                _visitDate = value;
            }
        }

        public VeterinaryVisit(Animal animalVisited, Veterinary veterinary, DateTime visitDate)
        {
            AnimalVisited = animalVisited;
            Veterinary = veterinary;
            VisitDate = visitDate;
        }
    }
}
