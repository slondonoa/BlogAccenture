using AccentureBlog.Core.Model;
using AccentureBlog.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccentureBLog.UI.Forms
{
    public partial class Posts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BlogPostService _service = new BlogPostService();
            List<BlogPost> lstPosts = new List<BlogPost>();
            lstPosts = _service.GetAllPosts();
            gvPosts.DataSource = lstPosts;
            gvPosts.DataBind();



        }
    }
}