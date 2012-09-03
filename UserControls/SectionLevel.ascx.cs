using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class UserControls_SectionLevel : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If SiteMap.CurrentNode is not null,
        // bind CurrentNode's ChildNodes to the GridView
        if (SiteMap.CurrentNode != null)
        {
            My_Nav.DataSource = SiteMap.CurrentNode.ChildNodes;
            My_Nav.DataBind();
        }
    }
}
