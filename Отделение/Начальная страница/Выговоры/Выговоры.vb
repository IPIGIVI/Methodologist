Imports System.Data.OleDb

Public Class Выговоры
    Private currentChildForm As Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New ДобавлениеВыговора)
        RefreshGrid()
    End Sub
    Private Sub Выговоры_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Выговоры". При необходимости она может быть перемещена или удалена.
        Me.ВыговорыTableAdapter.Fill(Me.Новые_базы_данныDataSet.Выговоры)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        k = DataGridView1.CurrentRow.Cells(k).Value
        c.CommandText = "delete from Выговоры where НомерВыговора = " & k
        c.ExecuteNonQuery()
        RefreshGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshGrid()
    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Выговоры"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Выговоры")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Выговоры"
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Если есть необходимость в проверке фамилии, раскомментируйте следующую строку:
        ' If Proverka_Familiya(TextBox1) = False Then Exit Sub
        Dim c As OleDbCommand
        c = New OleDbCommand("Select * from Выговоры where ФИО=@ФИО", conn)
        c.Parameters.AddWithValue("ФИО", TextBox1.Text)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = c
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim Index As Integer
        Index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(Index)

        РедактВыговоры.recordIndex = DataGridView1.CurrentRow.Cells(0).Value

        РедактВыговоры.Label1.Text = selectedRow.Cells(2).Value.ToString() 'Фио
        РедактВыговоры.Label5.Text = selectedRow.Cells(3).Value.ToString() 'Группа
        РедактВыговоры.ComboBox1.Text = selectedRow.Cells(4).Value.ToString() 'Выговоры
        РедактВыговоры.TextBox1.Text = selectedRow.Cells(5).Value.ToString() 'Результат
        РедактВыговоры.ShowDialog()
    End Sub
End Class