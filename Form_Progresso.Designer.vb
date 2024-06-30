<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Progresso
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
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtTabuada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbtResultado = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(-2, 350)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(446, 23)
        Me.Barra.TabIndex = 0
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(30, 78)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(70, 20)
        Me.txtQuantidade.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(25, 120)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtTabuada
        '
        Me.txtTabuada.Location = New System.Drawing.Point(30, 28)
        Me.txtTabuada.Name = "txtTabuada"
        Me.txtTabuada.Size = New System.Drawing.Size(70, 20)
        Me.txtTabuada.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tabuada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantidade:"
        '
        'lbtResultado
        '
        Me.lbtResultado.FormattingEnabled = True
        Me.lbtResultado.Location = New System.Drawing.Point(158, 28)
        Me.lbtResultado.Name = "lbtResultado"
        Me.lbtResultado.Size = New System.Drawing.Size(273, 316)
        Me.lbtResultado.TabIndex = 7
        '
        'Form_Progresso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 375)
        Me.Controls.Add(Me.lbtResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTabuada)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Barra)
        Me.Name = "Form_Progresso"
        Me.Text = "Form_Progresso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtTabuada As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbtResultado As System.Windows.Forms.ListBox
End Class
