CREATE TABLE [GMK].[tb_resultadoEncuesta] (
    [codResultadoEncuesta]       INT IDENTITY (1, 1) NOT NULL,
    [puntajeCaracteristicaCombo] INT NULL,
    [codEncuesta]                INT NULL,
    [codMedioComunicacion]       INT NULL,
    CONSTRAINT [PK_tb_resultadoEncuesta] PRIMARY KEY CLUSTERED ([codResultadoEncuesta] ASC)
);

