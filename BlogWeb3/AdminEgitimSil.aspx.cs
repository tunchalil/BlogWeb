﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.EgitimTableAdapter dt = new DataSet1TableAdapters.EgitimTableAdapter();

            dt.EgitimSil(Convert.ToInt16(id));

            Response.Redirect("AdminEgitim.aspx");

        }
    }
}