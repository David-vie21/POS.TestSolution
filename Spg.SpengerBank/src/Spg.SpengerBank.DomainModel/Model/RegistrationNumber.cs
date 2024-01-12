using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Model
{
    public record RegistrationNumber
    {
        public string Prefix { get; set; }
        public string Identifier { get; set; }
        public string Suffix { get; set; }

        public RegistrationNumber(string prefix, string identifier, string suffix)
        {
            Prefix = prefix;
            Identifier = identifier;
            Suffix = suffix;
        }
    }
}
    