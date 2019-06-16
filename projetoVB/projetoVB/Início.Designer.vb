<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Início
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CLIENTES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "PRODUTOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(236, 254)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Sair"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 45)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "ORDENS DE COMPRA"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(187, 44)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Página Web Local"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 250)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Painel de controlo"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 199)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(147, 45)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "DOAÇÕES"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(318, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaçõesToolStripMenuItem})
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        Me.AcercaToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.AcercaToolStripMenuItem.Text = "Informações"
        '
        'InformaçõesToolStripMenuItem
        '
        Me.InformaçõesToolStripMenuItem.Name = "InformaçõesToolStripMenuItem"
        Me.InformaçõesToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.InformaçõesToolStripMenuItem.Text = "Acerca"
        '
        'Início
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(318, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Início"
        Me.Text = "Início"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button6 As Button
End Class
