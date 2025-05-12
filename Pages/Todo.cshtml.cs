using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoListApp.Data;
using TodoListApp.Models;

namespace TodoListApp.Pages
{
    public class TodoModel : PageModel
    {
        private readonly TodoContext _context;
        public TodoModel(TodoContext context)
        {
            _context = context;
        }

        public List<Todo> Todos { get; set; } = new();

        [BindProperty]
        public Todo NewTodo { get; set; } = new();

        public async Task OnGetAsync()
        {
            Todos = await _context.Todos.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!string.IsNullOrWhiteSpace(NewTodo.Title))
            {
                _context.Todos.Add(NewTodo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostToggleAsync(int id, bool isDone)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo != null)
            {
                todo.IsDone = isDone;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostClearAllAsync()
        {
            _context.Todos.RemoveRange(_context.Todos);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
 
}
}