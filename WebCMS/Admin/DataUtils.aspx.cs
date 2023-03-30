using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.HtmlControls;
using Ext.Net;
using Ext.Net.Utilities;
using System.Linq;
using System.Reflection;
using System.Text;
using CoreNET.Common.Base;
using CoreNET.Common.BO;

public partial class DataUtils : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!Page.IsPostBack)
    {

      //ConstantDictExt.SetInstanceNullForReloadDict();
      //DmtahunLookupControl.SetListDataNull();
      //SsappuserLookupControl.SetListDataNull();
      //SsconfiggroupLookupControl.SetListDataNull();
      //SsconfigparamsLookupControl.SetListDataNull();
      //SsmapclassLookupControl.SetListDataNull();
      //SsmaplookupclassLookupControl.SetListDataNull();
      //SswebuserLookupControl.SetListDataNull();

      try
      {
        CoreNET.Common.Base.GlobalAsp.BuildDao();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message + " at " + ex.StackTrace);
      }
      MasterAppConstants.Instance.StatusTesting = true;
      GlobalExt.SetSessionUser(MasterAppConstants.Instance.MasterAppID, "LTQgXGd0FEFQGQLB1LXaKg==");//user=tester, password=1, change every day :-D

      Response.Redirect("Page/PageTreeGrid.aspx?id=9922");
      //Load assembly CoreNET.Common.BO, tampilkan di combobox
      //Bikin combo box untuk mengetes semua
      //1.Kelengkapan property

    }
  }
}