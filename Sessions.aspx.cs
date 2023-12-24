using System;
using System.Data;
using System.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["BackgroundColor"] != null)
        {
            ColorSelector.SelectedValue = Session["BackgroundColor"].ToString();
            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
        }
    }

    protected void ColorSelector_IndexChanged(object sender, EventArgs e)
    {
        BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
        Session["BackgroundColor"] = ColorSelector.SelectedValue;
    }
}
