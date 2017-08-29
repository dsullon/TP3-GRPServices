CREATE TABLE [GMK].[tb_combo] (
    [codCombo]          INT             NOT NULL,
    [nombreCombo]       NVARCHAR (50)   NULL,
    [descripcionCombo]  NVARCHAR (50)   NULL,
    [precioCombo]       DECIMAL (10, 5) NULL,
    [descuentoCombo]    DECIMAL (10, 5) NULL,
    [estadoCombo]       CHAR (10)       NULL,
    [categoriaCombo]    NVARCHAR (50)   NULL,
    [fechaCreacion]     DATE            NULL,
    [fechaModificacion] DATE            NULL,
    CONSTRAINT [PK_tb_combo] PRIMARY KEY CLUSTERED ([codCombo] ASC)
);

