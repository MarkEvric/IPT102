CREATE PROCEDURE [dbo].[NewProfileDetails]
	@ProfileName NVARCHAR(50),
    @ProfileLastName NVARCHAR(50),
    @ProfileMiddleName NVARCHAR(50),
    @ProfileContactNumber int(50),
    @ProfileAddress NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;


    INSERT INTO ProfileDB (ProfileName, ProfileLastName, ProfileMiddleName, ProfileContactNumber, ProfileAddress)
    VALUES (@ProfileName, @ProfileLastName, @ProfileMiddleName, ProfileContactNumber, ProfileAddress);

END