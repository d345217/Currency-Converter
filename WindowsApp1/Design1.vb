Public Class Design1
    Dim Amount As Double
    Dim ConversionRate As Double
    Dim Total As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCountries.Items.Add("United Kingdom")
        lstCountries.Items.Add("Ukraine")
        lstCountries.Items.Add("Usa")
        lstCountries.Items.Add("Euro")
        lstCountries.Items.Add("Poland")
    End Sub

    Private Sub btnCalculate1_Click(sender As Object, e As EventArgs)
        If (lstCountries.SelectedItem = "United Kingdom") Then
            ConversionRate = 1
            txtRate.Text = ConversionRate
        End If
        If (lstCountries.SelectedItem = "Ukraine") Then
            ConversionRate = 45.08
            txtRate.Text = ConversionRate
        End If
        If (lstCountries.SelectedItem = "Usa") Then
            ConversionRate = 1.23
            txtRate.Text = ConversionRate
        End If
        If (lstCountries.SelectedItem = "Euro") Then
            ConversionRate = 1.13
            txtRate.Text = ConversionRate
        End If
        If (lstCountries.SelectedItem = "Poland") Then
            ConversionRate = 5.3
            txtRate.Text = ConversionRate
        End If

        Amount = txtAmount.Text
        Total = Amount * ConversionRate
        txtTotal.Text = Total

        Dim lines() As String = IO.File.ReadAllLines("C:\Users\11155882\source\repos\WindowsApp1\WindowsApp1\output1.txt")
        lstEntries1.Items.AddRange(lines)
    End Sub

    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        lstEntries1.Items.Add(txtAmount.Text + " " + txtRate.Text)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\11155882\source\repos\WindowsApp1\WindowsApp1\output1.txt", True)
        file.WriteLine(txtRate.Text + " " + txtAmount.Text)
        file.Close()
    End Sub
End Class