Imports System.Data.OleDb
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class РедЭкз
    Private currentChildForm As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New Экз)
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
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

    Private Sub РедЭкз_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Новые_базы_данныDataSet.Группа". При необходимости она может быть перемещена или удалена.
        Me.ГруппаTableAdapter.Fill(Me.Новые_базы_данныDataSet.Группа)
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Новые базы данны.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s2, s3, s4, s5, s6 As String
        Dim r As DialogResult
        s1 = ComboBox1.Text 'Группа
        s2 = TextBox1.Text 'Дисциплина
        s3 = TextBox2.Text 'Преподаватель
        s4 = TextBox3.Text 'Аудитория
        s5 = DateTimePicker1.Value 'Дата
        s6 = TextBox4.Text 'Продолжительность
        r = DialogResult
        Dim c As New OleDbCommand
        Try
            If Proverka_Word_RUS_FIO(TextBox2) = False Then Exit Sub
            If Proverka_Word_RUS_chislo(TextBox3) = False Then Exit Sub
            If Proverka_Chislo(TextBox3) = False Then Exit Sub
            If ComboBox1.Text = "" Then
                GR()
            ElseIf TextBox2.Text = "" Then
                MsgBox("Укажите дисциплину по которой будет проходить экзамен", vbCritical, "Error")
            ElseIf TextBox2.Text = "" Then
                MsgBox("Укажите преподавателя принимающего экзамен", vbCritical, "Error")
            ElseIf TextBox3.Text = "" Then
                MsgBox("Укажите аудиторию в которой будет вестись экзамен", vbCritical, "Error")
            ElseIf TextBox4.Text = "" Then
                MsgBox("Укажите продолжительность экзамена", vbCritical, "Error")
            Else
                c.Connection = conn
                c.CommandText = "insert into Экзамен(Группа,Дисциплина,Преподаватель,Аудитория,Дата,Продолжительность) values ('" & s1 & "','" & s2 & "','" & s3 & "','" & s4 & "','" & s5 & "','" & s6 & "')"
                c.ExecuteNonQuery()
                RefreshGrid()
                OpenChildForm(New Экз)
            End If
        Catch ex As Exception
            MessageBox.Show("Произошла ошибка при вставке данных в базу данных: " & ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Экзамен"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Экзамен")
        Экз.DataGridView1.DataSource = ds
        Экз.DataGridView1.DataMember = "Экзамен"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "" 'Дисциплина
        TextBox2.Text = "" 'Преподаватель
        TextBox3.Text = "" 'Аудитория
        TextBox4.Text = "" 'Продолжительность
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