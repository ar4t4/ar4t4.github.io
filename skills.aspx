<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="skills.aspx.cs" Inherits="asif_portfolio.skills" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 419px;
            height: 206px;
            font-size: x-large;
        }
        .auto-style2 {
            color: #FFFFFF;
            margin-left: 17px;
        }
        .auto-style3 {
            height: 228px;
            width: 773px;
            margin-left: 492px;
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style6 {
            color: #FFFFFF;
            margin-left: 303px;
        }
        .auto-style7 {
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div class="auto-style1">
            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Edit Codeforces Rating<br />
            <br />
            <br />
            New rating&nbsp;&nbsp; <asp:TextBox ID="t1" runat="server" Height="28px" Width="112px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn1" runat="server" BackColor="#33CC33" CssClass="auto-style2" OnClick="btn1_Click" Text="Save" Width="63px" />
            </strong>
        </div>
        <div class="auto-style3">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><span class="auto-style4">&nbsp;Edit projects Number<br />
            <br />
            </span><span class="auto-style5">Frontend projects </span>
            <asp:TextBox ID="t2" runat="server" Height="25px" Width="133px"></asp:TextBox>
            <span class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style5">&nbsp; Backend Projects </span><span class="auto-style4">
            <asp:TextBox ID="t3" runat="server" Height="24px" Width="132px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn2" runat="server" BackColor="#66FF66" CssClass="auto-style7" OnClick="Btn2_Click" Text="Save" Width="65px" />
            <asp:Button ID="btn3" runat="server" BackColor="#66FF33" CssClass="auto-style6" OnClick="btn3_Click" Text="Save" Width="49px" />
            <br />
&nbsp;&nbsp; </span></strong>
        </div>
    </form>
</body>
</html>
