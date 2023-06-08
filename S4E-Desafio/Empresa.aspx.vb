Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Empresa
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String
    Private strSQLRelation As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListEmpresas()
    End Sub


    Protected Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            strSQL = "INSERT INTO Empresas (NomeEmpresa, CNPJ) VALUES (@NomeEmpresa, @Cnpj)"
            command = New SqlCommand(strSQL, connection)

            command.Parameters.AddWithValue("@NomeEmpresa", txtNomeEmpresa.Text)
            command.Parameters.AddWithValue("@Cnpj", txtCNPJ.Text)

            connection.Open()
            command.ExecuteNonQuery()

            If txtAssociadoId.Text <> "" Then
                Dim AssociadoId As Integer = txtAssociadoId.Text
                InsertRelation(AssociadoId, txtCNPJ.Text)
            End If

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

    Private Sub InsertRelation(AssociadoId As Integer, Cnpj As String)
        Dim EmpresaId As String

        connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

        command = New SqlCommand("SELECT Id FROM Empresas WHERE CNPJ = '" & Cnpj & "'", connection)
        connection.Open()
        EmpresaId = CInt(command.ExecuteScalar)

        strSQLRelation = "INSERT INTO EmpresaAssociado (AssociadoId, EmpresaId) VALUES ('" & AssociadoId & "', '" & EmpresaId & "')"

        command = New SqlCommand(strSQLRelation, connection)

        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Private Sub ListEmpresas()
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            strSQL = "SELECT * FROM Empresas"

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
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            If txtEmpresaId.Text = "" Then
                strSQL = "SELECT * FROM Empresas"
            Else
                Dim empresaId As Integer = txtEmpresaId.Text
                strSQL = "SELECT * FROM Empresas where Id = '" & empresaId & "'"
            End If

            command = New SqlCommand(strSQL, connection)
            da = New SqlDataAdapter(command)

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

    Protected Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            strSQL = "UPDATE Empresas set NomeEmpresa = @NomeEmpresa, CNPJ = @CNPJ where Id = @Id"
            command = New SqlCommand(strSQL, connection)

            command.Parameters.AddWithValue("@Nome", txtNomeEmpresa.Text)
            command.Parameters.AddWithValue("@CNPJ", txtCNPJ.Text)
            command.Parameters.AddWithValue("@Id", txtEmpresaId.Text)

            connection.Open()
            command.ExecuteNonQuery()
            MsgBox("Empresa atualizada!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            ListEmpresas()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            Dim empresaId As Integer = txtEmpresaId.Text
            strSQL = "DELETE Empresas WHERE Id = '" & empresaId & "'"

            connection.Open()
            command = New SqlCommand(strSQL, connection)
            command.ExecuteNonQuery()

            MsgBox("Empresa deletada!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            ListEmpresas()
            connection = Nothing
            command = Nothing
        End Try
    End Sub


End Class