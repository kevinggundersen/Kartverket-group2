@echo off

REM Build a temporary image for running migrations
docker build -t ef-migrations -f- . < Dockerfile.migrations

REM Run the migrations
docker run --rm -it --network dockercompose17884436360883254100_default ^
    -e ConnectionStrings__DefaultConnection="Server=db;Port=3306;Database=kartverket_db;User=root;Password=Innebandy1999;" ^
    ef-migrations