Imports System.Data.SqlClient

Public Class _Default
    Inherits Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ListAssociados()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

            strSQL = "INSERT INTO Associados (NomeAssociado, CPF, DataNascimento) VALUES (@Nome, @CPF, @Data)"
            command = New SqlCommand(strSQL, connection)

            command.Parameters.AddWithValue("@Nome", txtNomeAssociado.Text)
            command.Parameters.AddWithValue("@CPF", txtCPF.Text)
            command.Parameters.AddWithValue("@Data", txtDataAssociado.Text)

            connection.Open()
            command.ExecuteNonQuery()
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

    Private Sub ListAssociados()
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

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

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

            strSQL = "UPDATE Associados set NomeAssociado = @Nome, CPF = @CPF, DataNascimento = @Data where )"
            command = New SqlCommand(strSQL, connection)

            command.Parameters.AddWithValue("@Nome", txtNomeAssociado.Text)
            command.Parameters.AddWithValue("@CPF", txtCPF.Text)
            command.Parameters.AddWithValue("@Data", txtDataAssociado.Text)

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
            connection = New SqlConnection("Server=DESKTOP-G62G4S8\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

            strSQL = "SELECT * FROM Empresa where Id = @id"

            command.Parameters.AddWithValue("@id", txtIdAssociado.Text)

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

End Class

