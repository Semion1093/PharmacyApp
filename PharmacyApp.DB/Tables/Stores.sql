CREATE TABLE [dbo].[Stores] (
    [Id]         INT IDENTITY NOT NULL,
    [PharmacyId] INT          NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Stores_Pharmacies] FOREIGN KEY ([PharmacyId]) REFERENCES [dbo].[Pharmacies] ([Id]) ON DELETE CASCADE
);

