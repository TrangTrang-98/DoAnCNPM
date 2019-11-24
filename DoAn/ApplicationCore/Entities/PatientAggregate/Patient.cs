using System;
using System.Collections.Generic;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities.PatientAggregate
{
    public class Patient : IAggregateRoot
    {
        public string PatientId { get;  set; }

        public string PatientName { get;  set; }

        public bool Gender { get;  set; }

        public System.DateTime Birthday { get;  set; }

        public ApplicationCore.Entities.PatientAggregate.Address Address { get;  set; }

        public string Phone { get; set; }

        private List<ApplicationCore.Entities.PatientAggregate.PayForm> _payForm = new List<ApplicationCore.Entities.PatientAggregate.PayForm>();
        IEnumerable<ApplicationCore.Entities.PatientAggregate.PayForm> payForms => _payForm.AsReadOnly();

        

        public ICollection<Enrollments> Enrollment{get; set;}

        // public Patient(string name, bool gender, DateTime birth, Address address)
        // {
        //     PatientName = name;
        //     Gender = gender;
        //     Birthday = birth;
        //     Address = address;
        // }

    }

}