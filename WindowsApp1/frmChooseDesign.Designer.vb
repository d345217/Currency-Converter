<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseDesign
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDesign1 = New System.Windows.Forms.Button()
        Me.btnDesign2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Currency Converter Made by Maksym Chernenko!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDesign1
        '
        Me.btnDesign1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesign1.Location = New System.Drawing.Point(169, 237)
        Me.btnDesign1.Name = "btnDesign1"
        Me.btnDesign1.Size = New System.Drawing.Size(89, 45)
        Me.btnDesign1.TabIndex = 1
        Me.btnDesign1.Text = "Design1"
        Me.btnDesign1.UseVisualStyleBackColor = True
        '
        'btnDesign2
        '
        Me.btnDesign2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesign2.Location = New System.Drawing.Point(169, 305)
        Me.btnDesign2.Name = "btnDesign2"
        Me.btnDesign2.Size = New System.Drawing.Size(89, 45)
        Me.btnDesign2.TabIndex = 2
        Me.btnDesign2.Text = "Design2"
        Me.btnDesign2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Choose this if you want to convert Pound to Any"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(326, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Choose this if you want to convert Any to Any"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(165, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 57)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Please choose design which you want to use and have a great time!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmChooseDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDesign2)
        Me.Controls.Add(Me.btnDesign1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChooseDesign"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDesign1 As Button
    Friend WithEvents btnDesign2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
