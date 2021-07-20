# Ravn-Blazor-Challenge-VictorBenavides
 Ravn Challenge
README

	• BASIC SETUP
	- Blazor WebAssembly App (With .Net Core 5.1)
	- Ravn Challenge, get information of people from the swapi restful endpoints
	
	• ASSUMPTIONS
	- The application can be upgraded or extended, so we are leaving a trail in case we need to extend it's functionality.
	
	• CONFIGURATION
		- FOLDER CONFIGURATION
		a. Shared.Dtos
			- The shared component of the application has the Dtos for the application, they are Dtos and not Models because they are shared between swapi and this application and are subject to manipulation, and the other reason is that it doesn't interact with a database in our end so we do not have the need of actual models.
			
		b. Server
			- The controllers folder contains the controllers created for the application with their respective endpoints. As per the challenge instructions it only contains the controller to get the PEOPLE information from the swapi.
			- The helpers folder contains 3 helper classes for the project, each one designed to make the application extendable.
			- The interface folder contains the interfaces for the decoupling of the application. As per the challenge instructions, only one interface has been created for the PEOPLE endpoint of swapi.
			- The repos folder contains the repositories that implement the interfaces. There are 2 actions permitted but it can be extended further, GETSINGLE and GETALLPAGINATED.
			- The startup.cs class contains the scope for the interface and repository to be implemented as a dependency injection into the controller.
			- The appsettings.json contains the base url for the swapi. And it is used with dependency injection of the configuration interface on Microsoft.Extensions.Configuration
			
	• TECHNOLOGIES USED
		- Backend functionality uses the following:
			a. .net 5.1 with c# for web api creation and configuration.
			b. Newtonsoft.Json for the deserialization of the responses into C# Objects.
	
	

