<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOurService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOurService))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblOurService = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.picLogoSmall = New System.Windows.Forms.PictureBox()
        Me.lblHeaderPricing = New System.Windows.Forms.Label()
        Me.lblPricing = New System.Windows.Forms.Label()
        Me.btnPricingGuide = New System.Windows.Forms.Button()
        Me.lblHeaderPremium = New System.Windows.Forms.Label()
        Me.lblPremiumInfo = New System.Windows.Forms.Label()
        Me.btnViewFleet = New System.Windows.Forms.Button()
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
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "⇐ Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblOurService
        '
        Me.lblOurService.AutoSize = True
        Me.lblOurService.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOurService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblOurService.Location = New System.Drawing.Point(223, 41)
        Me.lblOurService.Name = "lblOurService"
        Me.lblOurService.Size = New System.Drawing.Size(323, 56)
        Me.lblOurService.TabIndex = 1
        Me.lblOurService.Text = "OUR SERVICE"
        '
        'lblAbout
        '
        Me.lblAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblAbout.Location = New System.Drawing.Point(38, 112)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(3518, 33)
        Me.lblAbout.TabIndex = 2
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        '
        'picLogoSmall
        '
        Me.picLogoSmall.Image = CType(resources.GetObject("picLogoSmall.Image"), System.Drawing.Image)
        Me.picLogoSmall.Location = New System.Drawing.Point(359, 616)
        Me.picLogoSmall.Name = "picLogoSmall"
        Me.picLogoSmall.Size = New System.Drawing.Size(200, 68)
        Me.picLogoSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoSmall.TabIndex = 3
        Me.picLogoSmall.TabStop = False
        '
        'lblHeaderPricing
        '
        Me.lblHeaderPricing.AutoSize = True
        Me.lblHeaderPricing.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderPricing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblHeaderPricing.Location = New System.Drawing.Point(36, 236)
        Me.lblHeaderPricing.Name = "lblHeaderPricing"
        Me.lblHeaderPricing.Size = New System.Drawing.Size(141, 44)
        Me.lblHeaderPricing.TabIndex = 4
        Me.lblHeaderPricing.Text = "Pricing"
        '
        'lblPricing
        '
        Me.lblPricing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPricing.AutoSize = True
        Me.lblPricing.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPricing.Location = New System.Drawing.Point(38, 295)
        Me.lblPricing.Name = "lblPricing"
        Me.lblPricing.Size = New System.Drawing.Size(1955, 33)
        Me.lblPricing.TabIndex = 5
        Me.lblPricing.Text = "Our fares are calculated based on the area travelled to, the number of passengers" &
    " and the type of service. There is a base fare of $30 on all services."
        '
        'btnPricingGuide
        '
        Me.btnPricingGuide.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnPricingGuide.FlatAppearance.BorderSize = 0
        Me.btnPricingGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPricingGuide.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPricingGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPricingGuide.Location = New System.Drawing.Point(245, 354)
        Me.btnPricingGuide.Name = "btnPricingGuide"
        Me.btnPricingGuide.Size = New System.Drawing.Size(359, 68)
        Me.btnPricingGuide.TabIndex = 6
        Me.btnPricingGuide.Text = "VIEW FULL PRICE GUIDE"
        Me.btnPricingGuide.UseVisualStyleBackColor = False
        '
        'lblHeaderPremium
        '
        Me.lblHeaderPremium.AutoSize = True
        Me.lblHeaderPremium.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderPremium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblHeaderPremium.Location = New System.Drawing.Point(36, 442)
        Me.lblHeaderPremium.Name = "lblHeaderPremium"
        Me.lblHeaderPremium.Size = New System.Drawing.Size(321, 44)
        Me.lblHeaderPremium.TabIndex = 7
        Me.lblHeaderPremium.Text = "Premium Service"
        '
        'lblPremiumInfo
        '
        Me.lblPremiumInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPremiumInfo.AutoSize = True
        Me.lblPremiumInfo.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPremiumInfo.Location = New System.Drawing.Point(38, 502)
        Me.lblPremiumInfo.Name = "lblPremiumInfo"
        Me.lblPremiumInfo.Size = New System.Drawing.Size(2698, 33)
        Me.lblPremiumInfo.TabIndex = 8
        Me.lblPremiumInfo.Text = resources.GetString("lblPremiumInfo.Text")
        '
        'btnViewFleet
        '
        Me.btnViewFleet.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnViewFleet.FlatAppearance.BorderSize = 0
        Me.btnViewFleet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewFleet.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewFleet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnViewFleet.Location = New System.Drawing.Point(260, 552)
        Me.btnViewFleet.Name = "btnViewFleet"
        Me.btnViewFleet.Size = New System.Drawing.Size(359, 68)
        Me.btnViewFleet.TabIndex = 9
        Me.btnViewFleet.Text = "VIEW FLEET"
        Me.btnViewFleet.UseVisualStyleBackColor = False
        '
        'formOurService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 696)
        Me.Controls.Add(Me.btnViewFleet)
        Me.Controls.Add(Me.lblPremiumInfo)
        Me.Controls.Add(Me.lblHeaderPremium)
        Me.Controls.Add(Me.btnPricingGuide)
        Me.Controls.Add(Me.lblPricing)
        Me.Controls.Add(Me.lblHeaderPricing)
        Me.Controls.Add(Me.picLogoSmall)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblOurService)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formOurService"
        Me.Text = "formOurService"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblOurService As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents picLogoSmall As PictureBox
    Friend WithEvents lblHeaderPricing As Label
    Friend WithEvents lblPricing As Label
    Friend WithEvents btnPricingGuide As Button
    Friend WithEvents lblHeaderPremium As Label
    Friend WithEvents lblPremiumInfo As Label
    Friend WithEvents btnViewFleet As Button
End Class
