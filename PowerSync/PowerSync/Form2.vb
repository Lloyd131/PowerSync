Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        For Each ctlf As Control In Me.Controls
            If TypeOf ctlf Is GroupBox Then
                ctlf.Location = New Point((Me.Width \ 2) - (ctlf.Width \ 2), (Me.Height \ 2) - (ctlf.Height \ 2))
            End If
        Next
    End Sub
End Class