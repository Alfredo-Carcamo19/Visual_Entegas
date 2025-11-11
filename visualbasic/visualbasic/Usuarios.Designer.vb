<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.lblid = New System.Windows.Forms.Label()
        Me.ct_idusuario = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.cmb_rol = New System.Windows.Forms.ComboBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.btborrar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.ct_password = New System.Windows.Forms.TextBox()
        Me.ct_username = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlControles.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        Me.pnlControles.Controls.Add(Me.lblid)
        Me.pnlControles.Controls.Add(Me.ct_idusuario)
        Me.pnlControles.Controls.Add(Me.lblRol)
        Me.pnlControles.Controls.Add(Me.cmb_rol)
        Me.pnlControles.Controls.Add(Me.groupBox1)
        Me.pnlControles.Controls.Add(Me.Password)
        Me.pnlControles.Controls.Add(Me.Username)
        Me.pnlControles.Controls.Add(Me.ct_password)
        Me.pnlControles.Controls.Add(Me.ct_username)
        Me.pnlControles.Location = New System.Drawing.Point(414, 424)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(683, 248)
        Me.pnlControles.TabIndex = 27
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(71, 33)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(26, 20)
        Me.lblid.TabIndex = 26
        Me.lblid.Text = "ID"
        '
        'ct_idusuario
        '
        Me.ct_idusuario.Location = New System.Drawing.Point(122, 33)
        Me.ct_idusuario.Name = "ct_idusuario"
        Me.ct_idusuario.Size = New System.Drawing.Size(253, 26)
        Me.ct_idusuario.TabIndex = 25
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(71, 184)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(33, 20)
        Me.lblRol.TabIndex = 24
        Me.lblRol.Text = "Rol"
        '
        'cmb_rol
        '
        Me.cmb_rol.FormattingEnabled = True
        Me.cmb_rol.Location = New System.Drawing.Point(122, 184)
        Me.cmb_rol.Name = "cmb_rol"
        Me.cmb_rol.Size = New System.Drawing.Size(253, 28)
        Me.cmb_rol.TabIndex = 23
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btsalir)
        Me.groupBox1.Controls.Add(Me.btborrar)
        Me.groupBox1.Controls.Add(Me.btguardar)
        Me.groupBox1.Controls.Add(Me.btnuevo)
        Me.groupBox1.Location = New System.Drawing.Point(415, 18)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(245, 212)
        Me.groupBox1.TabIndex = 22
        Me.groupBox1.TabStop = False
        '
        'btsalir
        '
        Me.btsalir.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalir.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btsalir.Location = New System.Drawing.Point(72, 163)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(97, 43)
        Me.btsalir.TabIndex = 3
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = False
        '
        'btborrar
        '
        Me.btborrar.BackColor = System.Drawing.Color.Crimson
        Me.btborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btborrar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btborrar.Location = New System.Drawing.Point(72, 112)
        Me.btborrar.Name = "btborrar"
        Me.btborrar.Size = New System.Drawing.Size(97, 45)
        Me.btborrar.TabIndex = 2
        Me.btborrar.Text = "Borrar"
        Me.btborrar.UseVisualStyleBackColor = False
        '
        'btguardar
        '
        Me.btguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btguardar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btguardar.Location = New System.Drawing.Point(72, 64)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(97, 42)
        Me.btguardar.TabIndex = 0
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = False
        '
        'btnuevo
        '
        Me.btnuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuevo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnuevo.Location = New System.Drawing.Point(72, 15)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(97, 40)
        Me.btnuevo.TabIndex = 1
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(37, 127)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(78, 20)
        Me.Password.TabIndex = 19
        Me.Password.Text = "Password"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(32, 85)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(83, 20)
        Me.Username.TabIndex = 18
        Me.Username.Text = "Username"
        '
        'ct_password
        '
        Me.ct_password.Location = New System.Drawing.Point(122, 127)
        Me.ct_password.Name = "ct_password"
        Me.ct_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ct_password.Size = New System.Drawing.Size(253, 26)
        Me.ct_password.TabIndex = 14
        '
        'ct_username
        '
        Me.ct_username.Location = New System.Drawing.Point(122, 82)
        Me.ct_username.Name = "ct_username"
        Me.ct_username.Size = New System.Drawing.Size(253, 26)
        Me.ct_username.TabIndex = 13
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(328, 12)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 62
        Me.dataGridView1.RowTemplate.Height = 28
        Me.dataGridView1.Size = New System.Drawing.Size(796, 406)
        Me.dataGridView1.TabIndex = 26
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 723)
        Me.Controls.Add(Me.pnlControles)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
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
    Private WithEvents Password As Label
    Private WithEvents Username As Label
    Private WithEvents ct_username As TextBox
    Private WithEvents dataGridView1 As DataGridView
    Friend WithEvents cmb_rol As ComboBox
    Private WithEvents ct_password As TextBox
    Private WithEvents lblRol As Label
    Private WithEvents ct_idusuario As TextBox
    Private WithEvents lblid As Label
End Class
