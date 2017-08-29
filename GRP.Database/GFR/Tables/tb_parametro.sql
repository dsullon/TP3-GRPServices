CREATE TABLE [GFR].[tb_parametro] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [codigoGrupo] INT           NOT NULL,
    [grupo]       VARCHAR (50)  NOT NULL,
    [codigo]      INT           NOT NULL,
    [nombre]      VARCHAR (100) NOT NULL,
    [valor]       VARCHAR (100) NULL,
    [descripcion] VARCHAR (255) NULL,
    [valueText1]  VARCHAR (255) NULL,
    [valueText2]  VARCHAR (255) NULL,
    [valueText3]  VARCHAR (255) NULL,
    [auditoriaUC] INT           NOT NULL,
    [auditoriaUM] INT           NULL,
    [auditoriaFC] DATETIME      NOT NULL,
    [auditoriaFM] DATETIME      NULL,
    CONSTRAINT [PK_Parametro] PRIMARY KEY CLUSTERED ([id] ASC)
);

