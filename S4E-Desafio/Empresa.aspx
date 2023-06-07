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
                <td style="font-size: medium; width: 578px"><span style="font-weight: bold">Nome</span></td>
                <td>
                    <asp:TextBox ID="txtNomeEmpresa" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; width: 578px"><span style="font-weight: bold">CNPJ</span></td>
                <td>
                    <asp:TextBox ID="txtCNPJ" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
                        <tr>
                <td style="width: 578px">&nbsp;</td>
                <td>
                    <asp:Button ID="SaveButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Salvar" style="height: 29px" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
