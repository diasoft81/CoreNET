<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tester.aspx.cs" Inherits="Tester" %>

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
    Width="700" Height="500" X="50" Y="50" Padding="10" Resizable="true" Closable="false"
    Layout="Fit">
    <Items>
      <ext:TabPanel ID="TabPanel1" runat="server">
        <Items>
          <ext:FormPanel ID="FormPanel" runat="server" Title="Testing" Margins="5 5 5 5"
            Padding="5">
            <Items>
              <ext:ComboBox ID="combobox1" runat="server" FieldLabel="Operation" AnchorHorizontal="100%">
                <Items>
                  <ext:ListItem Text="Checking Null Menu IDs" Value="IDS" />
                  <ext:ListItem Text="Creating Object" Value="OBJ" />
                </Items>
              </ext:ComboBox>
              <ext:TextArea ID="TextArea1" runat="server" FieldLabel="Text" Text="" AnchorHorizontal="100%" Height="300"/>
              <ext:Button ID="button1" Text="Process" Icon="ApplicationGo" runat="server">
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
