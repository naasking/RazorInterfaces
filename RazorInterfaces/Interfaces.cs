using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// The interface describing a parameterless Get request.
    /// </summary>
    public interface IPageGet
    {
        /// <summary>
        /// The method to Get a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnGet();
    }
	
    /// <summary>
    /// The interface describing a parameterless async Get request.
    /// </summary>
    public interface IPageGetAsync
    {
        /// <summary>
        /// The method to Get a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnGetAsync();
    }
	
    /// <summary>
    /// The interface describing an async Get request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Get request.</typeparam>
    public interface IPageGet<T>
    {
        /// <summary>
        /// The method to Get a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnGet(T value);
    }
	
    /// <summary>
    /// The interface describing an async Get request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Get request.</typeparam>
    public interface IPageGetAsync<T>
    {
        /// <summary>
        /// The method to Get a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnGetAsync(T value);
    }
    /// <summary>
    /// The interface describing a parameterless Post request.
    /// </summary>
    public interface IPagePost
    {
        /// <summary>
        /// The method to Post a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnPost();
    }
	
    /// <summary>
    /// The interface describing a parameterless async Post request.
    /// </summary>
    public interface IPagePostAsync
    {
        /// <summary>
        /// The method to Post a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnPostAsync();
    }
	
    /// <summary>
    /// The interface describing an async Post request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Post request.</typeparam>
    public interface IPagePost<T>
    {
        /// <summary>
        /// The method to Post a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnPost(T value);
    }
	
    /// <summary>
    /// The interface describing an async Post request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Post request.</typeparam>
    public interface IPagePostAsync<T>
    {
        /// <summary>
        /// The method to Post a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnPostAsync(T value);
    }
    /// <summary>
    /// The interface describing a parameterless Put request.
    /// </summary>
    public interface IPagePut
    {
        /// <summary>
        /// The method to Put a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnPut();
    }
	
    /// <summary>
    /// The interface describing a parameterless async Put request.
    /// </summary>
    public interface IPagePutAsync
    {
        /// <summary>
        /// The method to Put a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnPutAsync();
    }
	
    /// <summary>
    /// The interface describing an async Put request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Put request.</typeparam>
    public interface IPagePut<T>
    {
        /// <summary>
        /// The method to Put a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnPut(T value);
    }
	
    /// <summary>
    /// The interface describing an async Put request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Put request.</typeparam>
    public interface IPagePutAsync<T>
    {
        /// <summary>
        /// The method to Put a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnPutAsync(T value);
    }
    /// <summary>
    /// The interface describing a parameterless Delete request.
    /// </summary>
    public interface IPageDelete
    {
        /// <summary>
        /// The method to Delete a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnDelete();
    }
	
    /// <summary>
    /// The interface describing a parameterless async Delete request.
    /// </summary>
    public interface IPageDeleteAsync
    {
        /// <summary>
        /// The method to Delete a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnDeleteAsync();
    }
	
    /// <summary>
    /// The interface describing an async Delete request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Delete request.</typeparam>
    public interface IPageDelete<T>
    {
        /// <summary>
        /// The method to Delete a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnDelete(T value);
    }
	
    /// <summary>
    /// The interface describing an async Delete request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Delete request.</typeparam>
    public interface IPageDeleteAsync<T>
    {
        /// <summary>
        /// The method to Delete a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnDeleteAsync(T value);
    }
    /// <summary>
    /// The interface describing a parameterless Head request.
    /// </summary>
    public interface IPageHead
    {
        /// <summary>
        /// The method to Head a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnHead();
    }
	
    /// <summary>
    /// The interface describing a parameterless async Head request.
    /// </summary>
    public interface IPageHeadAsync
    {
        /// <summary>
        /// The method to Head a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnHeadAsync();
    }
	
    /// <summary>
    /// The interface describing an async Head request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Head request.</typeparam>
    public interface IPageHead<T>
    {
        /// <summary>
        /// The method to Head a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnHead(T value);
    }
	
    /// <summary>
    /// The interface describing an async Head request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Head request.</typeparam>
    public interface IPageHeadAsync<T>
    {
        /// <summary>
        /// The method to Head a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnHeadAsync(T value);
    }
    /// <summary>
    /// The interface describing a parameterless Options request.
    /// </summary>
    public interface IPageOptions
    {
        /// <summary>
        /// The method to Options a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnOptions();
    }
	
    /// <summary>
    /// The interface describing a parameterless async Options request.
    /// </summary>
    public interface IPageOptionsAsync
    {
        /// <summary>
        /// The method to Options a razor page.
        /// </summary>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnOptionsAsync();
    }
	
    /// <summary>
    /// The interface describing an async Options request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Options request.</typeparam>
    public interface IPageOptions<T>
    {
        /// <summary>
        /// The method to Options a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        IActionResult OnOptions(T value);
    }
	
    /// <summary>
    /// The interface describing an async Options request accepting a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the argument for the Options request.</typeparam>
    public interface IPageOptionsAsync<T>
    {
        /// <summary>
        /// The method to Options a razor page.
        /// </summary>
        /// <param name="value">The parameter to the method.</param>
        /// <returns>
        /// The routing directive from executing the method.
        /// </returns>
        Task<IActionResult> OnOptionsAsync(T value);
    }
}