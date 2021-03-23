using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class galeria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sciezkaKatalog = Server.MapPath("obrazy");
        string[] pliki = System.IO.Directory.GetFiles(sciezkaKatalog);


        for (int i = 0; i < pliki.Length; i++)
        {
            Image im = new Image();
            im.ImageUrl ="obrazy/"+ System.IO.Path.GetFileName(pliki[i]);
            im.Width = 400;
            im.Height = 300;
            Panel1.Controls.Add(im);
            
            Label lb = new Label();
            //lb.Text = sciezkaKatalog;
            lb.Text ="<br />"+ pliki[i] + "<br/>";
            Panel1.Controls.Add(lb);
        }
    }
}