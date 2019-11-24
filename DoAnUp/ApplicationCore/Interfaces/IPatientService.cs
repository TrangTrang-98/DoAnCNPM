using ApplicationCore.Entities.PatientAggregate;
namespace ApplicationCore.Interfaces
{
    public interface IPatientService
    {
        Patient GetPatient(string id);
        //IEnumerable<PatientDto> GetPatients(int pageIndex, int pageSize, out int count);
        //IEnumerable<string> GetGenres();

        void CreatePatient(Patient Patient); // dang ki benh nhan
        void UpdatePatient(Patient Patient);
        void DeletePatient(string id);
    }
}