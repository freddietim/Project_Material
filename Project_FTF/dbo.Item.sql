CREATE TABLE [dbo].[Item] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [Status]       NVARCHAR (MAX)  NOT NULL,
    [FirstName]    NVARCHAR (MAX)  NOT NULL,
    [LastName]     NVARCHAR (MAX)  NULL,
    [EmailAddress] NVARCHAR (MAX)  NOT NULL,
    [ItemType]     NVARCHAR (MAX)  NOT NULL,
    [ItemDesc]     NVARCHAR (1024) NOT NULL,
    [Abstract]     NVARCHAR (MAX)  NULL,
    [Location]     NVARCHAR (MAX)  DEFAULT ('') NOT NULL,
		
    CONSTRAINT [PK_dbo.Item] PRIMARY KEY CLUSTERED ([ID] ASC), 
   
);

