<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class РасчетПремии
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.КодЗанятияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФИОПреподавателяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПредметDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяПроведенияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЗанятияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Новые_базы_данныDataSet = New Отделение.Новые_базы_данныDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.УчителяBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.УчителяTableAdapter = New Отделение.Новые_базы_данныDataSetTableAdapters.УчителяTableAdapter()
        Me.ЗанятияTableAdapter = New Отделение.Новые_базы_данныDataSetTableAdapters.ЗанятияTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗанятияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Новые_базы_данныDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.УчителяBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 2
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодЗанятияDataGridViewTextBoxColumn, Me.ФИОПреподавателяDataGridViewTextBoxColumn, Me.ПредметDataGridViewTextBoxColumn, Me.ВремяПроведенияDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ЗанятияBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(15, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(441, 250)
        Me.DataGridView1.TabIndex = 47
        '
        'КодЗанятияDataGridViewTextBoxColumn
        '
        Me.КодЗанятияDataGridViewTextBoxColumn.DataPropertyName = "КодЗанятия"
        Me.КодЗанятияDataGridViewTextBoxColumn.HeaderText = "КодЗанятия"
        Me.КодЗанятияDataGridViewTextBoxColumn.Name = "КодЗанятияDataGridViewTextBoxColumn"
        Me.КодЗанятияDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ФИОПреподавателяDataGridViewTextBoxColumn
        '
        Me.ФИОПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "ФИО преподавателя"
        Me.ФИОПреподавателяDataGridViewTextBoxColumn.HeaderText = "ФИО преподавателя"
        Me.ФИОПреподавателяDataGridViewTextBoxColumn.Name = "ФИОПреподавателяDataGridViewTextBoxColumn"
        Me.ФИОПреподавателяDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ПредметDataGridViewTextBoxColumn
        '
        Me.ПредметDataGridViewTextBoxColumn.DataPropertyName = "Предмет"
        Me.ПредметDataGridViewTextBoxColumn.HeaderText = "Предмет"
        Me.ПредметDataGridViewTextBoxColumn.Name = "ПредметDataGridViewTextBoxColumn"
        Me.ПредметDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ВремяПроведенияDataGridViewTextBoxColumn
        '
        Me.ВремяПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Время проведения"
        Me.ВремяПроведенияDataGridViewTextBoxColumn.HeaderText = "Время проведения"
        Me.ВремяПроведенияDataGridViewTextBoxColumn.Name = "ВремяПроведенияDataGridViewTextBoxColumn"
        Me.ВремяПроведенияDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ЗанятияBindingSource
        '
        Me.ЗанятияBindingSource.DataMember = "Занятия"
        Me.ЗанятияBindingSource.DataSource = Me.Новые_базы_данныDataSet
        '
        'Новые_базы_данныDataSet
        '
        Me.Новые_базы_данныDataSet.DataSetName = "Новые_базы_данныDataSet"
        Me.Новые_базы_данныDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(574, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Очистить"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox2.Location = New System.Drawing.Point(635, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 46
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ComboBox4.DisplayMember = "Группа"
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.ItemHeight = 13
        Me.ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox4.Location = New System.Drawing.Point(415, 30)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox4.TabIndex = 45
        Me.ComboBox4.ValueMember = "Группа"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ComboBox3.DisplayMember = "Группа"
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.ItemHeight = 13
        Me.ComboBox3.Items.AddRange(New Object() {"Информатика", "История", "Физика", "Математика", "Литература ", "Русский язык ", "Курсы по photoshop"})
        Me.ComboBox3.Location = New System.Drawing.Point(288, 29)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 44
        Me.ComboBox3.ValueMember = "Группа"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ComboBox2.DisplayMember = "Группа"
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBox2.Location = New System.Drawing.Point(161, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 43
        Me.ComboBox2.ValueMember = "Группа"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(412, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Число занянтий в неделю"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(158, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Длительность занятия"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(684, 417)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(15, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(632, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Результат"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(285, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Предмет"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ФИО преподавателя"
        '
        'УчителяBindingSource
        '
        Me.УчителяBindingSource.DataMember = "Учителя"
        Me.УчителяBindingSource.DataSource = Me.Новые_базы_данныDataSet
        '
        'УчителяTableAdapter
        '
        Me.УчителяTableAdapter.ClearBeforeFill = True
        '
        'ЗанятияTableAdapter
        '
        Me.ЗанятияTableAdapter.ClearBeforeFill = True
        '
        'РасчетПремии
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "РасчетПремии"
        Me.Text = "РасчетПремии"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗанятияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Новые_базы_данныDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.УчителяBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Новые_базы_данныDataSet As Новые_базы_данныDataSet
    Friend WithEvents УчителяBindingSource As BindingSource
    Friend WithEvents УчителяTableAdapter As Новые_базы_данныDataSetTableAdapters.УчителяTableAdapter
    Friend WithEvents ЗанятияBindingSource As BindingSource
    Friend WithEvents ЗанятияTableAdapter As Новые_базы_данныDataSetTableAdapters.ЗанятияTableAdapter
    Friend WithEvents КодЗанятияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ФИОПреподавателяDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПредметDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВремяПроведенияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
