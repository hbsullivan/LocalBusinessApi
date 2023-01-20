# Local Business API 

### An API to find information about local businesses

#### By Henry Sullivan

***
## Table of Contents
* [Technologies](#technologies)
* [Description](#description)
* [Setup Instructions](#setup-installation-requirements)
* [API Documentation](#api-documentation)
* [License](#license)
***
## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC
* EF Core 6
* SQL
* MySQL
* LINQ
* Swagger

***
## Description

An API with full CRUD functionality that allows the user to GET, POST, PUT, and DELETE local businesses. Users can also search for businesses based on certain parameters such as Category and Name. Please find further documentation about the API below. 
***
## Setup Installation Requirements

### Open project
1. Navigate to the `LocalBusinessApi` directory.
2. Create a file named `appsettings.json` with the following code, making sure to replace [YOUR-USERNAME-HERE] and [YOUR-PASSWORD-HERE] with your personal username and password respectively.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=local_business_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```
3. Install dependencies within the `LocalBusinessApi` directory
```
$ dotnet restore
```

4. To build & run program in development mode 
 ```
 $ dotnet run
 ```

5. To build & run program in production mode 
 ```
 dotnet run --launch-profile "production"
 ```
***