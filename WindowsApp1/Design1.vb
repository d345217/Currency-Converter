Public Class Design1

    'variable validation
    Dim Amount As Double
    Dim ConversionRate As Double
    Dim Total As Double
    ReadOnly array(4, 1) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ArrayCreate()

        'filling listboxes with country names
        For i = 0 To 4
            lstCountries.Items.Add(array(i, 0))
        Next

        'adding history to lstEntries
        Dim lines() As String = IO.File.ReadAllLines("C:\Users\11155882\Source\Repos\d345217\Currency-Converter\WindowsApp1\output1.txt")
        lstEntries1.Items.AddRange(lines)

    End Sub

    Private Sub btnCalculate1_Click(sender As Object, e As EventArgs) Handles btnCalculate1.Click

        'input validation
        If Not ValidateInput() Then
            Exit Sub
        End If

        Calculate(lstCountries.SelectedIndex)

    End Sub

    Private Sub ArrayCreate()

        'adding countries
        array(0, 0) = "United Kingdom"
        array(1, 0) = "Ukraine"
        array(2, 0) = "USA"
        array(3, 0) = "Poland"
        array(4, 0) = "Euro"

        'adding change rate to Hryvna
        array(0, 1) = 1
        array(1, 1) = 44.66
        array(2, 1) = 1.21
        array(3, 1) = 5.3
        array(4, 1) = 1.13

    End Sub

    Private Sub Calculate(ByRef x As Integer)

        'calculations of conversion
        ConversionRate = array(x, 1)
        Amount = txtAmount.Text
        Total = Amount * ConversionRate

        'output to textbox
        txtTotal.Text = Math.Round(Total, 2)
        txtRate.Text = Math.Round(ConversionRate, 2)

    End Sub

    Private Function ValidateInput() As Boolean

        'check if amount is a positive number or exist
        If Not Double.TryParse(txtAmount.Text, Amount) OrElse Amount < 0 Then
            MessageBox.Show("Please enter a valid positive number for amount.")
            Return False
        End If

        'check if a country have been selected
        If lstCountries.SelectedIndex = -1 = -1 Then
            MessageBox.Show("Please select a 'From' and 'To' currency.")
            Return False
        End If

        Return True

    End Function


    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click

        'input validation
        If Not ValidateInput() Then
            Exit Sub
        End If

        'creating file which will held history of exchanges
        lstEntries1.Items.Add("United Kingdom -> " + lstCountries.SelectedItem + ";   " + txtAmount.Text + " => " + txtTotal.Text + " " + "(" + txtRate.Text + ")")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\11155882\Source\Repos\d345217\Currency-Converter\WindowsApp1\output1.txt", True)
        file.WriteLine("United Kingdom -> " + lstCountries.SelectedItem + ";   " + txtAmount.Text + " => " + txtTotal.Text + " " + "(" + txtRate.Text + ")")
        file.Close()

    End Sub

End Class