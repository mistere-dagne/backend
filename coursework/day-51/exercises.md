# Module 4 – Day 51 Exercises

## Exercise 1: What is a server?

A server is a program that starts running and waits for requests from other applications or devices. When a request arrives, it processes the request, performs the necessary operations and sends a response back to the client. A server continues running and listening for new requests. For example, when someone requests restaurant information from Addis Eats, the server receives the request, retrieves the information and sends it back.

## Exercise 2: Inspect three browser requests

Website inspected: https://ibtcollege.com

| Request | Method | Full path | Status code | Request body? |
|---|---|---|---|---|
| 1. Homepage | GET | https://ibtcollege.com/ | 200 | No |
| 2. Google Tag Manager | GET | https://www.googletagmanager.com/gtag/js?id=G-ZMBBD67SQ2 | 200 | No |
| 3. YouTube playback stats | POST | https://www.youtube-nocookie.com/api/stats/playback?ns=yt&el=embedded&cpn=zpzWV7uvxx4C3Iz-... | 204 | Yes |

## Exercise 3: Inspect request and response headers

Selected request: GET https://ibtcollege.com/

### Request headers

| Header | Value | What it does |
|---|---|---|
| Host (:authority) | ibtcollege.com | Identifies the host receiving the request. |
| Accept | text/html,application/xhtml+xml,... | Specifies the content types the browser can accept in the response. |
| Accept-Language | en-GB,en;q=0.9,en-US;q=0.8 | Indicates the preferred languages for the response. |
| User-Agent | Mozilla/5.0 ... Edg/143.0.0.0 | Identifies the browser and its environment. |

### Response headers

| Header | Value | What it does |
|---|---|---|
| Content-Type | text/html; charset=UTF-8 | Identifies the response body as HTML using UTF-8 encoding. |
| Cache-Control | public, max-age=0, s-maxage=3600 | Specifies caching instructions for browsers and shared caches. |
| Content-Encoding | br | Indicates that the response body is compressed using Brotli. |
| Server | cloudflare | Identifies the server infrastructure handling the response. |

## Exercise 4: Write a full HTTP request

```http
POST /api/v1/orders HTTP/1.1
Host: api.addiseats.et
Content-Type: application/json
Accept: application/json
Authorization: Bearer YOUR_ACCESS_TOKEN

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

Explanation:

- POST requests the creation of a new order.
- The path identifies the orders resource.
- Host identifies the server receiving the request.
- Content-Type specifies that the request body contains JSON.
- Accept indicates that the client expects a JSON response.
- Authorization supplies the authentication token.
- The JSON body contains the restaurant ID, delivery area, menu item ID, quantity and payment method.

A successful request should return 201 Created.

## Exercise 5: Choose the correct HTTP status codes

| Situation | Status code | Explanation |
|---|---|---|
| a. A list of restaurants is returned. | 200 OK | The request was successful and the restaurant list was returned. |
| b. An order is created. | 201 Created | A new order resource was successfully created. |
| c. An order is cancelled and nothing is returned. | 204 No Content | The cancellation was successful and no response body is needed. |
| d. The qty field arrives as "two". | 400 Bad Request | The request contains an invalid quantity format because a number was expected. |
| e. The authentication token has expired. | 401 Unauthorized | The authentication credentials are no longer valid. |
| f. A courier attempts to edit a menu. | 403 Forbidden | The courier is authenticated but does not have permission to edit the menu. |
| g. Someone requests order 99999, which does not exist. | 404 Not Found | The requested order resource does not exist. |
| h. Your code throws an unhandled exception. | 500 Internal Server Error | An unexpected error occurred inside the server application. |

## Exercise 6: Find a public API and identify its contract

Chosen API: JSONPlaceholder

Website: https://jsonplaceholder.typicode.com/

JSONPlaceholder is a free fake REST API used for testing, learning and prototyping.

Three things its API contract promises:

1. Available resources: It provides six resources: posts, comments, albums, photos, todos and users, with defined endpoints for accessing them.
2. HTTP methods: It supports GET, POST, PUT, PATCH and DELETE for retrieving, creating, updating and deleting resources.
3. JSON responses: It returns structured JSON data that developers can use when testing and developing applications.

One thing I would want to know before depending on it:

I would want to know whether changes made through POST, PUT, PATCH and DELETE requests are permanently saved or only simulated. This is important because I would need to know whether I can rely on the API to store and maintain data.

Source: https://jsonplaceholder.typicode.com/
