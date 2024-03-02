<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="asif_portfolio.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin Dashboard</title>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Admin Dashboard</h1>
            <ul class="dashboard-links">
                <li>
                    <h4><asp:Button ID="btnManageUsers" runat="server" Text="Show Messages" OnClick="btnManageUsers_Click" BackColor="#3333FF" Height="48px" style="color: #FFFFFF; font-weight: 700; font-size: large" Width="246px" /></h4>
                </li>
                <li><asp:Button ID="btnViewStatistics" runat="server" Text="Edit Skills" OnClick="btnViewStatistics_Click" BackColor="#3333FF" Height="47px" style="font-size: large; color: #FFFFFF; font-weight: 700" Width="250px" /></li>
                <li>&nbsp;<asp:Button ID="btnEditContent" runat="server" Text="Edit About" OnClick="btnEditContent_Click" BackColor="#3333FF" Height="43px" style="font-size: large; color: #FFFFFF; font-weight: 700; margin-left: 0px" Width="252px" />
            </ul>
        </div>
    </form>
</body>
</html>
