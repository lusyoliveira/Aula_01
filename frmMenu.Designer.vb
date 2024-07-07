<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraDeProgressoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavegaDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestaConexãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsProdutos = New System.Windows.Forms.ToolStripButton()
        Me.tsConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNivel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1032, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.BarraDeProgressoToolStripMenuItem, Me.NavegaDadosToolStripMenuItem, Me.TestaConexãoToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Image = CType(resources.GetObject("CadastroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'BarraDeProgressoToolStripMenuItem
        '
        Me.BarraDeProgressoToolStripMenuItem.Name = "BarraDeProgressoToolStripMenuItem"
        Me.BarraDeProgressoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BarraDeProgressoToolStripMenuItem.Text = "Tabuada"
        '
        'NavegaDadosToolStripMenuItem
        '
        Me.NavegaDadosToolStripMenuItem.Name = "NavegaDadosToolStripMenuItem"
        Me.NavegaDadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NavegaDadosToolStripMenuItem.Text = "Navega Dados"
        '
        'TestaConexãoToolStripMenuItem
        '
        Me.TestaConexãoToolStripMenuItem.Name = "TestaConexãoToolStripMenuItem"
        Me.TestaConexãoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TestaConexãoToolStripMenuItem.Text = "Testa Conexão"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsProdutos, Me.tsConsulta, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(37, 513)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsProdutos
        '
        Me.tsProdutos.AutoToolTip = False
        Me.tsProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsProdutos.Image = CType(resources.GetObject("tsProdutos.Image"), System.Drawing.Image)
        Me.tsProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsProdutos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsProdutos.Name = "tsProdutos"
        Me.tsProdutos.Size = New System.Drawing.Size(34, 37)
        Me.tsProdutos.Text = "Cadastro"
        Me.tsProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsConsulta
        '
        Me.tsConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsConsulta.Image = CType(resources.GetObject("tsConsulta.Image"), System.Drawing.Image)
        Me.tsConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsConsulta.Name = "tsConsulta"
        Me.tsConsulta.Size = New System.Drawing.Size(34, 29)
        Me.tsConsulta.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(34, 20)
        Me.ToolStripButton3.Text = "ooooo"
        Me.ToolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblData, Me.lblUsuario, Me.lblNivel})
        Me.StatusStrip1.Location = New System.Drawing.Point(37, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(995, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(16, 17)
        Me.lblData.Text = "..."
        '
        'lblUsuario
        '
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 17)
        Me.lblUsuario.Text = "usuario"
        '
        'lblNivel
        '
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(32, 17)
        Me.lblNivel.Text = "nivel"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 537)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsProdutos As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BarraDeProgressoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblNivel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NavegaDadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestaConexãoToolStripMenuItem As ToolStripMenuItem
End Class
