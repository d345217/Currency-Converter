﻿Public Class Form1
    Dim ConversionRate As Double
    Dim ConversionRateCross As Double
    Dim Amount As Double
    Dim Total As Double
    Dim AmountCross As Double
    Dim result As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ForAss2DataSet.tblRecord' table. You can move, or remove it, as needed.
        Me.TblRecordTableAdapter.Fill(Me.ForAss2DataSet.tblRecord)
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

            If TextBoxNew.Text = "" Then
                MsgBox("Enter the amount you want to convert")
            Else
                Try
                    Amount = TextBoxNew.Text
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


            result = AmountCross * ConversionRate
            TextBoxResult.Text = result
            TextBoxRate.Text = result / Amount
        Else
            TextBoxResult.Text = TextBoxNew.Text
            TextBoxRate.Text = result / Amount
        End If


        Dim anyRow As DataRow = Me.ForAss2DataSet.tblRecord.NewRow
        anyRow("Currency") = ""
    End Sub
End Class