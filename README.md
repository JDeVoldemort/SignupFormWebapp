# Overview

I initially wrote this as a CSharp program to practice razorpages, and C#. Coming back to it I got some features working more to my satisfaction. 
This WebApp is to allow individuals to sign up for church cleanings. Opening in Visual Studio and Runn/debug will allow you to see the program in action.
The Database is a local SQL database, and the program should create the database if it does not exist, but may require Db update commands to get running on another machine.
I Wanted to prepare the groundwork for a larger webapp I am making to help some associates with scheduling and tracking schedules. 
I got the Delete, Edit, Details, and Create pages working. I also got the DB to update when changes are made to the DB. In the previous version I had to manually update the DB after adding from the create page. 


[Software Demo Video](https://youtu.be/R9muSW2e-78)

# Web Pages

The homepage is what loads when you start the program. It is a simple page that allows you to navigate to the other pages.
The People page is where the program interacts with the DB. It allows you to add, remove, and edit people in the DB.
The Delete, Edit, Details, and Create pages are all used to interact with the DB and can be accessed by links on the people page.

# Development Environment

I used C# and Razorpages in Visual Studio 2019. I used the NuGet package manager to install the EntityFrameworkCore.SqlServer package.
I also used the NuGet package manager to install the Microsoft.EntityFrameworkCore.Tools package.
I used SQL Server Object Explorer to view the DB and makes some ajustments to the DB.
I started working with OAuth, but ran into incompatabilities which nearly broke the program. I removed the OAuth code and reverted to the previous version.

# Useful Websites

{Make a list of websites that you found helpful in this project}
* [Microsoft Learn- Razorpages](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-8.0&tabs=visual-studio)
* [LinkedIn Article](https://www.linkedin.com/pulse/razor-pages-vs-mvc-which-one-better-your-project-anar-solutions/)

# Future Work

{Make a list of things that you need to fix, improve, and add in the future.}
* I would like to get OAuth working so that I can have users log in and sign up for cleanings.
* If OAuth incombatabilities persist I would like to add a login page that allows users to log in and sign up for cleanings.
* I would like to limit the CRUD operations to only the admin user.