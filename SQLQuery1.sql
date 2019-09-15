CREATE TABLE [dbo].[Customers](
[Id] int IDENTITY(1,1) NOT NULL,
[FirstName] nvarchar(max) NOT NULL,
[LastName] nvarchar(max) NOT NULL,
[UserId] nvarchar(max) NOT NULL
PRIMARY KEY (Id)
);
GO

CREATE TABLE [dbo].[Desks](
[Id] int IDENTITY(1,1) NOT NULL,
[NearToWindow] bit NOT NULL,
PRIMARY KEY (Id)
);
GO

CREATE TABLE [dbo].[Bookings](
[Id] int IDENTITY(1,1) NOT NULL,
[CustomerId] int NOT NULL,
[DeskId] int NOT NULL,
[Birthday] bit NOT NULL
PRIMARY KEY (Id),
FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
FOREIGN KEY (DeskId) REFERENCES Desks(Id)
);
GO