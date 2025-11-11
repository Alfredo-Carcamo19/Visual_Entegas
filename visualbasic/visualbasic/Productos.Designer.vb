<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ct_idproducto = New System.Windows.Forms.TextBox()
        Me.ct_nombre = New System.Windows.Forms.TextBox()
        Me.ct_preciocompra = New System.Windows.Forms.TextBox()
        Me.ct_stockminimo = New System.Windows.Forms.TextBox()
        Me.ct_stock = New System.Windows.Forms.TextBox()
        Me.ct_descripcion = New System.Windows.Forms.TextBox()
        Me.ct_porcentaje = New System.Windows.Forms.TextBox()
        Me.ct_precioventa = New System.Windows.Forms.TextBox()
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.btborrar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(279, 23)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 62
        Me.dataGridView1.RowTemplate.Height = 28
        Me.dataGridView1.Size = New System.Drawing.Size(1105, 355)
        Me.dataGridView1.TabIndex = 0
        '
        'ct_idproducto
        '
        Me.ct_idproducto.Location = New System.Drawing.Point(158, 29)
        Me.ct_idproducto.Name = "ct_idproducto"
        Me.ct_idproducto.ReadOnly = True
        Me.ct_idproducto.Size = New System.Drawing.Size(145, 26)
        Me.ct_idproducto.TabIndex = 1
        '
        'ct_nombre
        '
        Me.ct_nombre.Location = New System.Drawing.Point(158, 74)
        Me.ct_nombre.Name = "ct_nombre"
        Me.ct_nombre.Size = New System.Drawing.Size(145, 26)
        Me.ct_nombre.TabIndex = 2
        '
        'ct_preciocompra
        '
        Me.ct_preciocompra.Location = New System.Drawing.Point(450, 50)
        Me.ct_preciocompra.Name = "ct_preciocompra"
        Me.ct_preciocompra.Size = New System.Drawing.Size(148, 26)
        Me.ct_preciocompra.TabIndex = 3
        '
        'ct_stockminimo
        '
        Me.ct_stockminimo.Location = New System.Drawing.Point(158, 200)
        Me.ct_stockminimo.Name = "ct_stockminimo"
        Me.ct_stockminimo.Size = New System.Drawing.Size(145, 26)
        Me.ct_stockminimo.TabIndex = 4
        '
        'ct_stock
        '
        Me.ct_stock.Location = New System.Drawing.Point(158, 157)
        Me.ct_stock.Name = "ct_stock"
        Me.ct_stock.Size = New System.Drawing.Size(145, 26)
        Me.ct_stock.TabIndex = 5
        '
        'ct_descripcion
        '
        Me.ct_descripcion.Location = New System.Drawing.Point(158, 118)
        Me.ct_descripcion.Multiline = True
        Me.ct_descripcion.Name = "ct_descripcion"
        Me.ct_descripcion.Size = New System.Drawing.Size(145, 26)
        Me.ct_descripcion.TabIndex = 6
        '
        'ct_porcentaje
        '
        Me.ct_porcentaje.Location = New System.Drawing.Point(450, 101)
        Me.ct_porcentaje.Name = "ct_porcentaje"
        Me.ct_porcentaje.Size = New System.Drawing.Size(148, 26)
        Me.ct_porcentaje.TabIndex = 7
        '
        'ct_precioventa
        '
        Me.ct_precioventa.Location = New System.Drawing.Point(450, 148)
        Me.ct_precioventa.Name = "ct_precioventa"
        Me.ct_precioventa.Size = New System.Drawing.Size(148, 26)
        Me.ct_precioventa.TabIndex = 8
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(450, 192)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(148, 28)
        Me.cmb_proveedor.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "id Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Porcentaje"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Precio Compra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stock Minimo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Descripcion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(342, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Precio Venta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(361, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Proveedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btsalir)
        Me.GroupBox1.Controls.Add(Me.btborrar)
        Me.GroupBox1.Controls.Add(Me.btguardar)
        Me.GroupBox1.Controls.Add(Me.btnuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(719, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 248)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'btsalir
        '
        Me.btsalir.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btsalir.Location = New System.Drawing.Point(47, 183)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(106, 43)
        Me.btsalir.TabIndex = 24
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = False
        '
        'btborrar
        '
        Me.btborrar.BackColor = System.Drawing.Color.Crimson
        Me.btborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btborrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btborrar.Location = New System.Drawing.Point(47, 127)
        Me.btborrar.Name = "btborrar"
        Me.btborrar.Size = New System.Drawing.Size(106, 41)
        Me.btborrar.TabIndex = 23
        Me.btborrar.Text = "Borrar"
        Me.btborrar.UseVisualStyleBackColor = False
        '
        'btguardar
        '
        Me.btguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btguardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btguardar.Location = New System.Drawing.Point(47, 74)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(106, 40)
        Me.btguardar.TabIndex = 22
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = False
        '
        'btnuevo
        '
        Me.btnuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnuevo.Location = New System.Drawing.Point(47, 25)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(106, 43)
        Me.btnuevo.TabIndex = 21
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 397)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(994, 297)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ct_preciocompra)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ct_idproducto)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ct_nombre)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ct_stockminimo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ct_stock)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ct_descripcion)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ct_porcentaje)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ct_precioventa)
        Me.GroupBox3.Controls.Add(Me.cmb_proveedor)
        Me.GroupBox3.Location = New System.Drawing.Point(52, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(642, 255)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1631, 733)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataGridView1 As DataGridView

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents ct_idproducto As TextBox
    Friend WithEvents ct_nombre As TextBox
    Friend WithEvents ct_preciocompra As TextBox
    Friend WithEvents ct_stockminimo As TextBox
    Friend WithEvents ct_stock As TextBox
    Friend WithEvents ct_descripcion As TextBox
    Friend WithEvents ct_porcentaje As TextBox
    Friend WithEvents ct_precioventa As TextBox
    Friend WithEvents cmb_proveedor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btsalir As Button
    Friend WithEvents btborrar As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents btnuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
