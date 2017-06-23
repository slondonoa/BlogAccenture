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
    public partial class NewPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BlogPostService _service = new BlogPostService();
                BlogPost _post = new BlogPost
                {
                    Title = txtTitle.Value,
                    PostContent = txtContent.Value,
                    Author = txtAuthor.Value,
                    DatePost = DateTime.Now
                };
                var result = _service.SavePost(_post);
                if (result)
                {
                    ShowMessage("Post creado correctament");
                    txtTitle.Value = string.Empty;
                    txtContent.Value = string.Empty;
                    txtAuthor.Value = string.Empty;

                }

            }
            catch (Exception ex)
            {

                ShowMessage(ex.Message);
            }
        }

        private void ShowMessage(string message)
        {
            txtMessage.Text = message;
            string script = "$('#myModal').modal()";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "invocarfuncion", script, true);

        }
    }
}