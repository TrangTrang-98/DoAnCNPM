using System;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
//using ApplicationCore.Entities.DoctorAggregate;
namespace ApplicationCore.Entities.DoctorAggregate
{
    public class Doctor : IAggregateRoot
    {
        public string DoctorId{get; set;}

        public string DoctorName{get; set;}

        public System.DateTime Birthday{get; set;}

        public string Phone{get; set;}

        // private List<DocAppointment> _appointment = new List<DocAppointment>();
        // IEnumerable<DocAppointment> appointment => _appointment.AsReadOnly();

        public Doctor(string id, string name, DateTime birthday, string phone)
        {
            DoctorId = id;
            DoctorName = name;
            Birthday = birthday;
            Phone = phone;
        }
    }
}