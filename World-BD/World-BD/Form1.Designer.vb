<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grdWorld = New System.Windows.Forms.DataGridView()
        Me.btnMostrar1 = New System.Windows.Forms.Button()
        Me.btnMostrar2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grdWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(93, 247)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(139, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(12, 245)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(238, 245)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(78, 23)
        Me.btnBorrar.TabIndex = 7
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(499, 231)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grdWorld
        '
        Me.grdWorld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdWorld.Location = New System.Drawing.Point(12, 12)
        Me.grdWorld.Name = "grdWorld"
        Me.grdWorld.Size = New System.Drawing.Size(388, 227)
        Me.grdWorld.TabIndex = 9
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(463, 38)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar1.TabIndex = 10
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseVisualStyleBackColor = True
        '
        'btnMostrar2
        '
        Me.btnMostrar2.Location = New System.Drawing.Point(463, 105)
        Me.btnMostrar2.Name = "btnMostrar2"
        Me.btnMostrar2.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar2.TabIndex = 11
        Me.btnMostrar2.Text = "Mostrar"
        Me.btnMostrar2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(437, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cantidad total de países, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de ciudad y de idiomas."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(437, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre de país, de ciudad, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "población total y año de indepencia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 280)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMostrar2)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.grdWorld)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "Form1"
        Me.Text = "Registro"
        CType(Me.grdWorld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents grdWorld As DataGridView
    Friend WithEvents btnMostrar1 As Button
    Friend WithEvents btnMostrar2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
