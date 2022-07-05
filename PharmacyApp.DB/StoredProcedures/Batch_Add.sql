CREATE PROCEDURE [dbo].[Batch_Add]
  @ProductId int, 
  @StoreId int, 
  @Count int AS BEGIN
INSERT INTO
  dbo.[Batches] (ProductId, StoreId, [Count])
VALUES
  (@ProductId, @StoreId, @Count)
SELECT
  scope_identity()
END
