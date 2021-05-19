﻿using Agili.Curso.EF.Models;
using System;
using Agili.Curso.EF.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.Helpers
{
    public static class PagedHelpers
    {
        public static ICollection<TEntity> GetPaged<TEntity>(this IQueryable<TEntity> query, int page, int limit) where TEntity : class, IEntityId
        {
            query = query.OrderBy(s => s.Id).Skip(page).Take(limit);
            return query.ToList();
        }

        //public static Expression<Func<Telefone, TelefoneDTO>> GetProjectionTelefones(this IEnumerable<Telefone> source)
        //{
        //    return source.AsQueryable().GetProjectionTelefone();

        //}
        public static Expression<Func<Telefone, TelefoneDTO>> GetProjectionTelefone()
        {
            return x => new TelefoneDTO()
            {
                Id = x.Id,
                Numero = x.Numero,
                TipoTelefone = x.TipoTelefone.Descricao
            };
        }
        public static Expression<Func<Telefone, TelefoneDTO>> GetProjectionTelefoneNao(this IEnumerable<Telefone> source)
        {
            return x => new TelefoneDTO()
            {
                Id = x.Id,
                Numero = x.Numero,
                TipoTelefone = x.TipoTelefone.Descricao
            };
        }
        public static Func<Telefone, TelefoneDTO> GetProjectionTelefoneColletion()
        {
            return x => new TelefoneDTO()
            {
                Id = x.Id,
                Numero = x.Numero,
                TipoTelefone = x.TipoTelefone.Descricao
            };
        }
    }
}
