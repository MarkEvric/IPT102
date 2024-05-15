CREATE PROCEDURE [dbo].[MQcreate]
    @MQName NVARCHAR(50), 
    @MQGradeYearLevel NVARCHAR(50), 
    @MQReasonForAdmission NVARCHAR(50), 
    @MQDate NVARCHAR(50), 
    @MQTime NVARCHAR(50)
AS
BEGIN
INSERT INTO[dbo].[MQTable]
(MQName,MQGradeYearLevel,MQReasonForAdmission,MQDate,MQTime)
VALUES(@MQName,
       @MQGradeYearLevel,
       @MQReasonForAdmission,
       @MQDate,
       @MQTime)
END