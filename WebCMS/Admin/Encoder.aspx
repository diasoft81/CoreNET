<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Encoder.aspx.cs" Inherits="Encoder" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
  <ext:ResourceManager ID="ResourceManager1" runat="server" ShowWarningOnAjaxFailure="false" />
  <ext:Store ID="StoreTestProc" runat="server" />
  <ext:Window ID="FormWindow" runat="server" Title="Operation" CenterOnLoad="true"
    Width="500" Height="350" X="50" Y="50" Padding="10" Resizable="false" Closable="false"
    Layout="Fit">
    <Items>
      <ext:TabPanel ID="TabPanel1" runat="server">
        <Items>
          <ext:FormPanel ID="FormPanel2" runat="server" Title="User Key" Margins="5 5 5 5"
            Padding="5">
            <Items>
              <ext:TextField ID="txtUserKey" runat="server" FieldLabel="User Key" AnchorHorizontal="100%" />
              <ext:Button ID="btnLogin" Text="Authenticate Key" Icon="ApplicationGo" runat="server">
                <DirectEvents>
                  <Click OnEvent="Button_1Click" />
                </DirectEvents>
              </ext:Button>
            </Items>
          </ext:FormPanel>
          <ext:FormPanel ID="FormPanel" runat="server" Title="Encryption" Margins="5 5 5 5"
            Padding="5" Hidden="true">
            <Items>
              <ext:ComboBox ID="combobox1" runat="server" FieldLabel="Operation" AnchorHorizontal="100%">
                <Items>
                  <ext:ListItem Text="Encryption" Value="EN" />
                  <ext:ListItem Text="Other" Value="OT" />
                </Items>
              </ext:ComboBox>
              <ext:TextField ID="textKey1" runat="server" FieldLabel="Key" AnchorHorizontal="100%" />
              <ext:TextField ID="textfield1" runat="server" FieldLabel="Input" AnchorHorizontal="100%" />
              <ext:TextField ID="textfield2" runat="server" FieldLabel="Output" AnchorHorizontal="100%" />
              <ext:Button ID="btnEncrypt" Text="Encrypt" Icon="ApplicationGo" runat="server">
                <DirectEvents>
                  <Click OnEvent="Button_1Click" />
                </DirectEvents>
              </ext:Button>
            </Items>
          </ext:FormPanel>
          <ext:FormPanel ID="FormPanel1" runat="server" Title="Connection String" Margins="5 5 5 5"
            Padding="5">
            <Items>
              <ext:TextField ID="textKey2" runat="server" FieldLabel="Key" AnchorHorizontal="100%" />
              <ext:TextField ID="txtServer" runat="server" FieldLabel="Server" Text="HY-NB" AnchorHorizontal="100%" />
              <ext:TextField ID="txtDB" runat="server" FieldLabel="DB" Text="SIPD" AnchorHorizontal="100%" />
              <ext:TextField ID="txtUser" runat="server" FieldLabel="User" Text="sa" AnchorHorizontal="100%" />
              <ext:TextField ID="txtPassword" runat="server" FieldLabel="Password" Text="password123!"
                AnchorHorizontal="100%" />
              <ext:TextArea ID="txtCS" runat="server" FieldLabel="Text" Text="" AnchorHorizontal="100%" />
              <ext:Button ID="btnEncrypt2" Text="Encrypt" Icon="ApplicationGo" runat="server">
                <DirectEvents>
                  <Click OnEvent="Button_1Click" />
                </DirectEvents>
              </ext:Button>
            </Items>
          </ext:FormPanel>
        </Items>
      </ext:TabPanel>
    </Items>
  </ext:Window>
  </form>
</body>
</html>
