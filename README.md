# Stock Profit Calculator

This project is a Stock Profit Calculator that calculates the profit based on selling shares using the FIFO (First In, First Out) accounting method. It consists of a backend implemented with ASP.NET Core and a frontend using React.

## Features

- **FIFO Accounting Method**: Calculates profit based on the FIFO method.
- **Validation**: Ensures inputs for the number of shares to sell and selling price per share are valid.
- **Extendable Design**: Structured to allow future enhancements, such as supporting additional accounting methods like LIFO.

## Technologies Used

- **Backend**: ASP.NET Core
- **Frontend**: React
- **Database**: Hardcoded in-memory data structure for simplicity

## Setup and Run

### Prerequisites

- .NET SDK
- Node.js and npm

### Backend Setup

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/StockProfitCalculator.git
    cd StockProfitCalculator
    ```

2. **Navigate to the backend project**:
    ```bash
    cd backend
    ```

3. **Run the application**:
    ```bash
    dotnet run
    ```

   The backend will be running on `https://localhost:5001`.

### Frontend Setup

1. **Navigate to the frontend project**:
    ```bash
    cd frontend
    ```

2. **Install dependencies**:
    ```bash
    npm install
    ```

3. **Run the application**:
    ```bash
    npm start
    ```

   The frontend will be running on `https://localhost:5173`.

### CORS Configuration

Ensure that the backend allows requests from the frontend by adding CORS policy:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
        });
    });

    services.AddControllers();
    // other services
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // other configurations
    app.UseCors();
    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
