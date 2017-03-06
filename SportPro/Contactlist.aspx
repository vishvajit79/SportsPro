<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contactlist.aspx.cs" Inherits="Contactlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="text-center">
        <br />
        <br />
        <p><strong>Contact List</strong> - Manage your contact list</p>
        <p>
            <a href="Customers.aspx">Contact list:</a>
        </p>
        <table class="table">
            <tr>
                <td rowspan="2">
                    <asp:ListBox ID="lstCall" CssClass="btn btn-secondary text-muted" runat="server" Width="100%"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="Button1" CssClass="btn btn-outline-danger" runat="server" Text="Remove Contact" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" CssClass="btn btn-outline-warning" runat="server" Text="Empty List" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button3" CssClass="btn btn-outline-info" runat="server" Text="Select Additional Customers" OnClick="Button3_Click" />
        <br />
        <br />
    </div>
</asp:Content>

