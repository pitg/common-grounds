Imports System.Data
Imports System.Data.SqlClient

Module Module1

    Sub Main()

        Dim username As String = ""
        Dim password As String = ""

        ' Ask for user input
        Console.WriteLine("Enter your username: ")
        username = Console.ReadLine()

        Console.WriteLine("Enter your password: ")
        password = Console.ReadLine()

        ' Define database connection and command
        Dim con As SqlConnection
        Dim cmd As SqlCommand

        ' Create connection object and pass connection string
        con = New SqlConnection("")

        ' Create command object and pass T-SQL command together with the connection object
        cmd = New SqlCommand("SELECT * FROM USERS WHERE Username=@Username AND Password=@Password", con)

        ' Neat way of passing parameters
        cmd.Parameters.AddWithValue("@Username", username)
        cmd.Parameters.AddWithValue("@Password", password)

        ' Execute the SQL command
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        ' Check if a record match
        If dr.HasRows Then
            Console.WriteLine("Login Successful!")
        Else
            Console.WriteLine("Login failed.")
        End If

    End Sub

End Module
