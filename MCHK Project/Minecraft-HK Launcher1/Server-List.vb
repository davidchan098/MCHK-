Imports System.Text.RegularExpressions

Public Class Server_List
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
    Dim 瀏覧器1Part As Integer = 1
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If 瀏覧器1Percent = 瀏覧器1Part Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            getlist()
        End If
        瀏覧器1Percent = 瀏覧器1Percent + 1
    End Sub
    Sub getlist()
        Dim Elems As HtmlElementCollection
        Dim WebOC As WebBrowser = WebBrowser1
        Elems = WebOC.Document.GetElementsByTagName("table")
        For Each elem As HtmlElement In Elems
            Dim NameStr As String = elem.GetAttribute("className")
            If NameStr.Equals("table table-bordered list") Then
                Dim MyRegex As New Regex("php([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&amp;\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?", RegexOptions.Multiline Or RegexOptions.CultureInvariant Or RegexOptions.Compiled)
                Dim matches As MatchCollection
                matches = MyRegex.Matches(elem.OuterHtml)
                ServerList.Items.Clear()
                Dim 記錄 As Boolean = False
                For Each item In matches
                    If 記錄 = False Then
                        記錄 = True
                        ServerList.Items.Add(Replace(item.ToString, "php?id=", ""))
                    Else
                        記錄 = False
                    End If
                Next
                ''Dim ContentStr As String = elem.GetAttribute("className") = "table table-bordered list"
                'Dim 文字() As String = Split(elem.OuterHtml.ToLower, "<table class=table-reset>")
                'TextBox1.Text = 文字(0).Substring(2)
                'TextBox2.Text = 文字(1).Substring(2)
                'TextBox3.Text = 文字(2).Substring(2)
                'TextBox4.Text = 文字(3).Substring(2)
                'TextBox5.Text = 文字(4).Substring(2)
                'TextBox6.Text = 文字(5).Substring(2)
                'TextBox7.Text = 文字(6).Substring(2)
                'TextBox8.Text = 文字(7).Substring(2)
                'For Each Part As String In Split(elem.OuterHtml.ToLower, "<table class=table-reset>")
                '    Replace(Part, vbCrLf, "")
                '    Replace(Part, vbCr, "")
                '    Replace(Part, "<table class=""table table-bordered list""><thead>", "")
                '    Replace(Part, "<tr>", "")
                '    Replace(Part, "<th>", "")
                '    TextBox1.Text = Part.Substring(2)
                'Next
            End If
        Next
    End Sub
End Class