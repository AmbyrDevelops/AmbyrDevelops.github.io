using AmbyrDevelops.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbyrDevelops.Interfaces
{
    public interface IPageRepository
    {
        public Task<IEnumerable<PageDTO>> GetPageSectionsAsync();
        public Task<string> AddPageSection(PageDTO pageSection);
    }
}
