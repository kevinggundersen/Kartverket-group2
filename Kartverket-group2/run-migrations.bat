@echo off



REM Build a temporary image for running migrations
echo Building migration image...
docker build -t ef-migrations -f- . < Dockerfile.migrations
if errorlevel 1 (
    echo Failed to build migration image
    exit /b 1
)

REM Run the migrations
echo Running migrations...
docker run --rm -it --network dockercompose12721281635303420820_default ^
    -e ConnectionStrings__DefaultConnection="Server=db;Port=3306;Database=kartverket_db;User=root;Password=Innebandy1999;" ^
    ef-migrations