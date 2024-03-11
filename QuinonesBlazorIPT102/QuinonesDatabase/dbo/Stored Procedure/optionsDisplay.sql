CREATE PROCEDURE [dbo].[optionsDisplay]
	AS
BEGIN
    SELECT 
        [OD].[PersonId] AS PersonId, 
        [OD].[FirstName] AS FirstName
    FROM 
        [dbo].[Persons] AS OD
END;