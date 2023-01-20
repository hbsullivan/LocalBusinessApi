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
## API Documentation
### __Endpoints__
```
 GET http://localhost:5000/api/v2/businesses
 GET http://localhost:5000/api/v2/businesses/{id}
 POST http://localhost:5000/api/v2/businesses
 PUT http://localhost:5000/api/v2/businesses/{id}
 DELETE http://localhost:5000/api/v2/businesses/{id}
 ```
Note: The {id} value in the URL is a variable and should be replaced with the id number of the review the user wants to GET, PUT, or DELETE

*** 
### __GET Queries__
For GET http://localhost:5000/api/v2/businesses

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
Category | string | Not Required | Returns businesses with matching category value
Name | string | Not Required | Returns businesses with matching name value
id | int | Not Required | Returns businesses with matching id value

### __Example GET Queries__

The following query will return all businesses with the id value of 1:

``` GET http://localhost:5000/api/v2/businesses/1```

The following query will return all businesses with the category value of "Restaurants":

``` GET http://localhost:5000/api/v2/businesses?category=restaurant ```

The following query will return all businesses with the name value of "Beso":

```GET http://localhost:5000/api/v2/businesses?name=beso```

It's possible to include multiple query strings by separating them with an &:

``` GET http://localhost:5000/api/v2/businesses?category=restaurant&name=beso ```
***

### __POST Queries__
For POST http://localhost:5000/api/v2/businesses

### __Example POST Query__
The follwing query will add the business to the api:

``` POST http://localhost:5000/api/v2/businesses ```

A body _must_ be included when making a POST request.
```
    {
      "category": "Restaurant",
      "name": "Beso",
      "daysOpen": "Monday-Friday"
    }

```
***
### __PUT Queries__
For PUT http://localhost:5000/api/v2/businesses/{id}

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
id | int | Required | Edits business with matching id value

### __Example PUT Query__
The following query will update a business with the businessId of 1:

``` PUT http://localhost:5000/api/v2/businesses/1```

A body _must_ be included when making a PUT request, and the businessId property in the body must match the id parameter in the endpoint.
```
    {
      "businessId": 1,
      "category": "Restaurant",
      "name": "Beso",
      "daysOpen": "Monday-Friday"
    }

```
***
### __DELETE Queries__
For DELETE http://localhost:5000/api/v2/businesses/{id}

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
id | int | Required | Deletes business with matching id value

### __Example DELETE Query__
The following query will delete a business with the businessId of 1:

``` PUT http://localhost:5000/api/v2/businesses/1```
***
### __Note on Versioning__
There are two versions available for the LocalBusinessApi. Version 2.0 is the most up to date, and includes the 'name' endpoint. To revert back to version 1.0, simply replace v2 in the endpoint with v1.
For example: 

```
Version 2.0
GET http://localhost:5000/api/v2/businesses

Version 1.0
GET http://localhost:5000/api/v1/businesses
```
***

## Known Bugs

* No known bugs. If you find one, please email me at  [sullivanbhenry@gmail.com](mailto:sullivanbhenry@gmail.com) and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

***

## License

MIT License

Copyright (c) 2023 Henry Sullivan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.