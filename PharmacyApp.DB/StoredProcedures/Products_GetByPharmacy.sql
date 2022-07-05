CREATE PROCEDURE [dbo].[Products_GetByPharmacy] 
    @Id int 
AS BEGIN
SELECT Products.[Name],
       sum([Batches].[Count])
FROM dbo.Products
JOIN [Batches] ON [Batches].ProductId = Products.Id
JOIN Stores ON Stores.Id = [Batches].StoreId
WHERE 
    @Id = PharmacyId
END