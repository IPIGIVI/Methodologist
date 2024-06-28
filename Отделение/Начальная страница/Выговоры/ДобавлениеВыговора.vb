Imports System.Data.OleDb

Public Class ДобавлениеВыговора
    Private currentChildForm As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New Выговоры)
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text <= 2 Then
            TextBox3.Text = "Продолжает учится"
        ElseIf ComboBox2.Text >= 3 Then
            TextBox3.Text = "Отчислен"
        End If
    End Sub

    Private Sub ДобавлениеВыговора_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.СтудентыTableAdapter.Fill(Me.Новые_базы_данныDataSet.Студенты)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s2, s3, s4, s5 As String
        Dim r As DialogResult
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        s3 = ComboBox1.Text
        s4 = ComboBox2.Text
        s5 = TextBox3.Text
        r = DialogResult
        Dim c As New OleDbCommand

        If Proverka_Word_RUS_FIO(TextBox1) = False Then Exit Sub
        If TextBox1.Text = "" Then
            MsgBox("Введите ФИО студента", vbCritical, "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Введите Код студента", vbCritical, "Error")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Введите группу", vbCritical, "Error")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Введите число выговоров", vbCritical, "Error")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Востанновите данные в результате или повторите попытку позже", vbCritical, "Error")
        Else

            c.Connection = conn
            c.CommandText = "insert into Выговоры(ФИО,КодСтуд,Группа,Выговоры,Результат) values ('" & s1 & "','" & s2 & "','" & s3 & "','" & s4 & "','" & s5 & "')"
            c.ExecuteNonQuery()
            RefreshGrid()
            OpenChildForm(New Выговоры)
        End If
    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Студенты"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Студенты")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Студенты"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'If Proverka_Chislo(TextBox2) = False Then Exit Sub
        Dim c As OleDbCommand
        c = New OleDbCommand("Select * from Студенты where ФИО=@ФИО", conn)
        c.Parameters.AddWithValue("ФИО", TextBox1.Text)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = c
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(Index)
        TextBox2.Text = selectedRow.Cells(0).Value.ToString()
        TextBox1.Text = selectedRow.Cells(1).Value.ToString()
        ComboBox1.Text = selectedRow.Cells(5).Value.ToString()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RefreshGrid()
    End Sub
End Class