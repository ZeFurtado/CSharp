using System.Data.SqlTypes;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorSql.Pages;

public class CiclosModel : PageModel
{
    private readonly AppDbContext _context;

    public CiclosModel(AppDbContext context)
    {
        _context = context;
    }

    public required IList<Ciclos> Ciclos { get; set; }

    public async Task OnGetAsync()
    {
        Ciclos = await _context.Ciclos.ToListAsync();
        
    }
}       