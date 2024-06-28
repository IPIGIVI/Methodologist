Imports System.Data.OleDb

Public Class РедГрупп
    Private currentChildForm As Form
    Private Sub РедГрупп_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Группа". При необходимости она может быть перемещена или удалена.
        Me.ГруппаTableAdapter.Fill(Me.Новые_базы_данныDataSet.Группа)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New Добавить)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Proverka_Word_RUS_chislo(TextBox1) = False Then Exit Sub
        Dim s1 As String
        s1 = TextBox1.Text
        Dim c As New OleDbCommand
        If TextBox1.Text = "" Then
            MsgBox("Введите группу")
        Else
            c.Connection = conn
            c.CommandText = "insert into Группа([Группа]) values ('" & s1 & "')"
            c.ExecuteNonQuery()
            RefreshGrid()
        End If
    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Группа"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Группа")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Группа"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        k = DataGridView1.CurrentRow.Cells(k).Value
        c.CommandText = "delete from Группа where КодГруппы = " & k
        c.ExecuteNonQuery()
        RefreshGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RefreshGrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
    End Sub
End Class