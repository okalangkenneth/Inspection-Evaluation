# Inspection-Evaluation

## Introduction.
While working for an inspection company as a project manager for the agricultural division, the process of accepting a project from a client, assigning the project to an inspector, daily evaluation of the project, a weekly report of the status of the project, quality control of submitted samples and its report, were all done manually and prone to data entry errors.

## Goals.
This project is being designed to overcome most of the manual processes that were going in the Inspection company. It is a web application that can simplify the task of the administrator, project manager, inspector, and quality controller. It will also serve as a gathering place for inspectors field reports. The application will also be able to call on a database via an API that has information on available jobs in each department.The inspectors will be able to search this database. Project managers will also be able to apply and also edit its content. I will then take advantage of any of the Azure computing services that will be available to enhence the application.

## Project description.
The project is designed in such a way that many of the input operations are done through forms. The forms are capable of validating and checking the integrity and correctness of the input. The database will be built from Entity Framework according to codefirst method. Frontend will be from Bootstrap. The dynamic functionality in the front-end will be written with javascript.The application will have a .NET Core API that will intergarte with MVC Core web interface.

### Project structure
LMS.G3
* ├─LMS.API [API for IEP]
* ├─LMS.ApiTests [Tests for the API]
* ├─LMS.Core [belongs to MVC]
* ├─LMS.Data [belongs to MVC]
* ├─LMS.Tests [Tests of the MVC]
* └─LMS.Web [MVC main part]





