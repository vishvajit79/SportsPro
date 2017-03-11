<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="text-center">
        <br />
        <br />
        <p><strong>Customers</strong> - Search and view your customer contact information</p>
        <p>&nbsp;</p>
        <table class="table">
            <thead class="bg-inverse">
                <tr>
                    <td class="text-white">Select a customer:</td>
                    <td>
                        <asp:DropDownList ID="ddlCustomerNames" CssClass="btn btn-secondary dropdown-toggle text-primary" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Address:</td>
                    <td>
                        <asp:Label ID="lblAddress" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Phone:</td>
                    <td>
                        <asp:Label ID="lblPhone" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td>
                        <asp:Button CssClass="btn btn-outline-primary" ID="btnAddToContactList" runat="server" Text="Add to Contact List" OnClick="btnAddToContactList_Click" />
                    </td>
                    <td>
                        <asp:Button CssClass="btn btn-outline-info" ID="btnDisplayContactList" runat="server" Text="Display Contact List" OnClick="btnDisplayContactList_Click" />
                        <asp:Label ID="lblCustomerError" runat="server"></asp:Label>
                    </td>
                </tr>
            </tfoot>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
        <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
    </div>
</asp:Content>

