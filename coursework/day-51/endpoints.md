# Addis Eats API – Endpoint Design

## 1. Endpoint Table

| Method | Path | Purpose | Success Code | Likely Failure Code |
|---|---|---|---|---|
| GET | `/api/v1/restaurants` | Retrieve all restaurants, with optional area filtering and pagination. | 200 OK | 400 Bad Request |
| GET | `/api/v1/restaurants/{restaurantId}` | Retrieve details of a specific restaurant. | 200 OK | 404 Not Found |
| GET | `/api/v1/restaurants/{restaurantId}/menu` | Retrieve the menu of a specific restaurant. | 200 OK | 404 Not Found |
| GET | `/api/v1/menu-items/{menuItemId}` | Retrieve details of a specific menu item. | 200 OK | 404 Not Found |
| POST | `/api/v1/orders` | Create a new customer order. | 201 Created | 422 Unprocessable Content |
| GET | `/api/v1/orders` | Retrieve the authenticated customer's orders. | 200 OK | 401 Unauthorized |
| GET | `/api/v1/orders/{orderId}` | Retrieve details of a specific order. | 200 OK | 404 Not Found |
| PATCH | `/api/v1/orders/{orderId}/status` | Update the status of an order. | 200 OK | 409 Conflict |
| POST | `/api/v1/payments/telebirr` | Initiate a TeleBirr payment for an order. | 201 Created | 503 Service Unavailable |
| GET | `/api/v1/payments/{paymentId}` | Retrieve the status of a specific payment. | 200 OK | 404 Not Found |
| POST | `/api/v1/users` | Register a new customer account. | 201 Created | 409 Conflict |
| POST | `/api/v1/auth/login` | Authenticate a user and return an access token. | 200 OK | 401 Unauthorized |
| GET | `/api/v1/auth/me` | Retrieve information about the currently authenticated user. | 200 OK | 401 Unauthorized |
| POST | `/api/v1/auth/logout` | Log out the currently authenticated user. | 204 No Content | 401 Unauthorized |

## 2. Example Query Parameters

Query parameters are used for filtering and pagination. They are placed after `?` in the URL.

Filter restaurants by area:

`GET /api/v1/restaurants?area=Bole`

Retrieve a specific page of restaurants:

`GET /api/v1/restaurants?page=1&pageSize=20`

Retrieve a specific page of customer orders:

`GET /api/v1/orders?page=1&pageSize=10`

## 3. Example Request Body

To create an order, the client sends a POST request to `/api/v1/orders` with a JSON body:

```json
{
  "restaurantId": 14,
  "area": "Bole",
  "items": [
    {
      "menuItemId": 7,
      "qty": 2
    }
  ],
  "paymentMethod": "TeleBirr"
}
```

## 4. API Design Notes

- All endpoints use the `/api/v1` version prefix.
- Plural nouns are used for resource names, such as `restaurants`, `orders` and `users`.
- Resource IDs are included in the URL path when accessing a specific resource.
- Query parameters are used for filtering and pagination.
- GET retrieves data, POST creates or initiates an action, and PATCH updates part of a resource.
- HTTP status codes communicate the result of each request.
- Protected endpoints require authentication.