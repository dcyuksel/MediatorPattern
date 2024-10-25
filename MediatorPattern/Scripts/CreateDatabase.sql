create database MediatorPattern;

CREATE TABLE People (
    [Id]    BIGINT IDENTITY(1,1) NOT NULL, 
    [Name]  NVARCHAR(200)        NOT NULL,
    [Age]   INT                  NOT NULL,
    [Email] NVARCHAR(100) UNIQUE NOT NULL,
);

INSERT INTO People ([Name], [Age], [Email]) VALUES ('Patty', 19, 'patty@gmail.com');
INSERT INTO People ([Name], [Age], [Email]) VALUES ('Alice', 32, 'alice@gmail.com');
INSERT INTO People ([Name], [Age], [Email]) VALUES ('Louis', 45, 'louis@gmail.com');
INSERT INTO People ([Name], [Age], [Email]) VALUES ('Bob',   27, 'bob@gmail.com');

CREATE TABLE Rights (
    [Id]            BIGINT IDENTITY(1,1) NOT NULL, 
    [Email]         NVARCHAR(100) UNIQUE NOT NULL,
    [DriverLicence] BIT                  NOT NULL,
    [Vote]          BIT                  NOT NULL,
    [DrinkAlcohol]  BIT                  NOT NULL,
);

INSERT INTO Rights ([Email], [DriverLicence], [Vote], [DrinkAlcohol]) VALUES ('patty@gmail.com', 1, 1, 1);
INSERT INTO Rights ([Email], [DriverLicence], [Vote], [DrinkAlcohol]) VALUES ('alice@gmail.com', 1, 1, 1);
INSERT INTO Rights ([Email], [DriverLicence], [Vote], [DrinkAlcohol]) VALUES ('louis@gmail.com', 1, 1, 1);
INSERT INTO Rights ([Email], [DriverLicence], [Vote], [DrinkAlcohol]) VALUES ('bob@gmail.com',   1, 1, 1);