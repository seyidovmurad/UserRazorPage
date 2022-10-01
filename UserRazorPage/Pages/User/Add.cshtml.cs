using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UserRazorPage.Data;
using UserRazorPage.Entities;

namespace UserRazorPage.Pages.Shared
{
    public class AddModel : PageModel
    {
        public Employee Employee { get; set; }

        private readonly WorkDbContext _context;

        public AddModel(WorkDbContext context)
        {
            _context = context;
        }


        public void OnGet(int id = 0)
        {
            Employee = _context.Employees.FirstOrDefault(e => e.Id == id) ?? new Employee();
        }


        public IActionResult OnPost(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id > 0)
                {
                    _context.Employees.Update(employee);
                }
                else
                {
                    _context.Employees.Add(employee);
                }
                _context.SaveChanges();
                return RedirectToPage("index");
            }
            return Page();

        }
    }
}
