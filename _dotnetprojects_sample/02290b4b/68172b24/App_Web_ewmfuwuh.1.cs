#pragma checksum "D:\DOTNETProjects\Sample\Default.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "521850500FC8173951A960A9DB0FB2AD0220F0CE"

#line 1 "D:\DOTNETProjects\Sample\Default.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BL.Class1 obj = new BL.Class1();
        obj.Add(1, 7);

    }
}

#line default
#line hidden
