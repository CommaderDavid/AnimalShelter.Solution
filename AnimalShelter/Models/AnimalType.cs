using System;

namespace AnimalShelter.Models
{
    public class AnimalType
    {
        public int AnimalTypeId { get; set; }
        public string TypeSpecies { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfAdmittance { get; set; }
        public string Breed { get; set; }
    }
}