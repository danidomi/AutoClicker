<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IntervalInput = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumberOfClicksInput = New System.Windows.Forms.TextBox()
        Me.Interval = New System.Windows.Forms.Button()
        Me.NumberClicks = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start = f3"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IntervalInput
        '
        Me.IntervalInput.Location = New System.Drawing.Point(166, 84)
        Me.IntervalInput.Name = "IntervalInput"
        Me.IntervalInput.Size = New System.Drawing.Size(75, 20)
        Me.IntervalInput.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(166, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop = f4"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumberOfClicksInput
        '
        Me.NumberOfClicksInput.Location = New System.Drawing.Point(166, 125)
        Me.NumberOfClicksInput.Name = "NumberOfClicksInput"
        Me.NumberOfClicksInput.Size = New System.Drawing.Size(75, 20)
        Me.NumberOfClicksInput.TabIndex = 3
        '
        'Interval
        '
        Me.Interval.Location = New System.Drawing.Point(46, 80)
        Me.Interval.Name = "Interval"
        Me.Interval.Size = New System.Drawing.Size(75, 24)
        Me.Interval.TabIndex = 4
        Me.Interval.Text = "Interval"
        Me.Interval.UseVisualStyleBackColor = True
        '
        'NumberClicks
        '
        Me.NumberClicks.Location = New System.Drawing.Point(46, 124)
        Me.NumberClicks.Name = "NumberClicks"
        Me.NumberClicks.Size = New System.Drawing.Size(75, 24)
        Me.NumberClicks.TabIndex = 6
        Me.NumberClicks.Text = "NumberClicks"
        Me.NumberClicks.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(46, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 24)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Test Clicks"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(166, 173)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "0"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 257)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.NumberClicks)
        Me.Controls.Add(Me.Interval)
        Me.Controls.Add(Me.NumberOfClicksInput)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.IntervalInput)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Auto Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IntervalInput As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NumberOfClicksInput As System.Windows.Forms.TextBox
    Friend WithEvents Interval As System.Windows.Forms.Button
    Friend WithEvents NumberClicks As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
