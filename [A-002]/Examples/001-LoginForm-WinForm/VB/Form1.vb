Imports System.Data.SqlClient

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Define database connection and command
        Dim con As SqlConnection
        Dim cmd As SqlCommand

        ' Create connection object and pass connection string
        con = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=KOIVOSNET;Integrated Security=True")

        ' Open the connection
        con.Open()

        ' Create command object and pass T-SQL command together with the connection object
        cmd = New SqlCommand("SELECT * FROM USERS WHERE Username=@Username AND Password=@Password", con)

        ' Neat way of passing parameters
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        ' Execute the SQL command
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        ' Check if a record match
        If dr.HasRows Then
            MsgBox("Login Successful!")
        Else
            MsgBox("Login failed.")
        End If

    End Sub

End Class
