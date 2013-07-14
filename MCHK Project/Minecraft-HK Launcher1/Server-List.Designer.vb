<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server_List
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "1.5.2", "mwser.minecraft-hk.com", "MW SER LXXX WORLD", "20/60", "HK"}, -1)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ServerList = New System.Windows.Forms.ListView()
        Me.ServerList_SID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ServerList_Version = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ServerList_ip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ServerList_MOTD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ServerList_Players = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ServerList_Country = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ServerList)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(983, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox2.Location = New System.Drawing.Point(164, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(0, 21)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(164, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(655, 21)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ServerList
        '
        Me.ServerList.AutoArrange = False
        Me.ServerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ServerList.BackgroundImage = Global.Minecraft_HK_Launcher.My.Resources.Resources._1
        Me.ServerList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ServerList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ServerList_SID, Me.ServerList_Version, Me.ServerList_ip, Me.ServerList_MOTD, Me.ServerList_Players, Me.ServerList_Country})
        Me.ServerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ServerList.HideSelection = False
        Me.ServerList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5})
        Me.ServerList.LabelWrap = False
        Me.ServerList.Location = New System.Drawing.Point(1, 45)
        Me.ServerList.MultiSelect = False
        Me.ServerList.Name = "ServerList"
        Me.ServerList.Scrollable = False
        Me.ServerList.ShowGroups = False
        Me.ServerList.Size = New System.Drawing.Size(979, 252)
        Me.ServerList.TabIndex = 0
        Me.ServerList.UseCompatibleStateImageBehavior = False
        Me.ServerList.View = System.Windows.Forms.View.Details
        '
        'ServerList_SID
        '
        Me.ServerList_SID.Text = "SID"
        Me.ServerList_SID.Width = 57
        '
        'ServerList_Version
        '
        Me.ServerList_Version.Text = "Version"
        Me.ServerList_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServerList_Version.Width = 81
        '
        'ServerList_ip
        '
        Me.ServerList_ip.Text = "Server ip"
        Me.ServerList_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServerList_ip.Width = 252
        '
        'ServerList_MOTD
        '
        Me.ServerList_MOTD.Text = "MOTD"
        Me.ServerList_MOTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServerList_MOTD.Width = 344
        '
        'ServerList_Players
        '
        Me.ServerList_Players.Text = "Players"
        Me.ServerList_Players.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServerList_Players.Width = 98
        '
        'ServerList_Country
        '
        Me.ServerList_Country.Text = "Country"
        Me.ServerList_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServerList_Country.Width = 145
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(835, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 44)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Country"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(736, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 44)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Player"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(393, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(343, 44)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "MOTD"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(140, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(252, 44)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Server ip"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(59, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 44)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Version"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SID"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(963, -6)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(45, 20)
        Me.WebBrowser1.TabIndex = 15
        Me.WebBrowser1.Url = New System.Uri("http://list.minecraft-hk.com/", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'Server_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 327)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Server_List"
        Me.Text = "Server_List"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ServerList As System.Windows.Forms.ListView
    Friend WithEvents ServerList_SID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServerList_Version As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServerList_ip As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServerList_MOTD As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServerList_Players As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServerList_Country As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
