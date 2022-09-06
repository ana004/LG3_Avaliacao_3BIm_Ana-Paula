using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;
namespace MvcRazorViews.Controllers;

public class SiteController : Controller{
    // private static List<ComercioViewModel> comercios = new List<ComercioViewModel>();
    private static List<SiteViewModel> comercios = new List<SiteViewModel>
    {
        new SiteViewModel(1, "Piso 1", "Cerâmica", "Aqui vende cerâmica", "Loja", "cer@gmial.com"),
        new SiteViewModel(12, "Piso 1", "Cerâmica", "Aqui vende cerâmica", "Loja", "cer@gmial.com")
    };

    public IActionResult Index()
    {
        return View(comercios);
    }
}