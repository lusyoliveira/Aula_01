﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestaConexao
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.ComboBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtlinhas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 128)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(594, 150)
        Me.dgvClientes.TabIndex = 1
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(439, 94)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(75, 23)
        Me.btnGravar.TabIndex = 29
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Código:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(456, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cargo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nome:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 26)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 22
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(301, 67)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(152, 20)
        Me.txtCargo.TabIndex = 21
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(459, 23)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txtSenha.Size = New System.Drawing.Size(136, 20)
        Me.txtSenha.TabIndex = 20
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(118, 67)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(177, 20)
        Me.txtUsuario.TabIndex = 19
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(118, 26)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(335, 20)
        Me.txtNome.TabIndex = 18
        '
        'txtTipo
        '
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.Location = New System.Drawing.Point(459, 67)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(136, 21)
        Me.txtTipo.TabIndex = 16
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(520, 94)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 31
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'txtlinhas
        '
        Me.txtlinhas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtlinhas.Location = New System.Drawing.Point(506, 281)
        Me.txtlinhas.Name = "txtlinhas"
        Me.txtlinhas.Size = New System.Drawing.Size(100, 20)
        Me.txtlinhas.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Quantidade:"
        '
        'frmTestaConexao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 322)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtlinhas)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.dgvClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTestaConexao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testar Conexão"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents txtlinhas As Label
    Friend WithEvents Label7 As Label
End Class
