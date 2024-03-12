CREATE TABLE [dbo].[ProfileDB]
(
	[ProfileId] INT NOT NULL PRIMARY KEY, 
    [ProfileName] NVARCHAR(50) NULL, 
    [ProfileLastName] NVARCHAR(50) NULL, 
    [ProfileMiddleName] NVARCHAR(50) NULL, 
    [ProfileContactNumber] INT NULL, 
    [ProfileAddress] NVARCHAR(50) NULL
)
