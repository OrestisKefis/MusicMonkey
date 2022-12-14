using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService.Core.Repositories
{
    public interface IArtistRepository : IGenericRepository<Artist>
    {
        IEnumerable<Artist> GetArtistsWithEverything();
        Artist GetArtistByIdWithEverything(int? id);
    }
}
