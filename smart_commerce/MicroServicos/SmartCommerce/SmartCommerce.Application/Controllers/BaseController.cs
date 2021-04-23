using Microsoft.AspNetCore.Mvc;
using System;

namespace SmartCommerce.Application.Controllers
{
    /// <summary>
    /// Clase base das controllers
    /// </summary>
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// Executa uma function 
        /// </summary>
        /// <param name="func">função para execução</param>
        /// <returns>Ok para sucesso e BadRequest para erros</returns>
        protected IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
