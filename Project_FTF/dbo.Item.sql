CREATE TABLE [dbo].[Item] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (MAX) NULL,
    [LastName]     NVARCHAR (MAX) NULL,
    [EmailAddress] NVARCHAR (MAX) NOT NULL,
    [ItemType]     NVARCHAR (MAX) NULL,
    [ItemDesc]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Item] PRIMARY KEY CLUSTERED ([ID] ASC)
);

