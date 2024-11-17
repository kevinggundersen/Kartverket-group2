# Kartverket-group2

## Setup Instructions

1. Clone the repository
   ```
   git clone https://github.com/your-username/kartverket-group2.git
   ```
   
3. Open `.env` and update the information with your local database details:
   ```ps1
   DB_PASSWORD=YOUR_PASSWORD
   DB_NAME=YOUR_DATABASE
   DB_PORT=_DB_PORT (3006 if using mariaDB)
   DB_USER=USER (probably 'root')
   
   SCRIPT_PATH=./Kartverket-group2/run-migrations.bat
   
   DB_SERVICE_NAME=db
   
   EMAIL_SMTP_SERVER=EMAIL_SMTP_SERVER (If gmail: smtp.gmail.com)
   EMAIL_PORT=EMAIL_PORT (If gmail: 587)
   EMAIL_USERNAME=EMAIL_ADDRESS
   EMAIL_PASSWORD=APP_PASSWORD (see below)
   EMAIL_FROM_ADDRESS=EMAIL_ADDRESS
   ```
   If using gmail for email service, you need to generate an app password in your Google account [Found here](https://myaccount.google.com/apppasswords).

4. Build and run the project.


## Update instructions

If you want to update your environment variables in the `.env` file. Follow these steps:

1. If you have containers/volumes asociated with the project. Remove those (Easiest way is through the docker desktop app).

2. Open `.env` and update the information with your local database details:
   ```ps1
   DB_PASSWORD=YOUR_PASSWORD
   DB_NAME=YOUR_DATABASE
   DB_PORT=_DB_PORT (3006 if using mariaDB)
   DB_USER=USER (probably 'root')
   
   SCRIPT_PATH=./Kartverket-group2/run-migrations.bat
   
   DB_SERVICE_NAME=db
   
   EMAIL_SMTP_SERVER=EMAIL_SMTP_SERVER (If gmail: smtp.gmail.com)
   EMAIL_PORT=EMAIL_PORT (If gmail: 587)
   EMAIL_USERNAME=EMAIL_ADDRESS
   EMAIL_PASSWORD=APP_PASSWORD
   EMAIL_FROM_ADDRESS=EMAIL_ADDRESS
   ```

3. Build and run the project.


