<%@ Page Title="Empresas" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.vb" Inherits="S4E_Desafio.Empresa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="background-color: purple; font-size: xx-large; color: white" align="center">
        Sistema Funcionários - Empresas
    </div>
    <br />
    <div style="background-color: purple; font-size: xx-large; color: white" align="center">
        Empresa
    </div>
    <div align="center" style="padding: 15px">

        <table class="w-100">
            <tr>
                <td style="font-size: medium; width: 578px; height: 27px;" >
                    <asp:Label ID="Label1" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="Medium" Text="Empresa Id"></asp:Label>
                </td>
                <td style="height: 27px">
                    <asp:TextBox ID="txtEmpresaId" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    <asp:Button ID="SearchButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Pesquisar" Style="height: 29px" />
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; width: 578px; height: 27px;"><span style="font-weight: bold">Nome</span></td>
                <td style="height: 27px">
                    <asp:TextBox ID="txtNomeEmpresa" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; width: 578px; height: 27px;"><span style="font-weight: bold">CNPJ</span></td>
                <td style="height: 27px">
                    <asp:TextBox ID="txtCNPJ" runat="server" Font-Size="Medium" Width="200px" MaxLength="14"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 578px">
                    <asp:Label ID="Label2" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="Medium" Text="Associado Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAssociadoId" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 578px">&nbsp;</td>
                <td>
                    <asp:Button ID="SaveButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Salvar" Style="height: 29px" />
                    <asp:Button ID="UpdateButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Atualizar" />
                    <asp:Button ID="DeleteButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Deletar" />
                </td>
            </tr>
        </table>
        <br />
        <div align="center">
            <hr />

            <asp:GridView ID="GridViewEmpresa" runat="server" Width="80%">
                <HeaderStyle BackColor="#CC00FF" ForeColor="White" />
            </asp:GridView>

        </div>
        <br />
    </div>

</asp:Content>
