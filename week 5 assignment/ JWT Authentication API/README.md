# JWT Authentication API - ASP.NET Core

This project is a basic implementation of JWT (JSON Web Token) authentication using ASP.NET Core Web API. It includes functionality for user login and token generation, along with secured endpoints that require authentication.

## Features

- User login endpoint  
- JWT token generation  
- Secured API endpoints with [Authorize]  
- Configurable JWT secret and issuer  
- Simple structure for easy understanding  
- Tested with Swagger and Postman  

## JWT Configuration

Inside `appsettings.json`:

```json
"Jwt": {
  "Key": "THIS_IS_A_STRONG_KEY_FOR_JWT_@123456789", 
  "Issuer": "JwtAuthDemo"
}
```

> Ensure the key is at least 32 characters (256 bits) long for HS256 to work properly.

## Setup in Program.cs

```csharp
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddAuthorization();
```

## How to Test

### Using Swagger

1. Run the project and open: `https://localhost:<port>/swagger`
2. Call `/api/auth/login` with valid credentials
3. Copy the JWT token from the response
4. Click "Authorize" and paste the token
5. Try accessing `/api/test/getdata` (should return success)

### Using Postman

1. Send a POST request to `/api/auth/login`  
   Body (JSON):
   ```json
   {
     "username": "admin",
     "password": "123"
   }
   ```

2. Copy the returned token  
3. Set Authorization header as:  
   `Bearer <your_token>`  
4. Send GET request to `/api/test/getdata`

## Default Credentials (for testing)

```
Username: admin  
Password: 123
```

These are hardcoded inside `AuthController.cs` for demo purposes.

## Technologies Used

- ASP.NET Core Web API (.NET 6 / .NET 7)  
- JWT Bearer Authentication  
- Visual Studio Community Edition  
- Swagger (Swashbuckle)  
- Postman  

## Sample Screenshots to Take

- Swagger login request and token response  
- Swagger authorization using the token  
- Swagger call to protected endpoint (GET)  
- Postman request and response (if required)  
- Visual Studio diagnostics/tools window  
- Any successful build or debug window  

## Notes

- No database is used in this demo. For production, integrate EF Core or ASP.NET Identity.
- Never expose secret keys in plain text or source control.
- This is a basic version for academic and learning purposes.

## License

This project is free to use for educational and non-commercial purposes.
