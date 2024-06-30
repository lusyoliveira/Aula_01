<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormData
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
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtfinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Consultar = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(25, 153)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(648, 150)
        Me.dgvData.TabIndex = 6
        '
        'txtInicio
        '
        Me.txtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInicio.Location = New System.Drawing.Point(34, 127)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(82, 20)
        Me.txtInicio.TabIndex = 7
        '
        'txtfinal
        '
        Me.txtfinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfinal.Location = New System.Drawing.Point(190, 127)
        Me.txtfinal.Name = "txtfinal"
        Me.txtfinal.Size = New System.Drawing.Size(90, 20)
        Me.txtfinal.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fim:"
        '
        'Consultar
        '
        Me.Consultar.Location = New System.Drawing.Point(350, 127)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(75, 23)
        Me.Consultar.TabIndex = 11
        Me.Consultar.Text = "btnConsultar"
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'FormData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 395)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfinal)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "FormData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormData"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents txtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Consultar As System.Windows.Forms.Button
End Class
