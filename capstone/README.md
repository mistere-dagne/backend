# Addis Eats API - My Backend Capstone Project

## Overview

Addis Eats API is a backend project built with ASP.NET Core and C# as part of the IBT CodeOps Full Stack Software Development program.

## Day 55 – First API Endpoints

### Features

- Retrieve all restaurants.
- Retrieve a restaurant by ID.
- Retrieve menu items belonging to a restaurant.
- Filter menu items by category.

### API Endpoints

Base route: `/api/v1/restaurants`

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/v1/restaurants` | Retrieve all restaurants |
| GET | `/api/v1/restaurants/{id}` | Retrieve a restaurant by ID |
| GET | `/api/v1/restaurants/{id}/menu` | Retrieve a restaurant's menu |

### Query Parameters

**Get all restaurants**

| Parameter | Description | Current default |
|---|---|---|
| `address` | Filter restaurants by address | None |
| `page` | Page number | 1 |
| `pageSize` | Number of results per page | 20 |

**Get restaurant menu**

| Parameter | Description |
|---|---|
| `category` | Filter menu items by category |

### Response Status Codes

| Status | Meaning |
|---|---|
| 200 OK | Request successful |
| 404 Not Found | Restaurant does not exist |

An existing restaurant with no menu items returns `200 OK` with an empty array.

### Seed Data

- 12 restaurants.
- Menu items associated with restaurants.
- In-memory data storage.

### Project Structure

- `Controllers/` – Handles HTTP requests.
- `Services/` – Contains application logic.
- `Models/` – Contains domain entities.
- `DTOs/` – Contains data transfer objects.
- `Mappers/` – Converts entities into DTOs.
- `Data/` – Contains seed data.

### Running the Project

```bash
dotnet run
```

### Testing

API requests are stored in `AddisEats.Api.http`.

---

*This documentation describes the current Day 55 implementation and will be updated as the project develops.*
