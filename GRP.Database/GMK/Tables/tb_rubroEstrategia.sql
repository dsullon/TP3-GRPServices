CREATE TABLE [GMK].[tb_rubroEstrategia] (
    [codRubroEstrategia]    INT             NOT NULL,
    [nombreRubroEstrategia] NVARCHAR (50)   NULL,
    [porcentajeImportancia] DECIMAL (10, 5) NULL,
    [puntuacionEsperada]    INT             NULL,
    [codObjetivo]           INT             NULL,
    CONSTRAINT [PK_tb_rubroEstrategia] PRIMARY KEY CLUSTERED ([codRubroEstrategia] ASC),
    CONSTRAINT [FK_tb_rubroEstrategia_tb_Objetivo] FOREIGN KEY ([codObjetivo]) REFERENCES [GMK].[tb_Objetivo] ([codObjetivo])
);

