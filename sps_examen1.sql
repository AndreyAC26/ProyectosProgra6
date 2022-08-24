USE AdventureWorks2016CTP3
GO

-- =============================================
-- Author:		EXAMEN I PROGRAMACIÓN 6
-- Create date: 27/06/2022
-- Description:	RECUPERA LISTA DE SALESREASON
-- =============================================
CREATE PROCEDURE [dbo].[PA_recSalesReason]
AS
BEGIN
	SELECT SalesReasonID,
       [Name],
       ReasonType,
       ModifiedDate
	FROM Sales.SalesReason
END
GO

-- =============================================
-- Author:		EXAMEN I PROGRAMACIÓN 6
-- Create date: 27/06/2022
-- Description:	RECUPERA SALESREASON X ID.
-- =============================================
CREATE PROCEDURE [dbo].[PA_recSalesReasonXId]
@SalesReasonID SMALLINT
AS
BEGIN
	SELECT SalesReasonID,
       [Name],
       ReasonType,
       ModifiedDate
	FROM Sales.SalesReason
	WHERE SalesReasonID = @SalesReasonID
END
GO

-- =============================================
-- Author:		EXAMEN I PROGRAMACIÓN 6
-- Create date: 27/06/2022
-- Description:	INSERTA SALESREASON
-- =============================================
CREATE PROCEDURE [dbo].[PA_insSalesReason]
@Nombre NVARCHAR(50),
@ReasonType NVARCHAR(50),
@ModifiedDate DATETIME
AS
BEGIN
	INSERT INTO Sales.SalesReason([Name],ReasonType,ModifiedDate)
	VALUES(@Nombre,@ReasonType, @ModifiedDate)	
END
GO

-- =============================================
-- Author:		EXAMEN I PROGRAMACIÓN 6
-- Create date: 27/06/2022
-- Description:	MODIFICA SALESREASON
-- =============================================
CREATE PROCEDURE [dbo].[PA_modSalesReason]
@SalesReasonID INT,
@Nombre NVARCHAR(50),
@ReasonType NVARCHAR(50),
@ModifiedDate DATETIME
AS
BEGIN
	UPDATE Sales.SalesReason
	SET [Name] = @Nombre,
	    ReasonType = @ReasonType,
		ModifiedDate = @ModifiedDate
	WHERE SalesReasonID = @SalesReasonID
END
GO

-- =============================================
-- Author:		EXAMEN I PROGRAMACIÓN 6
-- Create date: 27/06/2022
-- Description:	ELIMINA SALESREASON
-- =============================================
CREATE PROCEDURE [dbo].[PA_delSalesReason]
@SalesReasonID INT
AS
BEGIN
	DELETE Sales.SalesReason
	WHERE SalesReasonID = @SalesReasonID
END
GO