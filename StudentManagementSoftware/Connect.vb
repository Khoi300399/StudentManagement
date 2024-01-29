Imports System.Data.SqlClient

Public Class Connect
    Dim chuoiketnoi As String = "Data Source=THANHKHOI\SQLEXPRESS;Initial Catalog=db_studentmanagementsoftware;User ID=sa;pwd=123456"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Public Sub ketnoicsdl() 'phuowng thuc khoi tao,phuong thuc nay thuc hien khi khoi tao doi tuong
        connect.Open()
    End Sub
    Public Function getDataTable(ByVal sql As String) As DataTable ' ca´u tru´c cu?a mô?t funtion la` 
        Dim dt As New DataTable ' 
        Using ad As New SqlDataAdapter(sql, connect) ' khoi ta?o OleDbDataAdapter giô´ng nhu mô?t ca´i bi`nh dê? lâ´y du~ liê?u
            ad.Fill(dt) ' dô? du~ liê?u va`o ba?ng
        End Using
        Return dt ' ha`m laybangdulieu se~ tra? vê` ba?ng dt 
    End Function
    Public Function getDataTable(ByVal ds As DataSet, ByVal tableName As String, ByVal sql As String) As DataTable
        If ds.Tables.Contains(tableName) Then ds.Tables(tableName).Clear()
        Using ad As New SqlDataAdapter(sql, connect)
            ad.Fill(ds, tableName)
        End Using
        Return ds.Tables(tableName)
    End Function
    Public Function laygiatritruyvan(ByVal chuoitruyvan As String) As Object
        Dim result As Object = Nothing
        Try
            connect.Open()
            Using cmd As SqlCommand = New SqlCommand(chuoitruyvan, connect)
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
    Public Sub thuchientruyvan(ByVal chuoitruyvan As String)
        Try
            connect.Open()
            Using cmd As SqlCommand = New SqlCommand(chuoitruyvan, connect)
                cmd.CommandTimeout = 300
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub
    Public Sub Update(ByVal dt As DataTable)
        Using da = New SqlDataAdapter("select * from " + dt.TableName, chuoiketnoi)
            Dim cb As New SqlCommandBuilder(da)
            Dim changes As DataTable = dt.GetChanges()
            If changes IsNot Nothing Then
                da.Update(changes)
                dt.AcceptChanges()
            End If
        End Using
    End Sub
End Class
