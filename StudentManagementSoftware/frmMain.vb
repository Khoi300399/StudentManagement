Public Class frmMain
    Private Sub itemStudentList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itemStudentList.ItemClick
        Dim frm As New frmStudentList
        frm.Show()
    End Sub
End Class
