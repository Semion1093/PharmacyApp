CREATE TABLE [dbo].[Pharmacies] (
    [Id]   INT IDENTITY NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    [Adress] VARCHAR (100) NOT NULL,
    [Phone] VARCHAR (12) NOT NULL,
    CONSTRAINT [PK_Pharmacies] PRIMARY KEY CLUSTERED ([Id] ASC) 
);

