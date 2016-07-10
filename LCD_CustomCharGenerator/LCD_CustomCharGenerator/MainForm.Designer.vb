<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LCDPanel = New System.Windows.Forms.Panel()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.ArduinoCodeBox = New System.Windows.Forms.TextBox()
        Me.GenCodeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CharNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelectAllButton = New System.Windows.Forms.Button()
        Me.InvertButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LCDPanel
        '
        Me.LCDPanel.BackColor = System.Drawing.Color.GreenYellow
        Me.LCDPanel.Location = New System.Drawing.Point(13, 110)
        Me.LCDPanel.Name = "LCDPanel"
        Me.LCDPanel.Size = New System.Drawing.Size(110, 165)
        Me.LCDPanel.TabIndex = 42
        '
        'OutputBox
        '
        Me.OutputBox.BackColor = System.Drawing.Color.White
        Me.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputBox.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.OutputBox.ForeColor = System.Drawing.Color.Black
        Me.OutputBox.Location = New System.Drawing.Point(155, 110)
        Me.OutputBox.Multiline = True
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.ReadOnly = True
        Me.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.OutputBox.Size = New System.Drawing.Size(159, 183)
        Me.OutputBox.TabIndex = 43
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(13, 281)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 23)
        Me.ClearButton.TabIndex = 44
        Me.ClearButton.Text = "Clear Pixels"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(155, 308)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(159, 23)
        Me.CopyButton.TabIndex = 45
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'ArduinoCodeBox
        '
        Me.ArduinoCodeBox.BackColor = System.Drawing.Color.White
        Me.ArduinoCodeBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ArduinoCodeBox.ForeColor = System.Drawing.Color.Black
        Me.ArduinoCodeBox.Location = New System.Drawing.Point(355, 23)
        Me.ArduinoCodeBox.Multiline = True
        Me.ArduinoCodeBox.Name = "ArduinoCodeBox"
        Me.ArduinoCodeBox.ReadOnly = True
        Me.ArduinoCodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.ArduinoCodeBox.Size = New System.Drawing.Size(439, 337)
        Me.ArduinoCodeBox.TabIndex = 46
        Me.ArduinoCodeBox.Text = "//Your arduino code will appear here"
        '
        'GenCodeButton
        '
        Me.GenCodeButton.Location = New System.Drawing.Point(155, 337)
        Me.GenCodeButton.Name = "GenCodeButton"
        Me.GenCodeButton.Size = New System.Drawing.Size(159, 23)
        Me.GenCodeButton.TabIndex = 47
        Me.GenCodeButton.Text = "Generate Arduino Code"
        Me.GenCodeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Enter your character name :"
        '
        'CharNameTextBox
        '
        Me.CharNameTextBox.Location = New System.Drawing.Point(157, 70)
        Me.CharNameTextBox.MaxLength = 10
        Me.CharNameTextBox.Name = "CharNameTextBox"
        Me.CharNameTextBox.Size = New System.Drawing.Size(159, 20)
        Me.CharNameTextBox.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 39)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "(HD44780)"
        '
        'SelectAllButton
        '
        Me.SelectAllButton.Location = New System.Drawing.Point(15, 310)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(108, 23)
        Me.SelectAllButton.TabIndex = 51
        Me.SelectAllButton.Text = "Select All"
        Me.SelectAllButton.UseVisualStyleBackColor = True
        '
        'InvertButton
        '
        Me.InvertButton.Location = New System.Drawing.Point(15, 339)
        Me.InvertButton.Name = "InvertButton"
        Me.InvertButton.Size = New System.Drawing.Size(108, 23)
        Me.InvertButton.TabIndex = 52
        Me.InvertButton.Text = "Invert"
        Me.InvertButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(806, 376)
        Me.Controls.Add(Me.InvertButton)
        Me.Controls.Add(Me.SelectAllButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CharNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenCodeButton)
        Me.Controls.Add(Me.ArduinoCodeBox)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.LCDPanel)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LCD Custom Character Generator :)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LCDPanel As System.Windows.Forms.Panel
    Friend WithEvents OutputBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents ArduinoCodeBox As System.Windows.Forms.TextBox
    Friend WithEvents GenCodeButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CharNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelectAllButton As System.Windows.Forms.Button
    Friend WithEvents InvertButton As System.Windows.Forms.Button

End Class
