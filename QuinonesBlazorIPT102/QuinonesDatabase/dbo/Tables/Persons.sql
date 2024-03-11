CREATE TABLE [dbo].[Persons]
(
	[PersonId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [MobileNumber] INT NULL, 
    [PAddress] VARCHAR(50) NULL 
)
