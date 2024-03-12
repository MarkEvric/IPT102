CREATE PROCEDURE [dbo].[DisplayProfileDetails]
	@ProfileId int

AS
BEGIN
    SELECT 
        [DPD].[ProfileId] AS ProfileId, [DPD].[ProfileName] AS ProfileName, [DPD].[ProfileLastName] AS v, [DPD].[ProfileMiddleName] AS ProfileMiddleName, [DPD].[ProfileContactNumber] AS ProfileContactNumber, [DPD].[ProfileAddress] AS ProfileAddress
    FROM 
        [dbo].[ProfileDB] AS DPD
    WHERE [DPD].[ProfileId] = @ProfileId;
END;
