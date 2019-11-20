using System;
using System.Collections.Generic;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities.PatientAggregate
{
    public class Patient : IAggregateRoot
    {
        public string PatientId { get; private set; }

        public string PatientName { get; private set; }

        public bool Gender { get; private set; }

        public System.DateTime Birthday { get; private set; }

        public ApplicationCore.Entities.PatientAggregate.Address address { get; private set; }

        public string Phone { get; private set; }

        private List<ApplicationCore.Entities.PatientAggregate.PayForm> _payForm = new List<ApplicationCore.Entities.PatientAggregate.PayForm>();
        IEnumerable<ApplicationCore.Entities.PatientAggregate.PayForm> payForms => _payForm.AsReadOnly();


    }

}