Public Class formGetQuote
    Dim passengers As Integer = 1
    Dim region As String
    Dim premium As Boolean = False

    Private Sub formGetQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25
        centre(picLogoSmall)
        picLogoSmall.Top = Me.Height - picLogoSmall.Height - 25
        centre(lblGetQuote)
        lblGetQuote.Top = 50
        lblPassengers.Left = 50
        placeUnder(lblPassengers, lblGetQuote, 50)
        btnFewer.Left = 50
        placeUnder(btnFewer, lblPassengers, 25)
        placeRight(lblNumPassengers, btnFewer, 15)
        placeUnder(lblNumPassengers, lblPassengers, 25)
        placeRight(btnMore, lblNumPassengers, 15)
        placeUnder(btnMore, lblPassengers, 25)
        placeUnder(lblRegion, btnFewer, 50)
        lblRegion.Left = 50
        placeUnder(cmbRegion, lblRegion, 25)
        chkPremium.Left = 50
        placeUnder(chkPremium, cmbRegion, 50)
        lblTotal.Top = lblPassengers.Top + (lblPassengers.Height + 25 + btnFewer.Height + 50 + lblRegion.Height + 25 + chkPremium.Height + 50 + chkPremium.Height) / 2 - lblTotal.Height / 2
        centre(btnPricingGuide)
        placeUnder(btnPricingGuide, chkPremium, 100)

        lblNumPassengers.Text = CStr(passengers)
        If passengers = 1 Then
            btnFewer.Enabled = False
        End If

        If cmbRegion.Items.Count > 0 Then
            cmbRegion.SelectedIndex = 0    'The first item has index 0 
        End If

        region = cmbRegion.Text
        calculateTotal(passengers, region, premium)
        'lblTotal.Left = Me.Width - lblTotal.Width - 25 'positioning of lblTotal has to be after price calculations because FormatCurrency changes width of lblTotal
        lblTotal.Left = Me.Width / 4 * 3 - lblTotal.Width / 2
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formLanding.Show()
        Threading.Thread.Sleep(150)
        Me.Close()
    End Sub

    Private Sub cmbRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRegion.SelectedIndexChanged
        lblGetQuote.Focus() 'VERY HACKY WORKAROUND BECAUSE COMBOBOXES AUTOMATICALLY HIGHLIGHT YOUR SELCETION AND THAT IS DUMB
        region = cmbRegion.SelectedItem.ToString()
        calculateTotal(passengers, region, premium)
    End Sub

    Private Sub btnFewer_Click(sender As Object, e As EventArgs) Handles btnFewer.Click
        passengers -= 1

        If passengers = 1 Then
            btnFewer.Enabled = False
        Else
            btnFewer.Enabled = True
            btnMore.Enabled = True
        End If

        lblNumPassengers.Text = CStr(passengers)
        calculateTotal(passengers, region, premium)
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        passengers += 1

        If passengers = 6 Then
            btnMore.Enabled = False
        Else
            btnMore.Enabled = True
            btnFewer.Enabled = True
        End If

        lblNumPassengers.Text = CStr(passengers)
        calculateTotal(passengers, region, premium)
    End Sub

    Private Sub chkPremium_CheckedChanged(sender As Object, e As EventArgs) Handles chkPremium.CheckedChanged
        premium = chkPremium.Checked
        calculateTotal(passengers, region, premium)
    End Sub

    Private Sub calculateTotal(ByVal passengers As Integer, ByVal region As String, ByVal premium As Boolean)
        Dim total As Decimal
        Dim regionFee As Integer
        Dim passengerMultiplier As Decimal
        Dim baseFee As Integer = 30
        Dim optionalPremium As Integer

        Select Case region
            Case "Sydney CBD"
                regionFee = 15
            Case "North Shore"
                regionFee = 20
            Case "Parramatta"
                regionFee = 25
            Case "Cronulla"
                regionFee = 22
            Case "Eastern Suburbs"
                regionFee = 18
        End Select

        passengerMultiplier = 1 + ((passengers - 1) * 0.1)
        optionalPremium = If(premium = True, 35, 0)

        total = (baseFee + regionFee) * passengerMultiplier + optionalPremium
        lblTotal.Text = FormatCurrency(total, 2)
    End Sub

    Private Sub btnPricingGuide_Click(sender As Object, e As EventArgs) Handles btnPricingGuide.Click
        formPriceGuide2.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class