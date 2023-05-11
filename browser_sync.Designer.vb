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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class browser_sync
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(browser_sync))
        hostDir = New TextBox()
        changeBtn = New Button()
        startBtn = New Button()
        closeBtn = New Button()
        custPortCheck = New CheckBox()
        portSelect = New NumericUpDown()
        allFilesRadio = New RadioButton()
        chooseFilesRadio = New RadioButton()
        GroupBox1 = New GroupBox()
        chooseIgnoredBtn = New Button()
        ignoredFilesText = New TextBox()
        ignoreFileCheck = New CheckBox()
        clearSelectionBtn = New Button()
        selectedFilesText = New TextBox()
        addMoreBtn = New Button()
        watchFilesCheck = New CheckBox()
        GroupBox3 = New GroupBox()
        chooseIndexBtn = New Button()
        chooseIndexCheck = New CheckBox()
        chooseFilesBtn = New Button()
        allRadio = New RadioButton()
        GroupBox2 = New GroupBox()
        GroupBox4 = New GroupBox()
        enableTunnelCheck = New CheckBox()
        logJsonCheck = New CheckBox()
        openWithLabel = New Label()
        browserSelectCombo = New ComboBox()
        hostnameText = New TextBox()
        hostnameCheck = New CheckBox()
        configBtn = New Button()
        configCheck = New CheckBox()
        httpsCheck = New CheckBox()
        copyCommandBtn = New Button()
        commandShowPanel = New Panel()
        commandShowText = New TextBox()
        CType(portSelect, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        commandShowPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' hostDir
        ' 
        hostDir.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        hostDir.Location = New Point(6, 22)
        hostDir.Name = "hostDir"
        hostDir.Size = New Size(682, 23)
        hostDir.TabIndex = 0
        hostDir.Text = "C:/" ' 
        ' changeBtn
        ' 
        changeBtn.ForeColor = Color.Black
        changeBtn.Location = New Point(694, 22)
        changeBtn.Name = "changeBtn"
        changeBtn.Size = New Size(76, 23)
        changeBtn.TabIndex = 2
        changeBtn.Text = "Change"
        changeBtn.UseVisualStyleBackColor = True
        ' 
        ' startBtn
        ' 
        startBtn.Location = New Point(713, 415)
        startBtn.Name = "startBtn"
        startBtn.Size = New Size(75, 23)
        startBtn.TabIndex = 3
        startBtn.Text = "Start"
        startBtn.UseVisualStyleBackColor = True
        ' 
        ' closeBtn
        ' 
        closeBtn.Location = New Point(627, 415)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(75, 23)
        closeBtn.TabIndex = 4
        closeBtn.Text = "Close"
        closeBtn.UseVisualStyleBackColor = True
        ' 
        ' custPortCheck
        ' 
        custPortCheck.AutoSize = True
        custPortCheck.ForeColor = Color.Transparent
        custPortCheck.Location = New Point(6, 22)
        custPortCheck.Name = "custPortCheck"
        custPortCheck.Size = New Size(96, 19)
        custPortCheck.TabIndex = 9
        custPortCheck.Text = "Custom Port:"
        custPortCheck.UseVisualStyleBackColor = True
        ' 
        ' portSelect
        ' 
        portSelect.Enabled = False
        portSelect.Location = New Point(108, 21)
        portSelect.Maximum = New [Decimal](New Integer() {9999, 0, 0, 0})
        portSelect.Minimum = New [Decimal](New Integer() {80, 0, 0, 0})
        portSelect.Name = "portSelect"
        portSelect.Size = New Size(69, 23)
        portSelect.TabIndex = 11
        portSelect.Value = New [Decimal](New Integer() {3000, 0, 0, 0})
        ' 
        ' allFilesRadio
        ' 
        allFilesRadio.AutoSize = True
        allFilesRadio.Checked = True
        allFilesRadio.ForeColor = Color.White
        allFilesRadio.Location = New Point(6, 14)
        allFilesRadio.Name = "allFilesRadio"
        allFilesRadio.Size = New Size(69, 19)
        allFilesRadio.TabIndex = 12
        allFilesRadio.TabStop = True
        allFilesRadio.Text = ": All files"
        allFilesRadio.UseVisualStyleBackColor = True
        ' 
        ' chooseFilesRadio
        ' 
        chooseFilesRadio.AutoSize = True
        chooseFilesRadio.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        chooseFilesRadio.ForeColor = Color.White
        chooseFilesRadio.Location = New Point(334, 14)
        chooseFilesRadio.Name = "chooseFilesRadio"
        chooseFilesRadio.Size = New Size(147, 19)
        chooseFilesRadio.TabIndex = 13
        chooseFilesRadio.Text = ": Choose files manually"
        chooseFilesRadio.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chooseIgnoredBtn)
        GroupBox1.Controls.Add(ignoredFilesText)
        GroupBox1.Controls.Add(ignoreFileCheck)
        GroupBox1.Controls.Add(clearSelectionBtn)
        GroupBox1.Controls.Add(selectedFilesText)
        GroupBox1.Controls.Add(addMoreBtn)
        GroupBox1.Controls.Add(watchFilesCheck)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(chooseFilesBtn)
        GroupBox1.Controls.Add(chooseFilesRadio)
        GroupBox1.Controls.Add(allRadio)
        GroupBox1.Controls.Add(allFilesRadio)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 82)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 66)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = " Watch for " ' 
        ' chooseIgnoredBtn
        ' 
        chooseIgnoredBtn.Enabled = False
        chooseIgnoredBtn.ForeColor = Color.Black
        chooseIgnoredBtn.Location = New Point(514, 38)
        chooseIgnoredBtn.Name = "chooseIgnoredBtn"
        chooseIgnoredBtn.Size = New Size(75, 23)
        chooseIgnoredBtn.TabIndex = 24
        chooseIgnoredBtn.Text = "Browse"
        chooseIgnoredBtn.UseVisualStyleBackColor = True
        chooseIgnoredBtn.Visible = False
        ' 
        ' ignoredFilesText
        ' 
        ignoredFilesText.Enabled = False
        ignoredFilesText.Location = New Point(189, 37)
        ignoredFilesText.Name = "ignoredFilesText"
        ignoredFilesText.Size = New Size(319, 23)
        ignoredFilesText.TabIndex = 23
        ignoredFilesText.Visible = False
        ' 
        ' ignoreFileCheck
        ' 
        ignoreFileCheck.AutoSize = True
        ignoreFileCheck.Location = New Point(96, 41)
        ignoreFileCheck.Name = "ignoreFileCheck"
        ignoreFileCheck.Size = New Size(87, 19)
        ignoreFileCheck.TabIndex = 22
        ignoreFileCheck.Text = "Ignore files:"
        ignoreFileCheck.UseVisualStyleBackColor = True
        ignoreFileCheck.Visible = False
        ' 
        ' clearSelectionBtn
        ' 
        clearSelectionBtn.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        clearSelectionBtn.ForeColor = Color.Black
        clearSelectionBtn.Location = New Point(96, 36)
        clearSelectionBtn.Name = "clearSelectionBtn"
        clearSelectionBtn.Size = New Size(24, 23)
        clearSelectionBtn.TabIndex = 21
        clearSelectionBtn.Text = "X"
        clearSelectionBtn.UseVisualStyleBackColor = True
        ' 
        ' selectedFilesText
        ' 
        selectedFilesText.Location = New Point(126, 37)
        selectedFilesText.Name = "selectedFilesText"
        selectedFilesText.Size = New Size(463, 23)
        selectedFilesText.TabIndex = 20
        selectedFilesText.Visible = False
        ' 
        ' addMoreBtn
        ' 
        addMoreBtn.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        addMoreBtn.ForeColor = Color.Black
        addMoreBtn.Location = New Point(565, 12)
        addMoreBtn.Name = "addMoreBtn"
        addMoreBtn.Size = New Size(24, 23)
        addMoreBtn.TabIndex = 19
        addMoreBtn.Text = "+"
        addMoreBtn.TextAlign = ContentAlignment.MiddleLeft
        addMoreBtn.UseVisualStyleBackColor = True
        addMoreBtn.Visible = False
        ' 
        ' watchFilesCheck
        ' 
        watchFilesCheck.AutoSize = True
        watchFilesCheck.Checked = True
        watchFilesCheck.CheckState = CheckState.Checked
        watchFilesCheck.Location = New Point(6, 41)
        watchFilesCheck.Name = "watchFilesCheck"
        watchFilesCheck.Size = New Size(84, 19)
        watchFilesCheck.TabIndex = 18
        watchFilesCheck.Text = "Watch files"
        watchFilesCheck.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(chooseIndexBtn)
        GroupBox3.Controls.Add(chooseIndexCheck)
        GroupBox3.Location = New Point(605, 0)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(171, 66)
        GroupBox3.TabIndex = 17
        GroupBox3.TabStop = False
        ' 
        ' chooseIndexBtn
        ' 
        chooseIndexBtn.Enabled = False
        chooseIndexBtn.ForeColor = Color.Black
        chooseIndexBtn.Location = New Point(5, 34)
        chooseIndexBtn.Name = "chooseIndexBtn"
        chooseIndexBtn.Size = New Size(159, 26)
        chooseIndexBtn.TabIndex = 16
        chooseIndexBtn.Text = "Browse"
        chooseIndexBtn.UseVisualStyleBackColor = True
        ' 
        ' chooseIndexCheck
        ' 
        chooseIndexCheck.AutoSize = True
        chooseIndexCheck.Location = New Point(6, 14)
        chooseIndexCheck.Name = "chooseIndexCheck"
        chooseIndexCheck.Size = New Size(160, 19)
        chooseIndexCheck.TabIndex = 15
        chooseIndexCheck.Text = "Choose custom index file"
        chooseIndexCheck.TextAlign = ContentAlignment.MiddleRight
        chooseIndexCheck.UseMnemonic = False
        chooseIndexCheck.UseVisualStyleBackColor = True
        ' 
        ' chooseFilesBtn
        ' 
        chooseFilesBtn.Enabled = False
        chooseFilesBtn.ForeColor = Color.Black
        chooseFilesBtn.Location = New Point(484, 12)
        chooseFilesBtn.Name = "chooseFilesBtn"
        chooseFilesBtn.Size = New Size(75, 23)
        chooseFilesBtn.TabIndex = 14
        chooseFilesBtn.Text = "Browse"
        chooseFilesBtn.UseVisualStyleBackColor = True
        ' 
        ' allRadio
        ' 
        allRadio.AutoSize = True
        allRadio.ForeColor = Color.White
        allRadio.Location = New Point(96, 14)
        allRadio.Name = "allRadio"
        allRadio.Size = New Size(213, 19)
        allRadio.TabIndex = 12
        allRadio.Text = ": All files (excluding the sub folders)"
        allRadio.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(hostDir)
        GroupBox2.Controls.Add(changeBtn)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 60)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Host from" ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(enableTunnelCheck)
        GroupBox4.Controls.Add(logJsonCheck)
        GroupBox4.Controls.Add(openWithLabel)
        GroupBox4.Controls.Add(browserSelectCombo)
        GroupBox4.Controls.Add(hostnameText)
        GroupBox4.Controls.Add(hostnameCheck)
        GroupBox4.Controls.Add(configBtn)
        GroupBox4.Controls.Add(configCheck)
        GroupBox4.Controls.Add(httpsCheck)
        GroupBox4.Controls.Add(custPortCheck)
        GroupBox4.Controls.Add(portSelect)
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(12, 163)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(776, 80)
        GroupBox4.TabIndex = 16
        GroupBox4.TabStop = False
        GroupBox4.Text = "Settings" ' 
        ' enableTunnelCheck
        ' 
        enableTunnelCheck.AutoSize = True
        enableTunnelCheck.Location = New Point(331, 55)
        enableTunnelCheck.Name = "enableTunnelCheck"
        enableTunnelCheck.Size = New Size(120, 19)
        enableTunnelCheck.TabIndex = 22
        enableTunnelCheck.Text = "Enable Tunnelling"
        enableTunnelCheck.UseVisualStyleBackColor = True
        ' 
        ' logJsonCheck
        ' 
        logJsonCheck.AutoSize = True
        logJsonCheck.Location = New Point(135, 55)
        logJsonCheck.Name = "logJsonCheck"
        logJsonCheck.Size = New Size(162, 19)
        logJsonCheck.TabIndex = 17
        logJsonCheck.Text = "JSON only for certain logs"
        logJsonCheck.UseVisualStyleBackColor = True
        ' 
        ' openWithLabel
        ' 
        openWithLabel.AutoSize = True
        openWithLabel.Location = New Point(494, 23)
        openWithLabel.Name = "openWithLabel"
        openWithLabel.Size = New Size(65, 15)
        openWithLabel.TabIndex = 21
        openWithLabel.Text = "Open with:" ' 
        ' browserSelectCombo
        ' 
        browserSelectCombo.FormattingEnabled = True
        browserSelectCombo.Items.AddRange(New Object() {"(Default Browser)", "Opera", "Opera GX", "Chrome", "Firefox", "Edge"})
        browserSelectCombo.Location = New Point(565, 19)
        browserSelectCombo.Name = "browserSelectCombo"
        browserSelectCombo.Size = New Size(204, 23)
        browserSelectCombo.TabIndex = 20
        browserSelectCombo.Text = "(Default Browser)" ' 
        ' hostnameText
        ' 
        hostnameText.Enabled = False
        hostnameText.Location = New Point(565, 51)
        hostnameText.Name = "hostnameText"
        hostnameText.Size = New Size(204, 23)
        hostnameText.TabIndex = 19
        ' 
        ' hostnameCheck
        ' 
        hostnameCheck.AutoSize = True
        hostnameCheck.Location = New Point(478, 55)
        hostnameCheck.Name = "hostnameCheck"
        hostnameCheck.Size = New Size(81, 19)
        hostnameCheck.TabIndex = 18
        hostnameCheck.Text = "Hostname"
        hostnameCheck.UseVisualStyleBackColor = True
        ' 
        ' configBtn
        ' 
        configBtn.Enabled = False
        configBtn.ForeColor = Color.Black
        configBtn.Location = New Point(376, 19)
        configBtn.Name = "configBtn"
        configBtn.Size = New Size(75, 23)
        configBtn.TabIndex = 14
        configBtn.Text = "Browse"
        configBtn.UseVisualStyleBackColor = True
        ' 
        ' configCheck
        ' 
        configCheck.AutoSize = True
        configCheck.Location = New Point(199, 22)
        configCheck.Name = "configCheck"
        configCheck.Size = New Size(171, 19)
        configCheck.TabIndex = 13
        configCheck.Text = "Choose a Configuration file"
        configCheck.UseVisualStyleBackColor = True
        ' 
        ' httpsCheck
        ' 
        httpsCheck.AutoSize = True
        httpsCheck.Location = New Point(6, 55)
        httpsCheck.Name = "httpsCheck"
        httpsCheck.Size = New Size(98, 19)
        httpsCheck.TabIndex = 12
        httpsCheck.Text = "Enable HTTPS"
        httpsCheck.UseVisualStyleBackColor = True
        ' 
        ' copyCommandBtn
        ' 
        copyCommandBtn.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        copyCommandBtn.FlatAppearance.BorderSize = 0
        copyCommandBtn.FlatStyle = FlatStyle.Flat
        copyCommandBtn.ForeColor = Color.White
        copyCommandBtn.Location = New Point(720, 3)
        copyCommandBtn.Name = "copyCommandBtn"
        copyCommandBtn.Size = New Size(51, 23)
        copyCommandBtn.TabIndex = 18
        copyCommandBtn.Text = "Copy"
        copyCommandBtn.UseVisualStyleBackColor = False
        ' 
        ' commandShowPanel
        ' 
        commandShowPanel.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        commandShowPanel.BorderStyle = BorderStyle.FixedSingle
        commandShowPanel.Controls.Add(commandShowText)
        commandShowPanel.Controls.Add(copyCommandBtn)
        commandShowPanel.Location = New Point(12, 259)
        commandShowPanel.Name = "commandShowPanel"
        commandShowPanel.Size = New Size(776, 140)
        commandShowPanel.TabIndex = 19
        ' 
        ' commandShowText
        ' 
        commandShowText.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        commandShowText.BorderStyle = BorderStyle.None
        commandShowText.Font = New Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        commandShowText.ForeColor = Color.LightGray
        commandShowText.Location = New Point(-1, -1)
        commandShowText.Multiline = True
        commandShowText.Name = "commandShowText"
        commandShowText.Size = New Size(715, 140)
        commandShowText.TabIndex = 19
        ' 
        ' browser_sync
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        ClientSize = New Size(800, 450)
        Controls.Add(commandShowPanel)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(closeBtn)
        Controls.Add(startBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "browser_sync"
        Text = "Browser Sync"
        CType(portSelect, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        commandShowPanel.ResumeLayout(False)
        commandShowPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents hostDir As TextBox
    Friend WithEvents changeBtn As Button
    Friend WithEvents startBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents custPortCheck As CheckBox
    Friend WithEvents portSelect As NumericUpDown
    Friend WithEvents allFilesRadio As RadioButton
    Friend WithEvents chooseFilesRadio As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chooseFilesBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chooseIndexBtn As Button
    Friend WithEvents chooseIndexCheck As CheckBox
    Friend WithEvents allRadio As RadioButton
    Friend WithEvents watchFilesCheck As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents logJsonCheck As CheckBox
    Friend WithEvents openWithLabel As Label
    Friend WithEvents browserSelectCombo As ComboBox
    Friend WithEvents hostnameText As TextBox
    Friend WithEvents hostnameCheck As CheckBox
    Friend WithEvents configBtn As Button
    Friend WithEvents configCheck As CheckBox
    Friend WithEvents httpsCheck As CheckBox
    Friend WithEvents copyCommandBtn As Button
    Friend WithEvents commandShowPanel As Panel
    Friend WithEvents commandShowText As TextBox
    Friend WithEvents selectedFilesText As TextBox
    Friend WithEvents addMoreBtn As Button
    Friend WithEvents clearSelectionBtn As Button
    Friend WithEvents chooseIgnoredBtn As Button
    Friend WithEvents ignoredFilesText As TextBox
    Friend WithEvents ignoreFileCheck As CheckBox
    Friend WithEvents enableTunnelCheck As CheckBox
End Class
