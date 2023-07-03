class Partido
{
    public int IdPartido{get; private set;}
    public string Nombre{get; private set;}
    public string Logo{get; private set;}
    public string SitioWeb{get; private set;}
    public DateTime FechaFundacion{get; private set;}
    public int CantidadDiputados{get; private set;}
    public int CantidadSenadores{get; private set;}

    public Partido( int idPartido,string nombre, string logo, string sitioWeb,DateTime fechaFundacion, int cantidadDiputados,int cantidadSenadores)
    {
     IdPartido=idPartido;
     Nombre = nombre;
     Logo = logo;
     SitioWeb = sitioWeb;
     FechaFundacion = fechaFundacion;
     CantidadDiputados = cantidadDiputados;
     CantidadSenadores = cantidadSenadores;
    }


}

