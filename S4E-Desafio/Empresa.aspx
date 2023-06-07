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
                <td style="font-size: medium; width: 578px; height: 27px;"><span style="font-weight: bold">Nome</span></td>
                <td style="height: 27px">
                    <asp:TextBox ID="txtNomeEmpresa" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; width: 578px; height: 27px;"><span style="font-weight: bold">CNPJ</span></td>
                <td style="height: 27px">
                    <asp:TextBox ID="txtCNPJ" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 578px">&nbsp;</td>
                <td>
                    <asp:Button ID="SaveButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Salvar" Style="height: 29px" />
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

        <div style="background-color: purple; font-size: large; color: white; width: 50%" align="center">
            Pesquisa Individual
        </div>
        <div align="center" style="padding: 15px">

            <table align="center" class="w-100">
                <tr>
                    <td style="width: 578px; height: 21px; font-size: medium;" align="right">
                        <span style="font-weight: bold">Id:</span></td>
                    <td style="height: 21px">
                        <asp:TextBox ID="txtIdEmpresa" runat="server" Font-Size="Medium" Width="200px" TextMode="Number"></asp:TextBox>
                        <asp:Button ID="SearchButton" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Pesquisar" Style="height: 29px" />
                    </td>
                </tr>
            </table>
                    <br />
        <div align="center">
            <hr />

            <asp:GridView ID="GridViewEmpresaIndividual" runat="server" Width="80%">
                <HeaderStyle BackColor="#CC00FF" ForeColor="White" />
            </asp:GridView>

        </div>
        <br />

        </div>
    </div>

</asp:Content>
