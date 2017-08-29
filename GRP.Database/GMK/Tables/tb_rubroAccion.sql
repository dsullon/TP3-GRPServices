CREATE TABLE [GMK].[tb_rubroAccion] (
    [codRubroAccion]        INT             NOT NULL,
    [nombreRubroAccion]     NVARCHAR (50)   NULL,
    [porcentajeImportancia] DECIMAL (10, 5) NULL,
    [costoPermitidoRubro]   DECIMAL (10, 5) NULL,
    [codObjetivo]           INT             NULL,
    CONSTRAINT [PK_tb_rubroAccion] PRIMARY KEY CLUSTERED ([codRubroAccion] ASC),
    CONSTRAINT [FK_tb_rubroAccion_tb_Objetivo] FOREIGN KEY ([codObjetivo]) REFERENCES [GMK].[tb_Objetivo] ([codObjetivo])
);

