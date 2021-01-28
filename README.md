# _Kabloom: The Ultimate Plant Tracker!_

<p align="center">
    <br>
        <a href="https://github.com/ebezjian">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars.githubusercontent.com/u/49379604?s=460&u=28a995564e8709eb7ba2d8f7a4e0165562a37cd3&v=4">
    </a>
        <br>
        <a href="https://github.com/SarahGilbert064">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars.githubusercontent.com/u/72630313?s=460&u=12fb92750dc134aacbae9ad21fc39442a9dc19ee&v=4">
    </a>
        <br>
        <a href="https://github.com/grand-scheme">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars.githubusercontent.com/u/72650879?s=460&u=8ecf4ccb9ac936e6108d17da3e725ad2bae185a2&v=4">
    </a>
    <br>
        <a href="https://github.com/GarrettBrown-dev">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars1.githubusercontent.com/u/69095640?s=460&u=eefe493b85312d332eedc271ee24a39d586446ae&v=4">
    </a>
</p>

<p align="center">
  <small>Last Updated: January 28th, 2021</small>
</p>

#### _._

# 🧑‍💻 Contributers

| Name                                                            | GitHub Profile                                          |
| --------------------------------------------------------------- | ------------------------------------------------------- |
| [Ellie Lambert](https://www.linkedin.com/in/eleanor-p-lambert/) | [ebezjian](https://github.com/ebezjian)                 |
| [Sarah Gilbert](https://www.linkedin.com/in/sarahgilbertpdx/)   | [SarahGilbert064](https://github.com/SarahGilbert064)   |
| [Shannon Grantski](https://www.linkedin.com/in/grand-scheme/)   | [grand-scheme](https://github.com/grand-scheme)         |
| [Garrett Brown](https://www.linkedin.com/in/garrett-brown-d/)   | [GarrettBrown-dev](https://github.com/GarrettBrown-dev) |

# ℹ️ Description

Welcome to Kabloom! This application was created for all plant lovers and growers. Once on the home page, the user will be able to register an account with Kabloom for future use. Once the user has logged into their personal account, they will gain access to the Trefle API, which will provide them with 1,000's of plants to (one day) add to their garden!

# Stretch Goals

- Allow user to add specific plants from the Trefle API to their account to personalize their "garden".
- Allow users to add information to each plant in their garden, such as watering times, date of planting and harvest dates.
- Create another database to hold each user's plants information such as watering times, date of planting, and harvest dates.
- Allow the user to search through the "Locations" database and add their region/area's garden shops to their account.

# 💾 Installation Requirements

Software Requirements

- An internet browser of your choice.
- A code editor.
- .NET Core
- MySQL
- MySQL Workbench
- Postman

# 🖥️ Opening the Project on your Local System

Open by Downloading or Cloning

- [Click to view Github repository](https://github.com/SarahGilbert064/Kabloom.Solution.git) Or simply paste the following url into your prefered browser https://github.com/SarahGilbert064/Kabloom.Solution
- To Clone repository simply click the green Code button and copy the url.
- Using a preferred terminal(Such as GitBash) use the command `git clone paste-url-here` in which ever directory you wish.
- Open the newly cloned repo with your text editor, and open a terminal with GitBash.
- In the terminal run command `cd KabloomClient`
- In the terminal run command `dotnet restore`
- In the terminal run command `dotnet build`
- In the terminal run command `dotnet run`
- Travel to `https://localhost:5001`to view in browser

  # AppSettings

  1. Create a new file in the ParksAPI.Solution/ParksAPI directory named `appsettings.json`
  2. Add in the following code snippet to the new appsettings.json file:

```
{
   "Logging": {
       "LogLevel": {
       "Default": "Warning"
       }
   },
   "AllowedHosts": "*",
   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=kabloomTrefleApi;uid=root;pwd=YourPassword;"
   }
}
```

3. Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

- Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core

- Type `dotnet ef database update` into the terminal to create your database tables.

## 🛰️ API Documentation

We decided to sign up and obtain an Api Key for the free Trefle API, which gives you access to over 20,000 plants worldwide. Please check out their documentation at [Trefle: A Global Plant API](https://trefle.io/)

#### Sample JSON Response

```
{
    "id": 678281,
    "common-name": "Evergreen Oak",
    "scientific_name": "Quercus rotundifolia",
    "family_common_name": "Beech Family",
}
```

# 🪲 Bugs / Issues

- None currently to note

# ☎️ Support / Contact Details

- Please feel free to reach out to:

| Name             | Engineer/Designer         |
| ---------------- | ------------------------- |
| Sarah Gilbert    | sarahgilbert064@gmail.com |
| Garrett Brown    | gman9mm@live.com          |
| Shannon Grantski | grantski@pm.me            |
| Ellie Lambert    | ebezjian@gmail.com        |

# ⚙️ Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

- [Bootstrap Components](https://getbootstrap.com/docs/3.3/components/)
- C#
- JavaScript
- Razor
- Entity Framework Core
- Identity
- MySql
- MySql Workbench
- Postman
- VSCode
- Webflow
- Trefle

</details>

# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_{Ellie Lambert}_**, **_{Sarah Gilbert}_**, **_{Shannon Grantski}_** and **_{Garrett Brown}_**
