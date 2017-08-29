CREATE TABLE [GFR].[tb_sugerencia] (
    [idSugerencia]   INT          IDENTITY (1, 1) NOT NULL,
    [descripcion]    VARCHAR (50) NOT NULL,
    [prioridad]      VARCHAR (50) NOT NULL,
    [comentarioJEfe] VARCHAR (50) NOT NULL,
    [id]             INT          NOT NULL,
    CONSTRAINT [PK_Sugerencia] PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id]) REFERENCES [GFR].[tb_local] ([id])
);

