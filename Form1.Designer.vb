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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumeroPacelas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlinhas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbproduto = New System.Windows.Forms.ComboBox()
        CType(Me.dgvValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(52, 28)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtProduto.TabIndex = 0
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(226, 27)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Produto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor:"
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(210, 68)
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
        Me.dgvValor.Location = New System.Drawing.Point(355, 9)
        Me.dgvValor.Name = "dgvValor"
        Me.dgvValor.Size = New System.Drawing.Size(480, 150)
        Me.dgvValor.TabIndex = 5
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parcela, Me.Data, Me.Valor})
        Me.dgvParcelas.Location = New System.Drawing.Point(28, 294)
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
        Me.txtParcela.Location = New System.Drawing.Point(28, 245)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(100, 20)
        Me.txtParcela.TabIndex = 7
        '
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(354, 261)
        Me.mskData.Mask = "99/99/9999"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(75, 20)
        Me.mskData.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Gerar Paracela"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(558, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 58)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Gravar Parcela"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Valor Parcela:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Data Pagamento:"
        '
        'txtNumeroPacelas
        '
        Me.txtNumeroPacelas.Location = New System.Drawing.Point(134, 244)
        Me.txtNumeroPacelas.Name = "txtNumeroPacelas"
        Me.txtNumeroPacelas.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPacelas.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Parcelas:"
        '
        'txtlinhas
        '
        Me.txtlinhas.Location = New System.Drawing.Point(355, 182)
        Me.txtlinhas.Name = "txtlinhas"
        Me.txtlinhas.Size = New System.Drawing.Size(100, 20)
        Me.txtlinhas.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Qnt Linhas:"
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(688, 182)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(100, 20)
        Me.txtresultado.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(685, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Resultado"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(289, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(335, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Consultar entre datas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbproduto
        '
        Me.cmbproduto.FormattingEnabled = True
        Me.cmbproduto.Location = New System.Drawing.Point(688, 229)
        Me.cmbproduto.Name = "cmbproduto"
        Me.cmbproduto.Size = New System.Drawing.Size(121, 21)
        Me.cmbproduto.TabIndex = 20
        Me.cmbproduto.Text = "Selecione"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 507)
        Me.Controls.Add(Me.cmbproduto)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtlinhas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumeroPacelas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mskData)
        Me.Controls.Add(Me.txtParcela)
        Me.Controls.Add(Me.dgvParcelas)
        Me.Controls.Add(Me.dgvValor)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtProduto)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPacelas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Parcela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtlinhas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtresultado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmbproduto As System.Windows.Forms.ComboBox

End Class
