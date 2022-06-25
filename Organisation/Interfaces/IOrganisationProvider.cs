using Organisation.DB;
using System.Collections.Generic;

namespace Organisation.Interfaces
{
    public interface IOrganisationProvider
    {
        Task<(bool IsSuccess, IEnumerable<Models.Organisation> Organisations, string ErrorMessage)> GetOrganisationDetailsAync();
        Task<(bool IsSuccess, Models.Organisation Organisation, string ErrorMessage)> GetOrganisationDetailsByOrganisationNumberAync(string organisationNumber);
        Task<(bool IsSuccess, string ErrorMessage)> CreateOrganisationAsync(Models.Organisation organisation);
        Task<(bool IsSuccess, string ErrorMessage)> AddEmployeeInOrganisationAsync(Models.Employee employee);
        Task<(bool IsSuccess, IEnumerable<Models.Employee> Employees, string ErrorMessage)> GetEmployeeDetailsByOrganisationNumberAync(string organisationNumber);
        Task<(bool IsSuccess, int Count, string ErrorMessage)> GetEmployeeCountByOrganisationAync(string organisationNumber);


    }
}
