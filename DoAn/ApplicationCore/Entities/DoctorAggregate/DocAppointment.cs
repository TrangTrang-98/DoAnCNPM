namespace ApplicationCore.Entities.DoctorAggregate
{
    public class DocAppointment // value object
    {
        public System.DateTime AppointmentDate{get; private set;}
        public System.DateTime AppointmentTime{get; private set;}
    }
}