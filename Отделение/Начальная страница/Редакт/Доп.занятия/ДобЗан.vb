Imports System.Data.OleDb

Public Class ДобЗан
    Private currentChildForm As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New Занятия)
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s2, s3 As String
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        s3 = MaskedTextBox1.Text
        Dim c As New OleDbCommand
        If Proverka_Word_RUS_FIO(TextBox1) = False Then Exit Sub
        If TextBox1.Text = "" Then
            MsgBox("Введите ФИО преподавателя", vbCritical, "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Введите предмет", vbCritical, "Error")
        ElseIf MaskedTextBox1.Text = ":-:" Then
            MsgBox("Введите время проведения", vbCritical, "Error")
        Else
            c.Connection = conn
            c.CommandText = "insert into Занятия([ФИО преподавателя],[Предмет],[Время проведения]) values ('" & s1 & "','" & s2 & "','" & s3 & "')"
            c.ExecuteNonQuery()
            RefreshGrid()
            OpenChildForm(New Занятия)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        MaskedTextBox1.Clear()
    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Занятия"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Занятия")
        Занятия.DataGridView1.DataSource = ds
        Занятия.DataGridView1.DataMember = "Занятия"
    End Sub
End Class