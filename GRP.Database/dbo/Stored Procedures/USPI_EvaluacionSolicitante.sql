CREATE PROCEDURE [dbo].[USPI_EvaluacionSolicitante]
	@IdSolicitante int,
	@FueAprobado bit
AS
BEGIN
	
	UPDATE Solicitante SET FueAprobado = @FueAprobado
	WHERE Id = @IdSolicitante

END


