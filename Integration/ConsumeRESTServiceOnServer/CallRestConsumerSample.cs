﻿using System;

public partial class CMSWebParts_TestWebParts_RestTest : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var consumer = new RESTConsumer();
        var userData = consumer.GetUsersFeed("http://localhost:80/", "RestClient", "secretpassword");
    }
}
