CREATE PROCEDURE [dbo].[selectedContact]
	@PersonId int

AS
BEGIN
    SELECT 
        [SC].[PersonId] AS PersonId,[SC].[FirstName] AS FirstName, [SC].[LastName] AS LastName, [SC].[Email] AS Email,
        [SC].[MobileNumber] AS MobileNumber,[SC].[PAddress] AS PAddress
        
    FROM 
        [dbo].[Persons] AS SC
    WHERE [SC].[PersonId] = @PersonId;
END;