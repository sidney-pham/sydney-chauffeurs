Public Class formMeetingMap
    Dim terminal As String

    Private Sub formMeetingMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25
        centre(picLogoSmall)
        picLogoSmall.Top = Me.Height - picLogoSmall.Height - 25
        centre(lblMeetingMap)
        lblMeetingMap.Top = 50
        lblLocation.Left = 50
        placeUnder(lblLocation, lblMeetingMap, 50)
        cmbLocation.Left = 50
        placeUnder(cmbLocation, lblLocation, 25)
        lblPickupInternational.MaximumSize = New Size((Me.Width - 100), 0) 'Set 50 spacing on each side
        lblPickupInternational.Left = 50
        placeUnder(lblPickupInternational, cmbLocation, 50)
        lblPickupDomestic.MaximumSize = New Size((Me.Width - 100), 0) 'Set 50 spacing on each side
        lblPickupDomestic.Left = 50
        placeUnder(lblPickupDomestic, cmbLocation, 50)
        picMapT1.Left = 50
        placeUnder(picMapT1, lblPickupInternational, 25)
        picMapT1.Height = (btnBack.Top - picMapT1.Top) * 0.8
        picMapT1.Width = picMapT1.Height / 1034 * 2006
        centre(picMapT1)

        If cmbLocation.Items.Count > 0 Then
            cmbLocation.SelectedIndex = 0    'The first item has index 0 
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formBook.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub cmbRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged
        lblMeetingMap.Focus() 'VERY HACKY WORKAROUND BECAUSE COMBOBOXES AUTOMATICALLY HIGHLIGHT YOUR SELCETION AND THAT IS DUMB

        If cmbLocation.Text = "T1 (International)" Then
            lblPickupInternational.Show()
            picMapT1.Show()
            lblPickupDomestic.Hide()
        ElseIf cmbLocation.Text = "T2 & T3 (Domestic)" Then
            lblPickupDomestic.Show()
            lblPickupInternational.Hide()
            picMapT1.Hide()
        End If
    End Sub
End Class