# Kartverket-group2

## Setup Instructions

1. Clone the repository
   ```
   git clone https://github.com/your-username/kartverket-group2.git
   ```

2. Copy `appsettings.json.example` to `appsettings.json` and update the connection string with your local database details:
   ```json
   "DefaultConnection": "Server=localhost;Port=3306;Database=your_database_name;User=your_username;Password=your_password;"
   ```
   
3. Change name of `.env.example` to `.env` and update the information with your local database details:
   ```ps1
   DB_PASSWORD=******* #Replace with your database password
   DB_USER=******* #Replace with your database user (Probably "root")
   DB_NAME=******* #Replace with your database name
   DB_PORT=******* #Replace with your database port (likely 3306 if using mariadb)

   SCRIPT_PATH=./Kartverket-group2/run-migrations.bat

   DB_SERVICE_NAME=db
   ```

4. Build and run the project.
   
5. Run the file `run-migrations.bat` to update the newly created database



