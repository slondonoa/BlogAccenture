using AccentureBlog.Core.Model;
using AccentureBlog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureBlog.Core.Services
{
    /// <summary>
    /// Clase intermedia entre la logica de negocio y la base de datos 
    /// </summary>
    public class BlogPostService
    {
        /// <summary>
        /// Metodo para guardar un nuevo post
        /// </summary>
        /// <param name="model">Modelo tipo BlogPost</param>
        /// <returns>bool</returns>
        public bool SavePost(BlogPost model)
        {
            try
            {
                BlogPostRepository _repo = new BlogPostRepository();
                _repo.SavePost(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Metodo para obtener todos los post creados 
        /// </summary>
        /// <returns></returns>
        public List<BlogPost> GetAllPosts()
        {
            BlogPostRepository _repo = new BlogPostRepository();
            return _repo.GetAllPosts();
        }

    }
}
