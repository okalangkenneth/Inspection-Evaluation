# Inspection-Evaluation

## Introduction.
While working for an inspection company as a project manager for the agricultural division, the process of accepting a project from a client, assigning the project to an inspector, daily evaluation of the project, a weekly report of the status of the project, quality control of submitted samples and its report, were all done manually and prone to data entry errors.

## Goals.
This project is being designed to overcome most of the manual processes that were going in the Inspection company. It is a web application that can simplify the task of the administrator, project manager, inspector, and quality controller. It will also serve as a gathering place for inspectors field reports. The application will also be able to call on a database via an API that has information on clients and jobs related to them. I will then take advantage of the Azure web services to deploy the application.

## Project description.
The project is designed in such a way that many of the input operations are done through forms. The forms are capable of validating and checking the integrity and correctness of the input. The database will be built from Entity Framework according to codefirst method. Frontend will be from Bootstrap. The dynamic functionality in the front-end will be written with javascript.The application will have a .NET Core API that will intergarte with MVC Core web interface.

## User creteria
The project will contain five types of users. The Administrator, Project Manager, Inspector, Quality controller, and Client. The administrator deals with total administration projects in the company. The administrator is able to controll all the activities in the company. The project manager handles all the information of scheduling of the job to the inspector. The project manager monitors each inspectors performance. The project manager reports all activities of each inspector to the administrator at the end of each day's work. The inspector has to know the jobs assigned to him/her and update the daily activities which include picking and submission of samples for analysis and supervision of loading/offloading of produce into a warehouse. The inspector reports delays or any problems encountered while carrying out his/her duties. The client will be able to create a job.Below is a summary of user tasks.

### Administrator
* Handle all Inspector database.
* Handle Client Information
* Handle project details
* Assign project to project leader
* Monitor project status

### Project manager
* Handle Inspector details
* Handle Job details
* Assign Jobs to Inspector
* Report to the administrator
* Handles daily activities, delays and other problems related to the job.

### Inspector
* View job
* Update activities
* Submit days report

### Quality controller
* Create a quality certificate

### Client
* Create a job.







