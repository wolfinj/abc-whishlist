# Simple wishlist API

<br>

> API for adding, updating and deleting items from wishlist.
> Using Sql server, .NET6, and Entity framework
>
<br>

## API Reference

### Wishlist operations

<br>

#### Get all items from wishlist

```
  GET /api/items
```

<br>

#### Get item by ID

```
  GET /api/item/{id}
```

| Parameter | Type  | Description              |
|:----------|:------|:-------------------------|
| `id`      | `int` | **Required**. Id of item |

<br>

#### Delete item by ID

```
  DELETE /api/item/{id}
```

| Parameter | Type  | Description                   |
|:----------|:------|:------------------------------|
| `id`      | `int` | **Required**. Id of candidate |

<br>

#### Add item to wishlist

```
  POST /api/item/
```

```json
{
  "name": "string",
  "url": "string"
}
```

| Parameter | Type       | Description                |
|:----------|:-----------|:---------------------------|
| `name`    | `string`   | **Required**. Name of item |
| `url`     | `string`   | **Optional**. Link of item |

<br>

#### Update item

```
  PUT /api/item/{id}
```

```json
{
  "name": "string",
  "url": "string"
}
```

| Parameter | Type     | Description                              |
|:----------|:---------|:-----------------------------------------|
| `id`      | `int`    | **Required**. ID of item to update       |
| `name`    | `string` | **Required**. Name of item               |
| `url`     | `string` | **Optional**. Link of item               |

<br>

### User operations

<br>

#### Get user names from json request
```
  POST /api/item/
```

```json
{
  "users": [
    {
      "id": 0,
      "type": "string",
      "name": "string",
      "email": "string"
    }
  ]
}
```

| Parameter | Type     | Description                  |
|:----------|:---------|:-----------------------------|
| `users`   | `user[]` | **Required**. array of users |
| `name`    | `string` | **Required**. name of user   |
| `email`   | `string` | **Required**. e-mail of user |
| `type`    | `string` | **Required**. type of user   |
| `id`      | `int`    | **Required**. id of user     |



---







