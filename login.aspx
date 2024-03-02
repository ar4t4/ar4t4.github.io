<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="asif_portfolio.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }

        .container {
            width: 300px;
            margin: 0 auto;
            margin-top: 100px;
            background-color: #fff;
            border-radius: 5px;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group span {
            display: block;
            margin-bottom: 5px;
        }

        .form-group input[type="text"],
        .form-group input[type="password"] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
        }

        .btn-login {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: #fff;
            border-radius: 3px;
            cursor: pointer;
            transition: background-color 0.3s;
            margin-left: 0px;
        }

        .btn-login:hover {
            background-color: #0056b3;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h2>Login Page</h2>
        <div class="form-group">
            <span>Username:</span>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <span>Password:</span>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-login" OnClick="btnLogin_Click" />
        </div>
    </div>
    </form>
</body>
</html>
