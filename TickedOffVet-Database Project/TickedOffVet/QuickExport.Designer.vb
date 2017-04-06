<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickExport
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
        Me.dataGridPet = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridPet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridPet
        '
        Me.dataGridPet.AllowUserToAddRows = False
        Me.dataGridPet.AllowUserToDeleteRows = False
        Me.dataGridPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPet.Location = New System.Drawing.Point(12, 12)
        Me.dataGridPet.Name = "dataGridPet"
        Me.dataGridPet.ReadOnly = True
        Me.dataGridPet.RowTemplate.Height = 24
        Me.dataGridPet.Size = New System.Drawing.Size(511, 456)
        Me.dataGridPet.TabIndex = 0
        '
        'QuickExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 480)
        Me.Controls.Add(Me.dataGridPet)
        Me.Name = "QuickExport"
        Me.Text = "QuickExport"
        CType(Me.dataGridPet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataGridPet As System.Windows.Forms.DataGridView
End Class
