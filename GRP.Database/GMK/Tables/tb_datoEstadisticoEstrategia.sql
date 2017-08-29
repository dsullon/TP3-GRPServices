CREATE TABLE [GMK].[tb_datoEstadisticoEstrategia] (
    [codDatoEstEstrategia]        INT             NOT NULL,
    [nombreDatoEstEstrategia]     NVARCHAR (50)   NULL,
    [puntuacionDatoEstEstrategia] INT             NULL,
    [porcentajeDatoEstEstrategia] DECIMAL (10, 5) NULL,
    [codEstrategia]               INT             NULL,
    [codRubroEstrategia]          INT             NULL,
    CONSTRAINT [PK_tb_datoEstadisticoEstrategia] PRIMARY KEY CLUSTERED ([codDatoEstEstrategia] ASC),
    CONSTRAINT [FK_tb_datoEstadisticoEstrategia_tb_estrategia] FOREIGN KEY ([codEstrategia]) REFERENCES [GMK].[tb_estrategia] ([codEstrategia]),
    CONSTRAINT [FK_tb_datoEstadisticoEstrategia_tb_rubroEstrategia] FOREIGN KEY ([codRubroEstrategia]) REFERENCES [GMK].[tb_rubroEstrategia] ([codRubroEstrategia])
);

