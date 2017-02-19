-- ALTER TABLE [Sales].[Store] DROP CONSTRAINT [FK_Store_TaxAuditor_TaxAuditorID]
-- ALTER TABLE [Sales].[Store] DROP COLUMN TaxAuditorID
-- DROP TABLE [custom].[OpeningHour] 
-- DROP TABLE [custom].[TaxAuditor]


CREATE SCHEMA custom

CREATE TABLE [custom].[TaxAuditor]
(
	[TaxAuditorID] INT IDENTITY(1,1) PRIMARY KEY,
	[FirstName] NVARCHAR(200),
	[LastName] NVARCHAR(200)
)


ALTER TABLE [Sales].[Store] ADD TaxAuditorID INT NULL
ALTER TABLE [Sales].[Store] ADD CONSTRAINT [FK_Store_TaxAuditor_TaxAuditorID] FOREIGN KEY ([TaxAuditorID]) REFERENCES [custom].[TaxAuditor] ([TaxAuditorID])

CREATE TABLE [custom].[OpeningHour]
(
	[BusinessEntityID] INT NOT NULL,
	[DayOfWeek] INT NOT NULL,
	[OpeningTime] TIME NOT NULL,
	[ClosingTime] TIME NOT NULL
)
ALTER TABLE [custom].[OpeningHour] ADD CONSTRAINT [PK_OpeningHour] PRIMARY KEY CLUSTERED ([BusinessEntityID], [DayOfWeek])
ALTER TABLE [custom].[OpeningHour] ADD CONSTRAINT [FK_OpeningHour_Store_BusinessEntityID] FOREIGN KEY ([BusinessEntityID]) REFERENCES [Sales].[Store] ([BusinessEntityID])

INSERT INTO [custom].[TaxAuditor] ([FirstName], [LastName]) VALUES ('Mike', 'Wazowski')
INSERT INTO [custom].[TaxAuditor] ([FirstName], [LastName]) VALUES ('James', 'Sullivan')
UPDATE [Sales].[Store] SET [TaxAuditorID] = 1+(BusinessEntityID % 3)%2


INSERT INTO [custom].[OpeningHour] ([BusinessEntityID], [DayOfWeek], [OpeningTime], [ClosingTime]) SELECT [BusinessEntityID], 1, '08:30', '17:30' FROM [Sales].[Store]
INSERT INTO [custom].[OpeningHour] ([BusinessEntityID], [DayOfWeek], [OpeningTime], [ClosingTime]) SELECT [BusinessEntityID], 2, '08:30', '17:30' FROM [Sales].[Store]
INSERT INTO [custom].[OpeningHour] ([BusinessEntityID], [DayOfWeek], [OpeningTime], [ClosingTime]) SELECT [BusinessEntityID], 3, '08:30', '17:30' FROM [Sales].[Store]
INSERT INTO [custom].[OpeningHour] ([BusinessEntityID], [DayOfWeek], [OpeningTime], [ClosingTime]) SELECT [BusinessEntityID], 4, '08:30', '17:30' FROM [Sales].[Store]
INSERT INTO [custom].[OpeningHour] ([BusinessEntityID], [DayOfWeek], [OpeningTime], [ClosingTime]) SELECT [BusinessEntityID], 5, '09:30', '14:30' FROM [Sales].[Store]
