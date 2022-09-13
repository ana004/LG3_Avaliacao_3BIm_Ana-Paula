using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;
namespace MvcRazorViews.Controllers;

public class AdminController : Controller 
{
  // private static List<ComercioViewModel> comercios = new List<ComercioViewModel>();
    private static List<SiteViewModel> comercios = new List<SiteViewModel>
    {
        new SiteViewModel(1, "Piso 1", "Cerâmica", "Aqui vende cerâmica", "Loja", "cer@gmial.com"),
        new SiteViewModel(2, "Piso 2", "Cerâmica2", "Aqui vende cerâmica2", "Loja2", "cer2@gmial.com"),
        new SiteViewModel(3, "Piso 3", "Cerâmica3", "Aqui vende cerâmica3", "Loja3", "cer4@gmial.com"),
        new SiteViewModel(4, "Piso 2", "Cerâmica2", "Aqui vende cerâmica2", "Loja2", "cer2@gmial.com")
    };

    public IActionResult Index()
    {
        return View(comercios);
    }
    
     public IActionResult Show(int id)
    {
        return View(comercios[id-1]);
    }

    public void Delete(int id)
    {
        comercios.RemoveAt(id-1);
    }

    public IActionResult Create([FromForm] int id, [FromForm] string nome, [FromForm] string piso, [FromForm] string descricao, [FromForm] string tipo, [FromForm] string email)
    {
        SiteViewModel novoComercio = new SiteViewModel(id, piso, nome, descricao, tipo, email);
        comercios.Add(novoComercio);
        return View();
    }

}