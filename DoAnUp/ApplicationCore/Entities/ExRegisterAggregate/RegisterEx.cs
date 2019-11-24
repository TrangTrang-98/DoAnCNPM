using System;
using System.Collections.Generic;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities.ExRegisterAggregate
{
    public class RegisterEx : IAggregateRoot
    {
        public string _patient{get; private set;} // id tk dang ki kham benh

        public string _doctor{get; }

       List<ApplicationCore.Entities.ExRegisterAggregate.ExForm> _exForms 
                = new List<ApplicationCore.Entities.ExRegisterAggregate.ExForm>();

        private readonly List<ApplicationCore.Entities.ExRegisterAggregate.Dept> _dept 
                = new List<ApplicationCore.Entities.ExRegisterAggregate.Dept>();
        List<ApplicationCore.Entities.ExRegisterAggregate.Dept> _depts 
                = new List<ApplicationCore.Entities.ExRegisterAggregate.Dept>();
        
        public System.DateTime RegisterDate{get; private set;} = System.DateTime.Now;

        public RegisterEx(string id, string doctor, List<ApplicationCore.Entities.ExRegisterAggregate.Dept> depts, List<ApplicationCore.Entities.ExRegisterAggregate.ExForm> exForm)
        {
            _patient = id;
            _doctor = doctor;
            _depts = depts;
            _exForms = exForm;
        }
    }
}