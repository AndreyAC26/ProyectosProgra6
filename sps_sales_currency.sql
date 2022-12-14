USE [AdventureWorks2019]
GO

-- =============================================
-- Author:		PROGRAMACIÓN 6
-- Create date: 13/06/2022
-- Description:	RECUPERA CURRENCY
-- =============================================
CREATE PROCEDURE [SALES].[recCurrency]
AS
BEGIN
	SELECT CurrencyCode, [Name]
	FROM Sales.Currency
END
GO
-- =============================================
-- Author:		PROGRAMACIÓN 6
-- Create date: 13/06/2022
-- Description:	RECUPERA CURRENCY X ID
-- =============================================
CREATE PROCEDURE [SALES].[recCurrencyxId]
@CurrencyCode NCHAR(3)
AS
BEGIN
	SELECT CurrencyCode, [Name]
	FROM Sales.Currency
	WHERE CurrencyCode = @CurrencyCode
END
GO

-- =============================================
-- Author:		PROGRAMACIÓN 6
-- Create date: 13/06/2022
-- Description:	INSERTA CURRENCY
-- =============================================
CREATE PROCEDURE [SALES].[insCurrency]
@CurrencyCode NCHAR(3),
@CNAME NVARCHAR(50)
AS
BEGIN
	INSERT INTO Sales.Currency(CurrencyCode, [Name], ModifiedDate)
	VALUES(@CurrencyCode, @CNAME, GETDATE())
END
GO

-- =============================================
-- Author:		PROGRAMACIÓN 6
-- Create date: 13/06/2022
-- Description:	MODIFICA CURRENCY
-- =============================================
CREATE PROCEDURE [SALES].[modCurrency]
@CurrencyCode NCHAR(3),
@CNAME NVARCHAR(50)
AS
BEGIN
	UPDATE Sales.Currency
	SET [Name] = @CNAME
	WHERE CurrencyCode = @CurrencyCode
END
GO

-- =============================================
-- Author:		PROGRAMACIÓN 6
-- Create date: 13/06/2022
-- Description:	ELIMINA CURRENCY
-- =============================================
CREATE PROCEDURE [SALES].[delCurrency]
@CurrencyCode NCHAR(3)
AS
BEGIN
	DELETE Sales.Currency
	WHERE CurrencyCode = @CurrencyCode
END
GO