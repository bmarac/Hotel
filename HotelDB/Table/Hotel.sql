CREATE TABLE [dbo].[Hotel]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50),
    [Price] FLOAT,
    [City] NVARCHAR(50),
)
