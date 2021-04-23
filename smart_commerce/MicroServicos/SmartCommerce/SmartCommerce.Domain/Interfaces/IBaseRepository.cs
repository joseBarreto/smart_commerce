using SmartCommerce.Domain.Entities;
using System.Collections.Generic;

namespace SmartCommerce.Domain.Interfaces
{
    /// <summary>
    /// Base para entidades
    /// </summary>
    /// <typeparam name="TEntity">Entidade herdada de BaseEntity</typeparam>
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Insere um novo registro
        /// </summary>
        /// <param name="obj">obj para inserção</param>
        void Insert(TEntity obj);

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="obj">obj para atualização</param>
        void Update(TEntity obj);

        /// <summary>
        /// Remove um registro
        /// </summary>
        /// <param name="id">identificador do registro</param>
        void Delete(int id);

        /// <summary>
        /// Procura uma lista de registros
        /// </summary>
        /// <returns>Lista dos registros</returns>
        IList<TEntity> Select();

        /// <summary>
        /// Procura um registro
        /// </summary>
        /// <param name="id">Identificador do registro</param>
        /// <returns></returns>
        TEntity Select(int id);
    }
}
