Imports System.Data.OleDb

Public Class ДобавлениеСтуд
    Private currentChildForm As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New РедСтуд)
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

    Private Sub ДобавлениеСтуд_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Группа". При необходимости она может быть перемещена или удалена.
        Me.ГруппаTableAdapter.Fill(Me.Новые_базы_данныDataSet.Группа)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s3, s5 As String
        Dim s2, s4 As DateTime
        Dim r As DialogResult
        s1 = TextBox1.Text
        s2 = DateTimePicker1.Value
        s3 = TextBox2.Text
        s4 = DateTimePicker2.Value
        s5 = ComboBox1.Text
        r = DialogResult
        Dim c As New OleDbCommand

        If Proverka_Word_RUS_FIO(TextBox1) = False Then Exit Sub
        If Proverka_Word_RUS_ADDRESS(TextBox2) = False Then Exit Sub

        If TextBox1.Text = "" Then
            MsgBox("Введите ФИО Студента", vbCritical, "Error")
        ElseIf DateTime.Compare(DateTimePicker1.Value, DateTime.Now.AddYears(-15)) >= 0 Then
            MsgBox("Студент слишком молод", vbCritical, "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Адрес проживания студента", vbCritical, "Error")
        ElseIf DateTime.Compare(DateTimePicker2.Value, DateTime.Now) >= 0 Then
            MsgBox("Введите корректную Дату зачисления", vbCritical, "Error")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Введите Группу", vbCritical, "Error")
        Else
            c.Connection = conn
            c.CommandText = "INSERT INTO Студенты([ФИО],[Дата рождения],[Адрес проживания],[Год поступления],[Группа]) VALUES (?, ?, ?, ?, ?)"
            c.Parameters.AddWithValue("@p1", s1)
            c.Parameters.AddWithValue("@p2", s2)
            c.Parameters.AddWithValue("@p3", s3)
            c.Parameters.AddWithValue("@p4", s4)
            c.Parameters.AddWithValue("@p5", s5)
            c.ExecuteNonQuery()
            RefreshGrid()
            OpenChildForm(New РедСтуд)
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""

    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Студенты"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Студенты")
        РедСтуд.DataGridView1.DataSource = ds
        РедСтуд.DataGridView1.DataMember = "Студенты"
    End Sub
End Class