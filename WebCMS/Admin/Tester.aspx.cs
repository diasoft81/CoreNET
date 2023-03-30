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

public partial class Tester : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!Page.IsPostBack)
    {
      string typename = "CoreNET.Common.BO.Ss90dictionaryControl, CoreNET.Common.Sys";
      IDataControl dc = UtilityBO.Create(typename);

      ConstantDictExt.SetInstanceNullForReloadDict();
      //DmtahunLookupControl.SetListDataNull();
      //SsappuserLookupControl.SetListDataNull();
      //SsconfiggroupLookupControl.SetListDataNull();
      //SsconfigparamsLookupControl.SetListDataNull();
      //SsmapclassLookupControl.SetListDataNull();
      //SsmaplookupclassLookupControl.SetListDataNull();
      //SswebuserLookupControl.SetListDataNull();

      MasterAppConstants.Instance.StatusTesting = true;
      try
      {
        CoreNET.Common.Base.GlobalAsp.BuildDao();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message + " at " + ex.StackTrace);
      }
      //GlobalExt.SetSessionUser("LTQgXGd0FEFQGQLB1LXaKg==");//user=tester, password=1, change every day :-D

      //Response.Redirect("Page/PageTreeGrid.aspx?id=9922");
      //Load assembly CoreNET.Common.BO, tampilkan di combobox
      //Bikin combo box untuk mengetes semua
      //1.Kelengkapan property

    }
  }
  protected void Button_1Click(object sender, EventArgs args)
  {
    if (sender == button1)
    {
      //int counter = 0;
      TextArea1.Text = "Test " + combobox1.SelectedItem.Text + " starting at " + DateTime.Now.ToLongTimeString() + "\n";
      /*
      ViewmapmenuControl dc = new ViewmapmenuControl();
      List<ViewmapmenuControl> list = (List<ViewmapmenuControl>)dc.View(BaseDataControl.ALL);
      foreach (ViewmapmenuControl ctrl in list)
      {
        ++counter;
        string cname = ctrl.Mcolist1;
        switch (combobox1.Text)
        {
          case "IDS":
            if (string.IsNullOrEmpty(cname))
            {
              TextArea1.Text += "\n" + counter + ". Class for id " + ctrl.Menuid + ", menu " + ctrl.Nmmenu + " is null \n";
            }
            break;
          case "OBJ":
            try
            {
              if (!string.IsNullOrEmpty(cname))
              {
                IDataControlUI newdc = UtilityUI.Create(cname);
                TextArea1.Text += "\n" + counter + ". Create " + cname + " success... \n";
                newdc.SetPageKey();
                newdc.SetFilterKey((BaseBO)GlobalExt.GetSessionUser());
                newdc.View();
                TextArea1.Text += "Execute " + cname + ".View(); success... \n";
              }
            }
            catch (Exception ex)
            {
              TextArea1.Text += "Testing" + cname + " failed because " + ex.Message + " : " + ex.StackTrace + " \n";
            }
            break;
        }
      }
      */
      TextArea1.Text += "Test " + combobox1.SelectedItem.Text + " finished at " + DateTime.Now.ToLongTimeString() + "\n";
    }

  }
}