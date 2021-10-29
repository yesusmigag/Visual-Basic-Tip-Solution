' Name:         Tip Project
' Purpose:      Calculate and display a server's tip.
' Programmer:   Jesus M Alvarado Gonzalez 05/27/2021


Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates and displays a server's tip.
        ' Declare Decimal variables.

        Dim decBill As Decimal
        Dim decPercentage As Decimal
        Dim decTip As Decimal

        ' Convert txtBill.Text and txtPercentage.Text to numbers.

        Decimal.TryParse(txtBill.Text, decBill)
        Decimal.TryParse(txtPercentage.Text, decPercentage)

        ' Calculate the tip.

        decTip = decBill * (decPercentage / 100)

        ' Display the tip with a dollar sign and two decimal places.

        lblTip.Text = decTip.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ''Close aplication
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBill_TextChanged(sender As Object, e As EventArgs) Handles txtBill.TextChanged
        ''Clear the  bill box
        lblTip.Text = String.Empty

    End Sub

    Private Sub txtPercentage_TextChanged(sender As Object, e As EventArgs) Handles txtPercentage.TextChanged
        ''Clear the  Tip box
        lblTip.Text = String.Empty

    End Sub

    Private Sub txtBill_Enter(sender As Object, e As EventArgs) Handles txtBill.Enter

        txtBill.SelectAll()

    End Sub

    Private Sub txtPercentage_Enter(sender As Object, e As EventArgs) Handles txtPercentage.Enter

        txtPercentage.SelectAll()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
