using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class capnhatv2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
        {

        }

        protected void FormView1_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            FileUpload file = (FileUpload)FormView1.FindControl("FileUpload1");
            String path = Server.MapPath("~/img/");
            file.PostedFile.SaveAs(path + file.FileName);

            SqlDataSource1.UpdateParameters["anh"].DefaultValue = file.FileName;
        }
    }
}