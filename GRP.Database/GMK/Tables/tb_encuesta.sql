CREATE TABLE [GMK].[tb_encuesta] (
    [codEncuesta]                 INT           IDENTITY (1, 1) NOT NULL,
    [nombreEncuesta]              NVARCHAR (50) NULL,
    [fechaInicioEncuesta]         DATE          NULL,
    [fechaFinEncuesta]            DATE          NULL,
    [cantidadClientesEncuestados] INT           NULL,
    [codLocal]                    INT           NULL,
    CONSTRAINT [PK_tb_encuesta] PRIMARY KEY CLUSTERED ([codEncuesta] ASC)
);

