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

public partial class Encoder : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!Page.IsPostBack)
    {
      try
      {
        //CoreNET.Common.Base.GlobalAsp.BuildDao();
        txtUserKey.Text = GlobalExt.GetSessionKey();
        //Application[GlobalAsp.DAO] = "1";
        //MasterAppConstants.Instance.StatusTesting = false;
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message + " at " + ex.StackTrace);
      }
    }
  }
  protected void Button_1Click(object sender, EventArgs args)
  {
    /*@TODO Pastikan dilog yaa*/
    if (sender == btnLogin)
    {
      try
      {
        string key = txtUserKey.Text;
        GlobalExt.SetSessionUser(MasterAppConstants.Instance.MasterAppID, key);//"LTQgXGd0FEFQGQLB1LXaKg=="
        X.Msg.Alert(ConstantDictExt.Translate(GlobalExt.LBL_INFO), "User key anda berhasil...").Show();
      }
      catch (Exception ex)
      {
        X.Msg.Alert("Information", "Eror : " + ex.Message).Show();
      }
    }
    else if (sender == btnEncrypt)
    {
      try
      {
        switch (combobox1.Text)
        {
          case "EN":
            textfield2.Text = GlobalAsp.EncryptCSPublished(textfield1.Text, textKey1.Text);
            break;
        }
      }
      catch (Exception ex)
      {
        X.Msg.Alert(ConstantDictExt.Translate(GlobalExt.LBL_INFO), ex.Message).Show();
      }
    }
    else if (sender == btnEncrypt2)
    {
      try
      {
        if (ValidateServer(txtServer.Text))
        {
          string cs_template = @"data source={0};Initial Catalog={1};user id={2};password={3};Asynchronous Processing=true";
          string cs = string.Format(cs_template, txtServer.Text, txtDB.Text, txtUser.Text, txtPassword.Text);
          txtCS.Text = GlobalAsp.EncryptCSPublished(cs, textKey2.Text);
        }
      }
      catch (Exception ex)
      {
        X.Msg.Alert(ConstantDictExt.Translate(GlobalExt.LBL_INFO), ex.Message).Show();
      }
    }
  }

  private bool ValidateServer(string server)
  {
    bool valid = false;
    valid = !server.Equals(".") && !server.ToLower().Equals("localhost");
    if (!valid)
    {
      throw new Exception("Data Source Name is not valid. Use your SQL Server Instance.");
    }
    return true;
    throw new NotImplementedException();
  }
}