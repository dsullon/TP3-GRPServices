CREATE TABLE [GRP].[tb_detalleSolicitudRetiro] (
    [codSolicitudRetiro] BIGINT          NOT NULL,
    [codCombo]           BIGINT          NOT NULL,
    [montoActual]        DECIMAL (10, 2) NOT NULL,
    [montoNuevo]         DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([codSolicitudRetiro] ASC, [codCombo] ASC),
    CONSTRAINT [FK_SolicitudRetiro] FOREIGN KEY ([codSolicitudRetiro]) REFERENCES [GRP].[tb_solicitudRetiro] ([codSolicitudRetiro]),
    CONSTRAINT [FK_SolicitudRetiro_Combo] FOREIGN KEY ([codCombo]) REFERENCES [GRP].[tb_combo] ([codCombo])
);

