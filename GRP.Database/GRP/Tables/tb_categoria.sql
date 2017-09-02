CREATE TABLE [GRP].[tb_categoria] (
    [codCategoria] BIGINT        NOT NULL IDENTITY(1,1),
    [nombre]       VARCHAR (120) NULL,
    [descripcion]  VARCHAR (120) NULL,
    PRIMARY KEY CLUSTERED ([codCategoria] ASC)
);

