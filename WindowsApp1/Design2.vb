Public Class Design2
    Dim Amount As Double
    Dim ConversionRate As Double
    Dim AmountCross As Double
    Dim ConversionRateCross As Double

    Dim Result As Double
    Dim Currency As Decimal

    'For Design 1
    'Dim Total As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For Design_1
        'ListBox1.Items.Add("United Kingdom")
        'ListBox1.Items.Add("Ukraine")
        'ListBox1.Items.Add("Usa")
        'ListBox1.Items.Add("Euro")
        'ListBox1.Items.Add("Poland")

        ListBoxFrom.Items.Add("United Kingdom")
        ListBoxFrom.Items.Add("Ukraine")
        ListBoxFrom.Items.Add("Usa")
        ListBoxFrom.Items.Add("Euro")
        ListBoxFrom.Items.Add("Poland")

        ListBoxTo.Items.Add("United Kingdom")
        ListBoxTo.Items.Add("Ukraine")
        ListBoxTo.Items.Add("Usa")
        ListBoxTo.Items.Add("Euro")
        ListBoxTo.Items.Add("Poland")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'For Design 1
        'If (ListBox1.SelectedItem = "United Kingdom") Then
        '    ConversionRate = 1
        '    TextBox2.Text = ConversionRate
        'End If
        'If (ListBox1.SelectedItem = "Ukraine") Then
        '    ConversionRate = 45.08
        '    TextBox2.Text = ConversionRate
        'End If
        'If (ListBox1.SelectedItem = "Usa") Then
        '    ConversionRate = 1.23
        '    TextBox2.Text = ConversionRate
        'End If
        'If (ListBox1.SelectedItem = "Euro") Then
        '    ConversionRate = 1.13
        '    TextBox2.Text = ConversionRate
        'End If
        'If (ListBox1.SelectedItem = "Poland") Then
        '    ConversionRate = 5.3
        '    TextBox2.Text = ConversionRate
        'End If

        'Amount = TextBox3.Text
        'Total = Amount * ConversionRate
        'TextBox4.Text = Total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBoxTo.SelectedItem <> ListBoxFrom.SelectedItem Then

            If ListBoxFrom.SelectedItem = "United Kingdom" Then
                ConversionRateCross = 45.65
            End If
            If ListBoxFrom.SelectedItem = "Ukraine" Then
                ConversionRateCross = 1
            End If
            If ListBoxFrom.SelectedItem = "Usa" Then
                ConversionRateCross = 36.95
            End If
            If ListBoxFrom.SelectedItem = "Euro" Then
                ConversionRateCross = 40.15
            End If
            If ListBoxFrom.SelectedItem = "Poland" Then
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

            If ListBoxTo.SelectedItem = "United Kingdom" Then
                ConversionRate = 0.022
            End If
            If ListBoxTo.SelectedItem = "Ukraine" Then
                ConversionRate = 1
            End If
            If ListBoxTo.SelectedItem = "Usa" Then
                ConversionRate = 0.027
            End If
            If ListBoxTo.SelectedItem = "Euro" Then
                ConversionRate = 0.025
            End If
            If ListBoxTo.SelectedItem = "Poland" Then
                ConversionRate = 0.12
            End If


            Result = AmountCross * ConversionRate
            txtResult.Text = Result
        Else
            txtResult.Text = txtAmount.Text
        End If

        Currency = Result / Amount
        txtCurrency.Text = Math.Round(Currency, 2)

        Dim lines() As String = IO.File.ReadAllLines("C:\Users\11155882\source\repos\WindowsApp1\WindowsApp1\output.txt")
        lstEntries.Items.AddRange(lines)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lstEntries.Items.Add(txtAmount.Text + " " + txtCurrency.Text)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\11155882\source\repos\WindowsApp1\WindowsApp1\output.txt", True)
        file.WriteLine(txtCurrency.Text + " " + txtAmount.Text)
        file.Close()
    End Sub
End Class