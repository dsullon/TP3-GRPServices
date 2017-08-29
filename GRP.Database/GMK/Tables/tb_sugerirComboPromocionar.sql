CREATE TABLE [GMK].[tb_sugerirComboPromocionar] (
    [codSugerirComboPromocionar] INT           NOT NULL,
    [periodoInicial]             INT           NULL,
    [anioInicial]                INT           NULL,
    [periodoFinal]               INT           NULL,
    [aniofinal]                  INT           NULL,
    [primerPeriodo]              INT           NULL,
    [segundoPeriodo]             INT           NULL,
    [tercerPeriodo]              INT           NULL,
    [cuartoPeriodo]              INT           NULL,
    [observacionSugerencia]      NVARCHAR (50) NULL,
    [fechaRegistro]              DATE          NULL,
    CONSTRAINT [PK_tb_sugerirComboPromocionar] PRIMARY KEY CLUSTERED ([codSugerirComboPromocionar] ASC)
);

