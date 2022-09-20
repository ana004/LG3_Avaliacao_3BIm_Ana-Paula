namespace MvcRazorViews.ViewModels;

public class SiteViewModel 
{
    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome {  get; set; }
    public string Descricao { get; set; }
    public string Tipo { get; set; }
    public string Email { get; set; }

    public SiteViewModel(int id, string nome, string piso, string descricao, string tipo, string email)
    {
        Id = id;
        Nome = nome;
        Piso = piso;
        Descricao = descricao;
        Tipo = tipo;
        Email = email;
    }
}
