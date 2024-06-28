Imports System.Data.OleDb

Public Class ДобПрепод
    Private currentChildForm As Form
    Private Sub ДобПрепод_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Группа". При необходимости она может быть перемещена или удалена.
        Me.ГруппаTableAdapter.Fill(Me.Новые_базы_данныDataSet.Группа)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New РедПрепод)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s2, s3, s4 As String
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        s3 = ComboBox2.Text
        s4 = ComboBox1.Text
        Dim c As New OleDbCommand
        c.Connection = conn
        If Proverka_Word_RUS_FIO(TextBox1) = False Then Exit Sub
        If TextBox1.Text = "" Then
            MsgBox("Введите ФИО преподавателя", vbCritical, "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Введите предмет", vbCritical, "Error")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Укажите является ли учитель классным руководителем", vbCritical, "Error")
        ElseIf ComboBox2.Text = "Да" Then
            If ComboBox1.Text = "" Then
                GR()
            Else c.CommandText = "insert into Учителя([ФИО],[Предмет],[Классный Руководитель],[Группа]) values ('" & s1 & "','" & s2 & "','" & s3 & "','" & s4 & "')"
                c.ExecuteNonQuery()
                RefreshGrid()
                OpenChildForm(New РедПрепод)
            End If

        ElseIf ComboBox2.Text = "Нет" Then
            If ComboBox1.Text = "" Then
                c.CommandText = "insert into Учителя([ФИО],[Предмет],[Классный Руководитель],[Группа]) values ('" & s1 & "','" & s2 & "','" & s3 & "','" & s4 & "')"
                c.ExecuteNonQuery()
                RefreshGrid()
                OpenChildForm(New РедПрепод)
            Else
                MsgBox("Вы ввели группу", vbCritical, "Error")
                ComboBox1.Focus()
                ComboBox1.Text = ""

            End If

        Else
            c.CommandText = "insert into Учителя([ФИО],[Предмет],[Классный Руководитель],[Группа]) values ('" & s1 & "','" & s2 & "','" & s3 & "','" & s4 & "')"
            c.ExecuteNonQuery()
            RefreshGrid()
            OpenChildForm(New РедПрепод)
        End If
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
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Учителя"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Учителя")
        РедПрепод.DataGridView1.DataSource = ds
        РедПрепод.DataGridView1.DataMember = "Учителя"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.Text = "Нет" Then
            ComboBox1.Text = ""
        End If
    End Sub
    Private Sub GR()
        Dim i As String
        i = MsgBox("Нет нужной группы?", vbInformation + vbYesNo)
        If i = vbYes Then
            OpenChildForm(New РедГрупп)
        ElseIf i = vbNo Then
            MsgBox("Заполните строку группы")
        End If
    End Sub

End Class