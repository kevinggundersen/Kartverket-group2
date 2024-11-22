# Kartverket-group2

## Considerations
   We made the choice to have scripts and styles for specific views inside the html documents. This is not best practice, but we made the choice for easier development. If we had more time, we would move these parts into their own files.

## Why Docker?

   This solution is running in Docker containers, using Docker compose. This makes the project more accessible, by making it run the same way everywhere. It eliminates setup issues, keeps apps isolated from each other.

### Development Benefits
- Consistent environment across all developer machines
- Quick onboarding - just install Docker and run
- Local development matches production setup

### Deployment Advantages
- Simple deployments to any cloud platform
- Easy version rollbacks
- Identical behavior across Windows and Linux servers

### Dependencies
- .NET runtime and SDK versions are containerized
- Database and service dependencies managed via docker-compose
- No conflicts with other applications or system dependencies


## Setup Instructions

1. Clone the repository
   ```
   git clone https://github.com/your-username/kartverket-group2.git
   ```
   
3. Open `.env` and update the information with your database, and email details details:
   ```ps1
   # Database Configuration
   DB_HOST=localhost
   DB_PORT=DB_PORT (3006 if using mariaDB)
   DB_NAME=YOUR_DATABASE
   DB_USER=(probably 'root')
   DB_PASSWORD=YOUR_PASSWORD
   DB_SERVICE_NAME=db
   
   # Admin Configuration
   Admin Configuration manages user roles, permissions, and settings. It includes creating roles, managing users, and ensuring access control to maintain security within the application.
   ADMIN_EMAIL=admin@admin.com
   ADMIN_PASSWORD=Admin1234
   
   # Email configuration
   EMAIL_SMTP_SERVER=EMAIL_SMTP_SERVER (If gmail: smtp.gmail.com)
   EMAIL_PORT=EMAIL_PORT (If gmail: 587)
   EMAIL_USERNAME=EMAIL_ADDRESS
   EMAIL_PASSWORD=APP_PASSWORD (see below)
   EMAIL_FROM_ADDRESS=EMAIL_ADDRESS
   ```
   If using gmail for email service, you need to generate an app password in your Google account [Found here](https://myaccount.google.com/apppasswords).

4. Build and run the solution.


## Update instructions

If you want to update your environment variables in the `.env` file. Follow these steps:

1. If you have containers/volumes associated with the solution, remove those (Easiest way is through the docker desktop app).

2. Open `.env` and update the information with your database, and email details details:
   ```ps1
   # Database Configuration
   DB_HOST=localhost
   DB_PORT=DB_PORT (3006 if using mariaDB)
   DB_NAME=YOUR_DATABASE
   DB_USER=(probably 'root')
   DB_PASSWORD=YOUR_PASSWORD
   DB_SERVICE_NAME=db
   
   # Admin Configuration
   ADMIN_EMAIL=admin@admin.com
   ADMIN_PASSWORD=Admin1234
   
   # Email configuration
   EMAIL_SMTP_SERVER=EMAIL_SMTP_SERVER (If gmail: smtp.gmail.com)
   EMAIL_PORT=EMAIL_PORT (If gmail: 587)
   EMAIL_USERNAME=EMAIL_ADDRESS
   EMAIL_PASSWORD=APP_PASSWORD (see below)
   EMAIL_FROM_ADDRESS=EMAIL_ADDRESS
   ```

3. Build and run the solution.



