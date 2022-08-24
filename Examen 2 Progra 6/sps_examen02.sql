USE AdventureWorks2016CTP3
GO

-- =============================================
-- Author:		EXAMEN II PROGRAMACIÓN 6
-- Create date: 08/08/2022
-- Description:	RECUPERA Department
-- =============================================
CREATE PROCEDURE [dbo].[recDepartment]
AS
BEGIN
	SELECT DepartmentID,
		   [Name] As NomDpto,
		   GroupName
	FROM HumanResources.Department
END
GO

-- =============================================
-- Author:		EXAMEN II PROGRAMACIÓN 6
-- Create date: 08/08/2022
-- Description:	RECUPERA Department X ID
-- =============================================
CREATE PROCEDURE [dbo].[recDepartmentXId]
@DepartmentID SMALLINT
AS
BEGIN
	SELECT DepartmentID,
		   [Name] As NomDpto,
		   GroupName
	FROM HumanResources.Department
	WHERE DepartmentID = @DepartmentID
END
GO

-- =============================================
-- Author:		EXAMEN II PROGRAMACIÓN 6
-- Create date: 08/08/2022
-- Description:	INSERTAR Department
-- =============================================
CREATE PROCEDURE [dbo].[insDepartment]
@NomDpto NVARCHAR(50),
@GroupName NVARCHAR(50)
AS
BEGIN
	INSERT INTO HumanResources.Department
	VALUES(@NomDpto, @GroupName, GETDATE())
END
GO

-- =============================================
-- Author:		EXAMEN II PROGRAMACIÓN 6
-- Create date: 08/08/2022
-- Description:	MODIFICAR Department
-- =============================================
CREATE PROCEDURE [dbo].[modDepartment]
@DepartmentID SMALLINT,
@NomDpto NVARCHAR(50),
@GroupName NVARCHAR(50)
AS
BEGIN
	UPDATE HumanResources.Department
	SET [Name] = @NomDpto, 
	    GroupName = @GroupName
	WHERE DepartmentID = @DepartmentID
END
GO

-- =============================================
-- Author:		EXAMEN II PROGRAMACIÓN 6
-- Create date: 08/08/2022
-- Description:	ELIMINAR Department
-- =============================================
CREATE PROCEDURE [dbo].[delDepartment]
@DepartmentID SMALLINT
AS
BEGIN
	DELETE HumanResources.Department
	WHERE DepartmentID = @DepartmentID
END
GO

