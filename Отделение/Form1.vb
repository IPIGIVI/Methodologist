Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Form1
    Private currentbtn As IconButton
    Private RightBorderBtn As Panel
    Private currentChildForm As Form


    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().
        RightBorderBtn = New Panel()
        RightBorderBtn.Size = New Size(7, 60)
        Panel1.Controls.Add(RightBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            Disablebutton()
            currentbtn = CType(senderBtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.ForeColor = customColor
            currentbtn.IconColor = customColor
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            RightBorderBtn.BackColor = customColor
            RightBorderBtn.Location = New Point(0, currentbtn.Location.Y)
            RightBorderBtn.Visible = True
            RightBorderBtn.BringToFront()
            IconPictureBox1.IconChar = currentbtn.IconChar
            IconPictureBox1.IconColor = customColor
        End If
    End Sub
    Private Sub Disablebutton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(51, 51, 100)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText
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
        Panel3.Controls.Add(childForm)
        Panel3.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        Label1.Text = childForm.Text
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, RGBcolor.color2)
        OpenChildForm(New Выговоры)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, RGBcolor.color3)
        OpenChildForm(New Добавить)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender, RGBcolor.color4)
        OpenChildForm(New Премия)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ActivateButton(sender, RGBcolor.color5)
        OpenChildForm(New Экз)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) 
        ActivateButton(sender, RGBcolor.color6)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        Disablebutton()
        RightBorderBtn.Visible = False
        IconPictureBox1.IconChar = IconChar.Home
        IconPictureBox1.IconColor = Color.FromArgb(192, 192, 255)
        Label1.Text = "Home"
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        If InputBox("Введите пароль администратора", "Права администратора") <> "777" Then
            Exit Sub
        Else
            ActivateButton(sender, RGBcolor.color1)
            OpenChildForm(New user)
        End If
    End Sub
End Class
