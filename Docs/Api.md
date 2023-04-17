# Event Test API

- [Event Test API](#event-test-api)
  - [Create Events](#create-event)
    - [Create Events Request](#create-event-request)
    - [Create Events Response](#create-event-response)
  - [Get Events](#get-event)
    - [Get Events Request](#get-event-request)
    - [Get Events Response](#get-event-response)
  - [Update Events](#update-event)
    - [Update Events Request](#update-event-request)
    - [Update Events Response](#update-event-response)
  - [Delete Events](#delete-event)
    - [Delete Events Request](#delete-event-request)
    - [Delete Events Response](#delete-event-response)

## Create Events

### Create Events Request

```js
POST /events
```

```json
{
   "title": "Kane Bro,Sara Evans",
   "tickets": 8,
   "venue": "Comedy Club",
   "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
     "description":[
        "concert",
        "Avocado Toast",
        "drink",
        "rock"
   ],
}
```

### Create Events Response

```js
201 Created
```

```yml
Location: {{host}}/Events/{{id}}
```

```json
{
   "id": "00000000-0000-0000-0000-000000000000",
   "title": "Kane Bro,Sara Evans",
   "tickets": 8,
   "venue": "Comedy Club",
   "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
     "description":[
        "concert",
        "Avocado Toast",
        "drink",
        "rock"
   ],
}
```

## Get Events

### Get Events Request

```js
GET /events/{{id}}
```

### Get Events Response

```js
200 Ok
```

```json
{
   "id": "00000000-0000-0000-0000-000000000000",
   "title": "Kane Bro,Sara Evans",
   "tickets": 8,
   "venue": "Comedy Club",
   "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
   "lastModifiedDateTime": "2022-04-06T12:00:00",
     "description":[
        "concert",
        "Avocado Toast",
        "drink",
        "rock"
   ],
}
```

## Update Events

### Update Events Request

```js
PUT /events/{{id}}
```

```json
{
   "title": "Kane Bro,Sara Evans",
   "tickets": 8,
   "venue": "Comedy Club",
   "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
     "description":[
        "concert",
        "Avocado Toast",
        "drink",
        "rock"
   ],
}
```

### Update Events Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Events/{{id}}
```

## Delete Events

### Delete Events Request

```js
DELETE /events/{{id}}
```

### Delete Events Response

```js
204 No Content
```