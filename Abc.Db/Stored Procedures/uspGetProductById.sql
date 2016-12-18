CREATE PROCEDURE [dbo].[uspGetProductById]
	@paramProductId int = 0	
AS
BEGIN
	SELECT 
		p.[ProductId], 
		p.[Name], 
		p.[Description], 
		p.[ProductTypeId], 
		t.[Name]
	FROM 
		[dbo].[Product] p INNER JOIN [dbo].[ProductType] t ON p.ProductTypeId = t.ProductTypeId
	WHERE
		p.ProductId = @paramProductId
END