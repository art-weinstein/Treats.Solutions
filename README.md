# Pierre's Sweet and Savory Shop

### By Art Weinstein

### A basic webpage created to test student knowledge on building websites wtih many-to-many relationships and authentication.

## Technologies Used

* HTML
* CSS
* C#
* ASP.NET Core MVC
* NuGet
* MySql WorkBench
* Entity Framework Core

## Description

This program allows a user to create treats and flavors. Both treats and flavors can be associated with each other, for example the flavor vanilla can be connected with the treat cake. Any user can view the treats, flavors and their details. However to edit, delete, add or otherwise alter treats and flavors, the user must create an account. The website will not allow a user to access those permissions until after an account is registered. After the user registers an account, the will gain access to the edit, delete, create and add pages. If the user tries to access them without creating an account, the site will prompt them to log in, or create an account. 

## Setup/Installation Requirements

1. [Clone](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository) this repository.
2. Within VS code or similar software, create an "appsettings.json file with the "Factory" directory.
3. Within the appsettings.json file copy the following code and replace "EXAMPLE_PASSWORD" with your SQL workbench password.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=art_weinstein;uid=root;pwd=EXAMPLE_PASSWORD;"
  }
}
```

4. Install the necessary dependencies:
- type ```dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0```
- type ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2```
- type ```dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0 ```
6. enter ```dotnet build``` in your powershell terminal to build the program and verify the code is running correctly.
7. enter ```dotnet ef database update``` to populate your database with the necessary tables.
8. enter ```dotnet watch run``` to create a localhost in your browser and view the program. 

## Known Bugs

* No bugs known at the moment.

## License

* [MIT License](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Art Weinstein

## Contact Information

[Email](artur.weintsein@gmail.com)