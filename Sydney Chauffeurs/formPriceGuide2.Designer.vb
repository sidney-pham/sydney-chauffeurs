<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPriceGuide2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPriceGuide2))
        Me.lblPricingInfo = New System.Windows.Forms.Label()
        Me.lblPriceGuide = New System.Windows.Forms.Label()
        Me.picLogoSmall = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPricingInfo
        '
        Me.lblPricingInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPricingInfo.AutoSize = True
        Me.lblPricingInfo.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricingInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPricingInfo.Location = New System.Drawing.Point(22, 122)
        Me.lblPricingInfo.Name = "lblPricingInfo"
        Me.lblPricingInfo.Size = New System.Drawing.Size(1122, 363)
        Me.lblPricingInfo.TabIndex = 10
        Me.lblPricingInfo.Text = resources.GetString("lblPricingInfo.Text")
        '
        'lblPriceGuide
        '
        Me.lblPriceGuide.AutoSize = True
        Me.lblPriceGuide.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPriceGuide.Location = New System.Drawing.Point(258, 42)
        Me.lblPriceGuide.Name = "lblPriceGuide"
        Me.lblPriceGuide.Size = New System.Drawing.Size(310, 56)
        Me.lblPriceGuide.TabIndex = 9
        Me.lblPriceGuide.Text = "PRICE GUIDE"
        '
        'picLogoSmall
        '
        Me.picLogoSmall.Image = CType(resources.GetObject("picLogoSmall.Image"), System.Drawing.Image)
        Me.picLogoSmall.Location = New System.Drawing.Point(363, 615)
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
        Me.btnBack.Location = New System.Drawing.Point(13, 615)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "⇐ Get Quote"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'formPriceGuide2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 696)
        Me.Controls.Add(Me.lblPricingInfo)
        Me.Controls.Add(Me.lblPriceGuide)
        Me.Controls.Add(Me.picLogoSmall)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formPriceGuide2"
        Me.Text = "formPricingGuide2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPricingInfo As Label
    Friend WithEvents lblPriceGuide As Label
    Friend WithEvents picLogoSmall As PictureBox
    Friend WithEvents btnBack As Button
End Class
