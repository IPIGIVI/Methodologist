Imports System.Data.OleDb
Imports System.Windows.Controls

Public Class user
    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ПаролиDataSet.Пароли". При необходимости она может быть перемещена или удалена.
        Me.ПаролиTableAdapter.Fill(Me.ПаролиDataSet.Пароли)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Пароли.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s2 As String
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        Dim c As New OleDbCommand
        If TextBox1.Text = "" Then
            MsgBox("Введите нового пользователя", vbCritical, "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Введите пароль", vbCritical, "Error")
        Else
            c.Connection = conn
            c.CommandText = "insert into Пароли([Пользователь],[Пароль]) values ('" & s1 & "','" & s2 & "')"
            c.ExecuteNonQuery()
            RefreshGrid()
        End If
    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Пароли"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Пароли")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Пароли"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        k = DataGridView1.CurrentRow.Cells(k).Value
        c.CommandText = "delete from Пароли where ID = " & k
        c.ExecuteNonQuery()
        RefreshGrid()
    End Sub
End Class