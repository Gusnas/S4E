Imports System.Data.SqlClient

Public Class _Default
    Inherits Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String
    Private strSQLRelation As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ListAssociados()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            strSQL = "INSERT INTO Associados (NomeAssociado, CPF, DataNascimento) VALUES (@Nome, @CPF, @Data)"
            command = New SqlCommand(strSQL, connection)

            command.Parameters.AddWithValue("@Nome", txtNomeAssociado.Text)
            command.Parameters.AddWithValue("@CPF", txtCPF.Text)
            command.Parameters.AddWithValue("@Data", txtDataAssociado.Text)

            connection.Open()
            command.ExecuteNonQuery()

            If txtEmpresaId.Text <> "" Then
                Dim EmpresaId As Integer = txtEmpresaId.Text
                InsertRelation(EmpresaId, txtCPF.Text)
            End If

            MsgBox("Associado salvo!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            ListAssociados()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub InsertRelation(EmpresaId As Integer, CPF As String)
        Dim AssociadoId As String

        connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

        command = New SqlCommand("SELECT Id FROM Associados WHERE CPF = '" & CPF & "'", connection)
        connection.Open()
        AssociadoId = CInt(command.ExecuteScalar)

        strSQLRelation = "INSERT INTO EmpresaAssociado (AssociadoId, EmpresaId) VALUES ('" & AssociadoId & "', '" & EmpresaId & "')"

        command = New SqlCommand(strSQLRelation, connection)

        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Private Sub ListAssociados()
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            strSQL = "SELECT * FROM Associados"

            command = New SqlCommand(strSQL, connection)
            da = New SqlDataAdapter(strSQL, connection)

            connection.Open()

            Dim dt As New DataTable
            da.Fill(dt)

            GridViewAssociado.DataSource = dt
            GridViewAssociado.DataBind()

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

            strSQL = "UPDATE Associados set NomeAssociado = @Nome, CPF = @CPF, DataNascimento = @Data where Id = @Id"
            command = New SqlCommand(strSQL, connection)

            command.Parameters.AddWithValue("@Nome", txtNomeAssociado.Text)
            command.Parameters.AddWithValue("@CPF", txtCPF.Text)
            command.Parameters.AddWithValue("@Data", txtDataAssociado.Text)
            command.Parameters.AddWithValue("@Id", txtAssociadoId.Text)

            connection.Open()
            command.ExecuteNonQuery()
            MsgBox("Associado atualizado!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            ListAssociados()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Protected Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            If txtAssociadoId.Text = "" Then
                strSQL = "SELECT * FROM Associados"
            Else
                Dim associadoId As Integer = txtAssociadoId.Text
                strSQL = "SELECT * FROM Associados WHERE Id = '" & associadoId & "'"
            End If

            command = New SqlCommand(strSQL, connection)
            da = New SqlDataAdapter(command)

            Dim dt As New DataTable

            da.Fill(dt)

            GridViewAssociado.DataSource = dt
            GridViewAssociado.DataBind()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E_Core;Trusted_Connection=True;")

            Dim associadoId As Integer = txtAssociadoId.Text
            strSQL = "DELETE Associados WHERE Id = '" & associadoId & "'"
            connection.Open()
            command = New SqlCommand(strSQL, connection)
            command.ExecuteNonQuery()

            MsgBox("Associado deletado!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            ListAssociados()
            connection = Nothing
            command = Nothing
        End Try
    End Sub
End Class

