<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMeetingMap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMeetingMap))
        Me.lblMeetingMap = New System.Windows.Forms.Label()
        Me.picLogoSmall = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblPickupDomestic = New System.Windows.Forms.Label()
        Me.lblPickupInternational = New System.Windows.Forms.Label()
        Me.picMapT1 = New System.Windows.Forms.PictureBox()
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMapT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMeetingMap
        '
        Me.lblMeetingMap.AutoSize = True
        Me.lblMeetingMap.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeetingMap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblMeetingMap.Location = New System.Drawing.Point(207, 9)
        Me.lblMeetingMap.Name = "lblMeetingMap"
        Me.lblMeetingMap.Size = New System.Drawing.Size(799, 56)
        Me.lblMeetingMap.TabIndex = 9
        Me.lblMeetingMap.Text = "WHERE TO MEET YOUR CHAUFFEUR"
        '
        'picLogoSmall
        '
        Me.picLogoSmall.Image = CType(resources.GetObject("picLogoSmall.Image"), System.Drawing.Image)
        Me.picLogoSmall.Location = New System.Drawing.Point(409, 578)
        Me.picLogoSmall.Name = "picLogoSmall"
        Me.picLogoSmall.Size = New System.Drawing.Size(200, 68)
        Me.picLogoSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoSmall.TabIndex = 8
        Me.picLogoSmall.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(12, 578)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "⇐ Book Now"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cmbLocation
        '
        Me.cmbLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cmbLocation.DropDownHeight = 150
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.DropDownWidth = 35
        Me.cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLocation.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cmbLocation.IntegralHeight = False
        Me.cmbLocation.ItemHeight = 28
        Me.cmbLocation.Items.AddRange(New Object() {"T1 (International)", "T2 & T3 (Domestic)"})
        Me.cmbLocation.Location = New System.Drawing.Point(59, 167)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(300, 36)
        Me.cmbLocation.TabIndex = 11
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblLocation.Location = New System.Drawing.Point(52, 116)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(155, 39)
        Me.lblLocation.TabIndex = 10
        Me.lblLocation.Text = "Location"
        '
        'lblPickupDomestic
        '
        Me.lblPickupDomestic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPickupDomestic.AutoSize = True
        Me.lblPickupDomestic.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickupDomestic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPickupDomestic.Location = New System.Drawing.Point(53, 273)
        Me.lblPickupDomestic.Name = "lblPickupDomestic"
        Me.lblPickupDomestic.Size = New System.Drawing.Size(3266, 33)
        Me.lblPickupDomestic.TabIndex = 12
        Me.lblPickupDomestic.Text = resources.GetString("lblPickupDomestic.Text")
        '
        'lblPickupInternational
        '
        Me.lblPickupInternational.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPickupInternational.AutoSize = True
        Me.lblPickupInternational.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickupInternational.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPickupInternational.Location = New System.Drawing.Point(53, 347)
        Me.lblPickupInternational.Name = "lblPickupInternational"
        Me.lblPickupInternational.Size = New System.Drawing.Size(3217, 33)
        Me.lblPickupInternational.TabIndex = 13
        Me.lblPickupInternational.Text = resources.GetString("lblPickupInternational.Text")
        '
        'picMapT1
        '
        Me.picMapT1.Image = CType(resources.GetObject("picMapT1.Image"), System.Drawing.Image)
        Me.picMapT1.Location = New System.Drawing.Point(47, 393)
        Me.picMapT1.Name = "picMapT1"
        Me.picMapT1.Size = New System.Drawing.Size(731, 330)
        Me.picMapT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMapT1.TabIndex = 14
        Me.picMapT1.TabStop = False
        '
        'formMeetingMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 657)
        Me.Controls.Add(Me.picMapT1)
        Me.Controls.Add(Me.lblPickupInternational)
        Me.Controls.Add(Me.lblPickupDomestic)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblMeetingMap)
        Me.Controls.Add(Me.picLogoSmall)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formMeetingMap"
        Me.Text = "formMeetingMap"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMapT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMeetingMap As Label
    Friend WithEvents picLogoSmall As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblPickupDomestic As Label
    Friend WithEvents lblPickupInternational As Label
    Friend WithEvents picMapT1 As PictureBox
End Class
