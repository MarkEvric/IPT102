﻿CREATE TABLE [dbo].[MQTable]
(
	[MQId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MQName] NVARCHAR(50) NULL, 
    [MQGradeYearLevel] NVARCHAR(50) NULL, 
    [MQReasonForAdmission] NVARCHAR(50) NULL, 
    [MQDate] NVARCHAR(50) NULL, 
    [MQTime] NVARCHAR(50) NULL
)
