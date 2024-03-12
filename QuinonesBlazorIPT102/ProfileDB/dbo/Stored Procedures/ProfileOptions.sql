CREATE PROCEDURE [dbo].[ProfileOptions]
	
	AS
BEGIN
    SELECT 
        [PO].[ProfileId] AS ProfileId, 
        [PO].[ProfileName] AS ProfileName
    FROM 
        [dbo].[ProfileDB] AS PO
END;
