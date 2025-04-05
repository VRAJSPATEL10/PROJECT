# PROJECT
# User Management API

This is a simple User Management API built with ASP.NET Core.

## Endpoints

- **GET /api/users**: Get all users.
- **GET /api/users/{id}**: Get a user by ID.
- **POST /api/users**: Create a new user.
- **PUT /api/users/{id}**: Update an existing user.
- **DELETE /api/users/{id}**: Delete a user.

## Middleware

- Logging middleware is implemented to log the request processing time.
- Validation middleware is used to ensure that the user input is valid before processing.
