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
<<<<<<< HEAD
- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite
- dotnet ef migrations add InitialCreate
- dotnet ef database update
=======
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet ef migrations add InitialCreate
dotnet ef database update
>>>>>>> dc51a477788223e24e3e2080ddd4a5ce98e7482d

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
