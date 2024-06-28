Imports System.Data.OleDb

Public Class ОкноВхода
    Private currentChildForm As Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
        Me.CancelButton = Button2
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Пароли.accdb")
        Dim c As OleDbCommand = New OleDbCommand("SELECT * FROM Пароли WHERE Пользователь = '" & TextBox1.Text & "' AND [Пароль] = '" & TextBox2.Text & "' ", con)
        Dim user As String = ""
        Dim pass As String = ""
        con.Open()
        Dim sdr As OleDbDataReader = c.ExecuteReader()
        If (sdr.Read() = True) Then
            user = sdr("Пользователь")
            pass = sdr("Пароль")
            Me.Hide()
            Form1.Show()

        Else
            MsgBox("Проаерьте ввод данных", vbCritical, "Ошибка 404")
        End If
    End Sub

    Private Sub Label3_DoubleClick(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox("Обратитесь к оператору")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        ElseIf CheckBox1.Checked = False Then
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
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
        Form1.Panel3.Controls.Add(childForm)
        Form1.Panel3.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        Form1.Label1.Text = childForm.Text
    End Sub
End Class