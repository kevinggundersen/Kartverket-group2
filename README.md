# Kartverket-group2

### Considerations
   We made the choice

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

1. If you have containers/volumes asociated with the solution, remove those (Easiest way is through the docker desktop app).

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


