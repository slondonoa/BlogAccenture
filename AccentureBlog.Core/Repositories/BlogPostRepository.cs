using AccentureBlog.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureBlog.Core.Repositories
{
	/// <summary>
    /// Clase para acceso a datos 
    /// </summary>
    public class BlogPostRepository
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
                using (var db = new AccentureBlogEntities())
                {
                    db.BlogPosts.Add(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
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
            using (var db = new AccentureBlogEntities())
            {
                return db.BlogPosts.ToList();
            }

        }

    }
}
