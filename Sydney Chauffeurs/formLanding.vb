Public Class formLanding

    Private Sub FormLanding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centre(picSydneyChauffeurs)
        picSydneyChauffeurs.Top = 100
        centre(btnOurService)
        centre(btnGetQuote)
        centre(btnBook)
        placeUnder(btnGetQuote, btnOurService, 30)
        placeUnder(btnBook, btnGetQuote, 30)
        'btnOurService is positioned manually
    End Sub

    Private Sub picSydneyChauffeurs_Click(sender As Object, e As EventArgs) Handles picSydneyChauffeurs.Click
        flashColours()
    End Sub

    Private Sub flashColours()
        While True
            Dim randomValue1 As Integer = CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0
            Dim randomValue2 As Integer = CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0
            Dim randomValue3 As Integer = CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0
            picSydneyChauffeurs.ForeColor = Color.FromArgb(randomValue1, randomValue2, randomValue3)
            System.Threading.Thread.Sleep(100)
            Me.Refresh()
            'Application.DoEvents()
        End While
    End Sub

    Private Sub btnOurService_Click(sender As Object, e As EventArgs) Handles btnOurService.Click
        formOurService.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnGetQuote_Click(sender As Object, e As EventArgs) Handles btnGetQuote.Click
        formGetQuote.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        formBook.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class
