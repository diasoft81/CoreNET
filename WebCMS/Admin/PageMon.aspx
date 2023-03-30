<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageMon.aspx.cs" Inherits="Admin_PageMon" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <ext:resourcemanager id="ResourceManager1" runat="server" showwarningonajaxfailure="false" />
    <ext:window
      id="Window1"
      runat="server"
      title="Hello World!"
      icon="Application"
      height="185px"
      width="350px"
      bodystyle="background-color: #fff;"
      padding="5"
      collapsible="true"
      modal="true">
            <Content>
                This is my first <a target="_blank" href="http://www.ext.net/"> Ext.Net</a> Window.
            </Content>
        </ext:window>
  </form>
</body>
</html>
