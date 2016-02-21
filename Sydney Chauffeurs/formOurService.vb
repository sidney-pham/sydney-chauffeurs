Public Class formOurService
    Private Sub formOurService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25
        centre(lblOurService)
        lblOurService.Top = 50
        placeUnder(lblAbout, lblOurService, 50)
        lblAbout.Left = 50
        lblAbout.MaximumSize = New Size((Me.Width - 100), 0) 'Set 50 spacing on each side
        centre(picLogoSmall)
        picLogoSmall.Top = Me.Height - picLogoSmall.Height - 25
        lblHeaderPricing.Left = 50
        placeUnder(lblHeaderPricing, lblAbout, 50)
        lblPricing.Left = 50
        placeUnder(lblPricing, lblHeaderPricing, 25)
        lblPricing.MaximumSize = New Size((Me.Width - 100), 0) 'Set 50 spacing on each side
        centre(btnPricingGuide)
        placeUnder(btnPricingGuide, lblPricing, 25)
        lblHeaderPremium.Left = 50
        placeUnder(lblHeaderPremium, btnPricingGuide, 50)
        lblPremiumInfo.Left = 50
        placeUnder(lblPremiumInfo, lblHeaderPremium, 25)
        lblPremiumInfo.MaximumSize = New Size((Me.Width - 100), 0) 'Set 50 spacing on each side
        centre(btnViewFleet)
        placeUnder(btnViewFleet, lblPremiumInfo, 25)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formLanding.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnPricingGuide_Click(sender As Object, e As EventArgs) Handles btnPricingGuide.Click
        formPriceGuide.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnViewFleet_Click(sender As Object, e As EventArgs) Handles btnViewFleet.Click
        formViewFleet.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class