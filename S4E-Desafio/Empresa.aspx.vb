Imports System.Data.SqlClient

Public Class Empresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim connect As New SqlConnection("")

        Dim nomeEmpresa As String = txtNomeEmpresa.Text
        Dim cnpjEmpresa As String = txtCNPJ.Text

        Dim command As New SqlCommand("Insert into Empresa values('" && "')")
    End Sub


End Class