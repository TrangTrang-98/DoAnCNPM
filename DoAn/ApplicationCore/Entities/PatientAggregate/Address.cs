namespace ApplicationCore.Entities.PatientAggregate
{
    public class Address // value object -- Patient
    {
        public string NumHouse{get; private set;}
        public string Street{get; private set;}
        public string District{get; private set;}
        public string City{get; private set;}
        public string Country{get; private set;}
    }
}