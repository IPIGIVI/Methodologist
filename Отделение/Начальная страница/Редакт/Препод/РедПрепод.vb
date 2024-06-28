Imports System.Data.OleDb

Public Class РедПрепод
    Private currentChildForm As Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New Добавить)
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
    Private Sub РедПрепод_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Учителя". При необходимости она может быть перемещена или удалена.
        Me.УчителяTableAdapter.Fill(Me.Новые_базы_данныDataSet.Учителя)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RefreshGrid()
    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Учителя"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Учителя")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Учителя"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        k = DataGridView1.CurrentRow.Cells(k).Value
        c.CommandText = "delete from Учителя where КодПрепод = " & k
        c.ExecuteNonQuery()
        RefreshGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New ДобПрепод)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Proverka_Chislo(TextBox1) = False Then Exit Sub
        Dim c As OleDbCommand
        c = New OleDbCommand("Select * from Учителя where КодПрепод=@КодПрепод", conn)
        c.Parameters.AddWithValue("КодПрепод", TextBox1.Text)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = c
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class