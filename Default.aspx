<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AFPABNBADMIN._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
        <div class="row justify-content-center align-items-center" style="margin-top: 10px;">
            <div class="col-5">
                <form action="" autocomplete="off">
                    <div class="card">
                        <div class="card-header">
                            <h4 class="card-title mt-2">Housekeeping</h4>
                        </div>
                        <div class="card-body">

                            <asp:Label ID="lblMessage" runat="server"></asp:Label>

                            <div class="form-group">
                                <label for="login">Login</label>
                                <asp:TextBox ID="txtLogin" runat="server" type="text" class="form-control" placeholder="Login" value="admin" Style="height: 100%"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="password">Mot de passe</label>
                                <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control" placeholder="Password" value="123"></asp:TextBox>
                            </div>

                            <asp:Button ID="btnValider" runat="server" Text="Se connecter" class="btn btn-primary" OnClick="btnValider_Click" />

                        </div>
                        <div class="card-footer">
                            <p></p>
                        </div>
                    </div>
                </form>
            </div>

        </div>
    </div>

</asp:Content>
