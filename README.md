# _Kabloom: The Ultimate Plant Tracker!_

<p align="center">
    <br>
        <a href="">
        <img style="border-radius: 100%; height: 50px; width: auto" src="">
    </a>
        <br>
        <a href="">
        <img style="border-radius: 100%; height: 50px; width: auto" src="">
    </a>
        <br>
        <a href="">
        <img style="border-radius: 100%; height: 50px; width: auto" src="">
    </a>
    <br>
        <a href="https://github.com/GarrettBrown-dev">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars1.githubusercontent.com/u/69095640?s=460&u=eefe493b85312d332eedc271ee24a39d586446ae&v=4">
    </a>
</p>

<p align="center">
  <small>Last Updated: January 25th, 2021</small>
</p>

#### _._ 

# 🧑‍💻 Contributers

| Name | GitHub Profile |
|------|----------------|



|[Garrett Brown](https://www.linkedin.com/in/garrett-brown-d/) |[GarrettBrown-dev](https://github.com/GarrettBrown-dev) |

# ℹ️ Description

This application will allow the user to enter in a plant in their care, (Possibly with the ability to upload photos?) with information from Trefle API to help give them tips on care. It will also have the ability to locate stores near you that sell plant-care materials which will be contained in a separate database as a showcase of knowledge of creating our own API.

# 💾 Installation Requirements

Software Requirements
* An internet browser of your choice.
* A code editor.
* .NET Core
* MySQL
* MySQL Workbench

# 🖥️ Opening the Project on your Local System

Open by Downloading or Cloning
- [Click to view Github repository](https://github.com/) Or simply paste the following url into your prefered browser https://github.com/
- To Clone repository simply click the green Code button and copy the url.
- Using a preferred terminal(Such as GitBash) use the command `git clone paste-url-here` in which ever directory you wish.
- Open the newly cloned repo with your text editor, and open a terminal with GitBash.
- In the terminal run command `cd KabloomApi`
- In the terminal run command `dotnet restore`
- In the terminal run command `dotnet build`
- In the terminal run command `dotnet run`

  # AppSettings

  1) Create a new file in the ParksAPI.Solution/ParksAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  `
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=kabloom_api;uid=root;pwd=YourPassword;"
    }
}
  `
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Type `dotnet ef database update` into the terminal to create your database tables.

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

### Using Swagger Documentation 
To explore the Kabloom API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5000/api/plant/poisonous
```

#### Sample JSON Response
```
{
    "PlantId": 3,
    "PlantName": "Devils Backbone, (AKA Bob)",
    "PlantSeedDate(?)": "01/01/2021",
    "Description": "Highly poisonous. But that's what makes him cool.",
}
```

### Plants
Access information on all types of plants.

#### HTTP Request
```
GET /api/plant
POST /api/plant
GET /api/plant/{id}
PUT /api/plant/{id}
DELETE /api/plant/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| PlantName | string | none | false | Return matches by name.
| PlantSeedDate | string | none | false | Return plant planting date. |
| ParkId | int | none | false | Return plant matches with a specific ID. |
| Description | string | none | false | Return matches by description text... Not recommended as you have to type the whole chunk of text from the data, but included for good measure. |

#### Example Query
```
https://localhost:5000/api/plant/?plantname=bob&plantid=3
```

# 🪲 Bugs / Issues

* None currently to note

# ☎️ Support / Contact Details

* Please feel free to reach out to <>

# ⚙️ Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* [Bootstrap Components](https://getbootstrap.com/docs/3.3/components/)
* C#
* Razor
* Entity Framework Core
* Swashbuckle
* Swagger
* Nuget Versioning
* MySql
* MySql Workbench
* CORS
* Trefle

</details>

# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 