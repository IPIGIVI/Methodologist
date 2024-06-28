Imports System.Data.OleDb
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class РедСтуд
    Private currentChildForm As Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New Добавить)
    End Sub

    Private Sub РедСтуд_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Студенты". При необходимости она может быть перемещена или удалена.
        Me.СтудентыTableAdapter.Fill(Me.Новые_базы_данныDataSet.Студенты)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New ДобавлениеСтуд)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        k = DataGridView1.CurrentRow.Cells(k).Value
        c.CommandText = "delete from Студенты where Код = " & k
        c.ExecuteNonQuery()
        RefreshGrid()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Proverka_Chislo(TextBox1) = False Then Exit Sub
        Dim c As OleDbCommand
        c = New OleDbCommand("Select * from Студенты where Код=@Код", conn)
        c.Parameters.AddWithValue("Код", TextBox1.Text)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = c
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RefreshGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Index As Integer
        Index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(Index)

        Досье.recordIndex = DataGridView1.CurrentRow.Cells(0).Value

        Досье.TextBox1.Text = selectedRow.Cells(1).Value.ToString() 'Фио
        Досье.MaskedTextBox1.Text = selectedRow.Cells(2).Value.ToString() 'Дата рождения
        Досье.TextBox2.Text = selectedRow.Cells(3).Value.ToString() 'Адрес
        Досье.MaskedTextBox2.Text = selectedRow.Cells(4).Value.ToString() 'Год поступления
        Досье.ComboBox1.Text = selectedRow.Cells(5).Value.ToString()
        Досье.ShowDialog()
    End Sub
End Class