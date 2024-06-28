Imports System.Data.OleDb
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Досье
    Public recordIndex As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As New OleDbCommand
        If Proverka_Word_RUS_FIO(TextBox1) = False Then Exit Sub
        If MaskedTextBox1.Text > MaskedTextBox2.Text Then
            MsgBox("Ошибка ввода данных", vbCritical, "Error")
        ElseIf MaskedTextBox1.Text = "" Then
            MsgBox("Заполните дату", vbCritical, "Error")
        ElseIf MaskedTextBox1.Text - MaskedTextBox2.Text > 15 Then
            c.Connection = conn
            c.CommandText = "UPDATE [Студенты] SET [ФИО]='" & TextBox1.Text & "', [Группа]='" & ComboBox1.Text & "', [Дата рождения]='" & MaskedTextBox1.Text & "', [Год поступления]='" & MaskedTextBox2.Text & "', [Адрес проживания]='" & TextBox2.Text & "' WHERE [Код]=" & recordIndex
            c.ExecuteNonQuery()
            Close()
        End If
    End Sub

    Private Sub Досье_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Группа". При необходимости она может быть перемещена или удалена.
        Me.ГруппаTableAdapter.Fill(Me.Новые_базы_данныDataSet.Группа)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
End Class