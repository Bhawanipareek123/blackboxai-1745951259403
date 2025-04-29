# Graphic Designer Portfolio Website

## Project Structure

- `index.html` - Frontend static website built with Tailwind CSS, Google Fonts, and Font Awesome.
- `backend/GraphicDesignerPortfolioAPI/` - .NET 6 Web API backend project connecting to MSSQL server.

## Backend Setup

1. Open the `backend/GraphicDesignerPortfolioAPI` folder in Visual Studio or your preferred IDE.
2. Ensure you have .NET 6 SDK installed.
3. Update the connection string in `appsettings.json` if needed to match your MSSQL server.
4. Run the following commands to create the database and apply migrations (if migrations are added):
   ```
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
5. Run the backend API:
   ```
   dotnet run
   ```
   The API will be available at `https://localhost:5001`.

## Frontend Setup

1. Serve the `index.html` file using any static file server. For example, using Python:
   ```
   python3 -m http.server 8000
   ```
2. Open your browser and navigate to `http://localhost:8000`.

## How They Connect

- The frontend contact form submits data to the backend API at `https://localhost:5001/api/contact`.
- The backend connects to the MSSQL server `LAPTOP-15CAGEP5\SQLEXPRESS` to store contact submissions.
- The backend also exposes portfolio data via API endpoints (can be extended).

## Notes

- Ensure CORS is enabled in the backend to allow requests from `http://localhost:8000`.
- Make sure both backend and frontend servers are running simultaneously.
- Adjust URLs in `index.html` if backend runs on a different port or domain.

## Further Improvements

- Add authentication if needed.
- Add portfolio management UI and backend.
- Add deployment scripts.

If you need help with running or extending the project, feel free to ask.
