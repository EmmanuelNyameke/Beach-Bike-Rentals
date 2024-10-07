Option Strict On
Public Class frmBike
    Const _cdecpricePerPay As Decimal = 9.95D
    Private Sub btnFindCost_Click(sender As Object, e As EventArgs) Handles btnFindCost.Click
        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal
        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecpricePerPay
        lblTotal.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub frmBike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = ""
        txtNumberOfDays.Focus()
        lblCost.Text = _cdecpricePerPay.ToString("C") & " Per Day"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberOfDays.Clear()
        lblTotal.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
