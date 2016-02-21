<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLanding
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLanding))
        Me.btnGetQuote = New System.Windows.Forms.Button()
        Me.btnOurService = New System.Windows.Forms.Button()
        Me.picSydneyChauffeurs = New System.Windows.Forms.PictureBox()
        Me.btnBook = New System.Windows.Forms.Button()
        CType(Me.picSydneyChauffeurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGetQuote
        '
        Me.btnGetQuote.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnGetQuote.FlatAppearance.BorderSize = 0
        Me.btnGetQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetQuote.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetQuote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnGetQuote.Location = New System.Drawing.Point(161, 505)
        Me.btnGetQuote.Name = "btnGetQuote"
        Me.btnGetQuote.Size = New System.Drawing.Size(514, 100)
        Me.btnGetQuote.TabIndex = 1
        Me.btnGetQuote.Text = "GET A QUOTE"
        Me.btnGetQuote.UseVisualStyleBackColor = False
        '
        'btnOurService
        '
        Me.btnOurService.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnOurService.FlatAppearance.BorderSize = 0
        Me.btnOurService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOurService.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOurService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnOurService.Location = New System.Drawing.Point(161, 377)
        Me.btnOurService.Name = "btnOurService"
        Me.btnOurService.Size = New System.Drawing.Size(514, 100)
        Me.btnOurService.TabIndex = 2
        Me.btnOurService.Text = "OUR SERVICE"
        Me.btnOurService.UseVisualStyleBackColor = False
        '
        'picSydneyChauffeurs
        '
        Me.picSydneyChauffeurs.Image = CType(resources.GetObject("picSydneyChauffeurs.Image"), System.Drawing.Image)
        Me.picSydneyChauffeurs.Location = New System.Drawing.Point(129, 40)
        Me.picSydneyChauffeurs.Name = "picSydneyChauffeurs"
        Me.picSydneyChauffeurs.Size = New System.Drawing.Size(620, 256)
        Me.picSydneyChauffeurs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSydneyChauffeurs.TabIndex = 3
        Me.picSydneyChauffeurs.TabStop = False
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBook.Location = New System.Drawing.Point(161, 634)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(514, 100)
        Me.btnBook.TabIndex = 4
        Me.btnBook.Text = "BOOK A CHAUFFEUR CAR"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'formLanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 735)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.picSydneyChauffeurs)
        Me.Controls.Add(Me.btnOurService)
        Me.Controls.Add(Me.btnGetQuote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formLanding"
        Me.Text = "Sydney Chauffeurs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picSydneyChauffeurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOurService As Button
    Friend WithEvents picSydneyChauffeurs As PictureBox
    Friend WithEvents btnGetQuote As Button
    Friend WithEvents btnBook As Button
End Class
