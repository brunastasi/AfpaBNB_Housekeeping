<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeBehind="AdminAvi.aspx.cs" Inherits="AFPABNBADMIN.AdminAvi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentMain2" runat="server">
    <asp:GridView ID="gdvAvi" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Button3" runat="server" CssClass="btn btn-success mt-3" Text='Activé' OnClick="btnActiver_Click" CommandArgument='<%#Eval("IdAvis") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-danger mt-3" Text='Desactivé' OnClick="btnDesactiver_Click" CommandArgument='<%#Eval("IdAvis") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>
