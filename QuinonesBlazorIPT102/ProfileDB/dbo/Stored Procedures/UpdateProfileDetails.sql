CREATE PROCEDURE [dbo].[UpdateProfileDetails]
	@ProfileId INT,
    @ProfileName NVARCHAR(MAX),
    @ProfileLastName NVARCHAR(MAX),
    @ProfileMiddleName NVARCHAR(MAX),
    @ProfileContactNumber int(MAX),
    @ProfileAddress NVARCHAR(MAX)
   
AS
BEGIN
    UPDATE [dbo].[ProfileDB]
    SET
        [ProfileName] = @ProfileName,
        [ProfileLastName] = @ProfileLastName,
        [ProfileMiddleName] = @ProfileMiddleName,
        [ProfileContactNumber] = @ProfileContactNumber,
        [ProfileAddress] = @ProfileAddress
      

    WHERE [ProfileId] = @ProfileId;
END;