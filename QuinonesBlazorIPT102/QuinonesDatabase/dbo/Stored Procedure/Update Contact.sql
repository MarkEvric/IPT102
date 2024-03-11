CREATE PROCEDURE [dbo].[Update Contact]
	@PersonId INT,
    @FirstName NVARCHAR(MAX),
    @LastName NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @MobileNumber NVARCHAR(MAX),
    @PAddress NVARCHAR(MAX)
AS
BEGIN
    UPDATE [dbo].[Persons]
    SET
        [FirstName] = @FirstName,
        [LastName] = @LastName,
        [Email] = @Email,
        [MobileNumber] = @MobileNumber,
        [PAddress] = @PAddress

    WHERE [PersonId] = @PersonId;
END;