using System;

namespace CompanyManagement.Database.Entities
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string CountryIso { get; set; }
    }
}
