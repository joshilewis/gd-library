# gd-library
Take-home assignment submitted for job application at Give Directly

## To Run
 - [Install `dotnet`](https://docs.microsoft.com/en-us/dotnet/core/install/).
 - Create a PostgreSQL user/role `gdlibrary` with password `gdlibrary`.
 - Create a PostgreSQL database `gdlibrary` owned by user `gdlibrary`.
 - [Install the .Net Core CLI Tools](https://docs.microsoft.com/en-us/ef/core/get-started/overview/install): `dotnet tool install --global dotnet-ef`.
 - Run the migrations to stand-up the database and seed it with some data: `dotnet ef database update`.
 - Run the application: `dotnet run`.
 - Navigate to https://localhost:7287/swagger

## Assumptions
 - Only 1 'Active' Request is allowed per book.
 - I have implemented a _soft delete_ for Requests, using an `Active` flag - Deleting a Request deactivates it.
 - If a Book is Requested, but already has an Active Request against it, the endpoint returns `false` for _Available_.
 - Listing Requests returns only Active Requests.
 - When getting a Request using an _id_ (`/request/:id`), the `id` identifies to the book, _not_ the request.

## Todo
Things that I didn't get to in the 3 hours:
 - Email validation: I have used the built-in Email address validation for the `POST` endpoint but it is not working correctly.
 - Instead of using a [single controller](https://github.com/joshilewis/gd-library/blob/main/GDLibrary.Api/Controllers/RequestsController.cs) for all endpoints, I prefer to split endpoints into their own classes with own dependencies.
 - Introduce a generic `IHandler` interface for all Handlers for automatic service registration for dependency injection - (currently all services are [registered manually](https://github.com/joshilewis/gd-library/blob/main/GDLibrary.Api/Program.cs#L16-L25))
 - Introduce an abstract `QueryObject` for all [query objects](https://github.com/joshilewis/gd-library/tree/main/GDLibrary.Api/Data)
   - To reduce duplicated dependency and constructor code common to all query objects.
   - Would allow for automatic service registration for dependency injection.
 - Automated testing
   - I am a big proponent of TDD, with integration tests. Some examples of my approach:
    - [Recent job application take-home assignment](https://github.com/joshilewis/Contacts/tree/master/Specs)
    - [Side project from 2017 I used to learn CQRS and Event Sourcing](https://github.com/joshilewis/lendtome/tree/master/Tests)
