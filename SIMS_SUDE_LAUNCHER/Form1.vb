Public Class Launcher

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Play_Sims1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Play_Sims1.Click
        Dim p As New Process()
        p.StartInfo.FileName = ".\The Sims\sims.exe"
        p.Start()
    End Sub

    Private Sub Button_Play_Sims2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Play_Sims2.Click

        If CheckBox_Launcher_Sims2.Checked Then
            Dim p As New Process()
            p.StartInfo.FileName = ".\The Sims 2\The Sims 2 Mansion and Garden Stuff\TSBin\Sims2Launcher.exe"
            p.Start()
        End If

        If CheckBox_Launcher_Sims2.Checked = False Then
            Dim p As New Process()
            p.StartInfo.FileName = ".\The Sims 2\The Sims 2 Mansion and Garden Stuff\TSBin\Sims2EP9.exe"
            p.Start()
        End If

    End Sub

    Private Sub Button_Play_Sims3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Play_Sims3.Click
        If CheckBox_Launcher_Sims3.Checked Then
            Dim p As New Process()
            p.StartInfo.FileName = ".\The Sims 3\Game\Bin\Sims3Launcher.exe"
            p.Start()
        End If

        If CheckBox_Launcher_Sims3.Checked = False Then
            Dim p As New Process()
            p.StartInfo.FileName = ".\The Sims 3\Game\Bin\TS3.exe"
            p.Start()
        End If
    End Sub

    Private Sub Button_Play_Sims4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Play_Sims4.Click
        Dim p As New Process()
        p.StartInfo.FileName = ".\The Sims 4\Game\Bin\TS4_x64.exe"
        p.Start()
    End Sub

    Private Sub Button_DLC_Toggler_Sims3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DLC_Toggler_Sims3.Click
        Dim p As New Process()
        p.StartInfo.FileName = ".\The Sims 3\dlc-toggler.exe"
        p.Start()
    End Sub

    Private Sub Button_DLC_Toggler_Sims4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DLC_Toggler_Sims4.Click
        Dim p As New Process()
        p.StartInfo.FileName = ".\The Sims 4\dlc-toggler.exe"
        p.Start()
    End Sub
End Class
