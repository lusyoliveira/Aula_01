<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.dgvValor = New System.Windows.Forms.DataGridView()
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.Parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtParcela = New System.Windows.Forms.TextBox()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.btnGerar = New System.Windows.Forms.Button()
        Me.btnGravaParc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumeroPacelas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.cmbproduto = New System.Windows.Forms.ComboBox()
        Me.txtresultado = New System.Windows.Forms.Label()
        Me.lblLinhas = New System.Windows.Forms.Label()
        CType(Me.dgvValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(12, 28)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(427, 20)
        Me.txtProduto.TabIndex = 0
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(445, 28)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Produto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor:"
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(551, 28)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(75, 23)
        Me.btnGravar.TabIndex = 4
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'dgvValor
        '
        Me.dgvValor.AllowUserToAddRows = False
        Me.dgvValor.AllowUserToDeleteRows = False
        Me.dgvValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValor.Location = New System.Drawing.Point(12, 54)
        Me.dgvValor.Name = "dgvValor"
        Me.dgvValor.Size = New System.Drawing.Size(807, 150)
        Me.dgvValor.TabIndex = 5
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parcela, Me.Data, Me.Valor})
        Me.dgvParcelas.Location = New System.Drawing.Point(12, 294)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.Size = New System.Drawing.Size(807, 150)
        Me.dgvParcelas.TabIndex = 6
        '
        'Parcela
        '
        Me.Parcela.HeaderText = "Parcela"
        Me.Parcela.Name = "Parcela"
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'txtParcela
        '
        Me.txtParcela.Location = New System.Drawing.Point(12, 268)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(100, 20)
        Me.txtParcela.TabIndex = 7
        '
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(224, 267)
        Me.mskData.Mask = "99/99/9999"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(83, 20)
        Me.mskData.TabIndex = 8
        '
        'btnGerar
        '
        Me.btnGerar.Location = New System.Drawing.Point(339, 265)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(100, 23)
        Me.btnGerar.TabIndex = 9
        Me.btnGerar.Text = "Gerar Paracela"
        Me.btnGerar.UseVisualStyleBackColor = True
        '
        'btnGravaParc
        '
        Me.btnGravaParc.Location = New System.Drawing.Point(445, 265)
        Me.btnGravaParc.Name = "btnGravaParc"
        Me.btnGravaParc.Size = New System.Drawing.Size(91, 23)
        Me.btnGravaParc.TabIndex = 10
        Me.btnGravaParc.Text = "Gravar Parcela"
        Me.btnGravaParc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Valor Parcela:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Data Pagamento:"
        '
        'txtNumeroPacelas
        '
        Me.txtNumeroPacelas.Location = New System.Drawing.Point(118, 267)
        Me.txtNumeroPacelas.Name = "txtNumeroPacelas"
        Me.txtNumeroPacelas.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPacelas.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Parcelas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Qnt Linhas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Resultado"
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(542, 265)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(106, 22)
        Me.btnConsulta.TabIndex = 19
        Me.btnConsulta.Text = "Consulta Parcelas"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'cmbproduto
        '
        Me.cmbproduto.FormattingEnabled = True
        Me.cmbproduto.Location = New System.Drawing.Point(632, 28)
        Me.cmbproduto.Name = "cmbproduto"
        Me.cmbproduto.Size = New System.Drawing.Size(187, 21)
        Me.cmbproduto.TabIndex = 20
        Me.cmbproduto.Text = "Selecione"
        '
        'txtresultado
        '
        Me.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtresultado.Location = New System.Drawing.Point(234, 213)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(73, 20)
        Me.txtresultado.TabIndex = 21
        '
        'lblLinhas
        '
        Me.lblLinhas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLinhas.Location = New System.Drawing.Point(76, 213)
        Me.lblLinhas.Name = "lblLinhas"
        Me.lblLinhas.Size = New System.Drawing.Size(73, 20)
        Me.lblLinhas.TabIndex = 22
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 461)
        Me.Controls.Add(Me.lblLinhas)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.cmbproduto)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumeroPacelas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGravaParc)
        Me.Controls.Add(Me.btnGerar)
        Me.Controls.Add(Me.mskData)
        Me.Controls.Add(Me.txtParcela)
        Me.Controls.Add(Me.dgvParcelas)
        Me.Controls.Add(Me.dgvValor)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.dgvValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents dgvValor As System.Windows.Forms.DataGridView
    Friend WithEvents dgvParcelas As System.Windows.Forms.DataGridView
    Friend WithEvents txtParcela As System.Windows.Forms.TextBox
    Friend WithEvents mskData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnGerar As System.Windows.Forms.Button
    Friend WithEvents btnGravaParc As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPacelas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Parcela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents cmbproduto As System.Windows.Forms.ComboBox
    Friend WithEvents txtresultado As Label
    Friend WithEvents lblLinhas As Label
End Class
