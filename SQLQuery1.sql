CREATE TABLE [dbo].[House_category] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Quantity] int  NOT NULL
);
GO

-- Creating table 'Tips'
CREATE TABLE [dbo].[Tips] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Img_src] nvarchar(max)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [House_categeryId] int  NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'House_category'
ALTER TABLE [dbo].[House_category]
ADD CONSTRAINT [PK_House_category]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tips'
ALTER TABLE [dbo].[Tips]
ADD CONSTRAINT [PK_Tips]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [House_categeryId] in table 'Tips'
ALTER TABLE [dbo].[Tips]
ADD CONSTRAINT [FK_House_categeryTip]
    FOREIGN KEY ([House_categeryId])
    REFERENCES [dbo].[House_category]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_House_categeryTip'
CREATE INDEX [IX_FK_House_categeryTip]
ON [dbo].[Tips]
    ([House_categeryId]);
GO