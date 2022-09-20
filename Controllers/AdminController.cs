using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;
namespace MvcRazorViews.Controllers;

public class AdminController : Controller 
{
//   private static List<SiteViewModel> comercios = new List<SiteViewModel>();
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

    public IActionResult SiteIndex()
    {
        return View(comercios);
    } 
    
     public IActionResult Show(int id)
    {
        int i = 0;
        foreach(var comercio in comercios)
        {
            if(comercio.Id == id)
                {
                    return View(comercios[i]);
                }
            ++i;
        }
         return View(comercios[i]);
    }

    public IActionResult Delete(int id)
    {
        int i = 0;
        foreach(var comercio in comercios)
        {
            if(comercio.Id == id)
                {
                    comercios.RemoveAt(i);
                    return RedirectToAction(nameof(Index));
                }
            ++i;
        }
        
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create([FromForm] string nome, [FromForm] string piso, [FromForm] string descricao, [FromForm] string tipo, [FromForm] string email)
    {
        comercioExistsByName(nome);
        int id = 4;
        id++;
        SiteViewModel novoComercio = new SiteViewModel(id, nome, piso, descricao, tipo, email);
        comercios.Add(novoComercio);
        return View();
    }

    private void comercioExistsByName(string name) 
    {    
        if(comercios.Any(e => e.Nome.Equals(name)))
            throw new Exception($"O nome {name} já existe");   
    }

}