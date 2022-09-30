﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService.Core.Repositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        IEnumerable<Genre> GetGenresWithEverything();
        IEnumerable<object> GetGenres();
    }
}
