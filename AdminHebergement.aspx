<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeBehind="AdminHebergement.aspx.cs" Inherits="AFPABNBADMIN.AdminHebergement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentMain2" runat="server">

    <asp:ListView ID="lvwHebergement" runat="server">
        <ItemTemplate>

            <div class="d-flex border bg-light p-2 mb-1">
                <div class="border">
                    <img src="./Images/<%#Eval("Photo") %>" class="petite" style="height: 400px; width: 400px;" />
                    <div class="grande">
                    </div>
                </div>
                <div class="d-flex flex-column px-4">
                    <div>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("IdHebergement") %>'><h3><%#Eval("Nom") %></h3></asp:LinkButton>
                    </div>
                    <div>
                        <%--<span class="badge badge-pill badge-info"><%#Eval("Adresse.Ville") %></span>--%>
                        <%--<span class="badge badge-pill badge-warning"><%#Eval("Prix") %> €</span>--%>
                    </div>
                    <div>
                        <p></br><%#Eval("Description") %></p>
                    </div>
                    <div>
                        <div class="btn-group" role="group" aria-label="Button group with nested dropdown">
                            <asp:Button ID="Button3" runat="server" CssClass="btn btn-success mt-3" Text='Activé' Onclick="btnActiver_Click" CommandArgument='<%#Eval("IdHebergement") %>' />
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-danger mt-3" Text='Desactivé' Onclick="btnDesactiver_Click" CommandArgument='<%#Eval("IdHebergement") %>' />
                        </div>
                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:ListView>

</asp:Content>
