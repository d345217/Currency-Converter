Public Class frmDesign1

    Private Sub frmDesign1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ArrayCreate()

        'filling listboxes with country names
        For i = 0 To array.GetLength(0) - 1
            cmbCountry.Items.Add(array(i, 0))
        Next

        'adding history to lstEntries
        Dim lines() As String = IO.File.ReadAllLines(IO.Path.Combine(Application.StartupPath, "output1.txt"))
        lstEntries.Items.AddRange(lines)

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'input validation
        If Not ValidateInput() Then
            Exit Sub
        End If

        Calculate(cmbCountry.SelectedIndex)

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
        Rate = array(x, 1)
        Amount = txtAmount.Text
        Result = Amount * Rate

        'output to textbox
        txtTotal.Text = Math.Round(Result, 2)
        txtRate.Text = Math.Round(Rate, 2)

    End Sub

    Private Function ValidateInput() As Boolean

        'check if amount is a positive number or exist
        If Not Double.TryParse(txtAmount.Text, Amount) OrElse Amount < 0 Then
            MessageBox.Show("Please enter a valid positive number for amount.")
            Return False
        End If

        'check if a country have been selected
        If cmbCountry.SelectedIndex = -1 = -1 Then
            MessageBox.Show("Please select a 'From' and 'To' currency.")
            Return False
        End If

        Return True

    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'input validation
        If Not ValidateInput() Then
            Exit Sub
        End If


        'adding info about exchange to listbox
        lstEntries.Items.Add("United Kingdom -> " + cmbCountry.SelectedItem + ";   " + txtAmount.Text + " => " + txtTotal.Text + " " + "(" + txtRate.Text + ")")

        'creating file which will held history of exchanges
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter((IO.Path.Combine(Application.StartupPath, "output1.txt")), True)
        file.WriteLine("United Kingdom -> " + cmbCountry.SelectedItem + ";   " + txtAmount.Text + " => " + txtTotal.Text + " " + "(" + txtRate.Text + ")")
        file.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'clearing all the fields
        cmbCountry.SelectedIndex = -1
        txtAmount.Clear()
        txtRate.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click

        'moving user to the Choosing design form
        Me.Hide()
        frmChooseDesign.Show()

    End Sub

End Class