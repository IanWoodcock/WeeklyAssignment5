Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        'numerical value verification
        If IsNumeric(txtGroupSize.Text) Then
            intGroup = Convert.ToInt32(txtGroupSize.Text)
            If intGroup > 0 And intGroup < 20 Then
                If rbtnCSE.Checked Then
                    decRegistration = decSuperHero
                ElseIf rbtrnCA.Checked Then
                    decRegistration = decAutographs
                ElseIf rbtnC.Checked Then
                    decRegistration = decConvention
                End If
                decTotalCost = (intGroup * decRegistration)
                lblTotalCost.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Entry Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupSize.Text = ""
        lblTotalCost.Text = "$    "
        rbtnC.Checked = True
    End Sub
End Class
