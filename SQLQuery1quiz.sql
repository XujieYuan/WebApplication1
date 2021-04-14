CREATE TABLE [dbo].[Results] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Answer] nvarchar(max)  NOT NULL,
    [Count] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO