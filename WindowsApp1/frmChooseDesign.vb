Public Class frmChooseDesign
    Private Sub btnDesign1_Click(sender As Object, e As EventArgs) Handles btnDesign1.Click
        Me.Hide()
        frmDesign1.Show()
    End Sub

    Private Sub btnDesign2_Click(sender As Object, e As EventArgs) Handles btnDesign2.Click
        Me.Hide()
        frmDesign2.Show()
    End Sub
End Class