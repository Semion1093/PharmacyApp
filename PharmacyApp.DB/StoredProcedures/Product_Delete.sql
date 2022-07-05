CREATE PROCEDURE [dbo].[Product_Delete] 
  @Id int AS BEGIN
DELETE FROM
  dbo.Products
WHERE
  @Id = Id
END
