# LibraryManagement Project

# Features
- Author Management
- Book Management
- Branch Management
- Customer Management

# Installation
- Install [.NET Core SDK .0](https://dotnet.microsoft.com/download)
- Install Entity Framework Core NuGet package

Open Command :
\ndotnet add package Microsoft.EntityFrameworkCore
\ndotnet add package Microsoft.EntityFrameworkCore.Design
\ndotnet add package Microsoft.EntityFrameworkCore.Sqlite
\ndotnet ef migrations add InitialCreate
\ndotnet ef database update

# Usage
1. Unzip the file
2. cd LibraryManagement
3. dotnet run
4. Open a browser, navigate to http://localhost:5000



# Main Structure
- 📂Data
    - ApplicationDbContext.cs
- 📂Controller
- 📂Model     
- 📂ViewModels
- 📂Views     
    - 📂Author
        - Create.cshtml
        - Details.cshtml 
        - Edit.cshtml   
        - Index.cshtml 
    - 📂Book
        - Create.cshtml 
        - Details.cshtml
        - Edit.cshtml    
        - Index.cshtml   
    - 📂Branch
        - Create.cshtml  
        - Details.cshtml 
        - Edit.cshtml    
        - Index.cshtml   
    - 📂Customer
        - Create.cshtml  
        - Details.cshtml 
        - Edit.cshtml    
        - Index.cshtml   
    - 📂Shared
        - _Layout.cshtml 
- 📂wwwroot      
    - 📂css      
- 
- 📑appsettings.json   
- 📑Program.cs         
