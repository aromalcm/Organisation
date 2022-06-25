using Organisation.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organisation.Controllers
{
    [ApiController]
    [Route("api/organisations")]
    public class OrganisationController:ControllerBase
    {
        private readonly IOrganisationProvider OrganisationsProvider;
        public OrganisationController(IOrganisationProvider OrganisationsProvider)
        {
            this.OrganisationsProvider = OrganisationsProvider;
        }

        [HttpPost("/organisation")]
        public async Task<IActionResult> CreateOrganisationAsync(Models.Organisation organisations)
        {
            var result = await OrganisationsProvider.CreateOrganisationAsync(organisations);
            if (result.IsSuccess)
            {
                return Ok(result.IsSuccess);
            }
            return NotFound();
        }

        [HttpPost("/employee")]
        public async Task<IActionResult> AddEmployeeInOrganisationAsync(Models.Employee employee)
        {
            var result = await OrganisationsProvider.AddEmployeeInOrganisationAsync(employee);
            if (result.IsSuccess)
            {
                return Ok(result.IsSuccess);
            }
            return NotFound();
        }

        [HttpGet("/organisationDetails")]
        public async Task<IActionResult> GetOrganisationDetailsAync()
        {
            var result = await OrganisationsProvider.GetOrganisationDetailsAync();
            if (result.IsSuccess)
            {
                return Ok(result.Organisations);
            }
            return NotFound();
        }

        [HttpGet("/organisationDetails/{organisationNumber}")]
        public async Task<IActionResult> GetOrganisationDetailsByOrganisationNumberAync(string organisationNumber)
        {
            var result = await OrganisationsProvider.GetOrganisationDetailsByOrganisationNumberAync(organisationNumber);
            if (result.IsSuccess)
            {
                return Ok(result.Organisation);
            }
            return NotFound();
        }

        [HttpGet("/employeeDetails/{organisationNumber}")]
        public async Task<IActionResult> GetEmployeeDetailsByOrganisationNumberAync(string organisationNumber)
        {
            var result = await OrganisationsProvider.GetEmployeeDetailsByOrganisationNumberAync(organisationNumber);
            if (result.IsSuccess)
            {
                return Ok(result.Employees);
            }
            return NotFound();
        }

        [HttpGet("/employeeCount/{organisationNumber}")]
        public async Task<IActionResult> GetEmployeeCountByOrganisationAync(string organisationNumber)
        {
            var result = await OrganisationsProvider.GetEmployeeCountByOrganisationAync(organisationNumber);
            if (result.IsSuccess)
            {
                return Ok(result.Count);
            }
            return NotFound();
        }
    }
}
