# Kartverket-group2

## Setup Instructions

1. Clone the repository
   ```
   git clone https://github.com/your-username/kartverket-group2.git
   ```

2. Install MariaDB on your local machine.

3. Create a new database in MariaDB for this project.

4. Copy `appsettings.json.example` to `appsettings.json` and update the connection string with your local database details:
   ```json
   "DefaultConnection": "Server=localhost;Port=3306;Database=your_database_name;User=your_username;Password=your_password;"
   ```
   
5. Change name of `docker-compose.yml.example` to `docker-compose.yml` and update the connection string with your local database details:
   ```yml
   "ConnectionStrings__DefaultConnection=Server=db;Port=3306;Database=kartverket_db;User=root;Password=your_password;"
   ```

7. Install the required NuGet packages:
   - Pomelo.EntityFrameworkCore.MySql
   - Microsoft.EntityFrameworkCore.Tools
   - Microsoft.EntityFrameworkCore.Design

8. Open Package Manager Console and run the following commands to set up the database:
   ```
   dotnet tool install --global dotnet-ef
   dotnet restore
   dotnet ef database update
   ```

9. Build and run the project.
