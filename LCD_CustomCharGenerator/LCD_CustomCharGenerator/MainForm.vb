Public Class MainForm

#Region "My Methods"

    Private Sub SetUpLCDpixels()

        Dim LocationX As Integer = 10
        Dim LocationY As Integer = 10
        For Row As Integer = 0 To 7 Step 1
            For Column As Integer = 0 To 4 Step 1
                Dim PixelBox As New CheckBox()
                With PixelBox
                    .Appearance = System.Windows.Forms.Appearance.Button
                    .AutoSize = True
                    .BackColor = System.Drawing.Color.White
                    .FlatAppearance.BorderColor = System.Drawing.Color.White
                    .FlatAppearance.BorderSize = 0
                    .FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
                    .FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
                    .FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
                    .FlatStyle = System.Windows.Forms.FlatStyle.Flat
                    .Location = New System.Drawing.Point(LocationX, LocationY)
                    .Name = "Pixel_" & Row & Column
                    .Text = ""
                    .Size = New System.Drawing.Size(6, 6)
                    .TabIndex = 0
                    .Tag = Row & Column
                    .UseCompatibleTextRendering = True
                    .UseVisualStyleBackColor = False
                End With
                LCDPanel.Controls.Add(PixelBox)
                AddHandler PixelBox.Click, AddressOf GenerateOutput
                AddHandler PixelBox.CheckedChanged, AddressOf GenerateOutput
                LocationX = LocationX + 20
            Next
            LocationX = 10
            LocationY = LocationY + 20
        Next

    End Sub

    Private Sub ClearPixels()
        For Each Box In LCDPanel.Controls
            If TypeOf Box Is CheckBox Then
                DirectCast(Box, CheckBox).Checked = False
            End If
        Next
        OutputBox.Clear()
        ArduinoCodeBox.Clear()
    End Sub
    Private Sub SelectAll()
        For Each Box In LCDPanel.Controls
            If TypeOf Box Is CheckBox Then
                DirectCast(Box, CheckBox).Checked = True
            End If
        Next
        GenerateOutput()
    End Sub
    Private Sub Invert()
        For Each Box In LCDPanel.Controls
            If TypeOf Box Is CheckBox Then
                Dim PixelBox As CheckBox = DirectCast(Box, CheckBox)
                If (PixelBox.Checked) Then
                    PixelBox.Checked = False
                ElseIf Not PixelBox.Checked Then
                    PixelBox.Checked = True
                End If
            End If
        Next
        GenerateOutput()
    End Sub
    Private Sub GenerateOutput()
        OutputBox.Clear()

        Dim RowsLCD(7) As Integer
        Dim ColumnsLCD(4) As Integer

        If String.IsNullOrEmpty(CharNameTextBox.Text) Then
            OutputBox.AppendText("byte myCharacter[8] = {" & vbCrLf)
        Else
            OutputBox.AppendText("byte " & CharNameTextBox.Text.Replace(" ", "") & "[8] = {" & vbCrLf)
        End If

        For Each Box In LCDPanel.Controls
            If TypeOf Box Is CheckBox Then
                Dim Pixel As CheckBox = CType(Box, CheckBox)
                Dim PixelRow As Integer = Integer.Parse(CType(Pixel.Tag, String).ElementAt(0))
                Dim PixelColumn As Integer = Integer.Parse(CType(Pixel.Tag, String).ElementAt(1))
                'RichTextBox1.AppendText(Pixel.Name & " : " & PixelRow & PixelColumn & " " & (IIf(Pixel.Checked, "Checked", "Unchecked")) & vbCrLf)
                If Pixel.CheckState = CheckState.Checked Then
                    RowsLCD(PixelRow) = 1
                    ColumnsLCD(PixelColumn) = 1
                ElseIf Pixel.CheckState = CheckState.Unchecked Then
                    RowsLCD(PixelRow) = 0
                    ColumnsLCD(PixelColumn) = 0
                End If
                If PixelColumn = 0 Then
                    OutputBox.AppendText(vbTab & "0b")
                End If
                If PixelColumn = 4 Then
                    'RichTextBox1.AppendText(RowsLCD(PixelRow) & ColumnsLCD(PixelColumn) & " ")
                    If Not PixelRow = 7 Then
                        OutputBox.AppendText(RowsLCD(PixelRow) & ",")
                    Else
                        OutputBox.AppendText(RowsLCD(PixelRow))
                    End If
                    OutputBox.AppendText(vbCrLf)
                Else
                    'RichTextBox1.AppendText(RowsLCD(PixelRow) & ColumnsLCD(PixelColumn) & " ")
                    OutputBox.AppendText(RowsLCD(PixelRow))
                End If
                'RichTextBox1.AppendText(RowsLCD(PixelRow) & ColumnsLCD(PixelColumn) & " ")
                'Dim r As Integer = Integer.Parse(PixelData)
                'Dim r As Char = PixelData.ElementAt(0)
            End If
        Next
        OutputBox.AppendText(vbTab & "};")

        'Threading.Thread.Sleep(1000)
        'For Each bit In RowsLCD
        '    For Each nextbit In ColumnsLCD
        '        RichTextBox1.AppendText(nextbit & " ")
        '    Next
        '    '             RichTextBox1.AppendText(vbCrLf & bit & " ")
        '    RichTextBox1.AppendText(vbCrLf)
        'Next


        '    If TypeOf ctrl Is CheckBox Then
        '        Dim x As CheckBox = DirectCast(ctrl, CheckBox)

        '        Dim rc As String = CType(x.Tag, String)

        '        RichTextBox1.AppendText(x.Name & " : " & rc & vbCrLf)
        '    End If
    End Sub

    Private Sub GenerateArduinoCode()
        ArduinoCodeBox.Clear()
        With ArduinoCodeBox
            .AppendText("#include <LiquidCrystal.h>" & vbCrLf)
            .AppendText("//Your respective LCD to Arduino pin numbers" & vbCrLf)
            .AppendText("LiquidCrystal lcd(12, 11, 5, 4, 3, 2);" & vbCrLf)
            .AppendText(OutputBox.Text & vbCrLf)
            .AppendText("void setup()" & vbCrLf & "{" & vbCrLf)
            If String.IsNullOrEmpty(CharNameTextBox.Text) Then
                .AppendText(vbTab & "lcd.createChar(0," & "myCharacter" & ");" & vbCrLf)
            Else
                .AppendText(vbTab & "lcd.createChar(0," & CharNameTextBox.Text & ");" & vbCrLf)
            End If
            .AppendText(vbTab & "lcd.begin(16, 2);" & vbCrLf)
            .AppendText(vbTab & "lcd.write((uint8_t) 0);" & vbCrLf)
            .AppendText("}" & vbCrLf)
            .AppendText("void loop()" & vbCrLf & "{" & vbCrLf & "}")
        End With
    End Sub

    'Public Sub DisplayOutput()
    '    For row As Integer = 0 To RowsLCD.Length - 1 Step 1
    '        For col As Integer = 0 To ColumnsLCD.Length - 1 Step 1
    '            Dim CurrentPixel As Integer = 0
    '            RichTextBox1.AppendText(RowsLCD(row) & ColumnsLCD(col) & " ")
    '            'If (RowsLCD(row) = 1 And ColumnsLCD(col) = 1) Then
    '            '    CurrentPixel = 1
    '            '    RichTextBox1.AppendText(CurrentPixel & " ")
    '            'Else
    '            '    CurrentPixel = 0
    '            '    RichTextBox1.AppendText(CurrentPixel & " ")
    '            'End If
    '        Next
    '        RichTextBox1.AppendText(vbCrLf)
    '    Next
    'End Sub

#End Region

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUpLCDpixels()
    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearPixels()
    End Sub


    Private Sub GenCodeButton_Click(sender As Object, e As EventArgs) Handles GenCodeButton.Click
        GenerateArduinoCode()
    End Sub

    Private Sub CharNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CharNameTextBox.TextChanged
        CharNameTextBox.Text.Replace(" ", "")
        If Not String.IsNullOrEmpty(CharNameTextBox.Text) Then
            GenerateOutput()
        Else
            OutputBox.Clear()
        End If
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        If String.IsNullOrEmpty(OutputBox.Text) Then
            MsgBox("No pixels were selected for code the to generate", MsgBoxStyle.Exclamation)
        Else
            My.Computer.Clipboard.SetText(OutputBox.Text)
        End If
    End Sub    

    Private Sub SelectAllButton_Click(sender As Object, e As EventArgs) Handles SelectAllButton.Click
        SelectAll()
    End Sub

    Private Sub InvertButton_Click(sender As Object, e As EventArgs) Handles InvertButton.Click
        Invert()
    End Sub
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MsgBox("Developed by alshell7", MsgBoxStyle.Information)
    End Sub
End Class
