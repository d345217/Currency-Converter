Public Class Design1
    Dim Amount As Double
    Dim ConversionRate As Double
    Dim Total As Double
    ReadOnly array(4, 1) As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArrayCreate()

        For i = 0 To 4
            lstCountries.Items.Add(array(i, 0))
        Next

        Dim lines() As String = IO.File.ReadAllLines("C:\Users\11155882\Source\Repos\d345217\Currency-Converter\WindowsApp1\output1.txt")
        lstEntries1.Items.AddRange(lines)
    End Sub
    Private Sub btnCalculate1_Click(sender As Object, e As EventArgs) Handles btnCalculate1.Click
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
        ConversionRate = array(x, 1)
        Amount = txtAmount.Text
        Total = Amount * ConversionRate

        txtTotal.Text = Math.Round(Total, 2)
        txtRate.Text = Math.Round(ConversionRate, 2)
    End Sub

    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        lstEntries1.Items.Add("United Kingdom -> " + lstCountries.SelectedItem + ";   " + txtAmount.Text + " => " + txtTotal.Text + " " + "(" + txtRate.Text + ")")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\11155882\Source\Repos\d345217\Currency-Converter\WindowsApp1\output1.txt", True)
        file.WriteLine("United Kingdom -> " + lstCountries.SelectedItem + ";   " + txtAmount.Text + " => " + txtTotal.Text + " " + "(" + txtRate.Text + ")")
        file.Close()
    End Sub
End Class