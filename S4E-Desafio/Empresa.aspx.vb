Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Empresa
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListEmpresas()
    End Sub


    Protected Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

            strSQL = "INSERT INTO Empresa (NomeEmpresa, CNPJ) VALUES (@NomeEmpresa, @CNPJ)"
            command = New SqlCommand(strSQL, connection)

            command.Parameters.AddWithValue("@NomeEmpresa", txtNomeEmpresa.Text)
            command.Parameters.AddWithValue("@Cnpj", txtCNPJ.Text)

            connection.Open()
            command.ExecuteNonQuery()
            MsgBox("Empresa salva!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            ListEmpresas()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub ListEmpresas()
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

            strSQL = "SELECT * FROM Empresa"

            command = New SqlCommand(strSQL, connection)
            da = New SqlDataAdapter(strSQL, connection)

            connection.Open()

            Dim dt As New DataTable
            da.Fill(dt)

            GridViewEmpresa.DataSource = dt
            GridViewEmpresa.DataBind()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Protected Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

            strSQL = "SELECT * FROM Empresa WHERE Id = @Id"

            Dim id As Integer = txtIdEmpresa.Text

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@Id", txtIdEmpresa.Text)

            da = New SqlDataAdapter(strSQL, connection)

            connection.Open()

            Dim dt As New DataTable
            da.Fill(dt)

            GridViewEmpresaIndividual.DataSource = dt
            GridViewEmpresaIndividual.DataBind()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
        End Try
    End Sub
End Class