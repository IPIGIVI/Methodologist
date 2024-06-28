Imports System.Data.OleDb
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class РедактВыговоры
    Public recordIndex As Integer


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer
        If TextBox1.Text = "" Then
            MsgBox("Ошибка.Введите результат", vbCritical, "Error")
        End If
        If ComboBox1.Text > 3 Then
            For a = ComboBox1.Text To 4 Step -1
            Next a
            ComboBox1.Text = a
            MsgBox("Ошибка ввода", vbCritical, "Error")
            Exit Sub
        ElseIf ComboBox1.Text <= 0 Then
            For a = ComboBox1.Text To 0 Step 1
            Next a
            ComboBox1.Text = a
            MsgBox("Ошибка ввода", vbCritical, "Error")
            Exit Sub
        End If
        Dim c As New OleDbCommand
        c.Connection = conn
        c.Connection = conn
        c.CommandText = "UPDATE [Выговоры] SET [Выговоры]='" & ComboBox1.Text & "', [Результат]='" & TextBox1.Text & "' WHERE [НомерВыговора]=" & recordIndex
        c.ExecuteNonQuery()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = ComboBox1.Text + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Text = ComboBox1.Text - 1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <= 2 Then
            TextBox1.Text = "Продолжает учится"
        ElseIf ComboBox1.Text >= 3 Then
            TextBox1.Text = "Отчислен"
        End If
    End Sub
End Class