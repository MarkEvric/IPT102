CREATE PROCEDURE [dbo].[MQdisplay]
AS
BEGIN
IF(SELECT COUNT(*)FROM[dbo].[MQTable])=0
BEGIN
	INSERT INTO[dbo].[MQTable]
(MQName,MQradeYearLevel,MQReasonForAdmission,MQDate,MQTime)
VALUES(N'Mark Evric Quinones',
       N'BSIT-3',
       N'HIV',
       N'12-4-2023',
       N'12:59 AM'),
       (N'Christene Joy Burata',
       N'BSIT-3',
       N'kalibanga',
       N'12-4-2023',
       N'8:00 AM')
END

SELECT
[MQId] as QBMQId,
[MQName] as MQName,
[MQGradeYearLevel] as MQGradeYearLevel,
[MQReasonForAdmission] as MQReasonForAdmission,
[MQDate] as MQDate,
[MQTime] as MQTime

FROM[dbo].[MQTable]

END