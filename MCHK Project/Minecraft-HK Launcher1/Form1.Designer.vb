<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.Button6 = New System.Windows.Forms.Button()
      Me.TextBox2 = New System.Windows.Forms.TextBox()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.mirroredTabControl1 = New MirroredTabControl.MirroredTabControl()
      Me.tabPage5 = New System.Windows.Forms.TabPage()
      Me.tabPage4 = New System.Windows.Forms.TabPage()
      Me.tabPage3 = New System.Windows.Forms.TabPage()
      Me.tabPage2 = New System.Windows.Forms.TabPage()
      Me.tabPage1 = New System.Windows.Forms.TabPage()
      Me.Panel2.SuspendLayout
      CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
      Me.mirroredTabControl1.SuspendLayout
      Me.SuspendLayout
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.Color.White
      Me.Panel2.Controls.Add(Me.Button6)
      Me.Panel2.Controls.Add(Me.TextBox2)
      Me.Panel2.Controls.Add(Me.TextBox1)
      Me.Panel2.Controls.Add(Me.Label3)
      Me.Panel2.Controls.Add(Me.Label2)
      Me.Panel2.Controls.Add(Me.Label1)
      Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.Panel2.Location = New System.Drawing.Point(0, 383)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(1007, 57)
      Me.Panel2.TabIndex = 11
      '
      'Button6
      '
      Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(184,Byte),Integer), CType(CType(218,Byte),Integer), CType(CType(253,Byte),Integer))
      Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
      Me.Button6.FlatAppearance.BorderSize = 2
      Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(184,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
      Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(184,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
      Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Button6.Location = New System.Drawing.Point(863, 8)
      Me.Button6.Name = "Button6"
      Me.Button6.Size = New System.Drawing.Size(141, 39)
      Me.Button6.TabIndex = 7
      Me.Button6.Text = "LOGIN"
      Me.Button6.UseVisualStyleBackColor = false
      '
      'TextBox2
      '
      Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(184,Byte),Integer), CType(CType(218,Byte),Integer), CType(CType(253,Byte),Integer))
      Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.TextBox2.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextBox2.ForeColor = System.Drawing.Color.RoyalBlue
      Me.TextBox2.Location = New System.Drawing.Point(628, 31)
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.TextBox2.Size = New System.Drawing.Size(234, 20)
      Me.TextBox2.TabIndex = 4
      Me.TextBox2.UseSystemPasswordChar = true
      '
      'TextBox1
      '
      Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184,Byte),Integer), CType(CType(218,Byte),Integer), CType(CType(253,Byte),Integer))
      Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.TextBox1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextBox1.ForeColor = System.Drawing.Color.RoyalBlue
      Me.TextBox1.Location = New System.Drawing.Point(628, 3)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(234, 20)
      Me.TextBox1.TabIndex = 3
      '
      'Label3
      '
      Me.Label3.AutoSize = true
      Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label3.Location = New System.Drawing.Point(535, 24)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(91, 23)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "Password:"
      '
      'Label2
      '
      Me.Label2.AutoSize = true
      Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label2.Location = New System.Drawing.Point(490, 2)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(136, 23)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "Mojang Acount:"
      '
      'Label1
      '
      Me.Label1.AutoSize = true
      Me.Label1.Font = New System.Drawing.Font("Calibri", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.Location = New System.Drawing.Point(3, 8)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(217, 39)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Play Minecraft!"
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184,Byte),Integer), CType(CType(218,Byte),Integer), CType(CType(253,Byte),Integer))
      Me.PictureBox1.Image = Global.Minecraft_HK_Launcher.My.Resources.Resources.logo
      Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(322, 74)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 0
      Me.PictureBox1.TabStop = false
      '
      'mirroredTabControl1
      '
      Me.mirroredTabControl1.Controls.Add(Me.tabPage1)
      Me.mirroredTabControl1.Controls.Add(Me.tabPage2)
      Me.mirroredTabControl1.Controls.Add(Me.tabPage3)
      Me.mirroredTabControl1.Controls.Add(Me.tabPage4)
      Me.mirroredTabControl1.Controls.Add(Me.tabPage5)
      Me.mirroredTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.mirroredTabControl1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.mirroredTabControl1.ItemSize = New System.Drawing.Size(100, 75)
      Me.mirroredTabControl1.Location = New System.Drawing.Point(0, 0)
      Me.mirroredTabControl1.Mirror = true
      Me.mirroredTabControl1.Multiline = true
      Me.mirroredTabControl1.Name = "mirroredTabControl1"
      Me.mirroredTabControl1.Padding = New System.Drawing.Point(20, 3)
      Me.mirroredTabControl1.SelectedIndex = 0
      Me.mirroredTabControl1.Size = New System.Drawing.Size(1007, 383)
      Me.mirroredTabControl1.TabIndex = 13
      '
      'tabPage5
      '
      Me.tabPage5.Location = New System.Drawing.Point(4, 79)
      Me.tabPage5.Name = "tabPage5"
      Me.tabPage5.Size = New System.Drawing.Size(999, 300)
      Me.tabPage5.TabIndex = 4
      Me.tabPage5.Text = "Home"
      Me.tabPage5.UseVisualStyleBackColor = true
      '
      'tabPage4
      '
      Me.tabPage4.Location = New System.Drawing.Point(4, 79)
      Me.tabPage4.Name = "tabPage4"
      Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPage4.Size = New System.Drawing.Size(999, 300)
      Me.tabPage4.TabIndex = 3
      Me.tabPage4.Text = "Minecraft-HK Server List"
      Me.tabPage4.UseVisualStyleBackColor = true
      '
      'tabPage3
      '
      Me.tabPage3.Location = New System.Drawing.Point(4, 79)
      Me.tabPage3.Name = "tabPage3"
      Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPage3.Size = New System.Drawing.Size(999, 300)
      Me.tabPage3.TabIndex = 2
      Me.tabPage3.Text = "Folder Shortcuts"
      Me.tabPage3.UseVisualStyleBackColor = true
      '
      'tabPage2
      '
      Me.tabPage2.Location = New System.Drawing.Point(4, 79)
      Me.tabPage2.Name = "tabPage2"
      Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPage2.Size = New System.Drawing.Size(999, 300)
      Me.tabPage2.TabIndex = 1
      Me.tabPage2.Text = "Options"
      Me.tabPage2.UseVisualStyleBackColor = true
      '
      'tabPage1
      '
      Me.tabPage1.Location = New System.Drawing.Point(4, 79)
      Me.tabPage1.Name = "tabPage1"
      Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPage1.Size = New System.Drawing.Size(999, 300)
      Me.tabPage1.TabIndex = 0
      Me.tabPage1.Text = "About"
      Me.tabPage1.UseVisualStyleBackColor = true
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(184,Byte),Integer), CType(CType(218,Byte),Integer), CType(CType(253,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(1007, 440)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.mirroredTabControl1)
      Me.Controls.Add(Me.Panel2)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.MaximizeBox = false
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Minecraft-HK Launcher"
      Me.Panel2.ResumeLayout(false)
      Me.Panel2.PerformLayout
      CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
      Me.mirroredTabControl1.ResumeLayout(false)
      Me.ResumeLayout(false)
    End Sub
    Private tabPage5 As System.Windows.Forms.TabPage
    Private tabPage4 As System.Windows.Forms.TabPage
    Private tabPage3 As System.Windows.Forms.TabPage
    Private tabPage2 As System.Windows.Forms.TabPage
    Private tabPage1 As System.Windows.Forms.TabPage
    Private mirroredTabControl1 As MirroredTabControl.MirroredTabControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
