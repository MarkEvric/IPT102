CREATE PROCEDURE [dbo].[MQupdate]
    @MQId INT,
    @MQName NVARCHAR(50), 
    @MQGradeYearLevel NVARCHAR(50), 
    @MQReasonForAdmission NVARCHAR(50), 
    @MQDate NVARCHAR(50), 
    @MQTime NVARCHAR(50)
AS
BEGIN
UPDATE[dbo].[MQTable]
set
[MQName]=coalesce(@MQName,[MQName]),
[MQGradeYearLevel]=coalesce(@MQGradeYearLevel,[MQGradeYearLevel]),
[MQReasonForAdmission]=coalesce(@MQReasonForAdmission,[MQReasonForAdmission]),
[MQDate]=coalesce(@MQDate,[MQDate]),
[MQTime]=coalesce(@MQTime,[MQTime])
WHERE [MQId]=@MQId
END