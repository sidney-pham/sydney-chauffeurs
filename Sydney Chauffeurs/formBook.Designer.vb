<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBook))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picLogoSmall = New System.Windows.Forms.PictureBox()
        Me.lblBookNow = New System.Windows.Forms.Label()
        Me.lblCall = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.btnMeetingMap = New System.Windows.Forms.Button()
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(12, 616)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "⇐ Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'picLogoSmall
        '
        Me.picLogoSmall.Image = CType(resources.GetObject("picLogoSmall.Image"), System.Drawing.Image)
        Me.picLogoSmall.Location = New System.Drawing.Point(409, 616)
        Me.picLogoSmall.Name = "picLogoSmall"
        Me.picLogoSmall.Size = New System.Drawing.Size(200, 68)
        Me.picLogoSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoSmall.TabIndex = 5
        Me.picLogoSmall.TabStop = False
        '
        'lblBookNow
        '
        Me.lblBookNow.AutoSize = True
        Me.lblBookNow.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookNow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblBookNow.Location = New System.Drawing.Point(207, 47)
        Me.lblBookNow.Name = "lblBookNow"
        Me.lblBookNow.Size = New System.Drawing.Size(294, 56)
        Me.lblBookNow.TabIndex = 6
        Me.lblBookNow.Text = "BOOK NOW"
        '
        'lblCall
        '
        Me.lblCall.AutoSize = True
        Me.lblCall.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblCall.Location = New System.Drawing.Point(253, 166)
        Me.lblCall.Name = "lblCall"
        Me.lblCall.Size = New System.Drawing.Size(184, 44)
        Me.lblCall.TabIndex = 7
        Me.lblCall.Text = "Call Us ☎"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(278, 235)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(179, 33)
        Me.lblPhoneNumber.TabIndex = 8
        Me.lblPhoneNumber.Text = "0404 999 888"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(288, 342)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(209, 44)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email Us ✉"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblEmailAddress.Location = New System.Drawing.Point(278, 422)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(415, 33)
        Me.lblEmailAddress.TabIndex = 10
        Me.lblEmailAddress.Text = "sydney.chauffeurs@gmail.com"
        '
        'btnMeetingMap
        '
        Me.btnMeetingMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMeetingMap.FlatAppearance.BorderSize = 0
        Me.btnMeetingMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeetingMap.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeetingMap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnMeetingMap.Location = New System.Drawing.Point(250, 478)
        Me.btnMeetingMap.Name = "btnMeetingMap"
        Me.btnMeetingMap.Size = New System.Drawing.Size(482, 68)
        Me.btnMeetingMap.TabIndex = 11
        Me.btnMeetingMap.Text = "WHERE TO MEET YOUR CHAUFFEUR"
        Me.btnMeetingMap.UseVisualStyleBackColor = False
        '
        'formBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 696)
        Me.Controls.Add(Me.btnMeetingMap)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblCall)
        Me.Controls.Add(Me.lblBookNow)
        Me.Controls.Add(Me.picLogoSmall)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formBook"
        Me.Text = "formBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents picLogoSmall As PictureBox
    Friend WithEvents lblBookNow As Label
    Friend WithEvents lblCall As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents btnMeetingMap As Button
End Class
