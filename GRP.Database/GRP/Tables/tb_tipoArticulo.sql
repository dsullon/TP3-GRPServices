CREATE TABLE [GRP].[tb_tipoArticulo] (
    [codTipoArticulo] INT             IDENTITY (1, 1) NOT NULL,
    [nombre]          VARCHAR (120)   NULL,
    [descripcion]     VARCHAR (120)   NULL,
    [costoXUM]        DECIMAL (10, 2) NOT NULL,
    [tipoArticulo]    VARCHAR (35)    NOT NULL,
    [unidadMedida]    VARCHAR (10)    NOT NULL,
    CONSTRAINT [PK__tb_tipoA__BB3C9F93A07D551F] PRIMARY KEY CLUSTERED ([codTipoArticulo] ASC)
);

