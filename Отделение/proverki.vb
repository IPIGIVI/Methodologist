Module proverki
    Public Function Checking(ByVal TextField As TextBox) As Boolean
        Dim I As Integer
        Dim s As String
        For I = 1 To Len(TextField.Text)
            s = Mid(TextField.Text, I, 1)
        Next
        If s Like "[а-яА-Я]" Or s = "." Or s = "/" Or s Like "[0-9]" Then
            Checking = True
        Else
            Checking = False
            MsgBox("Введите данные русскими символами", vbCritical, "Error")
            TextField.Clear()
            TextField.Focus()
        End If
    End Function

    Public Function Proverka_Word_RUS_FIO(ByVal TextField As TextBox) As Boolean
        Dim I As Integer, s As String
        For I = 1 To Len(TextField.Text)
            s = Mid(TextField.Text, I, 1)
        Next
        If s Like "[а-яА-Я]" Or s = "." Then
            Proverka_Word_RUS_FIO = True
        Else
            Proverka_Word_RUS_FIO = False
            MsgBox("Введите данные русскими символами", vbCritical, "Error")
            TextField.Clear()
            TextField.Focus()
        End If
    End Function

    Public Function Proverka_Word_RUS_ADDRESS(ByVal TextField As TextBox) As Boolean
        Dim I As Integer, s As String
        For I = 1 To Len(TextField.Text)
            s = Mid(TextField.Text, I, 1)
        Next
        If s Like "[а-яА-Я]" Or s = "." Or s = "/" Or s = "-" Or s = "," Or s Like "[0-9]" Then
            Proverka_Word_RUS_ADDRESS = True
        Else
            Proverka_Word_RUS_ADDRESS = False
            MsgBox("Введите данные русскими символами", vbCritical, "Error")
            TextField.Clear()
            TextField.Focus()
        End If
    End Function

    'Функция проверки текстового поля на русские символы и цифры
    Public Function Proverka_Word_RUS_chislo(ByVal TextField As TextBox) As Boolean
        Dim s As String 'Объявление переменной s
        For I = 1 To Len(TextField.Text)   'Цикл повторяется в зависимости от длины строки
            s = Mid(TextField.Text, I, 1)   'Присвоить переменной s символ с индексом i
        Next
        If ((s Like "[а-яА-Я]") Or (IsNumeric(s))) Then     'Если s это русская буква или цифра тогда условие выполняется
            Proverka_Word_RUS_chislo = True     'Присвоить True 
        Else
            Proverka_Word_RUS_chislo = False    'Присвоить False
            MsgBox("Введите корректные данные", vbCritical, "Error") 'Сообщение об ошибке
            TextField.Focus()                    'Передача фокуса полю
        End If
    End Function

    Public Function Proverka_Word_RUS_chek(ByVal TextField As ComboBox) As Boolean
        Dim I As Integer, s As String
        For I = 1 To Len(TextField.Text)
            s = Mid(TextField.Text, I, 1)
        Next
        If ((s Like "[а-яА-Я]") Or (IsNumeric(TextField.Text))) Then
            Proverka_Word_RUS_chek = True
        Else
            Proverka_Word_RUS_chek = False
            MsgBox("Выберите необходимый элемент из списка", vbCritical, "Error")
            TextField.Focus()
            TextField.Text = ""
        End If
    End Function

    Public Function Proverka_Word_RUS(ByVal TextField As TextBox) As Boolean
        Dim I As Integer, s As String
        For I = 1 To Len(TextField.Text)
            s = Mid(TextField.Text, I, 1)
        Next
        If s Like "[а-яА-Я]" Then
            Proverka_Word_RUS = True
        Else
            Proverka_Word_RUS = False
            MsgBox("Введите данные русскими символами", vbCritical, "Error")
            TextField.Clear()
            TextField.Focus()
        End If
    End Function

    'Функция проверки текстового поля на цифры
    Public Function Proverka_Chislo(ByVal TextField As TextBox) As Boolean
        If TextField.Text = "" Then
            Proverka_Chislo = False
            MsgBox("Введите данные", vbCritical, "Error")
            Exit Function
        ElseIf Not IsNumeric(TextField.Text) Then   'Если строка яв-ся числом тогда условие выполняется
            Proverka_Chislo = False
            MsgBox("Введите данные цифрами", vbCritical, "Error")   'Сообщение об ошибке
            TextField.Clear()       'Очистить поле
            TextField.Focus()        'Передача фокуса полю
            Exit Function
        End If
        Proverka_Chislo = True      'Вернуть True
    End Function

    Public Function Proverka_BALL(ByVal TextField As TextBox) As Boolean
        If TextField.Text = "" Then
            Proverka_BALL = False
            MsgBox("Введите данные", vbCritical, "Error")
            Exit Function
        ElseIf Not IsNumeric(TextField.Text) Then   'Если строка яв-ся числом тогда условие выполняется
            Proverka_BALL = False 'Присвоить False
            MsgBox("Введите цифру", vbCritical, "Error")   'Сообщение об ошибке
            TextField.Clear()       'Очистить поле
            TextField.Focus()        'Передача фокуса полю
            Exit Function
        ElseIf CInt(TextField.Text) < 0 Or CInt(TextField.Text) > 100 Then
            Proverka_BALL = False
            MsgBox("Введите количество баллов от 1 до 100", vbCritical, "Error")   'Сообщение об ошибке
            TextField.Clear()       'Очистить поле
            TextField.Focus()        'Передача фокуса полю
            Exit Function
        End If
        Proverka_BALL = True      'Вернуть True
    End Function

    'Функция проверки на пустое поле
    Public Function Proverka_NULL(ByVal TextField As TextBox) As Boolean
        If TextField.Text = "" Then
            Proverka_NULL = False
            MsgBox("Введите данные", vbCritical, "Error")
            Exit Function
        End If
        Proverka_NULL = True
    End Function

    'Функция переводит первые Букву в заглавную
    Public Function U_Case(ByVal TextField As TextBox) As Boolean
        Dim a, b As String  'Объявление переменных
        a = Mid(TextField.Text, 1, 1)   'Отделим первый символ строки и переведем в заглавную букву
        b = Mid(TextField.Text, 2)      'Отделим все остальне символы
        TextField.Text = UCase(a) & b   'Вернуть новую строку 
    End Function
End Module
