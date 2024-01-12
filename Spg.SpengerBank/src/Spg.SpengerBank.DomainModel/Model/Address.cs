using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Model
{
    public record Address
    {
        public string Nummber { get; }
        public string Street { get; }
        public string City { get; }
        public string ZipCode { get; }

        public Address(string nummber, string street, string city, string zipCode)
        {
            Nummber = nummber;
            Street = street;
            City = city;
            ZipCode = zipCode;
        }

        public Address()
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
