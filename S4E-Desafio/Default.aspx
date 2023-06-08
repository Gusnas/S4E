<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="S4E_Desafio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="background-color: purple; font-size: xx-large; color: white" align="center">
        Sistema Associados - Empresas
    </div>
    <br />
    <div style="background-color: purple; font-size: xx-large; color: white" align="center">
        Associados
    </div>
    <div align="center" style="padding: 15px">

        <table class="w-100">
            <tr>
                <td style="width: 578px; height: 21px; font-size: medium;">
                    <span style="font-weight: bold">Associado Id</span></td>
                <td style="height: 21px">
                    <asp:TextBox ID="txtAssociadoId" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    <asp:Button ID="SearchButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Pesquisar" />
                </td>
            </tr>
            <tr>
                <td style="width: 578px; height: 21px">
                    <asp:Label ID="Label1" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="Medium" Text="Nome"></asp:Label>
                </td>
                <td style="height: 21px">
                    <asp:TextBox ID="txtNomeAssociado" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 578px; height: 27px">
                    <asp:Label ID="Label2" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="Medium" Text="CPF"></asp:Label>
                </td>
                <td style="height: 27px">
                    <asp:TextBox ID="txtCPF" runat="server" Font-Size="Medium" Width="200px" MaxLength="11"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 578px">
                    <asp:Label ID="Label3" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="Medium" Text="Data de Nascimento"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDataAssociado" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 578px; height: 21px; font-size: medium;">
                    <span style="font-weight: bold">Empresa Id</span></td>
                <td style="height: 21px">
                    <asp:TextBox ID="txtEmpresaId" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 578px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Salvar" />
                    <asp:Button ID="UpdateButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Atualizar" />
                    <asp:Button ID="DeleteButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Deletar" />
                </td>
            </tr>
        </table>
        <div align="center">
            <hr />

            <asp:GridView ID="GridViewAssociado" runat="server" Width="80%">
                <HeaderStyle BackColor="#CC00FF" ForeColor="White" />
            </asp:GridView>

        </div>
        <br />
</div>
</asp:Content>
