namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        IPatientRepository Patient{get;}
        //IDoctorRepository Doctor{get;}
        //IUserRepository User{get;}
        // bo sung them nhung repository khac

        int Complete();
    }
}