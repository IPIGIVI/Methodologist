<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Экз
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.КодЭкзаменаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГруппаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДисциплинаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПреподавательDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АудиторияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДатаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПродолжительностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЭкзаменBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Новые_базы_данныDataSet = New Отделение.Новые_базы_данныDataSet()
        Me.ЭкзаменTableAdapter = New Отделение.Новые_базы_данныDataSetTableAdapters.ЭкзаменTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЭкзаменBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Новые_базы_данныDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(136, 320)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 20)
        Me.TextBox1.TabIndex = 36
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(361, 320)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 23)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Поиск"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(464, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Обновить"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Экзамены"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(684, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(574, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Удалить"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодЭкзаменаDataGridViewTextBoxColumn, Me.ГруппаDataGridViewTextBoxColumn, Me.ДисциплинаDataGridViewTextBoxColumn, Me.ПреподавательDataGridViewTextBoxColumn, Me.АудиторияDataGridViewTextBoxColumn, Me.ДатаDataGridViewTextBoxColumn, Me.ПродолжительностьDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ЭкзаменBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 250)
        Me.DataGridView1.TabIndex = 12
        '
        'КодЭкзаменаDataGridViewTextBoxColumn
        '
        Me.КодЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "КодЭкзамена"
        Me.КодЭкзаменаDataGridViewTextBoxColumn.HeaderText = "КодЭкзамена"
        Me.КодЭкзаменаDataGridViewTextBoxColumn.Name = "КодЭкзаменаDataGridViewTextBoxColumn"
        Me.КодЭкзаменаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ГруппаDataGridViewTextBoxColumn
        '
        Me.ГруппаDataGridViewTextBoxColumn.DataPropertyName = "Группа"
        Me.ГруппаDataGridViewTextBoxColumn.HeaderText = "Группа"
        Me.ГруппаDataGridViewTextBoxColumn.Name = "ГруппаDataGridViewTextBoxColumn"
        Me.ГруппаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ДисциплинаDataGridViewTextBoxColumn
        '
        Me.ДисциплинаDataGridViewTextBoxColumn.DataPropertyName = "Дисциплина"
        Me.ДисциплинаDataGridViewTextBoxColumn.HeaderText = "Дисциплина"
        Me.ДисциплинаDataGridViewTextBoxColumn.Name = "ДисциплинаDataGridViewTextBoxColumn"
        Me.ДисциплинаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ПреподавательDataGridViewTextBoxColumn
        '
        Me.ПреподавательDataGridViewTextBoxColumn.DataPropertyName = "Преподаватель"
        Me.ПреподавательDataGridViewTextBoxColumn.HeaderText = "Преподаватель"
        Me.ПреподавательDataGridViewTextBoxColumn.Name = "ПреподавательDataGridViewTextBoxColumn"
        Me.ПреподавательDataGridViewTextBoxColumn.ReadOnly = True
        '
        'АудиторияDataGridViewTextBoxColumn
        '
        Me.АудиторияDataGridViewTextBoxColumn.DataPropertyName = "Аудитория"
        Me.АудиторияDataGridViewTextBoxColumn.HeaderText = "Аудитория"
        Me.АудиторияDataGridViewTextBoxColumn.Name = "АудиторияDataGridViewTextBoxColumn"
        Me.АудиторияDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ДатаDataGridViewTextBoxColumn
        '
        Me.ДатаDataGridViewTextBoxColumn.DataPropertyName = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.Name = "ДатаDataGridViewTextBoxColumn"
        Me.ДатаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ПродолжительностьDataGridViewTextBoxColumn
        '
        Me.ПродолжительностьDataGridViewTextBoxColumn.DataPropertyName = "Продолжительность"
        Me.ПродолжительностьDataGridViewTextBoxColumn.HeaderText = "Продолжительность"
        Me.ПродолжительностьDataGridViewTextBoxColumn.Name = "ПродолжительностьDataGridViewTextBoxColumn"
        Me.ПродолжительностьDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ЭкзаменBindingSource
        '
        Me.ЭкзаменBindingSource.DataMember = "Экзамен"
        Me.ЭкзаменBindingSource.DataSource = Me.Новые_базы_данныDataSet
        '
        'Новые_базы_данныDataSet
        '
        Me.Новые_базы_данныDataSet.DataSetName = "Новые_базы_данныDataSet"
        Me.Новые_базы_данныDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЭкзаменTableAdapter
        '
        Me.ЭкзаменTableAdapter.ClearBeforeFill = True
        '
        'Экз
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Экз"
        Me.Text = "Экз"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЭкзаменBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Новые_базы_данныDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Новые_базы_данныDataSet As Новые_базы_данныDataSet
    Friend WithEvents ЭкзаменBindingSource As BindingSource
    Friend WithEvents ЭкзаменTableAdapter As Новые_базы_данныDataSetTableAdapters.ЭкзаменTableAdapter
    Friend WithEvents КодЭкзаменаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГруппаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДисциплинаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПреподавательDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents АудиторияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДатаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПродолжительностьDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
