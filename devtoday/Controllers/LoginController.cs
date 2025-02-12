using Microsoft.AspNetCore.Mvc;

namespace devtoday.Controllers;

public class LoginController: Controller {
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger) {
        _logger = logger;
    }

    public IActionResult Index() {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(string username, string password)
    {
       if (username == "admin" && password == "admin") {
           return Redirect($"/Dashboard/Index");
       }
       
       return View("Index");
       
    }
    
}