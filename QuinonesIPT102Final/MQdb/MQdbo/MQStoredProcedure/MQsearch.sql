CREATE PROCEDURE [dbo].[MQsearch]
	@MQkeyword NVARCHAR(50)
AS
BEGIN
SELECT
[MQId] as MQId,
[MQName] as MQName,
[MQGradeYearLevel] as MQGradeYearLevel,
[MQReasonForAdmission] as MQReasonForAdmission,
[MQDate] as MQDate,
[MQTime] as MQTime

FROM[dbo].[MQTable]WHERE
[MQId] like @MQkeyword or
[MQName] like @MQkeyword or
[MQGradeYearLevel] like @MQkeyword or
[MQReasonForAdmission] like @MQkeyword or
[MQDate] like @MQkeyword or
[MQTime] like @MQkeyword 
ORDER BY [MQName]
END