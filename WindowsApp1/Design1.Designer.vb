<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Design1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstCountries = New System.Windows.Forms.ListBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstEntries1 = New System.Windows.Forms.ListBox()
        Me.btnSave1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Currency Exchange (Pound to Any)"
        '
        'lstCountries
        '
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.Location = New System.Drawing.Point(184, 103)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(120, 43)
        Me.lstCountries.TabIndex = 20
        '
        'txtRate
        '
        Me.txtRate.Enabled = False
        Me.txtRate.Location = New System.Drawing.Point(184, 182)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 21
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(184, 236)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 22
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(184, 285)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 23
        '
        'btnCalculate1
        '
        Me.btnCalculate1.Location = New System.Drawing.Point(360, 285)
        Me.btnCalculate1.Name = "btnCalculate1"
        Me.btnCalculate1.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate1.TabIndex = 24
        Me.btnCalculate1.Text = "Calculate"
        Me.btnCalculate1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Conversion Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Total"
        '
        'lstEntries1
        '
        Me.lstEntries1.FormattingEnabled = True
        Me.lstEntries1.Location = New System.Drawing.Point(498, 103)
        Me.lstEntries1.Name = "lstEntries1"
        Me.lstEntries1.Size = New System.Drawing.Size(290, 69)
        Me.lstEntries1.TabIndex = 29
        '
        'btnSave1
        '
        Me.btnSave1.Location = New System.Drawing.Point(360, 236)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(75, 23)
        Me.btnSave1.TabIndex = 30
        Me.btnSave1.Text = "Save"
        Me.btnSave1.UseVisualStyleBackColor = True
        '
        'Design1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSave1)
        Me.Controls.Add(Me.lstEntries1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalculate1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lstCountries)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Design1"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalculate1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstEntries1 As ListBox
    Friend WithEvents btnSave1 As Button
End Class
