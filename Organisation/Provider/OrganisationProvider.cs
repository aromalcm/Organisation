using AutoMapper;
using Organisation.DB;
using Organisation.Interfaces;
using Organisation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organisation.Service
{
    public class OrganisationProvider : IOrganisationProvider
    {
        private readonly OrganisationDbContext dbContext;
        private readonly ILogger<OrganisationProvider> logger;
        private readonly IMapper mapper;

        public OrganisationProvider(OrganisationDbContext dbContext, ILogger<OrganisationProvider> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.dbContext = dbContext;
            Seed();
        }

        private void Seed()
        {
            if (!dbContext.Organisations.Any())
            {
                dbContext.Organisations.Add(new DB.Organisation() { OrganisationName = "Barclays UK PLC", OrganisationNumber = "09740322", AddressLine1 = "1 Churchill Place", Town = "London", Postcode = "E14 5HP" });
                dbContext.Organisations.Add(new DB.Organisation() { OrganisationName = "HSBC BANK PLC", OrganisationNumber = "00014259", AddressLine1 = "8 Canada Square", Town = "London", Postcode = "E14 5HQ" });
                dbContext.Organisations.Add(new DB.Organisation() { OrganisationName = "LLOYDS BANK PLC", OrganisationNumber = "00002065", AddressLine1 = "25 Gresham Street", Town = "London", Postcode = "EC2V 7HN" });
                dbContext.Organisations.Add(new DB.Organisation() { OrganisationName = "TSB BANK PLC", OrganisationNumber = "SC095237", AddressLine1 = "Henry Duncan House", AddressLine2 = "120 George Street", Town = "Edinburgh", Postcode = "EH2 4LH" });
                dbContext.Organisations.Add(new DB.Organisation() { OrganisationName = "CLYDESDALE BANK PLC", OrganisationNumber = "SC001111", AddressLine1 = "30 St Vincent Place", Town = "Glasgow", Postcode = "G1 2HL" });
                dbContext.Organisations.Add(new DB.Organisation() { OrganisationName = "STANDARD CHARTERED PLC", OrganisationNumber = "00966425", AddressLine1 = "1 Basinghall Avenue", Town = "London", Postcode = "EC2V 5DD" });
                dbContext.Organisations.Add(new DB.Organisation() { OrganisationName = "BANK OF SCOTLAND PLC", OrganisationNumber = "SC327000", AddressLine1 = "The Mound", Town = "Edinburgh", Postcode = "EH1 1YZ" });

                dbContext.SaveChanges();
            }
            if (!dbContext.Employees.Any())
            {
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 1, OrganisationNumber = "09740322", FirstName = "Janet", LastName = "Smith" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 2, OrganisationNumber = "09740322", FirstName = "Frank", LastName = "Bloswick" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 3, OrganisationNumber = "09740322", FirstName = "Tonya", LastName = "Bazinaw" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 4, OrganisationNumber = "09740322", FirstName = "Mike", LastName = "St. Onge" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 5, OrganisationNumber = "09740322", FirstName = "Jackie", LastName = "Jones" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 6, OrganisationNumber = "09740322", FirstName = "Darren", LastName = "Tillbrooke" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 7, OrganisationNumber = "09740322", FirstName = "Stephanie", LastName = "Holsinger" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 8, OrganisationNumber = "09740322", FirstName = "Rene", LastName = "Hughey" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 9, OrganisationNumber = "09740322", FirstName = "Robert", LastName = "Rogers" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 10, OrganisationNumber = "09740322", FirstName = "Richard", LastName = "LaPine" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 11, OrganisationNumber = "09740322", FirstName = "Kathy", LastName = "Summerfield" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 12, OrganisationNumber = "09740322", FirstName = "Kathy", LastName = "Bodwin" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 13, OrganisationNumber = "00002065", FirstName = "Mitch", LastName = "Krause" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 14, OrganisationNumber = "00002065", FirstName = "George", LastName = "Dow" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 15, OrganisationNumber = "00002065", FirstName = "Jack", LastName = "Malone" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 16, OrganisationNumber = "00002065", FirstName = "Bill", LastName = "Schweiz" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 17, OrganisationNumber = "00002065", FirstName = "Mark", LastName = "Gunter" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 18, OrganisationNumber = "00002065", FirstName = "Bob", LastName = "Anderson" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 19, OrganisationNumber = "00002065", FirstName = "Scott", LastName = "Simpson" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 20, OrganisationNumber = "00002065", FirstName = "Phil", LastName = "Dingman" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 21, OrganisationNumber = "00002065", FirstName = "Chad", LastName = "Leiker" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 22, OrganisationNumber = "00002065", FirstName = "Ian", LastName = "Benson" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 23, OrganisationNumber = "00002065", FirstName = "Nicole", LastName = "Lane" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 24, OrganisationNumber = "00002065", FirstName = "Steve", LastName = "Lundeen" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 25, OrganisationNumber = "00002065", FirstName = "Erica", LastName = "Black" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 26, OrganisationNumber = "00002065", FirstName = "Xenos", LastName = "Mathis" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 27, OrganisationNumber = "00002065", FirstName = "Kyle", LastName = "Good" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 28, OrganisationNumber = "00002065", FirstName = "Raja", LastName = "Dejesus" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 29, OrganisationNumber = "00002065", FirstName = "Timothy", LastName = "Frazier" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 30, OrganisationNumber = "00002065", FirstName = "Francine", LastName = "Morrison" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 31, OrganisationNumber = "SC095237", FirstName = "Avram", LastName = "Pate" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 32, OrganisationNumber = "SC095237", FirstName = "Hammett", LastName = "Coffey" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 33, OrganisationNumber = "SC095237", FirstName = "Hasad", LastName = "Wise" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 34, OrganisationNumber = "SC095237", FirstName = "Cullen", LastName = "Riddle" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 35, OrganisationNumber = "SC095237", FirstName = "Kato", LastName = "Delgado" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 36, OrganisationNumber = "SC095237", FirstName = "Todd", LastName = "Wright" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 37, OrganisationNumber = "SC095237", FirstName = "Troy", LastName = "Mccoy" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 38, OrganisationNumber = "SC095237", FirstName = "Gil", LastName = "Duncan" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 39, OrganisationNumber = "SC095237", FirstName = "Lionel", LastName = "Espinoza" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 40, OrganisationNumber = "SC095237", FirstName = "Victor", LastName = "Merrill" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 41, OrganisationNumber = "SC001111", FirstName = "Gennifer", LastName = "Vance" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 42, OrganisationNumber = "SC001111", FirstName = "Chancellor", LastName = "Warner" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 43, OrganisationNumber = "SC001111", FirstName = "Davis", LastName = "Wolf" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 44, OrganisationNumber = "00966425", FirstName = "Carlos", LastName = "Clarke" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 45, OrganisationNumber = "00966425", FirstName = "Dolan", LastName = "Mercado" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 46, OrganisationNumber = "00966425", FirstName = "Helen", LastName = "Guthrie" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 47, OrganisationNumber = "00966425", FirstName = "Elmo", LastName = "Douglas" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 48, OrganisationNumber = "00966425", FirstName = "Kane", LastName = "Rice" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 49, OrganisationNumber = "00966425", FirstName = "Colt", LastName = "Rowland" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 50, OrganisationNumber = "00966425", FirstName = "John", LastName = "Rose" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 51, OrganisationNumber = "00966425", FirstName = "Alfonso", LastName = "Hopkins" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 52, OrganisationNumber = "00966425", FirstName = "Ida", LastName = "Watts" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 53, OrganisationNumber = "00966425", FirstName = "Jennifer", LastName = "Coleman" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 54, OrganisationNumber = "00966425", FirstName = "Ciaran", LastName = "Newton" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 55, OrganisationNumber = "00966425", FirstName = "Hiram", LastName = "Carrillo" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 56, OrganisationNumber = "00966425", FirstName = "Devin", LastName = "Russell" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 57, OrganisationNumber = "00966425", FirstName = "Arsenio", LastName = "Jensen" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 58, OrganisationNumber = "00966425", FirstName = "Otto", LastName = "Gibbs" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 59, OrganisationNumber = "00966425", FirstName = "Hiram", LastName = "Vega" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 60, OrganisationNumber = "SC327000", FirstName = "Jarrod", LastName = "Randolph" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 61, OrganisationNumber = "SC327000", FirstName = "Josiah", LastName = "Gates" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 62, OrganisationNumber = "SC327000", FirstName = "Brandon", LastName = "Stanley" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 63, OrganisationNumber = "SC327000", FirstName = "Kennedy", LastName = "Nunez" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 64, OrganisationNumber = "SC327000", FirstName = "Lewis", LastName = "Sanchez" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 65, OrganisationNumber = "SC327000", FirstName = "Kassie", LastName = "Chaney" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 66, OrganisationNumber = "SC327000", FirstName = "Lance", LastName = "Knox" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 67, OrganisationNumber = "SC327000", FirstName = "Lamar", LastName = "Harrison" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 68, OrganisationNumber = "SC327000", FirstName = "Honorato", LastName = "Montgomery" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 69, OrganisationNumber = "00014259", FirstName = "Lisa", LastName = "Nielsen" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 70, OrganisationNumber = "00014259", FirstName = "Layla", LastName = "Barr" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 71, OrganisationNumber = "00014259", FirstName = "Nancy", LastName = "Mcclain" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 72, OrganisationNumber = "00014259", FirstName = "Kato", LastName = "Delgado" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 73, OrganisationNumber = "00014259", FirstName = "Todd", LastName = "Wright" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 74, OrganisationNumber = "00014259", FirstName = "Troy", LastName = "Mccoy" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 75, OrganisationNumber = "00014259", FirstName = "Gil", LastName = "Duncan" });
                dbContext.Employees.Add(new DB.Employee() { EmployeeId = 76, OrganisationNumber = "00014259", FirstName = "Lionel", LastName = "Espinoza" });
                dbContext.SaveChanges();
            }


        }

        public async Task<(bool IsSuccess, IEnumerable<Models.Organisation> Organisations, string ErrorMessage)> GetOrganisationDetailsAync()
        {
            try
            {
                var organisationDetails = await dbContext.Organisations.ToListAsync();
                if (organisationDetails != null)
                {
                    var result = mapper.Map<IEnumerable<DB.Organisation>, IEnumerable<Models.Organisation>>(organisationDetails);
                    return (true, result, "");
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Models.Organisation Organisation, string ErrorMessage)> GetOrganisationDetailsByOrganisationNumberAync(string organisationNumber)
        {
            try
            {
                var organisationDetails = await dbContext.Organisations.FirstOrDefaultAsync(p => p.OrganisationNumber == organisationNumber);
                if (organisationDetails != null)
                {
                    var result = mapper.Map<DB.Organisation, Models.Organisation>(organisationDetails);
                    return (true, result, "");
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> CreateOrganisationAsync(Models.Organisation organisation)
        {
            try
            {
                dbContext.Organisations.Add(new DB.Organisation()
                { 
                    AddressLine1 = organisation.AddressLine1,
                    AddressLine2=organisation.AddressLine2,
                    AddressLine3 = organisation.AddressLine3,
                    AddressLine4 = organisation.AddressLine4,   
                    OrganisationName = organisation.OrganisationName,
                    OrganisationNumber=organisation.OrganisationNumber,
                    Postcode = organisation.Postcode,
                    Town=organisation.Town
                });

                dbContext.SaveChanges();
                return (true, "");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> AddEmployeeInOrganisationAsync(Models.Employee employee)
        {
            try
            {
                dbContext.Employees.Add(new DB.Employee()
                {
                    OrganisationNumber = employee.OrganisationNumber,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName
                });

                dbContext.SaveChanges();
                return (true, "");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, IEnumerable<Models.Employee> Employees, string ErrorMessage)> GetEmployeeDetailsByOrganisationNumberAync(string organisationNumber)
        {
            try
            {  
                var employeeList = await dbContext.Employees.Where(c=>c.OrganisationNumber==organisationNumber).ToListAsync();
                if (employeeList != null && employeeList.Any())
                {
                    var result = mapper.Map<IEnumerable<DB.Employee>, IEnumerable<Models.Employee>>(employeeList);
                    return (true, result, "");
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, int Count, string ErrorMessage)> GetEmployeeCountByOrganisationAync(string organisationNumber)
        {
            try
            {
                
                var count = await dbContext.Employees.CountAsync(x=>x.OrganisationNumber==organisationNumber);
                return (true, count, "");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, 0, ex.Message);
            }
        }
    }
}
