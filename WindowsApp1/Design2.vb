Public Class Design2

    'variable validation
    Dim Amount As Double
    Dim Result As Decimal
    Dim Currency As Decimal
    ReadOnly array(4, 1) As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArrayCreate()

        'filling comboboxes with country names
        For i = 0 To array.GetLength(0) - 1
            cboFrom.Items.Add(array(i, 0))
            cboTo.Items.Add(array(i, 0))
        Next


        'adding history to lstEntries
        Dim lines() As String = IO.File.ReadAllLines(IO.Path.Combine(Application.StartupPath, "output2.txt"))
        lstEntries2.Items.AddRange(lines)

    End Sub
    Private Sub btnCalculate2_Click(sender As Object, e As EventArgs) Handles btnCalculate2.Click

        'input validation
        If Not ValidateInput() Then
            Exit Sub
        End If

        Calculate(cboFrom.SelectedIndex, cboTo.SelectedIndex)

    End Sub
    Private Sub ArrayCreate()

        'adding countries
        array(0, 0) = "United Kingdom"
        array(1, 0) = "Ukraine"
        array(2, 0) = "USA"
        array(3, 0) = "Poland"
        array(4, 0) = "Euro"

        'adding change rate to Hryvna
        array(0, 1) = 45.65
        array(1, 1) = 1
        array(2, 1) = 36.95
        array(3, 1) = 8.52
        array(4, 1) = 40.15

    End Sub

    Private Sub Calculate(ByRef x As Integer, y As Integer)

        'calculations of conversion
        Amount = txtAmount.Text
        Result = Amount * array(x, 1) * (1 / array(y, 1))
        Currency = Result / Amount

        'output to textbox
        txtCurrency.Text = Math.Round(Currency, 2)
        txtResult.Text = Math.Round(Result, 2)

    End Sub

    Private Function ValidateInput() As Boolean

        'check if amount is a positive number or exist
        If Not Double.TryParse(txtAmount.Text, Amount) OrElse Amount < 0 Then
            MessageBox.Show("Please enter a valid positive number for amount.")
            Return False
        End If

        'check if a 'From' and 'To' countries have been selected
        If cboFrom.SelectedIndex = -1 OrElse cboTo.SelectedIndex = -1 Then
            MessageBox.Show("Please select a 'From' and 'To' currency.")
            Return False
        End If

        Return True

    End Function

    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click

        'input validation
        If Not ValidateInput() Then
            Exit Sub
        End If

        'adding info about exchange to listbox
        lstEntries2.Items.Add(cboFrom.SelectedItem + " -> " + cboTo.SelectedItem + ";   " + txtAmount.Text + " => " + txtResult.Text + " " + "(" + txtCurrency.Text + ")")

        'creating file which will held history of exchanges
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter((IO.Path.Combine(Application.StartupPath, "output2.txt")), True)
        file.WriteLine(cboFrom.SelectedItem + " -> " + cboTo.SelectedItem + ";   " + txtAmount.Text + " => " + txtResult.Text + " " + "(" + txtCurrency.Text + ")")
        file.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'clearing all the fields
        cboFrom.SelectedIndex = -1
        cboTo.SelectedIndex = -1
        txtAmount.Clear()
        txtCurrency.Clear()
        txtResult.Clear()

    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click

        'switch From and To countries
        Dim x As String = cboFrom.SelectedItem
        Dim y As String = cboTo.SelectedItem

        cboFrom.SelectedItem = y
        cboTo.SelectedItem = x

    End Sub

End Class