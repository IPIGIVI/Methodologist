Imports System.Data.OleDb

Public Class РасчетПремии
    Private currentChildForm As Form
    Dim Index As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New Премия)
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
        Dim s1, s2 As String
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        Dim c As New OleDbCommand

        If Proverka_Word_RUS_FIO(TextBox1) = False Then Exit Sub
        If Proverka_Chislo(TextBox2) = False Then Exit Sub

        Try
            If TextBox1.Text = "" Then
                MsgBox("Введите ФИО преподавателя", vbCritical, "Error")
            ElseIf ComboBox2.Text = "" Then
                MsgBox("Выберите длительность занятия", vbCritical, "Error")
            ElseIf ComboBox3.Text = "" Then
                MsgBox("Выберите предмет", vbCritical, "Error")
            ElseIf ComboBox4.Text = "" Then
                MsgBox("Выберите число занятий", vbCritical, "Error")
            Else
                c.Connection = conn
                c.CommandText = "INSERT INTO Премия([ФИО],[Премия]) VALUES (?, ?)"
                c.Parameters.AddWithValue("@p1", s1)
                c.Parameters.AddWithValue("@p2", s2)
                c.ExecuteNonQuery()
                RefreshGrid()
                OpenChildForm(New Премия)
            End If
        Catch ex As Exception
            MessageBox.Show("Произошла ошибка при вставке данных в базу данных: " & ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim a As String
        a = 0
        If ComboBox2.Text = 1 Then
            TextBox2.Text = Val(TextBox2.Text) + 250
        ElseIf ComboBox2.Text = 2 Then
            TextBox2.Text = Val(TextBox2.Text) + 350
        ElseIf ComboBox2.Text = 3 Then
            TextBox2.Text = Val(TextBox2.Text) + 450
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Информатика" Then
            TextBox2.Text = Val(TextBox2.Text) + 930
        ElseIf ComboBox3.Text = "История" Then
            TextBox2.Text = Val(TextBox2.Text) + 640
        ElseIf ComboBox3.Text = "Физика" Then
            TextBox2.Text = Val(TextBox2.Text) + 1100
        ElseIf ComboBox3.Text = "Математика" Then
            TextBox2.Text = Val(TextBox2.Text) + 700
        ElseIf ComboBox3.Text = "Литература" Then
            TextBox2.Text = Val(TextBox2.Text) + 300
        ElseIf ComboBox3.Text = "Русский язык" Then
            TextBox2.Text = Val(TextBox2.Text) + 350
        ElseIf ComboBox3.Text = "Курсы по photoshop" Then
            TextBox2.Text = Val(TextBox2.Text) + 600
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = 1 Then
            TextBox2.Text = Val(TextBox2.Text) * ComboBox4.Text
        ElseIf ComboBox4.Text = 2 Then
            TextBox2.Text = Val(TextBox2.Text) * ComboBox4.Text
        ElseIf ComboBox4.Text = 3 Then
            TextBox2.Text = Val(TextBox2.Text) * ComboBox4.Text
        ElseIf ComboBox4.Text = 4 Then
            TextBox2.Text = Val(TextBox2.Text) * ComboBox4.Text
        ElseIf ComboBox4.Text = 5 Then
            TextBox2.Text = Val(TextBox2.Text) * ComboBox4.Text
        ElseIf ComboBox4.Text = 6 Then
            TextBox2.Text = Val(TextBox2.Text) * ComboBox4.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Премия"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Премия")
        Премия.DataGridView1.DataSource = ds
        Премия.DataGridView1.DataMember = "Премия"
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(Index)


        TextBox1.Text = selectedRow.Cells(1).Value.ToString() 'фио
        ComboBox3.Text = selectedRow.Cells(2).Value.ToString() 'предмет

    End Sub

    Private Sub РасчетПремии_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Занятия". При необходимости она может быть перемещена или удалена.
        Me.ЗанятияTableAdapter.Fill(Me.Новые_базы_данныDataSet.Занятия)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
End Class