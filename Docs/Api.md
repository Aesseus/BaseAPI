# Ride API

- [Ride API](#ride-api)
  - [Create Ride](#create-ride)
    - [Create Ride Request](#create-ride-request)
    - [Create Ride Response](#create-ride-response)
  - [Get Ride](#get-ride)
    - [Get Ride Request](#get-ride-request)
    - [Get Ride Response](#get-ride-response)
  - [Update Ride](#update-ride)
    - [Update Ride Request](#update-ride-request)
    - [Update Ride Response](#update-ride-response)
  - [Delete Ride](#delete-ride)
    - [Delete Ride Request](#delete-ride-request)
    - [Delete Ride Response](#delete-ride-response)

## Create Ride

### Create Ride Request

```js
POST /Rides
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Ride..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create Ride Response

```js
201 Created
```

```yml
Location: {{host}}/Rides/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Ride..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get Ride

### Get Ride Request

```js
GET /Rides/{{id}}
```

### Get Ride Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Ride..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update Ride

### Update Ride Request

```js
PUT /Rides/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Ride..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update Ride Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Rides/{{id}}
```

## Delete Ride

### Delete Ride Request

```js
DELETE /Rides/{{id}}
```

### Delete Ride Response
