Imports System.Data.SqlClient

Public Class _Default
    Inherits Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New SqlConnection("Server=DESKTOP-G62G4S8\\MSSQLSERVER01;Database=S4E;Trusted_Connection=True;")

        Dim nomeAssociado As String = txtNomeFuncionario.Text
        Dim dataAssociado As Date = txtDataFuncionario.Text
        Dim cpfAssociado As String = txtCPF.Text


        Dim command As New SqlCommand("Insert into Associado ")
    End Sub
End Class

