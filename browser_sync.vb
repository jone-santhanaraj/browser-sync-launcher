'---------------------------------------------------------------------------------------------
'
' Apache License 2.0
'
'Licensed under the Apache License, Version 2.0 (the "License");
'you may Not use this file except In compliance With the License.
'You may obtain a copy Of the License at
'
'http://www.apache.org/licenses/LICENSE-2.0
'
'Unless required by applicable law Or agreed To In writing, software
'distributed under the License Is distributed On an "AS IS" BASIS,
'WITHOUT WARRANTIES Or CONDITIONS Of ANY KIND, either express Or implied.
'See the License For the specific language governing permissions And
'limitations under the License.
'
'---------------------------------------------------------------------------------------------
'
' This project is built upon and intended to be used with the Browser-Sync development tool.
'
' Author Name: Jone-Santhanaraj
' Built On: 2023-05-11
' App Name: Browser-Sync Launcher
' Version: v1.0.000-Release
' Description: This is a Browser-Sync launcher tool that will users to create and
'              execute browser-sync commands as they need.
'
'---------------------------------------------------------------------------------------------

Imports System.IO

Public Class browser_sync

    'initial browser-sync command
    Dim init As String = "browser-sync "

    'created browser-sync command
    Dim command As String = "browser-sync"

    'browser-sync command attribute values
    Dim cwd As String = Directory.GetCurrentDirectory()
    Dim files As String = "**/*"
    Dim indexFile As String = ""
    Dim ignoreFiles As String = ""
    Dim port As String = "3000"
    Dim configPath As String = ""
    Dim browser As String = ""
    Dim host As String = "localhost"

    'browser-sync open-with-browser's path
    Dim opera As String = "AppData\Local\Programs\Opera\opera.exe"
    Dim operaGX As String = "AppData\Local\Programs\Opera GX\opera.exe"
    Dim chrome As String = "chrome"
    Dim firefox As String = "firefox"
    Dim edge As String = "msedge"

    'command attribute requirements (updated on form interation)
    Dim startServer As Boolean = True
    Dim mentionFiles As Boolean = True
    Dim mentionWatch As Boolean = False
    Dim mentionTunnel As Boolean = False
    Dim mentionHost As Boolean = False
    Dim mentionPort As Boolean = False
    Dim mentionCWD As Boolean = False
    Dim mentionIgnore As Boolean = False
    Dim mentionIndex As Boolean = False
    Dim mentionConfig As Boolean = False
    Dim mentionBrowser As Boolean = False
    Dim mentionHTTPS As Boolean = False
    Dim mentionJson As Boolean = False

    'basic form events - STARTS HERE
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hostDir.Text = cwd.Replace("\", "/")
        allFilesRadio.Checked = True
        allRadio.Checked = False
        chooseFilesRadio.Checked = False
        addMoreBtn.Visible = False
        selectedFilesText.Text = ""
        allFilesRadio.Enabled = True
        allRadio.Enabled = True
        chooseFilesRadio.Enabled = True
        chooseFilesBtn.Enabled = False
        mentionWatch = False
        mentionCWD = False
        selectedFilesText.Visible = False
        clearSelectionBtn.Visible = False
        ignoreFileCheck.Visible = True
        ignoredFilesText.Visible = True
        chooseIgnoredBtn.Visible = True
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        Dim processStartInfo As New ProcessStartInfo()
        processStartInfo.FileName = "cmd.exe"
        processStartInfo.Arguments = "/c " & command
        processStartInfo.WorkingDirectory = cwd

        Process.Start(processStartInfo)

        Close()
    End Sub
    'basic form events - ENDS HERE

    'Current Working Directory - STARTS HERE
    Private Sub changeBtn_Click(sender As Object, e As EventArgs) Handles changeBtn.Click
        Dim openFolderDialog As New FolderBrowserDialog()
        openFolderDialog.RootFolder = Environment.SpecialFolder.UserProfile
        openFolderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents"

        If openFolderDialog.ShowDialog() = DialogResult.OK Then
            cwd = openFolderDialog.SelectedPath
            files = "**/*"
            indexFile = ""
            hostDir.Text = cwd.Replace("\", "/")
            allFilesRadio.Checked = True
            allRadio.Checked = False
            chooseFilesRadio.Checked = False
            addMoreBtn.Visible = False
            selectedFilesText.Text = ""
            selectedFilesText.Visible = False
            clearSelectionBtn.Visible = False
            mentionCWD = True
        End If
        If (cwd = Directory.GetCurrentDirectory) Then
            mentionCWD = False
        ElseIf (cwd = openFolderDialog.SelectedPath) Then
            mentionCWD = True
        End If
    End Sub
    'Current Working Directory - ENDS HERE

    'All files including sub-folders radio - STARTS HERE
    Private Sub allRadio_CheckedChanged(sender As Object, e As EventArgs) Handles allRadio.CheckedChanged
        If allRadio.Checked = True Then
            files = "*"
            addMoreBtn.Visible = False
            selectedFilesText.Visible = False
        End If
        clearSelectionBtn.Visible = False
    End Sub
    'All files including sub-folders radio - ENDS HERE

    'All files excluding sub-folders radio - STARTS HERE
    Private Sub allFilesRadio_CheckedChanged(sender As Object, e As EventArgs) Handles allFilesRadio.CheckedChanged
        If allFilesRadio.Checked = True Then
            files = "**/*"
            addMoreBtn.Visible = False
            selectedFilesText.Visible = False
            clearSelectionBtn.Visible = False
            ignoreFileCheck.Visible = True
            ignoredFilesText.Visible = True
            chooseIgnoredBtn.Visible = True
        Else
            ignoreFileCheck.Visible = False
            ignoredFilesText.Visible = False
            chooseIgnoredBtn.Visible = False
        End If

    End Sub
    'All files excluding sub-folders radio - ENDS HERE

    'Manually choose files - STARTS HERE
    Private Sub chooseFilesRadio_CheckedChanged(sender As Object, e As EventArgs) Handles chooseFilesRadio.CheckedChanged
        If chooseFilesRadio.Checked = True Then
            chooseFilesBtn.Enabled = True
        Else
            chooseFilesBtn.Enabled = False
        End If
        clearSelectionBtn.Visible = False
    End Sub

    Private Sub chooseFilesBtn_Click(sender As Object, e As EventArgs) Handles chooseFilesBtn.Click
        Dim openFilesDialog As New OpenFileDialog()
        openFilesDialog.Multiselect = True
        openFilesDialog.InitialDirectory = cwd
        If openFilesDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim selectedFiles As String() = openFilesDialog.FileNames
            Dim fileNames As String = ""
            For index As Integer = 0 To selectedFiles.Length - 1
                If selectedFiles(index).StartsWith(openFilesDialog.InitialDirectory) Then
                    If index = 0 Then
                        fileNames = fileNames + selectedFiles(index).Replace(cwd & "\", "")
                    Else
                        fileNames = fileNames + ", " + selectedFiles(index).Replace(cwd & "\", "")
                    End If
                Else
                    MessageBox.Show("Please select files only within the working directory or change the working directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    fileNames = ""
                    Exit Sub
                End If
            Next
            files = fileNames
            addMoreBtn.Visible = True
            selectedFilesText.Visible = True
            selectedFilesText.Text = files
            clearSelectionBtn.Visible = True
            chooseFilesBtn.Text = "Re-Select"
        End If
    End Sub

    Private Sub selectedFilesText_TextChanged(sender As Object, e As EventArgs) Handles selectedFilesText.TextChanged
        files = selectedFilesText.Text
    End Sub

    Private Sub addMoreBtn_Click(Sender As Object, e As EventArgs)
        Dim openFilesDialog As New OpenFileDialog()
        openFilesDialog.Multiselect = True
        openFilesDialog.InitialDirectory = cwd
        If openFilesDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim selectedFiles As String() = openFilesDialog.FileNames
            Dim fileNames As String = ""
            For index As Integer = 0 To selectedFiles.Length - 1
                If selectedFiles(index).StartsWith(openFilesDialog.InitialDirectory) Then
                    fileNames = fileNames + ", " + selectedFiles(index).Replace(cwd & "\", "")
                Else
                    MessageBox.Show("Please select files only within the working directory or change the working directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    fileNames = ""
                    Exit Sub
                End If
            Next
            files = files & fileNames
            selectedFilesText.Text = files
        End If
    End Sub

    Private Sub clearSelectionBtn_Click(sender As Object, e As EventArgs) Handles clearSelectionBtn.Click
        selectedFilesText.Text = ""
        files = "*"
        clearSelectionBtn.Visible = False
        addMoreBtn.Visible = False
        selectedFilesText.Visible = False
        chooseFilesBtn.Text = "Browse"
        chooseFilesRadio.Checked = False
        allFilesRadio.Checked = True
    End Sub
    'Manually choose files - ENDS HERE

    'Explicit index file - STARTS HERE
    Private Sub chooseIndexCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chooseIndexCheck.CheckedChanged
        If chooseIndexCheck.Checked = True Then
            chooseIndexBtn.Enabled = True
            If Not indexFile = "" Then
                chooseIndexCheck.Text = indexFile
            Else
                chooseIndexCheck.Text = "Choose custom index file"
            End If
        Else
            chooseFilesBtn.Enabled = False
            chooseIndexCheck.Text = "Choose custom index file"
            mentionIndex = False
        End If
    End Sub

    Private Sub chooseIndexBtn_Click(sender As Object, e As EventArgs) Handles chooseIndexBtn.Click
        Dim openFilesDialog As New OpenFileDialog()
        openFilesDialog.InitialDirectory = cwd
        If openFilesDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If openFilesDialog.FileName.StartsWith(openFilesDialog.InitialDirectory) Then
                indexFile = openFilesDialog.FileName.Replace(cwd & "\", "")
                chooseIndexCheck.Text = indexFile
                mentionIndex = True
            Else
                MessageBox.Show("Please select files only within the working directory or change the working directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mentionIndex = False
                Exit Sub
            End If
        End If
    End Sub
    'Explicit index file - ENDS HERE

    'watch files checkbox - STARTS HERE
    Private Sub watchFilesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles watchFilesCheck.CheckedChanged

        If watchFilesCheck.Checked = True Then
            allFilesRadio.Enabled = True
            allRadio.Enabled = True
            chooseFilesRadio.Enabled = True
            chooseFilesBtn.Enabled = False
            mentionWatch = False
        Else
            allFilesRadio.Enabled = False
            allRadio.Enabled = False
            chooseFilesRadio.Enabled = False
            chooseFilesBtn.Enabled = False
            mentionWatch = True
        End If
    End Sub
    'watch files checkbox - ENDS HERE

    'mention files to ignore - STARTS HERE
    Private Sub ignoreFileCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ignoreFileCheck.CheckedChanged
        If ignoreFileCheck.Checked = True Then
            ignoredFilesText.Enabled = True
            chooseIgnoredBtn.Enabled = True
            mentionIgnore = True
        Else
            ignoredFilesText.Enabled = False
            chooseIgnoredBtn.Enabled = False
            mentionIgnore = False
        End If
    End Sub

    Private Sub ignoreFilesText_TextChanged(sender As Object, e As EventArgs) Handles ignoredFilesText.TextChanged
        ignoreFiles = ignoredFilesText.Text
    End Sub

    Private Sub chooseIgnoredBtn_Click(sender As Object, e As EventArgs) Handles chooseIgnoredBtn.Click
        Dim openFilesDialog As New OpenFileDialog()
        openFilesDialog.Multiselect = True
        openFilesDialog.InitialDirectory = cwd
        If openFilesDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim selectedFiles As String() = openFilesDialog.FileNames
            Dim fileNames As String = ""
            For index As Integer = 0 To selectedFiles.Length - 1
                If selectedFiles(index).StartsWith(openFilesDialog.InitialDirectory) Then
                    If index = 0 Then
                        fileNames = fileNames + selectedFiles(index).Replace(cwd & "\", "")
                    Else
                        fileNames = fileNames + ", " + selectedFiles(index).Replace(cwd & "\", "")
                    End If
                Else
                    MessageBox.Show("Please select files only within the working directory or change the working directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    fileNames = ""
                    Exit Sub
                End If
            Next
            ignoreFiles = fileNames
            ignoredFilesText.Text = ignoreFiles
        End If
    End Sub
    'mention files to ignore - ENDS HERE

    'mention port number - STARTS HERE
    Private Sub custPortCheck_CheckedChanged(sender As Object, e As EventArgs) Handles custPortCheck.CheckedChanged
        If custPortCheck.Checked = True Then
            portSelect.Enabled = True
            mentionPort = True
        Else
            portSelect.Enabled = False
            mentionPort = False
        End If
    End Sub

    Private Sub portSelect_ValueChanged(sender As Object, e As EventArgs) Handles portSelect.ValueChanged
        port = portSelect.Value
    End Sub
    'mention port number - ENDS HERE

    'mention config file - STARTS HERE
    Private Sub configCheck_CheckedChanged(sender As Object, e As EventArgs) Handles configCheck.CheckedChanged
        If configCheck.Checked = True Then
            configBtn.Enabled = True
            mentionConfig = True
        Else
            configBtn.Enabled = False
            mentionConfig = False
        End If
    End Sub

    Private Sub configBtn_Click(sender As Object, e As EventArgs) Handles configBtn.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "JavaScript Files (*.js)|*.js|All Files (*.*)|*.*"
        openFileDialog.Title = "Select Config File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            configPath = openFileDialog.FileName.Replace("\", "/")
        Else
            configPath = ""
        End If
    End Sub
    'mention config file - ENDS HERE

    'mention browser - STARTS HERE
    Private Sub browserSelectCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles browserSelectCombo.SelectedIndexChanged
        Dim userProfilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

        If browserSelectCombo.SelectedIndex = 1 Then
            browser = Path.Combine(userProfilePath, opera).Replace("\", "/")
            mentionBrowser = True
        ElseIf browserSelectCombo.SelectedIndex = 2 Then
            browser = Path.Combine(userProfilePath, operaGX).Replace("\", "/")
            mentionBrowser = True
        ElseIf browserSelectCombo.SelectedIndex = 3 Then
            browser = chrome
            mentionBrowser = True
        ElseIf browserSelectCombo.SelectedIndex = 4 Then
            browser = firefox
            mentionBrowser = True
        ElseIf browserSelectCombo.SelectedIndex = 5 Then
            browser = edge
            mentionBrowser = True
        Else
            browser = "Open with:"
            mentionBrowser = False
        End If
    End Sub
    'mention browser - ENDS HERE

    'enable HTTPS checkbox - STARTS HERE
    Private Sub httpsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles httpsCheck.CheckedChanged
        mentionHTTPS = httpsCheck.Checked
    End Sub
    'enable HTTPS checkbox - ENDS HERE

    'enable JSON logging checkbox - STARTS HERE
    Private Sub logJsonCheck_CheckedChanged(sender As Object, e As EventArgs) Handles logJsonCheck.CheckedChanged
        mentionJson = logJsonCheck.Checked
    End Sub
    'enable JSON logging checkbox - ENDS HERE

    'enable tunnel checkbox - STARTS HERE
    Private Sub enableTunnelCheck_CheckedChanged(sender As Object, e As EventArgs) Handles enableTunnelCheck.CheckedChanged
        If enableTunnelCheck.Checked = True Then
            mentionTunnel = True
        Else
            mentionTunnel = False
        End If
    End Sub
    'enable tunnel checkbox - ENDS HERE

    'enable custom hostname - STARTS HERE
    Private Sub hostnameCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hostnameCheck.CheckedChanged
        If hostnameCheck.Checked = True Then
            hostnameText.Enabled = True
            mentionHost = True
        Else
            hostnameText.Enabled = False
            mentionHost = False
        End If
    End Sub

    Private Sub hostnameText_TextChanged(sender As Object, e As EventArgs) Handles hostnameText.TextChanged
        host = hostnameText.Text
    End Sub
    'enable custom hostname - ENDS HERE

    'copy created command - STARTS HERE
    Private Sub copyCommandBtn_Click(sender As Object, e As EventArgs) Handles copyCommandBtn.Click
        Clipboard.SetText(commandShowText.Text)
    End Sub
    'copy created command - ENDS HERE

    'update command on every event - STARTS HERE
    Private Sub updateCommand_Change(sender As Object, e As EventArgs) Handles MyBase.Load, changeBtn.Click, watchFilesCheck.CheckedChanged, allFilesRadio.CheckedChanged, allRadio.CheckedChanged, ignoreFileCheck.CheckedChanged, chooseIgnoredBtn.Click, ignoredFilesText.TextChanged, chooseFilesRadio.CheckedChanged, chooseFilesBtn.Click, selectedFilesText.TextChanged, addMoreBtn.Click, clearSelectionBtn.Click, chooseIndexCheck.CheckedChanged, chooseIndexBtn.Click, custPortCheck.CheckedChanged, portSelect.ValueChanged, configCheck.CheckedChanged, configBtn.Click, httpsCheck.CheckedChanged, hostnameCheck.CheckedChanged, browserSelectCombo.SelectedIndexChanged, enableTunnelCheck.CheckedChanged, logJsonCheck.CheckedChanged, hostnameText.TextChanged

        Command = init

        If startServer Then
            command = command & "start --server"
        End If

        If mentionWatch Then
            command = command & " --watch false"
        End If

        If mentionTunnel Then
            command = command & " --tunnel"
        End If

        If mentionHost Then
            command = command & " --host " & host
        End If

        If mentionPort Then
            command = command & " --port " & port
        End If

        If mentionHTTPS Then
            command = command & " --https"
        End If

        If mentionCWD Then
            command = command & " --cwd " & $"""{cwd.Replace("\", "/")}"""
        End If

        If mentionFiles Then
            command = command & " --files " & $"""{files.Replace("\", "/")}"""
        End If

        If mentionIgnore Then
            If mentionJson Then
                If ignoredFilesText.Text = "" Then
                    command = command & " --ignore ""browser-sync-log.json"""
                Else
                    command = command & " --ignore " & $"""{"browser-sync-log.json, " & ignoreFiles.Replace("\", "/")}"""
                End If
            Else
                command = command & " --ignore " & $"""{ignoreFiles.Replace("\", "/")}"""
            End If
        Else
            If mentionJson Then
                command = command & " --ignore ""browser-sync-log.json"""
            End If
        End If

        If mentionIndex Then
            command = command & " --index " & $"""{indexFile}"""
        End If

        If mentionBrowser Then
            command = command & " --browser " & $"""{browser}"""
        End If

        If mentionConfig Then
            command = command & " --config " & $"""{configPath}"""
        End If

        If mentionJson Then
            command = command & " --json > browser-sync-log.json"
        End If

        commandShowText.Text = command
    End Sub
    'update command on every event - ENDS HERE

End Class
