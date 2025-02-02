# Number Classification API

This is a simple .NET Web API that classifies numbers based on their mathematical properties. It determines whether a number is prime, perfect, or an Armstrong number, and fetches a fun fact using the Numbers API.

## Features

- Accepts an string as input via query params in a **GET** request
- Validates the input and returns an appropriate error if string is not a valid integer
- Determines if the number is **prime, perfect, or an Armstrong number**
- Classifies the number as **odd or even**
- Computes the **sum of its digits**
- Retrieves a **fun fact** about the number from the [Numbers API](http://numbersapi.com/)
- Returns structured JSON responses
- Implements **input validation** and handles errors gracefully

## API Endpoints

### Classify a Number

**Endpoint:**  
GET /api/classify-number?number=1

**Example Response:**

#### Success Response (200 OK)
```json
{
    "number": 371,
    "is_prime": false,
    "is_perfect": false,
    "properties": ["armstrong", "odd"],
    "digit_sum": 11,
    "fun_fact": "371 is an Armstrong number because 3^3 + 7^3 + 1^3 = 371"
}
```

#### Error Response (400 Bad Request - Invalid Input)
```json
{
    "number": "alphabet",
    "error": true
}
```

## Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/ikennaumeh/hng12-stage-one.git
cd hng12-stage-one
```

### 2. Install Dependencies
Ensure you have .NET SDK installed, then run:
```bash
dotnet restore
```

### 3. Run the Application
```bash
dotnet run
```

The API will be available at: http://localhost:5000

## Technologies Used

- C# with .NET 8+
- ASP.NET Web API
- HttpClient for external API requests
- GitHub Actions (for CI/CD)

## Contributing

Want to improve the project? Feel free to contribute!

1. Fork the repository
2. Create a new branch (`git checkout -b feature-xyz`)
3. Commit your changes (`git commit -m "Added feature xyz"`)
4. Push the branch (`git push origin feature-xyz`)
5. Open a Pull Request

## License

This project is MIT Licensed.

## Author

Ikenna Umeh  
GitHub: [ikennaumeh](https://github.com/ikennaumeh)
