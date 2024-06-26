using Cleanarchiwithmediator.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarchiwithmediator.domain.repository
{
    public interface IBlog
    {
        Task<List<Blogs>> GetBlogs();
        Task<Blogs> GetBlogsById(int id);
        Task<Blogs> Create (Blogs blogs);
        Task<Blogs> Update (int id, Blogs blogs);
        Task<Blogs> Delete (int id);
    }
}
