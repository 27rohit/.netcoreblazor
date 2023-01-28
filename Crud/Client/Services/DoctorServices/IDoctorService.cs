using Crud.Shared;

namespace Crud.Client.Services.DoctorServices
{
    public interface IDoctorService
    {
        List<Doctor> Doctors { get; set; }
        List<Ward> Wards { get; set; }
        Task GetWards();
        Task GetDoctors();
        Task<Doctor> GetSingleDoctor(int Id);
        Task CreateDoctor(Doctor doctor);
        Task UpdateDoctor(Doctor doctor);
        Task DeleteDoctor(int Id);

    }
}
