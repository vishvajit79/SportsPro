<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Survey_Page.aspx.cs" Inherits="Survey_Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="text-center">
        <br />
        <br />
        <p><strong>Surveys</strong> - Collect feedback from customers</p>
        <br />
        <p class="text-muted">
            Enter your customer ID:<asp:TextBox CssClass="form-control" ID="txtCustomerID" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustomerID" Display="Dynamic" ErrorMessage="Customer Id is required." CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtCustomerID" Display="Dynamic" ErrorMessage="Customer id must be integer" Operator="DataTypeCheck" Type="Integer" CssClass="text-danger"></asp:CompareValidator>
            <asp:Label ID="lblInvalid" runat="server" Enabled="False" Text="Invalid customer id is entered or it doesn't have any closed incidents" CssClass="text-danger"></asp:Label>
            <br />
            <asp:Button ID="Button4" runat="server" CssClass="btn btn-outline-info" Text="Get Incidents" OnClick="Button4_Click" />
        </p>
        <p>
            <asp:ListBox ID="lbIncidentDisplay" CssClass="btn btn-secondary text-danger" Width="100%" runat="server"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Incidents]"></asp:SqlDataSource>
        </p>
        <hr />
        <p><strong>Please rate this incident by the following categories:</strong></p>
 
        <table class="table table-hover">
            <tr>
                <td class="text-info">Response Time:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Enabled="False" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Not Satisfied</asp:ListItem>
                        <asp:ListItem Value="2">Somewhat Satisfied</asp:ListItem>
                        <asp:ListItem Value="3">Satisfied</asp:ListItem>
                        <asp:ListItem Selected="True" Value="4">Completely Satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="text-info">Technician efficiency:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" Enabled="False" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Not Satisfied</asp:ListItem>
                        <asp:ListItem Value="2">Somewhat Satisfied</asp:ListItem>
                        <asp:ListItem Value="3">Satisfied</asp:ListItem>
                        <asp:ListItem Selected="True" Value="4">Completely Satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="text-info">Problem resolution:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server" Enabled="False" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Not Satisfied</asp:ListItem>
                        <asp:ListItem Value="2">Somewhat Satisfied</asp:ListItem>
                        <asp:ListItem Value="3">Satisfied</asp:ListItem>
                        <asp:ListItem Selected="True" Value="4">Completely Satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="text-muted">Additional comments:</td>
                <td>
                    <asp:TextBox ID="txtComment" runat="server" CssClass="text-primary form-control" Enabled="False" TextMode="MultiLine" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:CheckBox ID="cbContact" runat="server" Enabled="False" Text="Please contact me to discuss this incident." />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="contactByEmail" runat="server" Enabled="False" GroupName="grpContactMethod" Text="Contact by Email" Checked="True" />
                </td>
                <td>
                    <asp:RadioButton ID="contactByPhone" runat="server" Enabled="False" GroupName="grpContactMethod" Text="Contact by Phone" />
                </td>
            </tr>
        </table>
 
        <asp:Button ID="Button3" runat="server" CssClass="btn btn-outline-success" Text="Submit" OnClick="Button3_Click" />
        <br />
        <br />
    </div>

</asp:Content>