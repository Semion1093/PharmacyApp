CREATE TABLE [dbo].[Batches] (
    [Id]      INT IDENTITY NOT NULL,
    [ProductId]  INT NOT NULL,
    [StoreId] INT NOT NULL,
    [Count]   INT NOT NULL,
    CONSTRAINT [PK_Batches] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Batches_Goods] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Batches_Stores] FOREIGN KEY ([StoreId]) REFERENCES [dbo].[Stores] ([Id]) ON DELETE CASCADE
);

