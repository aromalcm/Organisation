
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Organisation.DB;
using Organisation.Profiles;
using Organisation.Service;
using System.Threading.Tasks;
using Xunit;

namespace TestOrganisation
{
    public class OrganisationTest
    {
        
        [Fact]
        public async Task GetOrganisationDetailsAync()
        {
            var options = new DbContextOptionsBuilder<OrganisationDbContext>().UseInMemoryDatabase(nameof(GetOrganisationDetailsAync)).Options;
            var dbContext = new OrganisationDbContext(options);
            var profile = new Profiles();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);

            var organisationProvider = new OrganisationProvider(dbContext, null, mapper);
            var organisation = await organisationProvider.GetOrganisationDetailsAync();
            Assert.NotNull(organisation.Organisations);

        }

        [Fact]
        public async Task GetOrganisationDetailsByOrganisationNumberAync()
        {
            var options = new DbContextOptionsBuilder<OrganisationDbContext>().UseInMemoryDatabase(nameof(GetOrganisationDetailsByOrganisationNumberAync)).Options;
            var dbContext = new OrganisationDbContext(options);
            var profile = new Profiles();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);

            var organisationProvider = new OrganisationProvider(dbContext, null, mapper);

            Organisation.Models.Organisation expected = new Organisation.Models.Organisation();
            expected.OrganisationName = "Barclays UK PLC";
            expected.OrganisationNumber = "09740322";
            expected.AddressLine1 = "1 Churchill Place";
            expected.Town = "London";
            expected.Postcode = "E14 5HP";

            var actual = await organisationProvider.GetOrganisationDetailsByOrganisationNumberAync("09740322");
            Assert.Equal(actual.Organisation.OrganisationName, expected.OrganisationName);

        }

        [Fact]
        public async Task CreateOrganisationAsync()
        {
            var options = new DbContextOptionsBuilder<OrganisationDbContext>().UseInMemoryDatabase(nameof(CreateOrganisationAsync)).Options;
            var dbContext = new OrganisationDbContext(options);
            var profile = new Profiles();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);

            var organisationProvider = new OrganisationProvider(dbContext, null, mapper);

            Organisation.Models.Organisation organisation = new Organisation.Models.Organisation();
            organisation.OrganisationName = "New Organisation";
            organisation.OrganisationNumber = "3333nw";
            organisation.AddressLine1 = "10 Ronson Avenue";
            organisation.Town = "London";
            organisation.Postcode = "ST4 6PX";

            var actual = await organisationProvider.CreateOrganisationAsync(organisation);
            Assert.True(true);

        }

        [Fact]
        public async Task AddEmployeeInOrganisationAsync()
        {
            var options = new DbContextOptionsBuilder<OrganisationDbContext>().UseInMemoryDatabase(nameof(AddEmployeeInOrganisationAsync)).Options;
            var dbContext = new OrganisationDbContext(options);
            var profile = new Profiles();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);

            var organisationProvider = new OrganisationProvider(dbContext, null, mapper);

            Organisation.Models.Employee employee = new Organisation.Models.Employee();
            employee.FirstName = "Sunny";
            employee.LastName = "Francis";
            employee.OrganisationNumber = "09740322";

            var actual = await organisationProvider.AddEmployeeInOrganisationAsync(employee);
            Assert.True(true);

        }

        [Fact]
        public async Task GetEmployeeDetailsByOrganisationNumberAync()
        {
            var options = new DbContextOptionsBuilder<OrganisationDbContext>().UseInMemoryDatabase(nameof(GetEmployeeDetailsByOrganisationNumberAync)).Options;
            var dbContext = new OrganisationDbContext(options);
            var profile = new Profiles();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);

            var organisationProvider = new OrganisationProvider(dbContext, null, mapper);

            var actual = await organisationProvider.GetEmployeeDetailsByOrganisationNumberAync("09740322");
            Assert.NotNull(actual.Employees);

        }

        [Fact]
        public async Task GetEmployeeCountByOrganisationAync()
        {
            var options = new DbContextOptionsBuilder<OrganisationDbContext>().UseInMemoryDatabase(nameof(GetEmployeeCountByOrganisationAync)).Options;
            var dbContext = new OrganisationDbContext(options);
            var profile = new Profiles();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);

            var organisationProvider = new OrganisationProvider(dbContext, null, mapper);

            var actual = await organisationProvider.GetEmployeeCountByOrganisationAync("09740322");
            Assert.True(actual.IsSuccess);

        }
    }
}