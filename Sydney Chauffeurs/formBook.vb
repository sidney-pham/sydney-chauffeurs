Public Class formBook
    Private Sub formBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25
        centre(picLogoSmall)
        picLogoSmall.Top = Me.Height - picLogoSmall.Height - 25
        centre(lblBookNow)
        lblBookNow.Top = 50
        centre(lblCall)
        placeUnder(lblCall, lblBookNow, 50)
        'Vertically centre info section
        'lblCall.Top = lblBookNow.Top + lblBookNow.Height + (picLogoSmall.Top - (lblBookNow.Top + lblBookNow.Height)) / 2 - (lblCall.Height + 25 + lblPhoneNumber.Height + 50 + lblEmail.Height + 25 + lblEmailAddress.Height) / 2
        centre(lblPhoneNumber)
        placeUnder(lblPhoneNumber, lblCall, 25)
        centre(lblEmail)
        placeUnder(lblEmail, lblPhoneNumber, 50)
        centre(lblEmailAddress)
        placeUnder(lblEmailAddress, lblEmail, 25)
        centre(btnMeetingMap)
        placeUnder(btnMeetingMap, lblEmailAddress, 100)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formLanding.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnMeetingMap_Click(sender As Object, e As EventArgs) Handles btnMeetingMap.Click
        formMeetingMap.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class