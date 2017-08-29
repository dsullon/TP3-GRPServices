
-- =============================================
-- Author:		Yussel Ulloa
-- Create date: 15/07/2017
-- Description:	lista las solicitudes por solicitante
-- =============================================
-- DROP PROCEDURE [dbo].[USPS_SolicitudXSolicitante]
CREATE PROCEDURE [dbo].[USPS_SolicitudXSolicitante]
	@solicitudId	int,
	@desc			varchar(100),
	@estado			int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	SET NOCOUNT ON;

	SELECT  SL.ID AS IdSolicitud,
			S.ID AS IdSolicitante, 
			SL.NumSolicitud,
			SL.FechaSolicitud,
			S.Nombres,
			S.ApellidoPaterno,
			S.ApellidoMaterno,
			S.Direccion,
			S.TipoDocumentoId,
			TD.Nombre as TipoDocumento,
			S.NumeroDocumento,
			SL.Estado as EstadoId,
			E.Nombre as Estado,
			S.Email
	FROM Solicitud SL
		INNER JOIN Solicitante S ON SL.Id = S.SolicitudId
		inner join Parametro E on SL.Estado = E.Codigo and E.CodigoGrupo = 3
		inner join Parametro TD on S.TipoDocumentoId = TD.Codigo and TD.CodigoGrupo = 5
	WHERE ((@solicitudId = -1 ) or (SL.Id = @solicitudId))
	AND ((@estado = -1 ) or (SL.Estado = @estado))
	AND ((@desc = '' ) or (SL.NumSolicitud like '%' + @desc + '%' or 
						  S.NumeroDocumento like '%' + @desc + '%' or 
						  S.Nombres like '%' + @desc + '%' or 
						  S.ApellidoPaterno like '%' + @desc + '%' or 
						  S.ApellidoMaterno like '%' + @desc + '%'))
	
	Set @coderr = 0
	Set @msgerr = 'OK'

END TRY
BEGIN CATCH
	DECLARE @mensajeError as varchar(4000)
	DECLARE @codSeveridad as int
	DECLARE @codStatus as int

	Select @mensajeError = ERROR_MESSAGE(),
		   @codSeveridad = ERROR_SEVERITY(),
		   @codStatus = ERROR_STATE()
	
	set @coderr = 1
	set @msgerr = @mensajeError

	-- RAISERROR(@mensajeError, @codSeveridad, @codStatus)
END CATCH


