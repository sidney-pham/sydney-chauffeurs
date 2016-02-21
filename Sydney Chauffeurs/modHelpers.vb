Module modHelpers
    Sub centre(ByVal control As Object)
        control.Left = formLanding.Width / 2 - control.Width / 2
    End Sub

    Sub placeUnder(ByVal control As Object, ByVal relativeControl As Object, ByVal pixels As Integer)
        control.Top = relativeControl.Top + relativeControl.Height + pixels
    End Sub

    Sub placeRight(ByVal control As Object, ByVal relativeControl As Object, ByVal pixels As Integer)
        control.Left = relativeControl.Left + relativeControl.Width + pixels
    End Sub
End Module
