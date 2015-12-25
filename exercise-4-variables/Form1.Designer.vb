<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblIDName = New System.Windows.Forms.Label()
        Me.lblFUCAC = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.btnCheckEntry = New System.Windows.Forms.Button()
        Me.rbSuit = New System.Windows.Forms.RadioButton()
        Me.rbDenim = New System.Windows.Forms.RadioButton()
        Me.rbTShirt = New System.Windows.Forms.RadioButton()
        Me.rbDress = New System.Windows.Forms.RadioButton()
        Me.gbClothing = New System.Windows.Forms.GroupBox()
        Me.gbShoes = New System.Windows.Forms.GroupBox()
        Me.rbPolishedLeather = New System.Windows.Forms.RadioButton()
        Me.rbHighHeels = New System.Windows.Forms.RadioButton()
        Me.rbThongs = New System.Windows.Forms.RadioButton()
        Me.rbBoatShoes = New System.Windows.Forms.RadioButton()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.gbClothing.SuspendLayout()
        Me.gbShoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIDName
        '
        Me.lblIDName.AutoSize = True
        Me.lblIDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDName.Location = New System.Drawing.Point(375, 9)
        Me.lblIDName.Name = "lblIDName"
        Me.lblIDName.Size = New System.Drawing.Size(0, 29)
        Me.lblIDName.TabIndex = 0
        '
        'lblFUCAC
        '
        Me.lblFUCAC.AutoSize = True
        Me.lblFUCAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFUCAC.Location = New System.Drawing.Point(12, 199)
        Me.lblFUCAC.Name = "lblFUCAC"
        Me.lblFUCAC.Size = New System.Drawing.Size(315, 25)
        Me.lblFUCAC.TabIndex = 1
        Me.lblFUCAC.Text = "Fun Unlimited Club Access Control"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(340, 48)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(125, 29)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Enter Age:"
        '
        'btnCheckEntry
        '
        Me.btnCheckEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckEntry.Location = New System.Drawing.Point(345, 131)
        Me.btnCheckEntry.Name = "btnCheckEntry"
        Me.btnCheckEntry.Size = New System.Drawing.Size(142, 59)
        Me.btnCheckEntry.TabIndex = 4
        Me.btnCheckEntry.Text = "Check Entry"
        Me.btnCheckEntry.UseVisualStyleBackColor = True
        '
        'rbSuit
        '
        Me.rbSuit.AutoSize = True
        Me.rbSuit.Checked = True
        Me.rbSuit.Location = New System.Drawing.Point(6, 35)
        Me.rbSuit.Name = "rbSuit"
        Me.rbSuit.Size = New System.Drawing.Size(50, 21)
        Me.rbSuit.TabIndex = 5
        Me.rbSuit.TabStop = True
        Me.rbSuit.Text = "Suit"
        Me.rbSuit.UseVisualStyleBackColor = True
        '
        'rbDenim
        '
        Me.rbDenim.AutoSize = True
        Me.rbDenim.Location = New System.Drawing.Point(6, 58)
        Me.rbDenim.Name = "rbDenim"
        Me.rbDenim.Size = New System.Drawing.Size(66, 21)
        Me.rbDenim.TabIndex = 6
        Me.rbDenim.Text = "Denim"
        Me.rbDenim.UseVisualStyleBackColor = True
        '
        'rbTShirt
        '
        Me.rbTShirt.AutoSize = True
        Me.rbTShirt.Location = New System.Drawing.Point(6, 83)
        Me.rbTShirt.Name = "rbTShirt"
        Me.rbTShirt.Size = New System.Drawing.Size(69, 21)
        Me.rbTShirt.TabIndex = 7
        Me.rbTShirt.Text = "T-Shirt"
        Me.rbTShirt.UseVisualStyleBackColor = True
        '
        'rbDress
        '
        Me.rbDress.AutoSize = True
        Me.rbDress.Location = New System.Drawing.Point(6, 106)
        Me.rbDress.Name = "rbDress"
        Me.rbDress.Size = New System.Drawing.Size(63, 21)
        Me.rbDress.TabIndex = 8
        Me.rbDress.Text = "Dress"
        Me.rbDress.UseVisualStyleBackColor = True
        '
        'gbClothing
        '
        Me.gbClothing.Controls.Add(Me.rbSuit)
        Me.gbClothing.Controls.Add(Me.rbDress)
        Me.gbClothing.Controls.Add(Me.rbDenim)
        Me.gbClothing.Controls.Add(Me.rbTShirt)
        Me.gbClothing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbClothing.Location = New System.Drawing.Point(12, 25)
        Me.gbClothing.Name = "gbClothing"
        Me.gbClothing.Size = New System.Drawing.Size(133, 144)
        Me.gbClothing.TabIndex = 9
        Me.gbClothing.TabStop = False
        Me.gbClothing.Text = "Clothing"
        '
        'gbShoes
        '
        Me.gbShoes.Controls.Add(Me.rbPolishedLeather)
        Me.gbShoes.Controls.Add(Me.rbHighHeels)
        Me.gbShoes.Controls.Add(Me.rbThongs)
        Me.gbShoes.Controls.Add(Me.rbBoatShoes)
        Me.gbShoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbShoes.Location = New System.Drawing.Point(158, 25)
        Me.gbShoes.Name = "gbShoes"
        Me.gbShoes.Size = New System.Drawing.Size(169, 144)
        Me.gbShoes.TabIndex = 10
        Me.gbShoes.TabStop = False
        Me.gbShoes.Text = "Shoes"
        '
        'rbPolishedLeather
        '
        Me.rbPolishedLeather.AutoSize = True
        Me.rbPolishedLeather.Checked = True
        Me.rbPolishedLeather.Location = New System.Drawing.Point(6, 35)
        Me.rbPolishedLeather.Name = "rbPolishedLeather"
        Me.rbPolishedLeather.Size = New System.Drawing.Size(133, 21)
        Me.rbPolishedLeather.TabIndex = 5
        Me.rbPolishedLeather.TabStop = True
        Me.rbPolishedLeather.Text = "Polished Leather"
        Me.rbPolishedLeather.UseVisualStyleBackColor = True
        '
        'rbHighHeels
        '
        Me.rbHighHeels.AutoSize = True
        Me.rbHighHeels.Location = New System.Drawing.Point(6, 106)
        Me.rbHighHeels.Name = "rbHighHeels"
        Me.rbHighHeels.Size = New System.Drawing.Size(95, 21)
        Me.rbHighHeels.TabIndex = 8
        Me.rbHighHeels.Text = "High Heels"
        Me.rbHighHeels.UseVisualStyleBackColor = True
        '
        'rbThongs
        '
        Me.rbThongs.AutoSize = True
        Me.rbThongs.Location = New System.Drawing.Point(6, 58)
        Me.rbThongs.Name = "rbThongs"
        Me.rbThongs.Size = New System.Drawing.Size(74, 21)
        Me.rbThongs.TabIndex = 6
        Me.rbThongs.Text = "Thongs"
        Me.rbThongs.UseVisualStyleBackColor = True
        '
        'rbBoatShoes
        '
        Me.rbBoatShoes.AutoSize = True
        Me.rbBoatShoes.Location = New System.Drawing.Point(6, 83)
        Me.rbBoatShoes.Name = "rbBoatShoes"
        Me.rbBoatShoes.Size = New System.Drawing.Size(99, 21)
        Me.rbBoatShoes.TabIndex = 7
        Me.rbBoatShoes.Text = "Boat Shoes"
        Me.rbBoatShoes.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(345, 87)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 38)
        Me.txtInput.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 262)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.gbShoes)
        Me.Controls.Add(Me.gbClothing)
        Me.Controls.Add(Me.btnCheckEntry)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblFUCAC)
        Me.Controls.Add(Me.lblIDName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbClothing.ResumeLayout(False)
        Me.gbClothing.PerformLayout()
        Me.gbShoes.ResumeLayout(False)
        Me.gbShoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDName As System.Windows.Forms.Label
    Friend WithEvents lblFUCAC As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents btnCheckEntry As System.Windows.Forms.Button
    Friend WithEvents rbSuit As System.Windows.Forms.RadioButton
    Friend WithEvents rbDenim As System.Windows.Forms.RadioButton
    Friend WithEvents rbTShirt As System.Windows.Forms.RadioButton
    Friend WithEvents rbDress As System.Windows.Forms.RadioButton
    Friend WithEvents gbClothing As System.Windows.Forms.GroupBox
    Friend WithEvents gbShoes As System.Windows.Forms.GroupBox
    Friend WithEvents rbPolishedLeather As System.Windows.Forms.RadioButton
    Friend WithEvents rbHighHeels As System.Windows.Forms.RadioButton
    Friend WithEvents rbThongs As System.Windows.Forms.RadioButton
    Friend WithEvents rbBoatShoes As System.Windows.Forms.RadioButton
    Friend WithEvents txtInput As System.Windows.Forms.TextBox

End Class
