# Project Title
[TOCM]

[TOC]

# Features
- Author Management
- Book Management
- Branch Management
- Customer Management

# Installation
- Install [.NET Core SDK .0](https://dotnet.microsoft.com/download)
- Install Entity Framework Core NuGet package

Open Command :
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet ef migrations add InitialCreate
dotnet ef database update

# Usage
1. unzip the file
2. cd LibraryManagement
3. dotnet run
4. Open a browser, navigate to http://localhost:5000



# Main Structure
- 📂Data
    - ApplicationDbContext.cs : 🟢DONE
- 📂Controller  : 🟢DONE
- 📂Model       : 🟢DONE
- 📂ViewModels  : 🟢DONE
- 📂Views       : 🟢DONE
    - 📂Author
        - Create.cshtml  : 🟢DONE
        - Details.cshtml : 🟢DONE
        - Edit.cshtml    : 🟢DONE
        - Index.cshtml   : 🟢DONE
    - 📂Book
        - Create.cshtml  : 🟢DONE
        - Details.cshtml : 🟢DONE
        - Edit.cshtml    : 🟢DONE
        - Index.cshtml   : 🟢DONE
    - 📂Branch
        - Create.cshtml  : 🟢DONE
        - Details.cshtml : 🟢DONE
        - Edit.cshtml    : 🟢DONE
        - Index.cshtml   : 🟢DONE
    - 📂Customer
        - Create.cshtml  : 🟢DONE
        - Details.cshtml : 🟢DONE
        - Edit.cshtml    : 🟢DONE
        - Index.cshtml   : 🟢DONE
    - 📂Shared
        - _Layout.cshtml : 🟢DONE
- 📂wwwroot      : 🟢DONE
    - 📂css      : 🟢DONE
- 
- 📑appsettings.json    : 🟢DONE
- 📑Program.cs          : 🟢DONE
