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
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblGravity = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.Location = New System.Drawing.Point(14, 323)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(76, 24)
        Me.lblSpeed.TabIndex = 7
        Me.lblSpeed.Text = "Speed: "
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(130, 113)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(117, 20)
        Me.txtTime.TabIndex = 6
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(14, 108)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(90, 24)
        Me.lblSeconds.TabIndex = 5
        Me.lblSeconds.Text = "Seconds:"
        '
        'lblGravity
        '
        Me.lblGravity.AutoSize = True
        Me.lblGravity.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGravity.Location = New System.Drawing.Point(12, 9)
        Me.lblGravity.Name = "lblGravity"
        Me.lblGravity.Size = New System.Drawing.Size(101, 31)
        Me.lblGravity.TabIndex = 4
        Me.lblGravity.Text = "Gravity"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(115, 323)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(20, 24)
        Me.lblNumber.TabIndex = 8
        Me.lblNumber.Text = "0"
        '
        'lblCalculate
        '
        Me.lblCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculate.Location = New System.Drawing.Point(18, 221)
        Me.lblCalculate.Name = "lblCalculate"
        Me.lblCalculate.Size = New System.Drawing.Size(117, 36)
        Me.lblCalculate.TabIndex = 9
        Me.lblCalculate.Text = "Calculate Speed"
        Me.lblCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 453)
        Me.Controls.Add(Me.lblCalculate)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblGravity)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents lblGravity As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblCalculate As System.Windows.Forms.Button

End Class
