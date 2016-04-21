Public Class main
    Dim stoptext = "netsh wlan stop hostednetwork"
    Dim starttext = "netsh wlan start hostednetwork"
    Dim checkstattxt = "netsh wlan show hostednetwork"
    Dim thewholetext = ""
    Private activeornot = False
    Private Function thestopstart() As String
        Return thewholetext
    End Function
    Public Sub getter(ByVal command As String)
        thewholetext = command
    End Sub

    Private Function setter() As String
        Return thewholetext

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        defaultCheckBox.Enabled = False
        'Ax1.Controls.Add(New System.Windows.Forms.Button)
        ' Dim abc As New XtremeSuiteControls.DateTimePicker
        'Me.AddOwnedForm(abc)
        ' Dim a = AxWebBrowser2.LocationURL
        'AxWebBrowser2.Navigate("google.com")
        'netsh wlan show hostednetwor

        getter(checkstattxt)
        Dim CMDThread2 As New Threading.Thread(AddressOf CMDAutomate)
        CMDThread2.Start()
        CMDThread2.Abort()


        If activeornot = True Then
            startContext.Enabled = False
            stopContext.Enabled = True
        Else
            startContext.Enabled = True
            stopContext.Enabled = False
        End If

    End Sub

    Private Results As String
    Private Delegate Sub delUpdate()
    Private Finished As New delUpdate(AddressOf UpdateText)
    Public textResult As String = ""

    Private Sub UpdateText()
        textResult = Results
        txtResults.Text = textResult
    End Sub

    Private Sub errorChecker()
        If textResult.Contains("administrator privilege") Then
            warnTxt.Text = "Run Wifi Ninja as Administrator"
        Else
            warnTxt.Text = ""
        End If
    End Sub
    Friend netexistornot As Boolean



    Public Function getNetVal() As String
        Dim thenametext As String
        Dim theprevtext As String
        Dim thepasstext As String
        Dim thefullcomm As String
        thenametext = netNameBox.Text
        thepasstext = passwordbox.Text
        theprevtext = "netsh wlan set hostednetwork"
        thefullcomm = theprevtext & " mode=allow ssid=" & thenametext & " key =" & thepasstext
        Return thefullcomm
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles creatNetBut.Click
        If (netNameBox.Text = "" Or netNameBox.Text.Contains(" ") Or passwordbox.Text = "" Or passwordbox.Text.Contains(" ") Or netNameBox.Text.Length < 3 Or passwordbox.Text.Length < 8) Then
            MsgBox("Invalid Input", MsgBoxStyle.Exclamation)
            passwordbox.Clear()
        Else
            getter(getNetVal())
            setter()
            Dim CMDThread As New Threading.Thread(AddressOf CMDAutomate)
            CMDThread.Start()
            startNet.Checked = False
            stopNet.Checked = False
            If textResult.Contains("The SSID of the hosted network has been successfully changed.") Then
                warnTxt.Text = textResult
                MsgBox("Successfully Created", MsgBoxStyle.OkOnly)
            Else
                warnTxt.Text = textResult
                MsgBox("Not Successfully Created", MsgBoxStyle.Exclamation)
            End If
            errorChecker()
        End If

    End Sub
   
    Private Sub CMDAutomate()
        Dim myprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd" 'starts cmd window
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.UseShellExecute = False 'required to redirect
        StartInfo.CreateNoWindow = True 'creates no cmd window
        myprocess.StartInfo = StartInfo
        myprocess.Start()
        Dim SR As System.IO.StreamReader = myprocess.StandardOutput
        Dim SW As System.IO.StreamWriter = myprocess.StandardInput
        SW.WriteLine(thewholetext) 'the command you wish to run.....
        SW.WriteLine("exit") 'exits command prompt window
        Results = SR.ReadToEnd 'returns results of the command window
        SW.Close()
        SR.Close()
        'invokes Finished delegate, which updates textbox with the results text
        Invoke(Finished)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ToolNotify.Visible = True
        ToolNotify.BalloonTipText = "The Wifi Hotspot Creator is still running here! Right-click Icon to view Menu"
        ToolNotify.BalloonTipTitle = "Wifi Ninja"
        ToolNotify.Text = "Wifi Nija - Hospot Creator"
        ToolNotify.ShowBalloonTip(6000)
    End Sub

    Private Sub startNet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startNet.CheckedChanged
    End Sub
    Private Sub starterstopper()
        If startNet.Checked = True Then
            thewholetext = starttext
            Dim CMDThread2 As New Threading.Thread(AddressOf CMDAutomate)
            CMDThread2.Start()
            errorChecker()
            If textResult.Contains("The hosted network started.") Then
                activeornot = True 'active or not, active = true, notactive = false
                MsgBox("Successfully Started", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Not Successfully Started", MsgBoxStyle.OkOnly)
            End If
        ElseIf stopNet.Checked = True Then
            thewholetext = stoptext
            Dim CMDThread2 As New Threading.Thread(AddressOf CMDAutomate)
            CMDThread2.Start()
            errorChecker()
            If textResult.Contains("The hosted network started.") Then
                activeornot = False 'active or not, active = true, notactive = false
                MsgBox("Successfully Stopped", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Not Successfully Stopped", MsgBoxStyle.OkOnly)
            End If
        Else
            MsgBox("Please check all fields!", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub stopNet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopNet.CheckedChanged
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goNetStart.Click
        starterstopper()
    End Sub
    Friend Sub exitHandler()
        If activeornot = True Then
            Dim i = MsgBox("This will stop your WIFI shared!", MsgBoxStyle.OkCancel)
            If i = MsgBoxResult.Cancel Then

            ElseIf i = MsgBoxResult.Ok Then
                thewholetext = stoptext
                Dim CMDThread2 As New Threading.Thread(AddressOf CMDAutomate)
                CMDThread2.Start()
                errorChecker()
                MsgBox("Net Successfully stopped", MsgBoxStyle.OkOnly)
                Me.Close()
            End If
        Else
            MsgBox("Closing....If app not closed, you can open again and stop network then exit", MsgBoxStyle.OkOnly)
            Me.Close()
        End If
    End Sub
    Private Sub main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub HowTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowTo.Click
        MsgBox("Enter a network name without space (only letters, and _ is allowed ), Enter the at least 8 character long password or key (Numbers preferable),  Click Create, Select Start (or Stop), Click OK. **Make sure you 'Set used network network to shared. How To Share? check http://windows.microsoft.com/en-us/windows/using-internet-connection-sharing' ", MsgBoxStyle.Information)
    End Sub
    Private Sub AboutTo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTo.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub showContext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showContext.Click
        Me.Show()
    End Sub

    Private Sub aboutContext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutContext.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub helpContext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helpContext.Click
        MsgBox("Enter a network name without space (only letters, and _ is allowed ), Enter the at least 8 character long password or key (Numbers preferable),  Click Create, Select Start (or Stop), Click OK. **Make sure you 'Set used network network to shared. How To Share? check http://windows.microsoft.com/en-us/windows/using-internet-connection-sharing' ", MsgBoxStyle.Information)
    End Sub

    Private Sub exitContext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitContext.Click
        exitHandler()
    End Sub

    Private Sub defaultCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultCheckBox.CheckedChanged
        If defaultCheckBox.Checked Then
            Dim k1 = textResult.IndexOf("""")
            Dim k2 = textResult.IndexOf("""", k1 + 1)
            Dim thessid = textResult.Substring(k1 + (1), (k2 - k1 - 1))
            netNameBox.Text = thessid
            netNameBox.Enabled = False
        End If
    End Sub

    Private Sub ToolNotify_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolNotify.MouseDoubleClick
    End Sub

End Class
