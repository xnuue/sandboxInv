Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url As String = "https://www.youtube.com/watch?v=a5VwSeCOMQU&t=7s"
        Dim url1 As String = "https://www.facebook.com/rafaeljetrocipriano"
        Dim url2 As String = "https://www.tiktok.com/@creamsonjet"
        MessageBox.Show("subscribe to my youtube channel: " + "CREAMSON")
        Process.Start(url)
        Process.Start(url1)
        Process.Start(url2)
    End Sub
End Class
