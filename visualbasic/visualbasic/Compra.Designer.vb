<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Me.bt_guardarcompra = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblprovedor = New System.Windows.Forms.Label()
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox()
        Me.dgv_carrito = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_preciocompra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.cmb_producto = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_carrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_guardarcompra
        '
        Me.bt_guardarcompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_guardarcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_guardarcompra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_guardarcompra.Location = New System.Drawing.Point(1127, 29)
        Me.bt_guardarcompra.Name = "bt_guardarcompra"
        Me.bt_guardarcompra.Size = New System.Drawing.Size(123, 41)
        Me.bt_guardarcompra.TabIndex = 15
        Me.bt_guardarcompra.Text = "Guardar"
        Me.bt_guardarcompra.UseVisualStyleBackColor = False
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.Color.Red
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_cancelar.Location = New System.Drawing.Point(991, 29)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(110, 41)
        Me.bt_cancelar.TabIndex = 14
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtp_fecha)
        Me.GroupBox3.Controls.Add(Me.lblfecha)
        Me.GroupBox3.Controls.Add(Me.lblprovedor)
        Me.GroupBox3.Controls.Add(Me.cmb_proveedor)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 121)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(112, 76)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(219, 26)
        Me.dtp_fecha.TabIndex = 1
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(14, 76)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(54, 20)
        Me.lblfecha.TabIndex = 3
        Me.lblfecha.Text = "Fecha"
        '
        'lblprovedor
        '
        Me.lblprovedor.AutoSize = True
        Me.lblprovedor.Location = New System.Drawing.Point(12, 25)
        Me.lblprovedor.Name = "lblprovedor"
        Me.lblprovedor.Size = New System.Drawing.Size(81, 20)
        Me.lblprovedor.TabIndex = 2
        Me.lblprovedor.Text = "Proveedor"
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(112, 25)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(224, 28)
        Me.cmb_proveedor.TabIndex = 0
        '
        'dgv_carrito
        '
        Me.dgv_carrito.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrito.Location = New System.Drawing.Point(421, 63)
        Me.dgv_carrito.Name = "dgv_carrito"
        Me.dgv_carrito.RowHeadersWidth = 62
        Me.dgv_carrito.RowTemplate.Height = 28
        Me.dgv_carrito.Size = New System.Drawing.Size(874, 390)
        Me.dgv_carrito.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_preciocompra)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.cmb_producto)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 263)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'txt_preciocompra
        '
        Me.txt_preciocompra.Location = New System.Drawing.Point(162, 144)
        Me.txt_preciocompra.Name = "txt_preciocompra"
        Me.txt_preciocompra.Size = New System.Drawing.Size(174, 26)
        Me.txt_preciocompra.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio Compra"
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_agregar.Location = New System.Drawing.Point(102, 200)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(155, 38)
        Me.btn_agregar.TabIndex = 7
        Me.btn_agregar.Text = "Agregar al Carrito"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Datos de la Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Producto"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(162, 101)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(174, 26)
        Me.txt_cantidad.TabIndex = 3
        '
        'cmb_producto
        '
        Me.cmb_producto.FormattingEnabled = True
        Me.cmb_producto.Location = New System.Drawing.Point(162, 60)
        Me.cmb_producto.Name = "cmb_producto"
        Me.cmb_producto.Size = New System.Drawing.Size(174, 28)
        Me.cmb_producto.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1388, 44)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Datos de la Compra"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bt_cancelar)
        Me.Panel2.Controls.Add(Me.bt_guardarcompra)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 565)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1388, 82)
        Me.Panel2.TabIndex = 16
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(1033, 482)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(165, 32)
        Me.lbl_total.TabIndex = 13
        Me.lbl_total.Text = "Total: $0.00"
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1388, 647)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_carrito)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Compra"
        Me.Text = "Compra"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_carrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_guardarcompra As Button
    Friend WithEvents bt_cancelar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgv_carrito As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents cmb_proveedor As ComboBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents cmb_producto As ComboBox
    Friend WithEvents txt_preciocompra As TextBox
    Friend WithEvents lblprovedor As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_total As Label
End Class
