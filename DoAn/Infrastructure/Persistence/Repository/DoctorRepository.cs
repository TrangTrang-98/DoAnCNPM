using ApplicationCore.Interfaces;
using ApplicationCore.Entities.DoctorAggregate;
using System.Collections.Generic;
namespace Infrastructure.Persistence.Repository
{
    public class DoctorRepository : EFRepository<Doctor>,  IDoctorRepository
    {
       public DoctorRepository(RegisterContext context) : base(context)
       {
           
       }

        /*public IEnumerable<string> GetDoctorName()
        {
            return Context.Doctors
                            .Select(m => m.DoctorName)
                            .Distinct().ToList();
        }*/

        protected new RegisterContext Context => Context as RegisterContext;
    }
    
}