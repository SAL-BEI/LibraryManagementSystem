Imports System.Data.SqlClient
Public Class Form1
    ' Variables used to connect to the DB
    Dim sqlconn As SqlConnection
    Dim sqlcmd As SqlCommand
    Dim sqlRd As SqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New SqlDataAdapter
    Dim sqlQuery As String

    ' My MSSQL server and database name
    Dim Server As String = "SALBEI\SQLEXPRESS"
    Dim Database As String = "LibraryDB"

    Private bitmap As Bitmap

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form loads, update the table
        updatetable()
    End Sub

    Private Sub updatetable()
        Try
            ' Open connection to the database
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' Execute SELECT query to retrieve all records from Books table
            sqlcmd = New SqlCommand("SELECT * FROM Books", sqlconn)
            sqlRd = sqlcmd.ExecuteReader()

            ' Load data into DataTable
            sqlDt.Clear()
            sqlDt.Load(sqlRd)
            sqlRd.Close()
            sqlconn.Close()

            ' Bind DataTable to DataGridView to display data
            dgvBooks.DataSource = sqlDt

        Catch ex As Exception
            ' Display error message if there's an exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close connection if it's still open
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try
    End Sub

    ' ADD button functionality
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Open connection to the database
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' Prepare INSERT query
            sqlQuery = "INSERT INTO Books (Title, Author, YearPublished, Genre) VALUES (@Title, @Author, @YearPublished, @Genre)"

            ' Execute INSERT query with parameters
            sqlcmd = New SqlCommand(sqlQuery, sqlconn)
            sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            sqlcmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", txtYearPublished.Text)
            sqlcmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            ' Display error message if there's an exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close connection if it's still open
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        ' Update DataGridView after adding a new record
        updatetable()
    End Sub

    ' UPDATE button functionality
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Open connection to the database
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' Prepare UPDATE query
            sqlQuery = "UPDATE Books SET Author = @Author, Genre = @Genre, YearPublished = @YearPublished WHERE Title = @Title"

            ' Execute UPDATE query with parameters
            sqlcmd = New SqlCommand(sqlQuery, sqlconn)
            sqlcmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            sqlcmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", Integer.Parse(txtYearPublished.Text))
            sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            ' Display error message if there's an exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close connection if it's still open
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        ' Update DataGridView after updating a record
        updatetable()
    End Sub

    ' DELETE button functionality
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Open connection to the database
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' Prepare DELETE query
            sqlQuery = "DELETE FROM Books WHERE Title = @Title"

            ' Execute DELETE query with parameters
            sqlcmd = New SqlCommand(sqlQuery, sqlconn)
            sqlcmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            sqlcmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", Integer.Parse(txtYearPublished.Text))
            sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            ' Display error message if there's an exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close connection if it's still open
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        ' Update DataGridView after deleting a record
        updatetable()
    End Sub

    ' CLEAR button functionality
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ' Open connection to the database
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' Prepare DELETE ALL query
            sqlQuery = "DELETE FROM Books"

            ' Execute DELETE ALL query
            sqlcmd = New SqlCommand(sqlQuery, sqlconn)
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            ' Display error message if there's an exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close connection if it's still open
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        ' Update DataGridView after clearing all records
        updatetable()
    End Sub

End Class

