Public Class HOME
    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Try
            If e.MaximumProgress <> 0 And e.MaximumProgress >= e.CurrentProgress Then
                PictureBox2.Size = New Size((PictureBox1.Size.Width * ((100 / 瀏覧器1Part) * 瀏覧器1Percent + (Convert.ToInt32(100 * e.CurrentProgress / e.MaximumProgress) - 1) / (瀏覧器1Part)) / 100), PictureBox1.Size.Height)
            Else
                PictureBox2.Size = New Size((PictureBox1.Size.Width * ((100 / 瀏覧器1Part) * 瀏覧器1Percent + (100 / 瀏覧器1Part)) / 100), PictureBox1.Size.Height)
            End If
            If PictureBox2.Size.Width > PictureBox1.Size.Width Then PictureBox2.Size = New Point(PictureBox1.Size.Width, PictureBox2.Size.Height)
        Catch ex As Exception
        End Try
    End Sub
    Dim 瀏覧器1Percent As Integer = 0
    Dim 瀏覧器1Part As Integer = 8
    Dim 瀏覧器2Percent As Integer = 0
    Dim 瀏覧器2Part As Integer = 0
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If 瀏覧器1Percent = 瀏覧器1Part Then
            WebBrowser1.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
        End If
        瀏覧器1Percent = 瀏覧器1Percent + 1
    End Sub
    Private Sub WebBrowser2_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs)
        Try
            If e.MaximumProgress <> 0 And e.MaximumProgress >= e.CurrentProgress Then
                PictureBox4.Size = New Size((PictureBox3.Size.Width * ((100 / 瀏覧器2Part) * 瀏覧器2Percent + (Convert.ToInt32(100 * e.CurrentProgress / e.MaximumProgress) - 1) / (瀏覧器2Part)) / 100), PictureBox3.Size.Height)
            Else
                PictureBox4.Size = New Size((PictureBox3.Size.Width * ((100 / 瀏覧器2Part) * 瀏覧器2Percent + (100 / 瀏覧器2Part)) / 100), PictureBox3.Size.Height)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class