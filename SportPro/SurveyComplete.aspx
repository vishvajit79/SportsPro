<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SurveyComplete.aspx.cs" Inherits="SurveyComplete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="text-center">
        <br />
        <br />
    <p><strong>Survey Complete</strong> -
        </p>
    <p>&nbsp;<br />
        <asp:Label ID="lblContactCheck" runat="server" CssClass="text-muted"></asp:Label>
        </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-outline-secondary" Text="Return to Survey" OnClick="Button1_Click" />
    </p>
        </div>
</asp:Content>

