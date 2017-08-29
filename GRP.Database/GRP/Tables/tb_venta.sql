CREATE TABLE [GRP].[tb_venta] (
    [codventa]   BIGINT          NOT NULL,
    [fechaVenta] DATETIME        NOT NULL,
    [monto]      DECIMAL (10, 2) NOT NULL,
    [igv]        DECIMAL (10, 2) NOT NULL,
    [montototal] DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([codventa] ASC)
);

