CREATE TABLE AppRoles (
    RoleId INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(100) NOT NULL
);

CREATE TABLE AppUsers (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    IdentityNumber NVARCHAR(50) UNIQUE NOT NULL,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    BirthDate DATE NOT NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Other')),
    ModifiedBy INT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    Status BIT DEFAULT 1,
    Balance DECIMAL(10,2) DEFAULT 0.00
);

CREATE TABLE UserRoles (
    RoleId INT NOT NULL,
    UserId INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    Status BIT DEFAULT 1,
    PRIMARY KEY (RoleId, UserId),
    FOREIGN KEY (RoleId) REFERENCES AppRoles(RoleId),
    FOREIGN KEY (UserId) REFERENCES AppUsers(UserId)
);

CREATE TABLE Developers (
    DeveloperId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE Games (
    GameId INT IDENTITY(1,1) PRIMARY KEY,
    GameName NVARCHAR(255) NOT NULL,
    PublisherName NVARCHAR(255) NOT NULL,
    ReleasedDate DATE NOT NULL,
    NumberOfEpisodes INT DEFAULT 0,
    Stocks INT DEFAULT 0,
    CreatedDate DATETIME DEFAULT GETDATE(),
    Status BIT DEFAULT 1,
    ModifiedDate DATETIME NULL,
    CreatedBy INT NULL,
    GameImg NVARCHAR(255) NULL,
    Price DECIMAL(10,2) DEFAULT 0.00,
    FOREIGN KEY (CreatedBy) REFERENCES AppUsers(UserId)
);

CREATE TABLE GameDevelopers (
    GameId INT NOT NULL,
    DeveloperId INT NOT NULL,
    PRIMARY KEY (GameId, DeveloperId),
    FOREIGN KEY (GameId) REFERENCES Games(GameId),
    FOREIGN KEY (DeveloperId) REFERENCES Developers(DeveloperId)
);

CREATE TABLE UserGamesOwned (
    UserId INT NOT NULL,
    GameId INT NOT NULL,
    PRIMARY KEY (UserId, GameId),
    FOREIGN KEY (UserId) REFERENCES AppUsers(UserId),
    FOREIGN KEY (GameId) REFERENCES Games(GameId)
);
