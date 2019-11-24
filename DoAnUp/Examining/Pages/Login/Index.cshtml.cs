using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities.PatientAggregate;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using ApplicationCore.Entities.DoctorAggregate;
namespace Examining.Pages.Login
{
    public class IndexModel : PageModel
    {
        private readonly RegisterContext _context;
        public IndexModel(RegisterContext context)
        {
            _context = context;
        }

        public IList<Enrollments> ListEnrollment { get;set; }
       
        public async Task OnGetAsync()

        {

            ListEnrollment = await _context.Enrollments

                .Include(d => d.doctor)
                .Include(p => p.patient)

                .AsNoTracking()

                .ToListAsync();

        }
        // public async Task OnGetAsync()
        // {
        //     ListEnrollment = await _context.Enrollments.ToListAsync();
        //     // ListPatient  = await _context.Patients.ToListAsync();
        //     // ListDoctor  = await _context.Doctors.ToListAsync();
        // }
        
    }
}
