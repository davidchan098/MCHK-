Imports System.Net
Imports System.Text

Public Class Form1
    Public 版本 As String = "0.0.1"

    Private Property User As Object

    Public Sub 顯示(視窗 As Form, Optional 清除其他 As Boolean = True)
        視窗.TopLevel = False
        If 清除其他 = True Then Panel1.Controls.Clear()
        Panel1.Controls.Add(視窗)
        Panel1.Controls.SetChildIndex(視窗, 0)
        視窗.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text + " " + 版本
        PictureBox1.ImageLocation = "http://forum.minecraft-hk.com/static/image/minecraft-hkstyle/logo.png"
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown, Button1.Click
        顯示(HOME)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        顯示(Server_List)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        顯示(About)
    End Sub
    Public Function GetAccountStatus(ByVal Username As String, ByVal password As String)
        Dim status As String = "wrong,unknown"
        Dim bContent As Byte() = Encoding.ASCII.GetBytes("user=" & Username & "&password=" & password & "&version=13")
        Dim webReq As HttpWebRequest = HttpWebRequest.Create(New Uri("http://login.minecraft.net/"))
        webReq.ContentType = "application/x-www-form-urlencoded"
        webReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; sl; rv:1.9.2.13) Gecko/20101203 Firefox/3.6.13"
        webReq.Method = "POST"
        Dim ReqStream As IO.Stream = webReq.GetRequestStream()
        ReqStream.Write(bContent, 0, bContent.Length)
        ReqStream.Close()
        Dim webRes As HttpWebResponse = webReq.GetResponse()
        Dim ResStream As IO.StreamReader = New IO.StreamReader(webRes.GetResponseStream())
        Dim strResponse As String = ResStream.ReadToEnd()
        'Web Response Text
        '-------------------------
        'Wrong User = Bad Login
        'Wrong Password = Bad Login
        'No User &/Or Password = Bad Login
        'Wrong Version(version=) = Wrong Version
        'Done = NUMBERS(acc index):LOGINNAME:NUMBERS(cookie value):NUMBERS(cookie value)

        If strResponse.Contains("Bad login") Then
            status = "wrong,accountinfo"
        End If

        If strResponse.Contains(":") Then
            status = "works,done"
            Return status
            Return status
        End If


        'fear.v2games.de

        Return status
    End Function
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GetAccountStatus("USERNAME", "PASSWORD")
        'Process.Start()
    End Sub
End Class
