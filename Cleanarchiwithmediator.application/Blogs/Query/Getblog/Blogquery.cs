using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarchiwithmediator.application.Blogs.Query.Getblog
{
    public record Blogquery : IRequest<List<Blogdto>>;

   
}
