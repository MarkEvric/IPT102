CREATE PROCEDURE [dbo].[NewContact]
	@FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(50),
    @MobileNumber INT,
    @PAddress NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;


    INSERT INTO Persons (FirstName, LastName, Email, MobileNumber, PAddress)
    VALUES (@FirstName, @LastName, @Email, @MobileNumber, @PAddress);

END