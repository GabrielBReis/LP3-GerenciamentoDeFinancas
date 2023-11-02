CREATE TABLE [dbo].[Categoria] (
    [ID]        INT           NOT NULL,
    [NOME]      VARCHAR (30)  NOT NULL,
    [DESCRICAO] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Despesas] (
    [ID]          INT          NOT NULL,
    [DATA]        DATE         NOT NULL,
    [VALOR]       FLOAT (53)   NOT NULL,
    [DESCRICAO]   VARCHAR (30) NULL,
    [IDCATEGORIA] INT          NOT NULL,
    [IDUSUARIO]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Despesas_Usuario] FOREIGN KEY ([IDUSUARIO]) REFERENCES [dbo].[Usuario] ([ID]),
    CONSTRAINT [FK_Despesas_Categoria] FOREIGN KEY ([IDCATEGORIA]) REFERENCES [dbo].[Categoria] ([ID])
);

CREATE TABLE [dbo].[Receitas] (
    [ID]          INT          NOT NULL,
    [DATA]        DATE         NOT NULL,
    [VALOR]       FLOAT (53)   NOT NULL,
    [DESCRICAO]   VARCHAR (30) NULL,
    [IDCATEGORIA] INT          NOT NULL,
    [IDUSUARIO]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Receitas_Usuario] FOREIGN KEY ([IDUSUARIO]) REFERENCES [dbo].[Usuario] ([ID]),
    CONSTRAINT [FK_Receitas_Categoria] FOREIGN KEY ([IDCATEGORIA]) REFERENCES [dbo].[Categoria] ([ID])
);

CREATE TABLE [dbo].[Saldo] (
    [ID]        INT        NOT NULL,
    [VALOR]     FLOAT (53) NOT NULL,
    [IDUSUARIO] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Saldo_ToTable] FOREIGN KEY ([IDUSUARIO]) REFERENCES [dbo].[Usuario] ([ID])
);

CREATE TABLE [dbo].[Usuario] (
    [ID]    INT          NOT NULL,
    [NOME]  VARCHAR (30) NOT NULL,
    [SENHA] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

