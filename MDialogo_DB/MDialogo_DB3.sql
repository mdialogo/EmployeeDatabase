/*
   Wednesday, January 16, 201310:18:11 PM
   User: mike
   Server: DORIE-PC\SQLEXPRESS
   Database: MDialogo_DB
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.[Tmp_HR.Employee]
	(
	EmployeeID int NOT NULL IDENTITY (1, 1),
	LastName nvarchar(50) NULL,
	FirstName nvarchar(50) NULL,
	MiddleName nvarchar(50) NULL,
	Department nvarchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.[Tmp_HR.Employee] SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.[Tmp_HR.Employee] ON
GO
IF EXISTS(SELECT * FROM dbo.[HR.Employee])
	 EXEC('INSERT INTO dbo.[Tmp_HR.Employee] (EmployeeID, LastName, FirstName, MiddleName, Department)
		SELECT EmployeeID, LastName, FirstName, MiddleName, Department FROM dbo.[HR.Employee] WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.[Tmp_HR.Employee] OFF
GO
DROP TABLE dbo.[HR.Employee]
GO
EXECUTE sp_rename N'dbo.[Tmp_HR.Employee]', N'HR.Employee', 'OBJECT' 
GO
ALTER TABLE dbo.[HR.Employee] ADD CONSTRAINT
	[PK_HR.Employee] PRIMARY KEY CLUSTERED 
	(
	EmployeeID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
