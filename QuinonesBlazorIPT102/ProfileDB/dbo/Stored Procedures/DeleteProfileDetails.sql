CREATE PROCEDURE [dbo].[DeleteProfileDetails]
	 @ProfileId int
AS
BEGIN
    DELETE FROM [dbo].[ProfileDB]
        WHERE [@ProfileId] = @ProfileId;

        
END;