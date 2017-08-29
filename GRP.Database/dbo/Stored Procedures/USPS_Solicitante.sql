

-- DROP PROCEDURE [dbo].[USPS_Solicitante]
CREATE PROCEDURE [dbo].[USPS_Solicitante]
	@solId			int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	SELECT SL.ID AS IdSolicitud,
		   S.ID AS IdSolicitante,  
		   S.Nombres,
		   S.ApellidoPaterno, 
		   S.ApellidoMaterno,
		   S.NumeroDocumento,
		   S.TipoDocumentoId,
		   TD.Nombre as TipoDocumento,
		   SL.NumSolicitud,
		   TDSexo.Nombre as Sexo,
		   S.TituloObtenido,
		   S.MontoIngresosMes,
		   S.MontoGastosMes,
		   S.Cargo,
		   S.FechaNacimiento,
		   SL.MontoCapital
	FROM Solicitante S 
	INNER JOIN Solicitud SL on S.SolicitudId = SL.Id
	INNER JOIN Parametro TD on S.TipoDocumentoId = TD.Codigo and TD.CodigoGrupo = 5
	INNER JOIN Parametro TDSexo on S.SexoId = TDSexo.Codigo AND TDSexo.CodigoGrupo = 6
	WHERE S.id = @solId
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
