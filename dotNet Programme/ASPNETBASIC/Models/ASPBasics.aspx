<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPBasics.aspx.cs" Inherits="ASPBASICS.Models.ASPBasics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>hello world</h1>
        </div>
        <hr />
        <div>
        </div>
        <div> </div>
        <div>  <asp:Button ID="btn" runat="server" OnClick="btn_Click" text="Submit"/>
        </div>
        <div>  <asp:Label ID="inpLabel" runat="server"></asp:Label></div>
    </form>
</body>
</html>
