using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorSql.Pages;

public class PlantasModel : PageModel
{ 
    private readonly AppDbContext _context;

    public PlantasModel(AppDbContext context)
    {
        _context = context;
    }

    public required IList<Plantas> Plantas { get; set; }

    
    public async Task OnGetAsync()
    {
        Plantas = await _context.Plantas.ToListAsync();
    }
}