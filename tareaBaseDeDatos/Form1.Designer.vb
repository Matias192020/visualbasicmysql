<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.cbserie = New System.Windows.Forms.ComboBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.grdnombre = New System.Windows.Forms.DataGridView()
        CType(Me.grdnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "APELLIDO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SERIE:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(203, 12)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(121, 20)
        Me.txtnombre.TabIndex = 3
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(203, 52)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(121, 20)
        Me.txtapellido.TabIndex = 4
        '
        'cbserie
        '
        Me.cbserie.FormattingEnabled = True
        Me.cbserie.Items.AddRange(New Object() {"La Casa de Papel", "Poco Ortodoxa", "GOT", "Stranger Things", "Ninguna de las anterioes"})
        Me.cbserie.Location = New System.Drawing.Point(203, 96)
        Me.cbserie.Name = "cbserie"
        Me.cbserie.Size = New System.Drawing.Size(121, 21)
        Me.cbserie.TabIndex = 5
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(167, 311)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 29)
        Me.btnagregar.TabIndex = 6
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(286, 311)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 29)
        Me.btnsalir.TabIndex = 7
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'grdnombre
        '
        Me.grdnombre.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.grdnombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdnombre.Location = New System.Drawing.Point(84, 137)
        Me.grdnombre.Name = "grdnombre"
        Me.grdnombre.Size = New System.Drawing.Size(353, 150)
        Me.grdnombre.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(541, 352)
        Me.Controls.Add(Me.grdnombre)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.cbserie)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ENCUESTA"
        CType(Me.grdnombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents cbserie As ComboBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents grdnombre As DataGridView
End Class
