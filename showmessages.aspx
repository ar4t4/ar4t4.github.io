<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showmessages.aspx.cs" Inherits="asif_portfolio.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #00CC00;
        }
        .action-button {
    background-color: red;
    color: white;
    padding: 5px 10px;
    border: none;
    border-radius: 3px;
    cursor: pointer;
}

.action-button.reply {
    background-color: green;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1">&nbsp;Messages</span></h1>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="172px" style="margin-bottom: 6px" Width="1222px" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="message">
                <Columns>
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Subject" HeaderText="Subject" />
                    <asp:BoundField DataField="Message" HeaderText="Message" />
                    <asp:BoundField DataField="Date" HeaderText="Date" />
                     <asp:TemplateField HeaderText="Actions">
            <ItemTemplate>
                <asp:Button runat="server" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this row?');" CssClass="action-button" />
                 <asp:Button runat="server" CommandName="Reply" Text="Reply" OnClick="ReplyButton_Click" CssClass="action-button reply" />
            </ItemTemplate>
        </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
