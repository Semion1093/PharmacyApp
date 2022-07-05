CREATE PROCEDURE [dbo].[Product_Add]
  @Name varchar(50) AS BEGIN
INSERT INTO
  dbo.Products ([Name])
VALUES
  (@Name)
SELECT
  scope_identity()
END
