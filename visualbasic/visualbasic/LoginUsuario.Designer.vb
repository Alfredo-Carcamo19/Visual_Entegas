<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginusuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_enviar = New System.Windows.Forms.Button()
        Me.ct_clave = New System.Windows.Forms.TextBox()
        Me.ct_usuario = New System.Windows.Forms.TextBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.Imagen_Usuario = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Imagen_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.bt_enviar)
        Me.GroupBox1.Controls.Add(Me.ct_clave)
        Me.GroupBox1.Controls.Add(Me.ct_usuario)
        Me.GroupBox1.Controls.Add(Me.lbltitulo)
        Me.GroupBox1.Controls.Add(Me.Imagen_Usuario)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 462)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bt_enviar
        '
        Me.bt_enviar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enviar.Location = New System.Drawing.Point(39, 368)
        Me.bt_enviar.Name = "bt_enviar"
        Me.bt_enviar.Size = New System.Drawing.Size(250, 39)
        Me.bt_enviar.TabIndex = 3
        Me.bt_enviar.Text = "Login"
        Me.bt_enviar.UseVisualStyleBackColor = False
        '
        'ct_clave
        '
        Me.ct_clave.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ct_clave.Location = New System.Drawing.Point(39, 319)
        Me.ct_clave.Name = "ct_clave"
        Me.ct_clave.Size = New System.Drawing.Size(250, 26)
        Me.ct_clave.TabIndex = 2
        Me.ct_clave.Text = "Password"
        '
        'ct_usuario
        '
        Me.ct_usuario.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ct_usuario.Location = New System.Drawing.Point(39, 272)
        Me.ct_usuario.Name = "ct_usuario"
        Me.ct_usuario.Size = New System.Drawing.Size(250, 26)
        Me.ct_usuario.TabIndex = 1
        Me.ct_usuario.Text = "Username"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft YaHei", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(69, 22)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(192, 37)
        Me.lbltitulo.TabIndex = 8
        Me.lbltitulo.Text = "USER LOGIN"
        '
        'Imagen_Usuario
        '
        Me.Imagen_Usuario.Image = CType(resources.GetObject("Imagen_Usuario.Image"), System.Drawing.Image)
        Me.Imagen_Usuario.InitialImage = CType(resources.GetObject("Imagen_Usuario.InitialImage"), System.Drawing.Image)
        Me.Imagen_Usuario.Location = New System.Drawing.Point(39, 62)
        Me.Imagen_Usuario.Name = "Imagen_Usuario"
        Me.Imagen_Usuario.Size = New System.Drawing.Size(250, 173)
        Me.Imagen_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Imagen_Usuario.TabIndex = 7
        Me.Imagen_Usuario.TabStop = False
        '
        'loginusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(519, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(541, 515)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(541, 515)
        Me.Name = "loginusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Imagen_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltitulo As Label
    Friend WithEvents Imagen_Usuario As PictureBox
    Friend WithEvents ct_clave As TextBox
    Friend WithEvents ct_usuario As TextBox
    Friend WithEvents bt_enviar As Button
End Class
