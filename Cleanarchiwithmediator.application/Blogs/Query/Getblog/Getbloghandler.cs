using Cleanarchiwithmediator.domain.repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarchiwithmediator.application.Blogs.Query.Getblog
{
    public class Getbloghandler : IRequestHandler<Blogquery, List<Blogdto>>

    {
        private readonly IBlog _Iblog;
        public Getbloghandler(IBlog iblogR)
        {
            _Iblog = iblogR;
        }

        public async Task<List<Blogdto>> Handle(Blogquery request, CancellationToken cancellationToken)
        {
           var blogs = await _Iblog.GetBlogs();
            var bloglist= blogs.Select(x => new Blogdto { Author=x.author, Description=x.Description, Id=x.Id, Name=x.Name}).ToList();

            return bloglist;
        }
    }
}
