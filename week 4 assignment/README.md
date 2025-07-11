# WebApi_Handson – ASP.NET Core 8.0 Web API Assignment

## Description  
This project demonstrates the development of a basic Web API using ASP.NET Core 8.0. It includes endpoints for managing product data and utilizes Swagger for API testing and documentation. The application uses an in-memory list to simulate data operations.

## Objectives  
- Create a simple RESTful API with GET and POST functionality  
- Understand Web API routing and controller logic  
- Use Swagger UI for testing and documentation  
- Implement and manage product data using C#

## Implemented Endpoints

| HTTP Method | Route           | Description                    |
|-------------|------------------|--------------------------------|
| GET         | `/api/Products`  | Retrieves the list of products |
| POST        | `/api/Products`  | Adds a new product to the list |

## Key Components

**Product.cs**  
Defines the `Product` model with properties: `Id`, `Name`, and `Price`.

**ProductsController.cs**  
Handles HTTP requests related to product operations using an in-memory list.

**Program.cs**  
Configures application services and enables Swagger middleware for testing.

## How to Run and Test

1. Open the project in Visual Studio 2022 Community Edition.
2. Build and run the project.
3. Swagger UI will launch automatically at:  
   `https://localhost:<port>/swagger`
4. Use the Swagger interface to:
   - Test GET endpoint to view all products.
   - Test POST endpoint by providing product JSON input:
     ```json
     {
       "id": 1,
       "name": "Tablet",
       "price": 18000
     }
     ```

## Sample Output

```json
[
  {
    "id": 1,
    "name": "Tablet",
    "price": 18000
  },
  {
    "id": 2,
    "name": "Laptop",
    "price": 45000
  }
]
