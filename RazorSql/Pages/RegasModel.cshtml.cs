using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorSql.Pages;

public class RegasModel : PageModel
{
    private readonly AppDbContext _context;

    public RegasModel(AppDbContext context)
    {
        _context = context;
    }

    public required IList<Regas> Regas { get; set; }


    public async Task OnGetAsync()
    {
        Regas = await _context.Regas.ToListAsync();
    }
}