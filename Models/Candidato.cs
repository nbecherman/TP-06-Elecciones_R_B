class Candidato
{
   public int IdCandidato{get; private set;}
   public int IdPartido{get; private set;}
    public string Apellido{get; private set;}
    public string Nombre{get; private set;}
    public DateTime FechaNacimiento{get; private set;}
    public string Foto{get; private set;}
    public string Postulacion{get; private set;}

     public Candidato(int idCandidato, int idPartido, string apellido,string nombre,DateTime fechaNacimiento,string foto,string postulacion )
    {
     IdCandidato = idCandidato;
     IdPartido=idPartido;
     Apellido = apellido;
     Nombre = nombre;
     FechaNacimiento = fechaNacimiento;
     Foto = foto;
     Postulacion=postulacion;
    }




}