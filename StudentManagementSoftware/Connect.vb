Imports System.Data.SqlClient

Public Class Connect
    Dim databaseName As String = "db_student"
    Dim connectionMasterString As String = "Data Source=THANHKHOI\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
    Dim connectionString As String = $"Data Source=THANHKHOI\SQLEXPRESS;Initial Catalog={databaseName};Integrated Security=True"
    Dim dataBaseCreationString As String = $"CREATE DATABASE {databaseName}"
    Dim useDataBaseString As String = $"USE {databaseName}"
    Dim studentManagementTableString As String = "CREATE TABLE dt_student (" &
                                         "id INT PRIMARY KEY AUTO_INCREMENT," &
                                         "fullname VARCHAR(255) NOT NULL," &
                                         "email VARCHAR(255) NOT NULL," &
                                         "birthday DATE NOT NULL," &
                                         "phone VARCHAR(20) NOT NULL," &
                                         "address VARCHAR(255));"

    Dim connect As SqlConnection = New SqlConnection(connectionString)
    Public Sub Initialize()
        If Not DatabaseExists(connectionMasterString, databaseName) Then
            CreateDatabase(connectionMasterString, databaseName)
        End If
    End Sub

    Private Function DatabaseExists(connectionString As String, databaseName As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = $"SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE name = '{databaseName}'"
            Using command As New SqlCommand(query, connection)
                Return CInt(command.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Private Sub CreateDatabase(connectionString As String, databaseName As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(dataBaseCreationString, connection)
                command.ExecuteNonQuery()
            End Using

            Using command As New SqlCommand(useDataBaseString, connection)
                command.ExecuteNonQuery()
            End Using

            Using command As New SqlCommand(studentManagementTableString, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function getDataTable(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Using ad As New SqlDataAdapter(sql, connect)
            ad.Fill(dt)
        End Using
        Return dt
    End Function
    Public Function setValueDatabase(ByVal strQuery As String) As Object
        Dim result As Object = Nothing
        Try
            connect.Open()
            Using cmd As SqlCommand = New SqlCommand(strQuery, connect)
                cmd.CommandTimeout = 300
                result = cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            connect.Close()
        End Try
        Return result
    End Function
    Public Sub queryingData(ByVal strQuery As String)
        Try
            connect.Open()
            Using cmd As SqlCommand = New SqlCommand(strQuery, connect)
                cmd.CommandTimeout = 300
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub

    Public Sub Update(ByVal dataTable As DataTable)
        Using da = New SqlDataAdapter("select * from " + dataTable.TableName, connectionString)
            Dim cb As New SqlCommandBuilder(da)
            Dim changes As DataTable = dataTable.GetChanges()
            If changes IsNot Nothing Then
                da.Update(changes)
                dataTable.AcceptChanges()
            End If
        End Using
    End Sub


End Class
