<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="asif_portfolio.dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    /* Reset some default styles */
    body, ul {
        margin: 0;
        padding: 0;
    }

    /* Global styles */
    body {
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
    }

    .container {
        max-width: 1200px;
        margin: 20px auto;
        padding: 20px;
        background-color: #fff;
        border-radius: 5px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }

    h1 {
        margin-bottom: 20px;
        color: #333;
        text-align: center;
    }

    .dashboard-links {
        list-style-type: none;
        margin: 0;
        padding: 0;
    }

    .dashboard-links li {
        margin-bottom: 10px;
        color: #FFFFFF;
    }

    .dashboard-links li button {
        display: block;
        padding: 10px 20px;
        background-color: #007bff;
        color: #fff;
        text-decoration: none;
        border: none;
        border-radius: 5px;
        cursor: pointer;
        transition: background-color 0.3s ease;
    }

    .dashboard-links li button:hover {
        background-color: #0056b3;
    }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 188px;
        }
        .auto-style3 {
            width: 188px;
            height: 201px;
        }
        .auto-style4 {
            height: 201px;
        }
        .auto-style5 {
            width: 188px;
            color: #FFFFFF;
            height: 34px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            color: #FFFFFF;
        }
        .auto-style8 {
            height: 34px;
        }
        .auto-style9 {
            width: 259px;
        }
        .auto-style10 {
            width: 265px;
        }
        .auto-style11 {
            width: 275px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="label1" runat="server" style="font-size: large; font-weight: 700; color: #0000FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#6600FF" Height="37px" OnClick="Button1_Click" style="font-size: medium; color: #FFFFFF" Text="Logout" />



        </div>
         <div class="container">
     <h1>Admin Dashboard</h1>
     <ul class="dashboard-links">
         <li>
             <h4 class="auto-style9"><asp:Button ID="btnManageUsers" runat="server" Text="Show Messages" OnClick="btnManageUsers_Click" BackColor="#3333FF" Height="48px" style="color: #FFFFFF; font-weight: 700; font-size: large" Width="252px" /></h4>
         </li>
         <li class="auto-style10">&nbsp;<asp:Button ID="btnViewStatistics" runat="server" Text="Edit Skills" OnClick="btnViewStatistics_Click" BackColor="#3333FF" Height="47px" style="font-size: large; color: #FFFFFF; font-weight: 700" Width="254px" CssClass="auto-style6" /></li>
         <li class="auto-style11">&nbsp;<asp:Button ID="btnEditContent" runat="server" Text="Edit About" OnClick="btnEditContent_Click" BackColor="#3333FF" Height="43px" style="font-size: large; color: #FFFFFF; font-weight: 700; margin-left: 0px" Width="252px" />
     </ul>
 </div>


        
    <div>

       
    &nbsp;&nbsp;
        <table cellpadding="4" cellspacing="4" class="auto-style1">
            <tr>
                <td class="auto-style5"><strong>
                    <asp:Label ID="Label2" runat="server" BackColor="#990099" Text="Change profile picture"></asp:Label>
                    </strong></td>
                <td class="auto-style8">
                    <asp:FileUpload ID="upfile" runat="server" CssClass="auto-style6" Width="186px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <strong>
                    <asp:HyperLink ID="hyperlink" runat="server" Visible="False">show Changes</asp:HyperLink>
                    </strong>
                </td>
                <td>
                    <asp:Button ID="upbtn" runat="server" OnClick="upbtn_Click" Text="upload" Width="73px" BackColor="#33CC33" CssClass="auto-style7" />
                    <asp:Label ID="lbl2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
        </table>

       
    </div>
        <div id="divEditAbout" runat="server" style="display: none;">
    <asp:TextBox ID="txtAboutContent" runat="server" TextMode="MultiLine" Rows="4" Columns="50"></asp:TextBox>
    <br />
    <asp:Button ID="btnSaveAbout" runat="server" Text="Save" OnClick="btnSaveAbout_Click" />
</div>
    </form>

    </body>
</html>
