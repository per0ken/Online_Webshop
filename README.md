# Online_Webshop

This is a full-stack webshop made with ASP.NET and React.Js.

# Dependencies:

### Backend

* .NET 9.0.0
* ASP.NET 9.0.0
* EntityFrameworkCore.Design 9.0.0 - to migrate and update database
* EntityFrameworkCore.Sqlite 9.0.0 - to use sql database locally
* AspNetCore.Identity.EntityFrameworkCore 9.0.0 - Users, roles

### Frontend 

* Node.Js - npm 10.9.2 , node v22.14.0
* Vite + React - React 19
* React Router
* JS Cookie
* Redux
* RTK
* MUI
* ZOD

### Services

* Stripe - Payments

## Functionality:

* Filtering and sorting products
* Putting items in cart
* Completing an order
* Wishlisting an item
* Getting a notification in email when there is a discount for a product which is wishlisted by the user.
* Live chat support with admins
* Admin panel

## Architecture

* Fast and reliable application
* Transparent structure
* Safe identity manager
* Secure CRUD operations
* Database Initializer
* CORS and Rate limiting
* Catching data
* (test) Payments

## Settings up

# frontend
* npm install --legacy-peer-deps
* npm run dev
* .env(backend api url, stripe pk)

# backend
* Docker
* dotnet build
* dotnet restore
* dotnet run
* appsettings (sql, stripe)

# Successful payment:
4242 4242 4242 4242 12/26 123

# Not enough fund:
4000 0000 0000 9995 12/36 123

## This application is based on youtube tutorials and udemy courses!