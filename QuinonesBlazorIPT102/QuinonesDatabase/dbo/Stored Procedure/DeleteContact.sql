CREATE PROCEDURE [dbo].[DeleteContact]
	 @PersonId int
AS
BEGIN
    DELETE FROM [dbo].[Persons]
        WHERE [PersonId] = @PersonId;

        
END;