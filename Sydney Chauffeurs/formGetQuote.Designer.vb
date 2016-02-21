<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGetQuote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGetQuote))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picLogoSmall = New System.Windows.Forms.PictureBox()
        Me.lblGetQuote = New System.Windows.Forms.Label()
        Me.chkPremium = New System.Windows.Forms.CheckBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.cmbRegion = New System.Windows.Forms.ComboBox()
        Me.lblPassengers = New System.Windows.Forms.Label()
        Me.btnFewer = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.lblNumPassengers = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPricingGuide = New System.Windows.Forms.Button()
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
        Me.picLogoSmall.Location = New System.Drawing.Point(367, 616)
        Me.picLogoSmall.Name = "picLogoSmall"
        Me.picLogoSmall.Size = New System.Drawing.Size(200, 68)
        Me.picLogoSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoSmall.TabIndex = 4
        Me.picLogoSmall.TabStop = False
        '
        'lblGetQuote
        '
        Me.lblGetQuote.AutoSize = True
        Me.lblGetQuote.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGetQuote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblGetQuote.Location = New System.Drawing.Point(207, 56)
        Me.lblGetQuote.Name = "lblGetQuote"
        Me.lblGetQuote.Size = New System.Drawing.Size(327, 56)
        Me.lblGetQuote.TabIndex = 5
        Me.lblGetQuote.Text = "GET A QUOTE"
        '
        'chkPremium
        '
        Me.chkPremium.AutoSize = True
        Me.chkPremium.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPremium.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPremium.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPremium.FlatAppearance.BorderSize = 0
        Me.chkPremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPremium.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPremium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.chkPremium.Location = New System.Drawing.Point(54, 421)
        Me.chkPremium.Name = "chkPremium"
        Me.chkPremium.Size = New System.Drawing.Size(173, 43)
        Me.chkPremium.TabIndex = 6
        Me.chkPremium.Text = "Premium"
        Me.chkPremium.UseVisualStyleBackColor = False
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblRegion.Location = New System.Drawing.Point(47, 298)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(128, 39)
        Me.lblRegion.TabIndex = 7
        Me.lblRegion.Text = "Region"
        '
        'cmbRegion
        '
        Me.cmbRegion.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cmbRegion.DropDownHeight = 150
        Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegion.DropDownWidth = 35
        Me.cmbRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRegion.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cmbRegion.IntegralHeight = False
        Me.cmbRegion.ItemHeight = 28
        Me.cmbRegion.Items.AddRange(New Object() {"Sydney CBD", "North Shore", "Parramatta", "Cronulla", "Eastern Suburbs"})
        Me.cmbRegion.Location = New System.Drawing.Point(54, 349)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(300, 36)
        Me.cmbRegion.TabIndex = 8
        '
        'lblPassengers
        '
        Me.lblPassengers.AutoSize = True
        Me.lblPassengers.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassengers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPassengers.Location = New System.Drawing.Point(47, 161)
        Me.lblPassengers.Name = "lblPassengers"
        Me.lblPassengers.Size = New System.Drawing.Size(197, 39)
        Me.lblPassengers.TabIndex = 9
        Me.lblPassengers.Text = "Passengers"
        '
        'btnFewer
        '
        Me.btnFewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnFewer.Enabled = False
        Me.btnFewer.FlatAppearance.BorderSize = 0
        Me.btnFewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFewer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFewer.Location = New System.Drawing.Point(63, 215)
        Me.btnFewer.Name = "btnFewer"
        Me.btnFewer.Size = New System.Drawing.Size(50, 50)
        Me.btnFewer.TabIndex = 10
        Me.btnFewer.Text = "<"
        Me.btnFewer.UseVisualStyleBackColor = False
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMore.FlatAppearance.BorderSize = 0
        Me.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMore.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnMore.Location = New System.Drawing.Point(177, 215)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(50, 50)
        Me.btnMore.TabIndex = 11
        Me.btnMore.Text = ">"
        Me.btnMore.UseVisualStyleBackColor = False
        '
        'lblNumPassengers
        '
        Me.lblNumPassengers.AutoSize = True
        Me.lblNumPassengers.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPassengers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblNumPassengers.Location = New System.Drawing.Point(140, 216)
        Me.lblNumPassengers.Name = "lblNumPassengers"
        Me.lblNumPassengers.Size = New System.Drawing.Size(35, 39)
        Me.lblNumPassengers.TabIndex = 12
        Me.lblNumPassengers.Text = "1"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(547, 298)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(209, 112)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "$30"
        '
        'btnPricingGuide
        '
        Me.btnPricingGuide.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnPricingGuide.FlatAppearance.BorderSize = 0
        Me.btnPricingGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPricingGuide.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPricingGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPricingGuide.Location = New System.Drawing.Point(284, 492)
        Me.btnPricingGuide.Name = "btnPricingGuide"
        Me.btnPricingGuide.Size = New System.Drawing.Size(359, 68)
        Me.btnPricingGuide.TabIndex = 14
        Me.btnPricingGuide.Text = "VIEW FULL PRICE GUIDE"
        Me.btnPricingGuide.UseVisualStyleBackColor = False
        '
        'formGetQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 696)
        Me.Controls.Add(Me.btnPricingGuide)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblNumPassengers)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.btnFewer)
        Me.Controls.Add(Me.lblPassengers)
        Me.Controls.Add(Me.cmbRegion)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.chkPremium)
        Me.Controls.Add(Me.lblGetQuote)
        Me.Controls.Add(Me.picLogoSmall)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "formGetQuote"
        Me.Text = "formGetQuote"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogoSmall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents picLogoSmall As PictureBox
    Friend WithEvents lblGetQuote As Label
    Friend WithEvents chkPremium As CheckBox
    Friend WithEvents lblRegion As Label
    Friend WithEvents cmbRegion As ComboBox
    Friend WithEvents lblPassengers As Label
    Friend WithEvents btnFewer As Button
    Friend WithEvents btnMore As Button
    Friend WithEvents lblNumPassengers As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnPricingGuide As Button
End Class
