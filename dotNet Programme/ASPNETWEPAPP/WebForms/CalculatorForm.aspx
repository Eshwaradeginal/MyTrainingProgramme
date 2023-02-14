<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorForm.aspx.cs" Inherits="ASPwebApps.CalculatorForm" %>

<!DOCTYPE html>
<html>
<head>
    <title>my first Calculator</title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            font-style: italic;
            font-size: xx-large;
            text-align: justify;
            background-color: #FFFFCC;
        }
        .auto-style2 {
            text-align: center;
            font-size: xx-large;
            font-weight: 700;
            background-color: #FFFFCC;
        }
        .auto-style3 {
            background-color: #FFFFCC;
        }
        .auto-style4 {
            text-align: center;
            background-color: #FFFFCC;
        }
        .auto-style5 {
            font-weight: bold;
            font-style: italic;
            text-align: center;
            font-size: xx-large;
            color: #FF9966;
            background-color: #FFFFCC;
        }
        .auto-style6 {
            color: #FF9966;
            background-color: #FFFFCC;
        }
    </style>
</head>
<body style="margin-left: 24px">
    <form id="form1" runat="server">
    <div>
        <h1 style="font-style: italic; background-color: #0066FF; font-size: xx-large;" class="auto-style4">My Calculator</h1>
    </div>
    <div>

        <p class="auto-style2" style="font-size: xx-large; background-color: #FFCCCC"><strong><span class="auto-style6">First Number  </span></strong>:<asp:TextBox   runat="server" ID="txtfirstNo" CssClass="auto-style5"></asp:TextBox> </p>
        <p class="auto-style2">
                <span class="auto-style3">Select the Option: 
                </span> 
                <asp:DropDownList runat="server" ID="dpList" CssClass="auto-style1">
                    <asp:ListItem Text="Add" />
                    <asp:ListItem Text="Subtract" />
                    <asp:ListItem Text="Multiply" />
                    <asp:ListItem Text="Divide" />
                </asp:DropDownList>
            </p>

        <p class="auto-style2"><span class="auto-style3">Second Number :</span><asp:TextBox  runat="server" ID="txtSecondNo" CssClass="auto-style1"></asp:TextBox> </p>
        <h1>
                <asp:Button Text="Get Result" runat="server" ID="btnResult" OnClick="btnResult_Click" CssClass="auto-style1" />
            </h1>
            <p class="auto-style2">
               <asp:Label Text="The Result: " ID="lblDisplay" runat="server" CssClass="auto-style1" />
            </p>

    </div>
    </form>
</body>
</html>
