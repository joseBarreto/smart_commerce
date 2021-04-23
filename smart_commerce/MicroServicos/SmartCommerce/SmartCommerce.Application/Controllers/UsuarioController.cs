using Microsoft.AspNetCore.Mvc;
using SmartCommerce.Domain.Entities;
using SmartCommerce.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCommerce.Application.Controllers
{
    /// <summary>
    /// Controle de usuários 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : BaseController
    {
        /// <summary>
        /// Serviço de Usuário
        /// </summary>
        private readonly IBaseService<Usuario> _baseUserService;

        /// <summary>
        /// Ctr
        /// </summary>
        /// <param name="baseUserService"></param>
        public UsuarioController(IBaseService<Usuario> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        /// <summary>
        /// Insere um novo registro
        /// </summary>
        /// <param name="user">Modelo para inserir</param>
        /// <returns>Id do obj</returns>
        [SwaggerResponse(200, "Ok", typeof(Usuario))]
        [SwaggerResponse(400, "Bad Request", typeof(string))]
        [HttpPost]
        public IActionResult Create([FromBody] Usuario user)
        {
            if (user == null)
                return NotFound();

            return Execute(() => _baseUserService.Add(user).Id);
        }

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="user">Usuario com Id para atualização</param>
        /// <returns>Modelo atualizado</returns>
        [SwaggerResponse(200, "Ok", typeof(Usuario))]
        [SwaggerResponse(400, "Bad Request", typeof(string))]
        [HttpPut]
        public IActionResult Update([FromBody] Usuario user)
        {
            if (user == null)
                return NotFound();

            return Execute(() => _baseUserService.Update(user));
        }

        /// <summary>
        /// Remove um registro 
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns></returns>
        [SwaggerResponse(204, "Ok")]
        [SwaggerResponse(400, "Bad Request", typeof(string))]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() =>
            {
                _baseUserService.Delete(id);
                return new NoContentResult();
            });
        }

        /// <summary>
        /// Retorna uma lista de registros
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(200, "Ok", typeof(IList<Usuario>))]
        [SwaggerResponse(400, "Bad Request", typeof(string))]
        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseUserService.Get());
        }

        /// <summary>
        /// Procura um registro por Id
        /// </summary>
        /// <param name="id">Identificador unico</param>
        /// <returns></returns>
        [SwaggerResponse(200, "Ok", typeof(Usuario))]
        [SwaggerResponse(400, "Bad Request", typeof(string))]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseUserService.GetById(id));
        }

    }
}
