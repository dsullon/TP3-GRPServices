CREATE TABLE [GMK].[tb_medioComunicacion] (
    [codMedioComunicacion]           INT             IDENTITY (1, 1) NOT NULL,
    [nombreMedioComunicacion]        NVARCHAR (50)   NULL,
    [costoUnitarioMedioComunicacion] DECIMAL (10, 5) NULL,
    CONSTRAINT [PK_tb_medioComunicacion] PRIMARY KEY CLUSTERED ([codMedioComunicacion] ASC)
);

