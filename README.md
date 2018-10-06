# Razor Interfaces

This is a simple project to get up and running with Razor Pages. It defines
interfaces for the set of standard HTTP methods that you often have to
define for operational pages, like OnGet(), OnPostAsync(), etc. without
concern that you may have misspelled them.

Using this, you can declaratively specify what parameters these methods
accept, if any, and return an appropriate IActionResult:

    public class CustomerPage : PageModel
	                          , IPageGetAsync
							  , IPagePostAsync<Customer>
	{
		public IActionResult OnGet()
		{
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(Customer customer)
		{
			await DataLayer.Update(customer);
			return Page();
		}
	}

I welcome any requests for additional interfaces that may be useful. For
instance, I could define interfaces with multiple type parametersas well. I
think single parameter interfaces are probably the most common though.

# LICENSE

LGPL 2.1 is my go to license for C# libraries, since it lets you use it
in commercial programs unaltered, but if you alter it, you must share 
the love!
