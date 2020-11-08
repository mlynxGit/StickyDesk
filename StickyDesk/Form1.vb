Imports CefSharp.WinForms
Imports CefSharp
Public Class StickyDesk

    Private WithEvents browser As ChromiumWebBrowser

    Private Declare Auto Function FindWindow Lib "user32.dll" (
                                                                ByVal lpClassName As String,
                                                                ByVal lpWindowName As String
                                                                ) As IntPtr

    Private Declare Function SetParent Lib "user32" (
                                                        ByVal hWndChild As IntPtr,
                                                        ByVal hWndNewParent As IntPtr
                                                        ) As Integer
    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        Dim P As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        P = New Uri(P).LocalPath
        Dim us_string As String = IO.File.ReadAllLines(IO.Path.Combine(P, "ua.txt"))(0)
        settings.UserAgent = us_string
        settings.CachePath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CEF")
        CefSharp.Cef.Initialize(settings)
        browser = New ChromiumWebBrowser("https://keep.google.com") With {
            .Dock = DockStyle.Fill
        }
        panBrowser.Controls.Add(browser)

    End Sub

    Private Sub StickyDesk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetParent(Me.Handle, FindWindow("ProgMan", vbNullString))
    End Sub
End Class
