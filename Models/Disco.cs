namespace TP03_schnaider.Models;

public class Disco{
    public string nombreDisco { get; private set; }
    public string nombreArtista { get; private set; }
    public List<string> listaTemas { get; private set; }
    public string nombreGenero { get; private set; }
    public string nombreProductor {get; private set;}
    public string id {get; private set;}
    public string foto {get; private set;}
    

    public Disco(string nombreDisco, string nombreArtista, List<string> listaTemas, string nombreGenero, string nombreProductor, string id, string foto){
        this.nombreDisco = nombreDisco;
        this.nombreArtista = nombreArtista;
        this.listaTemas = listaTemas;
        this.nombreGenero = nombreGenero;
        this.nombreProductor = nombreProductor;
        this.id = id;
        this.foto = foto;
    }
}