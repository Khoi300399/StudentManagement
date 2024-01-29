Public Class frmAddStudent

    Dim connect As Connect = New Connect
    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub resetForm_load()
        txtFullname.EditValue = ""
        txtEmail.EditValue = ""
        txtPhone.EditValue = ""
        txtBirthday.EditValue = ""
        txtAddress.EditValue = ""
        btnSave.Enabled = True
    End Sub



    Private Sub save_load()
        If Convert.ToString(txtFullname.EditValue) = "" Then

            txtFullname.ErrorText = "Please enter your full name!"
            MessageBox.Show("Please enter your fullname!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Convert.ToString(txtEmail.EditValue) = "" Then

            txtFullname.ErrorText = "Please enter your email!"
            MessageBox.Show("Please enter your email!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Convert.ToString(txtBirthday.EditValue) = "" Then

            txtFullname.ErrorText = "Please enter your birthday!"
            MessageBox.Show("Please enter your birthday!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Convert.ToString(txtPhone.EditValue) = "" Then

            txtFullname.ErrorText = "Please enter your phone number!"
            MessageBox.Show("Please enter your phone number!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Convert.ToString(txtAddress.EditValue) = "" Then

            txtFullname.ErrorText = "Please enter your address!"
            MessageBox.Show("Please enter your address!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            connect.laygiatritruyvan("INSERT INTO dt_student(fullname, email, birthday, phone, address) VALUES( N'" & txtFullname.EditValue & "', N'" & txtEmail.EditValue & "','" & Convert.ToDateTime(txtBirthday.EditValue) & "'," & Convert.ToInt32(txtPhone.EditValue) & ", N'" & txtAddress.EditValue & "') ")
            btnSave.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReset_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReset.ItemClick
        resetForm_load()
    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        save_load()
    End Sub
End Class