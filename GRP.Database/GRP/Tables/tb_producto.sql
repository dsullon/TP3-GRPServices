CREATE TABLE [GRP].[tb_producto] (
    [codProducto] BIGINT          NOT NULL IDENTITY(1,1),
    [umbralCosto] DECIMAL (10, 2) NULL,
    [elaboracion] VARCHAR (MAX)   NOT NULL,
    [estado]      BIT             NULL,
    [precio]      DECIMAL (10, 2) NULL,
    [costo]       DECIMAL (10, 2) NULL,
    [nombre]      VARCHAR (40)    NOT NULL,
    [porciones] INT NULL DEFAULT 1, 
    [codCategoria] INT NULL, 
    PRIMARY KEY CLUSTERED ([codProducto] ASC)
);

