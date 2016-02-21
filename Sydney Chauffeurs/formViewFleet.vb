Public Class formViewFleet
    Private Sub formFleet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25
        centre(picLogoSmall)
        picLogoSmall.Top = Me.Height - picLogoSmall.Height - 25
        centre(lblFleet)
        lblFleet.Top = 50
        picHoldenCaprice.Top = 200
        picHoldenCaprice.Left = 50
        picHoldenCaprice.Width = (Me.Width - 100) / 3 - 20
        picHoldenCaprice.Height = picHoldenCaprice.Width / 400 * 283
        picChryslerStretch.Top = 200
        picChryslerStretch.Width = (Me.Width - 100) / 3 - 20
        picChryslerStretch.Height = picChryslerStretch.Width / 400 * 283
        centre(picChryslerStretch)
        picBentleyFlyingSpur.Top = 200
        picBentleyFlyingSpur.Width = (Me.Width - 100) / 3 - 20
        picBentleyFlyingSpur.Height = picBentleyFlyingSpur.Width / 400 * 283
        picBentleyFlyingSpur.Left = Me.Width - picBentleyFlyingSpur.Width - 50
        lblHoldenCapriceInfo.Left = 50
        placeUnder(lblHoldenCapriceInfo, picHoldenCaprice, 25)
        lblHoldenCapriceInfo.MaximumSize = New Size(picHoldenCaprice.Width, 0)
        lblChryslerStretchInfo.Left = picChryslerStretch.Left
        placeUnder(lblChryslerStretchInfo, picChryslerStretch, 25)
        lblChryslerStretchInfo.MaximumSize = New Size(picChryslerStretch.Width, 0)
        lblBentleyFlyingSpurInfo.Left = picBentleyFlyingSpur.Left
        placeUnder(lblBentleyFlyingSpurInfo, picBentleyFlyingSpur, 25)
        lblBentleyFlyingSpurInfo.MaximumSize = New Size(picBentleyFlyingSpur.Width, 0)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formOurService.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class