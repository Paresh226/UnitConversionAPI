# Unit Conversion API

## Overview

Unit Conversion API is a RESTful ASP.NET Core 8 Web API that allows users to convert numerical values between different units of measurement. The application currently supports conversions for:

* Length
* Temperature
* Weight/Mass

The solution is designed with scalability and maintainability in mind and can be extended to support hundreds of conversion categories and units in the future.

---

## Features

* ASP.NET Core 8 Web API
* RESTful API Design
* Swagger/OpenAPI Documentation
* Dependency Injection
* Global Exception Handling Middleware
* Layered Architecture
* Docker Support
* Easily Extensible Conversion Engine
* Production-Ready Project Structure

---

## Supported Conversion Categories

### Length

* Meter
* Kilometer
* Centimeter
* Feet
* Inch

### Temperature

* Celsius
* Fahrenheit
* Kelvin

### Weight/Mass

* Kilogram
* Gram
* Pound
* Ton

---

## Project Structure

```text
UnitConversionAPI
│
├── Controllers
│   └── ConversionController.cs
├── Converters
│   ├── LengthConverter.cs
│   ├── TemperatureConverter.cs
│   └── WeightConverter.cs
├── Interfaces
│   └── IConversionService.cs
├── Middleware
│   └── ExceptionMiddleware.cs
├── Models
│   ├── ConvertRequest.cs
│   └── ConvertResponse.cs
├── Services
│   └── ConversionService.cs
├── Program.cs
├── appsettings.json
├── Dockerfile
└── README.md
```

---

## Technology Stack

* .NET 8
* ASP.NET Core Web API
* Swagger/OpenAPI
* Docker
* C#
* Dependency Injection

---

## Prerequisites

Before running the application, ensure the following are installed:

* .NET SDK 8.0 or later
* Visual Studio 2022 or Visual Studio Code
* Git
* Docker Desktop (Optional)

---

## Running the Application Locally

### Clone the Repository

```bash
git clone https://github.com/Paresh226/UnitConversionAPI.git
cd UnitConversionAPI
```

### Restore Dependencies

```bash
dotnet restore
```

### Build the Project

```bash
dotnet build
```

### Run the Application

```bash
dotnet run
```

The application will start on:

```text
https://localhost:5001
http://localhost:5000
```

---

## Swagger Documentation

After running the application locally, Swagger UI can be accessed at:

```text
https://localhost:5001/swagger
```

Hosted Swagger URL:

```text
https://unitconversionapi-fbfc.onrender.com/swagger
```

---

## API Endpoint

### Convert Units

**POST**

```http
/api/conversion
```

### Request Body

```json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "feet",
  "value": 10
}
```

### Sample Response

```json
{
  "inputValue": 10,
  "fromUnit": "meter",
  "toUnit": "feet",
  "convertedValue": 32.81
}
```

---

## Example Requests

### Meter to Feet

```json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "feet",
  "value": 5
}
```

### Celsius to Fahrenheit

```json
{
  "category": "temperature",
  "fromUnit": "celsius",
  "toUnit": "fahrenheit",
  "value": 30
}
```

### Kilogram to Pound

```json
{
  "category": "weight",
  "fromUnit": "kilogram",
  "toUnit": "pound",
  "value": 10
}
```

---

## Error Handling

The application uses a custom global exception middleware to provide consistent error responses.

Example:

```json
{
  "statusCode": 400,
  "message": "Invalid Category"
}
```

---

## Docker Support

### Build Docker Image

```bash
docker build -t unitconversionapi .
```

### Run Docker Container

```bash
docker run -d -p 8080:8080 unitconversionapi
```

Application URL:

```text
http://localhost:8080/swagger
```

---

## Design Decisions

* Implemented Service Layer pattern to separate business logic.
* Used converter classes for each category to improve maintainability.
* Used Dependency Injection to support loose coupling and testability.
* Added Global Exception Middleware for centralized error handling.
* Designed the conversion engine to be easily extendable for future unit categories and hundreds of units.

---

## Future Enhancements

* Database-driven unit management.
* Unit conversion history.
* Authentication and Authorization.
* Caching support.
* Unit tests using xUnit.
* Logging using Serilog.
* API Versioning.
* CI/CD Pipeline integration.

---

## Repository

GitHub Repository:

```text
https://github.com/Paresh226/UnitConversionAPI
```

Hosted Application:

```text
https://unitconversionapi-fbfc.onrender.com/swagger/index.html
```
