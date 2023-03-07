Public Class Design2
    Dim Amount As Double
    Dim ConversionRate As Double
    Dim AmountCross As Double
    Dim ConversionRateCross As Double

    Dim Result As Double
    Dim Currency As Decimal
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstFrom.Items.Add("United Kingdom")
        lstFrom.Items.Add("Ukraine")
        lstFrom.Items.Add("Usa")
        lstFrom.Items.Add("Euro")
        lstFrom.Items.Add("Poland")

        lstTo.Items.Add("United Kingdom")
        lstTo.Items.Add("Ukraine")
        lstTo.Items.Add("Usa")
        lstTo.Items.Add("Euro")
        lstTo.Items.Add("Poland")
    End Sub
    Private Sub btnCalculate2_Click(sender As Object, e As EventArgs) Handles btnCalculate2.Click
        If lstTo.SelectedItem <> lstFrom.SelectedItem Then

            If lstFrom.SelectedItem = "United Kingdom" Then
                ConversionRateCross = 45.65
            End If
            If lstFrom.SelectedItem = "Ukraine" Then
                ConversionRateCross = 1
            End If
            If lstFrom.SelectedItem = "Usa" Then
                ConversionRateCross = 36.95
            End If
            If lstFrom.SelectedItem = "Euro" Then
                ConversionRateCross = 40.15
            End If
            If lstFrom.SelectedItem = "Poland" Then
                ConversionRateCross = 8.52
            End If

            If txtAmount.Text = "" Then
                MsgBox("Enter the amount you want to convert")
            Else
                Try
                    Amount = txtAmount.Text
                    AmountCross = Amount * ConversionRateCross
                Catch
                    MsgBox("Enter valid amount")
                End Try
            End If

            If lstTo.SelectedItem = "United Kingdom" Then
                ConversionRate = 0.022
            End If
            If lstTo.SelectedItem = "Ukraine" Then
                ConversionRate = 1
            End If
            If lstTo.SelectedItem = "Usa" Then
                ConversionRate = 0.027
            End If
            If lstTo.SelectedItem = "Euro" Then
                ConversionRate = 0.025
            End If
            If lstTo.SelectedItem = "Poland" Then
                ConversionRate = 0.12
            End If


            Result = AmountCross * ConversionRate
            txtResult.Text = Result
        Else
            txtResult.Text = txtAmount.Text
        End If

        Currency = Result / Amount
        txtCurrency.Text = Math.Round(Currency, 2)

        Dim lines() As String = IO.File.ReadAllLines("C:\Users\11155882\source\repos\WindowsApp1\WindowsApp1\output2.txt")
        lstEntries2.Items.AddRange(lines)
    End Sub

    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        lstEntries2.Items.Add(txtAmount.Text + " " + txtCurrency.Text)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\11155882\source\repos\WindowsApp1\WindowsApp1\output2.txt", True)
        file.WriteLine(txtCurrency.Text + " " + txtAmount.Text)
        file.Close()
    End Sub
End Class