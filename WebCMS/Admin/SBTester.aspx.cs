using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Admin_SBTester : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    ServiceDataControlClient client = new ServiceDataControlClient();
    string data = client.GetData(1);
    CoreNET.Common.Services.Daftunits list = client.GetList(1);
    client.Close();

  }
}