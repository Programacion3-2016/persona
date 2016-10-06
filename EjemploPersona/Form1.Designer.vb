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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PersonasCmb = New System.Windows.Forms.ComboBox()
        Me.EdadBtn = New System.Windows.Forms.Button()
        Me.AgregarCmd = New System.Windows.Forms.Button()
        Me.SexoBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Decir Nombre"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PersonasCmb
        '
        Me.PersonasCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PersonasCmb.FormattingEnabled = True
        Me.PersonasCmb.Location = New System.Drawing.Point(50, 27)
        Me.PersonasCmb.Name = "PersonasCmb"
        Me.PersonasCmb.Size = New System.Drawing.Size(255, 21)
        Me.PersonasCmb.TabIndex = 1
        '
        'EdadBtn
        '
        Me.EdadBtn.Location = New System.Drawing.Point(50, 100)
        Me.EdadBtn.Name = "EdadBtn"
        Me.EdadBtn.Size = New System.Drawing.Size(75, 23)
        Me.EdadBtn.TabIndex = 2
        Me.EdadBtn.Text = "Edad"
        Me.EdadBtn.UseVisualStyleBackColor = True
        '
        'AgregarCmd
        '
        Me.AgregarCmd.Location = New System.Drawing.Point(311, 25)
        Me.AgregarCmd.Name = "AgregarCmd"
        Me.AgregarCmd.Size = New System.Drawing.Size(108, 23)
        Me.AgregarCmd.TabIndex = 2
        Me.AgregarCmd.Text = "Agregar Persona"
        Me.AgregarCmd.UseVisualStyleBackColor = True
        '
        'SexoBtn
        '
        Me.SexoBtn.Location = New System.Drawing.Point(50, 129)
        Me.SexoBtn.Name = "SexoBtn"
        Me.SexoBtn.Size = New System.Drawing.Size(75, 23)
        Me.SexoBtn.TabIndex = 3
        Me.SexoBtn.Text = "Decir Sexo"
        Me.SexoBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 312)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SexoBtn)
        Me.Controls.Add(Me.AgregarCmd)
        Me.Controls.Add(Me.EdadBtn)
        Me.Controls.Add(Me.PersonasCmb)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PersonasCmb As ComboBox
    Friend WithEvents EdadBtn As Button
    Friend WithEvents AgregarCmd As Button
    Friend WithEvents SexoBtn As Button
    Friend WithEvents Button2 As Button
End Class
