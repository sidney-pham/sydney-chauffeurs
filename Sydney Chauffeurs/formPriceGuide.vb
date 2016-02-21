Public Class formPriceGuide
    Private Sub formPriceGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25
        centre(picLogoSmall)
        picLogoSmall.Top = Me.Height - picLogoSmall.Height - 25
        centre(lblPriceGuide)
        lblPriceGuide.Top = 50
        placeUnder(lblPricingInfo, lblPriceGuide, 50)
        lblPricingInfo.Left = 50
        lblPricingInfo.MaximumSize = New Size((Me.Width - 100), 0) 'Set 50 spacing on each side
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formOurService.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class