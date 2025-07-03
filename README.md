# Random Everything Api
A lightweight .NET web API that returns random values from a variety of things. Great for demos, testing, and fool around.

## Features
- Random name
- Random color
- Random country
- Random month
- Random number (0-99)

## Requirements
 - [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

## How to Use
**1. Clone the Repository:**
```sh
git clone https://github.com/rucev/random-everything-api
```
```sh
cd random-everything-api
```

**2. Build the API:**
```sh
dotnet build
```

**3. Run API locally:**
```sh
dotnet run
```

**4. Access the endpoints:**

The server runs at http://localhost:5018.

## API Endpoints

| Endpoint          | Description                  | Example Response |
| ----------------- | ---------------------------- | ---------------- |
| `/random/name`    | Returns a random name        | `"Daisy"`        |
| `/random/color`   | Returns a random color       | `"Blue"`         |
| `/random/country` | Returns a random country     | `"Iceland"`      |
| `/random/month`   | Returns a random month       | `"June"`         |
| `/random/number`  | Returns a random number 1–99 | `42`             |
