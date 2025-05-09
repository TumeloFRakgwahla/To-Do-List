using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoListApp.Data;
using TodoListApp.Models;

namespace TodoListApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TodoContext _context;
        public IndexModel(TodoContext context)
        {
            _context = context;
        }

        public List<Todo> Todos { get; set; } = new();

        [BindProperty]
        public Todo NewTodo { get; set; }

        public void OnGet()
        {
            Todos = _context.Todos.ToList();
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrWhiteSpace(NewTodo.Title))
            {
                _context.Todos.Add(NewTodo);
                _context.SaveChanges();
            }

            return RedirectToPage();
        }

    }
}
