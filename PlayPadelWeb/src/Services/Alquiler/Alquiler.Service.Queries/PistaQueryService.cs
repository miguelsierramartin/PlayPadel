using Alquiler.Persistence.Database;
using Alquiler.Service.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Service.Queries
{
   
        public interface IPistaQueryService
        {
            Task<DataCollection<PistaDto>> GetAllAsync(int page, int take, IEnumerable<int> clients = null);
            Task<PistaDto> GetAsync(int id);
        }

        public class PistaQueryService : IPistaQueryService
        {
            private readonly ApplicationDbContext _context;

            public PistaQueryService(
                ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<DataCollection<PistaDto>> GetAllAsync(int page, int take, IEnumerable<int> pistas = null)
            {
                var collection = await _context.Pistas
                    .Where(x => pistas == null || pistas.Contains(x.PistaID))
                    .OrderBy(x => x.Nombre)
                    .GetPagedAsync(page, take);

                return collection.MapTo<DataCollection<PistaDto>>();
            }

            public async Task<PistaDto> GetAsync(int id)
            {
                return (await _context.Pistas.SingleAsync(x => x.PistaID == id)).MapTo<PistaDto>();
            }
        }
    }
