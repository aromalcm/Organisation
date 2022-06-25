# Solution description

The solution is a web api project based on organisation that can be used as a microservice.

## Implemented
1. API to get the list of organisation.
2. API to get the orgnaisation based on organisation number. 
3. API to create an orgnaisation.
4. API to add an employee to the organisation.
5. API to list all the employees based on organisation number.
6. API to get employee count in an organisation.
7. Test project contain test method for all provider methods.

## Points
As SQL Server is not installed in my system I used  Entity framework in memory database.

## Table Design

Organisation Table 
-------------------
OrganisationNumber nvarchar(50) NOT NULL PRIMARY KEY
OrganisationName nvarchar(100) NOT NULL
AddressLine1 nvarchar(100) NOT NULL
AddressLine2 nvarchar(100)
AddressLine3 nvarchar(100)
AddressLine4 nvarchar(100)
Town nvarchar(100) 
Postcode nvarchar(20) NOT NULL

Employee Table 
---------------
EmployeeId int NOT NULL PRIMARY KEY
OrganisationNumber  nvarchar(50) FOREIGN KEY
FirstName nvarchar(100) NOT NULL
LastName nvarchar(100) NOT NULL

## Dependencies

Microsoft.EntityFrameworkCore,
Microsoft.EntityFrameworkCore.InMemory,
AutoMapper.Extensions.Microsoft.DepenendecyInjection
