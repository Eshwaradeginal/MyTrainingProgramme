<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductManage.aspx.cs" Inherits="SampleWebApp.Products" Trace="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <style type="text/css">
        .my-3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <h1 class="h1 text-danger">Product Database</h1>
    <hr />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                   <asp:ListBox runat="server">
       
    </asp:ListBox>
                </div>
                <div class="col-md-7">
                    <h2>Details of the Product</h2>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Image ID="imgPic" Height="253px" runat="server" Width="225px" />
                        </div>
                        <div class="col-md-4">
                            <p>Name: <asp:TextBox CssClass="form-control" runat="server" ID="txtName"/></p>
                            <p>Price: <asp:TextBox CssClass="form-control" runat="server" ID="txtPrice"/></p>
                            <p>Quantity: 
                                <asp:DropDownList CssClass="form-control" ID="dpQuantity" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                </asp:DropDownList>
                            </p>

                        </div>
                        <div class="col-md-2">
                            <asp:Button runat="server" CssClass="btn btn-info my-3"/>
                            <i class="fa fa-edit" />
                            <asp:Button Text="Delete" runat="server" CssClass="btn btn-danger my-3" />
                            <i class="fa fa-trash-o" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
