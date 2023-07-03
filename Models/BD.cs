using System.Data.SqlClient;
using Dapper;

namespace TPElecciones.Models;

public class BD
{    
public static string _connectionString = @"A-PHZ2-CIDI-049=localhost; 
Elecciones2023 = NombreBase;Trusted_Connection=True;";

public static void AgregarCandidato(Candidato can) 
    {
     Candidato Candidato = null;
     string sql = "INSERT INTO Candidato(IdCandidato,IdPartido,Apellido,Nombre,FechaNacimiento,Foto,Postulacion) VALUES(@cIdCandidato,@cIdPartido,@cApellido,@cNombre,@cFechaNacimiento,@cFoto,@cPostulacion)";
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
     db.Execute(sql, new {cIdCandidato = Candidato.IdCandidato, cIdPartido = Candidato.IdPartido, cApellido = Candidato.Apellido, cNombre = Candidato.Nombre, cFechaNacimiento=Candidato.FechaNacimiento, cFoto = Candidato.Foto, cPostulacion = Candidato.Postulacion});
     } 
    } 
public static int EliminarCandidato(int idCandidato)
    {
        int candidatosEliminados = 0;
        string sql = "DELETE FROM Candidato WHERE idCandidato = @idCandidato";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            candidatosEliminados=db.Execute(sql, new {IdCandidato = idCandidato});
        }
        return candidatosEliminados;
    }
public static Partido VerInfoPartido(int idPartido) 
  {
    Partido InfoPartido = null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sql="SELECT * FROM Partido WHERE idPartido = @IdPartido";
        InfoPartido = db.QueryFirstOrDefault<Partido>(sql, new {IdPartido = idPartido});
     }
     return InfoPartido;
  }
public static Candidato VerInfoCandidato(int idPartido) 
  {
    Candidato InfoCandidato = null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sql="SELECT * FROM Candidato WHERE idPartido = @IdPartido";
        InfoCandidato = db.QueryFirstOrDefault<Candidato>(sql, new {IdPartido = idPartido});
     }
     return InfoCandidato;
  }
public static List<Partido> ListarPartidos()
 {
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
     string sql = "SELECT * FROM Partido";
     _ListadoPartidos = db.Query<Partido>(sql).ToList(); 
    }
    return _ListadoPartidos;
 }
public static List<Candidato> ListarCandidatos(int idPartido)
{
 using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Candidatos WHERE idPartido = @IdPartido ";
        List<Candidato> _ListadoCandidatos = db.Query<Candidato>(sql, new {IdPartido = idPartido }).ToList();
    }
    return _ListadoCandidatos;

    //error ya que no existe listas de partido y candidatos. TMB hay algo en los nulls
}


}
