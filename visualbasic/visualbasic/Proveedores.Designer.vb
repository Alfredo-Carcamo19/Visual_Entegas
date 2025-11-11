<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.btborrar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ct_nombre = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblidprovedor = New System.Windows.Forms.Label()
        Me.ct_direccion = New System.Windows.Forms.TextBox()
        Me.ct_correo = New System.Windows.Forms.TextBox()
        Me.ct_telefono = New System.Windows.Forms.TextBox()
        Me.ct_idproveedor = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.Mensaje = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btsalir)
        Me.groupBox1.Controls.Add(Me.btborrar)
        Me.groupBox1.Controls.Add(Me.btguardar)
        Me.groupBox1.Controls.Add(Me.btnuevo)
        Me.groupBox1.Location = New System.Drawing.Point(531, 58)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(229, 224)
        Me.groupBox1.TabIndex = 22
        Me.groupBox1.TabStop = False
        '
        'btsalir
        '
        Me.btsalir.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btsalir.Location = New System.Drawing.Point(69, 169)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(97, 32)
        Me.btsalir.TabIndex = 8
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = False
        '
        'btborrar
        '
        Me.btborrar.BackColor = System.Drawing.Color.Maroon
        Me.btborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btborrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btborrar.Location = New System.Drawing.Point(69, 124)
        Me.btborrar.Name = "btborrar"
        Me.btborrar.Size = New System.Drawing.Size(97, 32)
        Me.btborrar.TabIndex = 7
        Me.btborrar.Text = "Borrar"
        Me.btborrar.UseVisualStyleBackColor = False
        '
        'btguardar
        '
        Me.btguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btguardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btguardar.Location = New System.Drawing.Point(69, 75)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(97, 35)
        Me.btguardar.TabIndex = 6
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = False
        '
        'btnuevo
        '
        Me.btnuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnuevo.Location = New System.Drawing.Point(69, 29)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(97, 32)
        Me.btnuevo.TabIndex = 5
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = False
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(77, 188)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(71, 20)
        Me.lbltelefono.TabIndex = 20
        Me.lbltelefono.Text = "Telefono"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(73, 143)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(75, 20)
        Me.lbldireccion.TabIndex = 19
        Me.lbldireccion.Text = "Direccion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(83, 105)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'ct_nombre
        '
        Me.ct_nombre.Location = New System.Drawing.Point(166, 102)
        Me.ct_nombre.Name = "ct_nombre"
        Me.ct_nombre.Size = New System.Drawing.Size(253, 26)
        Me.ct_nombre.TabIndex = 1
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(374, -1)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 62
        Me.dataGridView1.RowTemplate.Height = 28
        Me.dataGridView1.Size = New System.Drawing.Size(886, 368)
        Me.dataGridView1.TabIndex = 12
        '
        'lblidprovedor
        '
        Me.lblidprovedor.AutoSize = True
        Me.lblidprovedor.Location = New System.Drawing.Point(61, 65)
        Me.lblidprovedor.Name = "lblidprovedor"
        Me.lblidprovedor.Size = New System.Drawing.Size(99, 20)
        Me.lblidprovedor.TabIndex = 26
        Me.lblidprovedor.Text = "Id Proveedor"
        '
        'ct_direccion
        '
        Me.ct_direccion.Location = New System.Drawing.Point(166, 143)
        Me.ct_direccion.Name = "ct_direccion"
        Me.ct_direccion.Size = New System.Drawing.Size(253, 26)
        Me.ct_direccion.TabIndex = 2
        '
        'ct_correo
        '
        Me.ct_correo.Location = New System.Drawing.Point(166, 237)
        Me.ct_correo.Name = "ct_correo"
        Me.ct_correo.Size = New System.Drawing.Size(253, 26)
        Me.ct_correo.TabIndex = 4
        '
        'ct_telefono
        '
        Me.ct_telefono.Location = New System.Drawing.Point(166, 188)
        Me.ct_telefono.Name = "ct_telefono"
        Me.ct_telefono.Size = New System.Drawing.Size(253, 26)
        Me.ct_telefono.TabIndex = 3
        '
        'ct_idproveedor
        '
        Me.ct_idproveedor.Location = New System.Drawing.Point(166, 62)
        Me.ct_idproveedor.Name = "ct_idproveedor"
        Me.ct_idproveedor.Size = New System.Drawing.Size(253, 26)
        Me.ct_idproveedor.TabIndex = 0
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(100, 237)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(48, 20)
        Me.lblemail.TabIndex = 27
        Me.lblemail.Text = "Email"
        '
        'Mensaje
        '
        Me.Mensaje.AutoSize = True
        Me.Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensaje.Location = New System.Drawing.Point(3, 15)
        Me.Mensaje.Name = "Mensaje"
        Me.Mensaje.Size = New System.Drawing.Size(208, 25)
        Me.Mensaje.TabIndex = 28
        Me.Mensaje.Text = "Datos del Proveedor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.groupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 383)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 374)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Mensaje)
        Me.GroupBox3.Controls.Add(Me.lblemail)
        Me.GroupBox3.Controls.Add(Me.ct_idproveedor)
        Me.GroupBox3.Controls.Add(Me.lblidprovedor)
        Me.GroupBox3.Controls.Add(Me.ct_direccion)
        Me.GroupBox3.Controls.Add(Me.ct_correo)
        Me.GroupBox3.Controls.Add(Me.ct_telefono)
        Me.GroupBox3.Controls.Add(Me.lbltelefono)
        Me.GroupBox3.Controls.Add(Me.lbldireccion)
        Me.GroupBox3.Controls.Add(Me.lblNombre)
        Me.GroupBox3.Controls.Add(Me.ct_nombre)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 315)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 786)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btsalir As Button
    Private WithEvents btborrar As Button
    Private WithEvents btguardar As Button
    Private WithEvents btnuevo As Button
    Private WithEvents lbltelefono As Label
    Private WithEvents lbldireccion As Label
    Private WithEvents lblNombre As Label
    Private WithEvents ct_nombre As TextBox
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents lblidprovedor As Label
    Private WithEvents ct_direccion As TextBox
    Private WithEvents ct_correo As TextBox
    Private WithEvents ct_telefono As TextBox
    Private WithEvents ct_idproveedor As TextBox
    Private WithEvents lblemail As Label
    Private WithEvents Mensaje As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
