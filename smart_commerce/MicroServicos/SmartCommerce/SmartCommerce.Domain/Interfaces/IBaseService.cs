using SmartCommerce.Domain.Entities;
using System.Collections.Generic;

namespace SmartCommerce.Domain.Interfaces
{
    /// <summary>
    /// Base para os services 
    /// </summary>
    /// <typeparam name="TEntity">Entidade herdada de BaseEntity</typeparam>
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Insere um novo registro
        /// </summary>
        /// <param name="obj">obj para inserção</param>
        /// <returns>Um obj salvo com Id</returns>
        TEntity Add(TEntity obj);

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="obj">obj para atualização</param>
        TEntity Update(TEntity obj);

        /// <summary>
        /// Remove um registro
        /// </summary>
        /// <param name="id">identificador do registro</param>
        void Delete(int id);

        /// <summary>
        /// Procura uma lista de registros
        /// </summary>
        /// <returns>Lista dos registros</returns>
        IList<TEntity> Get();

        /// <summary>
        /// Procura um registro
        /// </summary>
        /// <param name="id">Identificador do registro</param>
        /// <returns></returns>
        TEntity GetById(int id);
    }
}
