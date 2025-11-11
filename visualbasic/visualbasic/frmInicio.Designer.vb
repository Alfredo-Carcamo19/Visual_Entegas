<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalClientes = New System.Windows.Forms.Label()
        Me.lblclientes = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblproductos = New System.Windows.Forms.Label()
        Me.lblTotalProductos = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblproveedores = New System.Windows.Forms.Label()
        Me.lblTotalProveedores = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblcompras = New System.Windows.Forms.Label()
        Me.lblTotalCompras = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblventas = New System.Windows.Forms.Label()
        Me.lblTotalVentas = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblusuarios = New System.Windows.Forms.Label()
        Me.lblTotalUsuarios = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblganacias = New System.Windows.Forms.Label()
        Me.lblSumaTotalVentas = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblclientes)
        Me.Panel1.Controls.Add(Me.lblTotalClientes)
        Me.Panel1.Location = New System.Drawing.Point(361, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 111)
        Me.Panel1.TabIndex = 0
        '
        'lblTotalClientes
        '
        Me.lblTotalClientes.AutoSize = True
        Me.lblTotalClientes.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalClientes.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalClientes.Location = New System.Drawing.Point(15, 30)
        Me.lblTotalClientes.Name = "lblTotalClientes"
        Me.lblTotalClientes.Size = New System.Drawing.Size(36, 40)
        Me.lblTotalClientes.TabIndex = 0
        Me.lblTotalClientes.Text = "0"
        '
        'lblclientes
        '
        Me.lblclientes.AutoSize = True
        Me.lblclientes.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblclientes.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblclientes.Location = New System.Drawing.Point(18, 69)
        Me.lblclientes.Name = "lblclientes"
        Me.lblclientes.Size = New System.Drawing.Size(77, 24)
        Me.lblclientes.TabIndex = 1
        Me.lblclientes.Text = "Clientes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblproductos)
        Me.Panel2.Controls.Add(Me.lblTotalProductos)
        Me.Panel2.Location = New System.Drawing.Point(361, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 108)
        Me.Panel2.TabIndex = 2
        '
        'lblproductos
        '
        Me.lblproductos.AutoSize = True
        Me.lblproductos.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblproductos.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblproductos.Location = New System.Drawing.Point(18, 56)
        Me.lblproductos.Name = "lblproductos"
        Me.lblproductos.Size = New System.Drawing.Size(95, 24)
        Me.lblproductos.TabIndex = 1
        Me.lblproductos.Text = "Productos"
        '
        'lblTotalProductos
        '
        Me.lblTotalProductos.AutoSize = True
        Me.lblTotalProductos.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProductos.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalProductos.Location = New System.Drawing.Point(26, 14)
        Me.lblTotalProductos.Name = "lblTotalProductos"
        Me.lblTotalProductos.Size = New System.Drawing.Size(36, 40)
        Me.lblTotalProductos.TabIndex = 0
        Me.lblTotalProductos.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblproveedores)
        Me.Panel3.Controls.Add(Me.lblTotalProveedores)
        Me.Panel3.Location = New System.Drawing.Point(626, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 111)
        Me.Panel3.TabIndex = 3
        '
        'lblproveedores
        '
        Me.lblproveedores.AutoSize = True
        Me.lblproveedores.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedores.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblproveedores.Location = New System.Drawing.Point(19, 70)
        Me.lblproveedores.Name = "lblproveedores"
        Me.lblproveedores.Size = New System.Drawing.Size(115, 24)
        Me.lblproveedores.TabIndex = 1
        Me.lblproveedores.Text = "Proveedores"
        '
        'lblTotalProveedores
        '
        Me.lblTotalProveedores.AutoSize = True
        Me.lblTotalProveedores.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProveedores.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalProveedores.Location = New System.Drawing.Point(16, 30)
        Me.lblTotalProveedores.Name = "lblTotalProveedores"
        Me.lblTotalProveedores.Size = New System.Drawing.Size(36, 40)
        Me.lblTotalProveedores.TabIndex = 0
        Me.lblTotalProveedores.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblcompras)
        Me.Panel4.Controls.Add(Me.lblTotalCompras)
        Me.Panel4.Location = New System.Drawing.Point(626, 212)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(230, 108)
        Me.Panel4.TabIndex = 3
        '
        'lblcompras
        '
        Me.lblcompras.AutoSize = True
        Me.lblcompras.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblcompras.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblcompras.Location = New System.Drawing.Point(18, 56)
        Me.lblcompras.Name = "lblcompras"
        Me.lblcompras.Size = New System.Drawing.Size(130, 24)
        Me.lblcompras.TabIndex = 1
        Me.lblcompras.Text = "Total Compras"
        '
        'lblTotalCompras
        '
        Me.lblTotalCompras.AutoSize = True
        Me.lblTotalCompras.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCompras.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalCompras.Location = New System.Drawing.Point(15, 14)
        Me.lblTotalCompras.Name = "lblTotalCompras"
        Me.lblTotalCompras.Size = New System.Drawing.Size(45, 40)
        Me.lblTotalCompras.TabIndex = 0
        Me.lblTotalCompras.Text = " 0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblventas)
        Me.Panel5.Controls.Add(Me.lblTotalVentas)
        Me.Panel5.Location = New System.Drawing.Point(905, 212)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(234, 108)
        Me.Panel5.TabIndex = 4
        '
        'lblventas
        '
        Me.lblventas.AutoSize = True
        Me.lblventas.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblventas.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblventas.Location = New System.Drawing.Point(18, 56)
        Me.lblventas.Name = "lblventas"
        Me.lblventas.Size = New System.Drawing.Size(113, 24)
        Me.lblventas.TabIndex = 1
        Me.lblventas.Text = "Total Ventas"
        '
        'lblTotalVentas
        '
        Me.lblTotalVentas.AutoSize = True
        Me.lblTotalVentas.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVentas.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalVentas.Location = New System.Drawing.Point(26, 14)
        Me.lblTotalVentas.Name = "lblTotalVentas"
        Me.lblTotalVentas.Size = New System.Drawing.Size(36, 40)
        Me.lblTotalVentas.TabIndex = 0
        Me.lblTotalVentas.Text = "0"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblusuarios)
        Me.Panel6.Controls.Add(Me.lblTotalUsuarios)
        Me.Panel6.Location = New System.Drawing.Point(905, 62)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(234, 111)
        Me.Panel6.TabIndex = 5
        '
        'lblusuarios
        '
        Me.lblusuarios.AutoSize = True
        Me.lblusuarios.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblusuarios.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblusuarios.Location = New System.Drawing.Point(18, 70)
        Me.lblusuarios.Name = "lblusuarios"
        Me.lblusuarios.Size = New System.Drawing.Size(83, 24)
        Me.lblusuarios.TabIndex = 1
        Me.lblusuarios.Text = "Usuarios"
        '
        'lblTotalUsuarios
        '
        Me.lblTotalUsuarios.AutoSize = True
        Me.lblTotalUsuarios.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsuarios.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalUsuarios.Location = New System.Drawing.Point(15, 30)
        Me.lblTotalUsuarios.Name = "lblTotalUsuarios"
        Me.lblTotalUsuarios.Size = New System.Drawing.Size(36, 40)
        Me.lblTotalUsuarios.TabIndex = 0
        Me.lblTotalUsuarios.Text = "0"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lblganacias)
        Me.Panel7.Controls.Add(Me.lblSumaTotalVentas)
        Me.Panel7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel7.Location = New System.Drawing.Point(463, 383)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(587, 106)
        Me.Panel7.TabIndex = 4
        '
        'lblganacias
        '
        Me.lblganacias.AutoSize = True
        Me.lblganacias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblganacias.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblganacias.Location = New System.Drawing.Point(18, 56)
        Me.lblganacias.Name = "lblganacias"
        Me.lblganacias.Size = New System.Drawing.Size(155, 25)
        Me.lblganacias.TabIndex = 1
        Me.lblganacias.Text = "Ganancia Neta"
        '
        'lblSumaTotalVentas
        '
        Me.lblSumaTotalVentas.AutoSize = True
        Me.lblSumaTotalVentas.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumaTotalVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSumaTotalVentas.Location = New System.Drawing.Point(26, 14)
        Me.lblSumaTotalVentas.Name = "lblSumaTotalVentas"
        Me.lblSumaTotalVentas.Size = New System.Drawing.Size(36, 40)
        Me.lblSumaTotalVentas.TabIndex = 0
        Me.lblSumaTotalVentas.Text = "0"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1283, 701)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmInicio"
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblclientes As Label
    Friend WithEvents lblTotalClientes As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblproductos As Label
    Friend WithEvents lblTotalProductos As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblproveedores As Label
    Friend WithEvents lblTotalProveedores As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblcompras As Label
    Friend WithEvents lblTotalCompras As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblventas As Label
    Friend WithEvents lblTotalVentas As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblusuarios As Label
    Friend WithEvents lblTotalUsuarios As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblganacias As Label
    Friend WithEvents lblSumaTotalVentas As Label
End Class
