CREATE TABLE [GRP].[tb_articulo] (
    [codArticulo]     BIGINT          NOT NULL IDENTITY(1,1),
    [nombre]          VARCHAR (120)   NULL,
    [descripcion]     VARCHAR (120)   NULL,
    [costoXUM]        DECIMAL (10, 2) NOT NULL,
    [codTipoArticulo] INT             NOT NULL,
    [unidadMedida]    VARCHAR (10)    NOT NULL,
    [estado]          BIT             NULL,
    [categoría]       VARCHAR (20)    NULL,
    PRIMARY KEY CLUSTERED ([codArticulo] ASC)
);