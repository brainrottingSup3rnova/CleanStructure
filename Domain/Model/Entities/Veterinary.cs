using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Veterinary
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il nome del veterinario non può essere vuoto");
                _name = value;
            }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il cognome del veterinario non può essere vuoto");
                _surname = value;
            }
        }
        private Email _email;
        public Email Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("L'email del veterinario non può essere nulla");
                _email = value;
            }
        }
        private Phone _phoneNumber;
        public Phone PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Il numero di telefono del veterinario non può essere nullo");
                _phoneNumber = value;
            }
        }
        public Veterinary(string name, string surname, Email email, Phone phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
