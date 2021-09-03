CREATE TABLE [dbo].[LogTable]
(
	[LogId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LogLevel] TEXT NULL, 
    [EventName] TEXT NULL, 
    [Source] TEXT NULL, 
    [ExceptionMessage] TEXT NULL, 
    [StackTrace] TEXT NULL, 
    [CreatedDate] TEXT NULL, 
    [UserId] INT NULL
)
