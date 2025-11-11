<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.lblidcliente = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.btborrar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lb_direccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ct_idcliente = New System.Windows.Forms.TextBox()
        Me.ct_email = New System.Windows.Forms.TextBox()
        Me.ct_telefono = New System.Windows.Forms.TextBox()
        Me.ct_direccion = New System.Windows.Forms.TextBox()
        Me.ct_nombre = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlControles.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        Me.pnlControles.Controls.Add(Me.lblidcliente)
        Me.pnlControles.Controls.Add(Me.groupBox1)
        Me.pnlControles.Controls.Add(Me.lblcorreo)
        Me.pnlControles.Controls.Add(Me.lbltelefono)
        Me.pnlControles.Controls.Add(Me.lb_direccion)
        Me.pnlControles.Controls.Add(Me.lblNombre)
        Me.pnlControles.Controls.Add(Me.ct_idcliente)
        Me.pnlControles.Controls.Add(Me.ct_email)
        Me.pnlControles.Controls.Add(Me.ct_telefono)
        Me.pnlControles.Controls.Add(Me.ct_direccion)
        Me.pnlControles.Controls.Add(Me.ct_nombre)
        Me.pnlControles.Location = New System.Drawing.Point(412, 414)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(683, 248)
        Me.pnlControles.TabIndex = 25
        '
        'lblidcliente
        '
        Me.lblidcliente.AutoSize = True
        Me.lblidcliente.Location = New System.Drawing.Point(81, 27)
        Me.lblidcliente.Name = "lblidcliente"
        Me.lblidcliente.Size = New System.Drawing.Size(26, 20)
        Me.lblidcliente.TabIndex = 23
        Me.lblidcliente.Text = "ID"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btsalir)
        Me.groupBox1.Controls.Add(Me.btborrar)
        Me.groupBox1.Controls.Add(Me.btguardar)
        Me.groupBox1.Controls.Add(Me.btnuevo)
        Me.groupBox1.Location = New System.Drawing.Point(415, 21)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(245, 215)
        Me.groupBox1.TabIndex = 22
        Me.groupBox1.TabStop = False
        '
        'btsalir
        '
        Me.btsalir.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalir.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btsalir.Location = New System.Drawing.Point(72, 166)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(97, 32)
        Me.btsalir.TabIndex = 3
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = False
        '
        'btborrar
        '
        Me.btborrar.BackColor = System.Drawing.Color.Crimson
        Me.btborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btborrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btborrar.Location = New System.Drawing.Point(72, 120)
        Me.btborrar.Name = "btborrar"
        Me.btborrar.Size = New System.Drawing.Size(97, 32)
        Me.btborrar.TabIndex = 2
        Me.btborrar.Text = "Borrar"
        Me.btborrar.UseVisualStyleBackColor = False
        '
        'btguardar
        '
        Me.btguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btguardar.ForeColor = System.Drawing.Color.White
        Me.btguardar.Location = New System.Drawing.Point(72, 71)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(97, 35)
        Me.btguardar.TabIndex = 0
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = False
        '
        'btnuevo
        '
        Me.btnuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnuevo.Location = New System.Drawing.Point(72, 25)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(97, 38)
        Me.btnuevo.TabIndex = 1
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = False
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(48, 199)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(57, 20)
        Me.lblcorreo.TabIndex = 21
        Me.lblcorreo.Text = "Correo"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(38, 150)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(71, 20)
        Me.lbltelefono.TabIndex = 20
        Me.lbltelefono.Text = "Telefono"
        '
        'lb_direccion
        '
        Me.lb_direccion.AutoSize = True
        Me.lb_direccion.Location = New System.Drawing.Point(34, 106)
        Me.lb_direccion.Name = "lb_direccion"
        Me.lb_direccion.Size = New System.Drawing.Size(75, 20)
        Me.lb_direccion.TabIndex = 19
        Me.lb_direccion.Text = "Direccion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(38, 64)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'ct_idcliente
        '
        Me.ct_idcliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ct_idcliente.Location = New System.Drawing.Point(119, 21)
        Me.ct_idcliente.Name = "ct_idcliente"
        Me.ct_idcliente.ReadOnly = True
        Me.ct_idcliente.Size = New System.Drawing.Size(253, 26)
        Me.ct_idcliente.TabIndex = 17
        Me.ct_idcliente.Visible = False
        '
        'ct_email
        '
        Me.ct_email.Location = New System.Drawing.Point(119, 196)
        Me.ct_email.Name = "ct_email"
        Me.ct_email.Size = New System.Drawing.Size(253, 26)
        Me.ct_email.TabIndex = 16
        '
        'ct_telefono
        '
        Me.ct_telefono.Location = New System.Drawing.Point(119, 147)
        Me.ct_telefono.Name = "ct_telefono"
        Me.ct_telefono.Size = New System.Drawing.Size(253, 26)
        Me.ct_telefono.TabIndex = 15
        '
        'ct_direccion
        '
        Me.ct_direccion.Location = New System.Drawing.Point(119, 106)
        Me.ct_direccion.Name = "ct_direccion"
        Me.ct_direccion.Size = New System.Drawing.Size(253, 26)
        Me.ct_direccion.TabIndex = 14
        '
        'ct_nombre
        '
        Me.ct_nombre.Location = New System.Drawing.Point(119, 61)
        Me.ct_nombre.Name = "ct_nombre"
        Me.ct_nombre.Size = New System.Drawing.Size(253, 26)
        Me.ct_nombre.TabIndex = 13
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.dataGridView1.Location = New System.Drawing.Point(241, 12)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 62
        Me.dataGridView1.RowTemplate.Height = 28
        Me.dataGridView1.Size = New System.Drawing.Size(1009, 381)
        Me.dataGridView1.TabIndex = 24
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1585, 686)
        Me.Controls.Add(Me.pnlControles)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.pnlControles.ResumeLayout(False)
        Me.pnlControles.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControles As Panel
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btsalir As Button
    Private WithEvents btborrar As Button
    Private WithEvents btguardar As Button
    Private WithEvents btnuevo As Button
    Private WithEvents lblcorreo As Label
    Private WithEvents lbltelefono As Label
    Private WithEvents lb_direccion As Label
    Private WithEvents lblNombre As Label
    Private WithEvents ct_idcliente As TextBox
    Private WithEvents ct_email As TextBox
    Private WithEvents ct_telefono As TextBox
    Private WithEvents ct_direccion As TextBox
    Private WithEvents ct_nombre As TextBox
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents lblidcliente As Label
End Class
