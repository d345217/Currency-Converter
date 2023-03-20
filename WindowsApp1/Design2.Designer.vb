<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Design2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForAss2DataSet = New WindowsApp1.ForAss2DataSet()
        Me.TblRecordTableAdapter = New WindowsApp1.ForAss2DataSetTableAdapters.tblRecordTableAdapter()
        Me.lstEntries2 = New System.Windows.Forms.ListBox()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.cboFrom = New System.Windows.Forms.ComboBox()
        Me.cboTo = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSwitch = New System.Windows.Forms.Button()
        CType(Me.TblRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForAss2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total"
        '
        'btnCalculate2
        '
        Me.btnCalculate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate2.Location = New System.Drawing.Point(154, 232)
        Me.btnCalculate2.Name = "btnCalculate2"
        Me.btnCalculate2.Size = New System.Drawing.Size(100, 55)
        Me.btnCalculate2.TabIndex = 12
        Me.btnCalculate2.Text = "Calculate"
        Me.btnCalculate2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(154, 121)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 15
        '
        'txtResult
        '
        Me.txtResult.Enabled = False
        Me.txtResult.Location = New System.Drawing.Point(154, 206)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 38)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Currency Exchange (Any to Any)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblRecordBindingSource
        '
        Me.TblRecordBindingSource.DataMember = "tblRecord"
        Me.TblRecordBindingSource.DataSource = Me.BindingSource1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.ForAss2DataSet
        Me.BindingSource1.Position = 0
        '
        'ForAss2DataSet
        '
        Me.ForAss2DataSet.DataSetName = "ForAss2DataSet"
        Me.ForAss2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRecordTableAdapter
        '
        Me.TblRecordTableAdapter.ClearBeforeFill = True
        '
        'lstEntries2
        '
        Me.lstEntries2.FormattingEnabled = True
        Me.lstEntries2.Location = New System.Drawing.Point(401, 26)
        Me.lstEntries2.Name = "lstEntries2"
        Me.lstEntries2.Size = New System.Drawing.Size(305, 316)
        Me.lstEntries2.TabIndex = 19
        '
        'txtCurrency
        '
        Me.txtCurrency.Enabled = False
        Me.txtCurrency.Location = New System.Drawing.Point(154, 163)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.ReadOnly = True
        Me.txtCurrency.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrency.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Currency"
        '
        'btnSave2
        '
        Me.btnSave2.Location = New System.Drawing.Point(349, 303)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(46, 39)
        Me.btnSave2.TabIndex = 22
        Me.btnSave2.Text = "Save"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'cboFrom
        '
        Me.cboFrom.FormattingEnabled = True
        Me.cboFrom.Location = New System.Drawing.Point(54, 77)
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.Size = New System.Drawing.Size(121, 21)
        Me.cboFrom.TabIndex = 23
        Me.cboFrom.Text = "Any"
        '
        'cboTo
        '
        Me.cboTo.FormattingEnabled = True
        Me.cboTo.Location = New System.Drawing.Point(228, 77)
        Me.cboTo.Name = "cboTo"
        Me.cboTo.Size = New System.Drawing.Size(121, 21)
        Me.cboTo.TabIndex = 24
        Me.cboTo.Text = "Any"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(154, 293)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 55)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSwitch
        '
        Me.btnSwitch.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.icon_for_switch
        Me.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSwitch.Location = New System.Drawing.Point(190, 77)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(21, 21)
        Me.btnSwitch.TabIndex = 26
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'Design2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 355)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.cboTo)
        Me.Controls.Add(Me.cboFrom)
        Me.Controls.Add(Me.btnSave2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurrency)
        Me.Controls.Add(Me.lstEntries2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalculate2)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Design2"
        Me.Text = "Exchanger"
        CType(Me.TblRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForAss2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ForAss2DataSet As ForAss2DataSet
    Friend WithEvents TblRecordBindingSource As BindingSource
    Friend WithEvents TblRecordTableAdapter As ForAss2DataSetTableAdapters.tblRecordTableAdapter
    Friend WithEvents lstEntries2 As ListBox
    Friend WithEvents txtCurrency As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave2 As Button
    Friend WithEvents cboFrom As ComboBox
    Friend WithEvents cboTo As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSwitch As Button
End Class
