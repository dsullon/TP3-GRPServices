CREATE TABLE [GMK].[tb_estrategia] (
    [codEstrategia]         INT           NOT NULL,
    [descripcionEstrategia] NVARCHAR (50) NULL,
    [fechaCumplimiento]     DATE          NULL,
    [estadoEstrategia]      NVARCHAR (50) NULL,
    [codObjetivo]           INT           NULL,
    CONSTRAINT [PK_tb_estrategia] PRIMARY KEY CLUSTERED ([codEstrategia] ASC),
    CONSTRAINT [FK_tb_estrategia_tb_Objetivo] FOREIGN KEY ([codObjetivo]) REFERENCES [GMK].[tb_Objetivo] ([codObjetivo])
);

