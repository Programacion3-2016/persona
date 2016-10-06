<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.NombreyApellidoTxt = New System.Windows.Forms.TextBox()
        Me.FechaDeNacimientoDtp = New System.Windows.Forms.DateTimePicker()
        Me.DniTxt = New System.Windows.Forms.TextBox()
        Me.SexoCmb = New System.Windows.Forms.ComboBox()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NombreyApellidoTxt
        '
        Me.NombreyApellidoTxt.Location = New System.Drawing.Point(122, 26)
        Me.NombreyApellidoTxt.Name = "NombreyApellidoTxt"
        Me.NombreyApellidoTxt.Size = New System.Drawing.Size(210, 20)
        Me.NombreyApellidoTxt.TabIndex = 0
        '
        'FechaDeNacimientoDtp
        '
        Me.FechaDeNacimientoDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDeNacimientoDtp.Location = New System.Drawing.Point(122, 78)
        Me.FechaDeNacimientoDtp.Name = "FechaDeNacimientoDtp"
        Me.FechaDeNacimientoDtp.Size = New System.Drawing.Size(87, 20)
        Me.FechaDeNacimientoDtp.TabIndex = 1
        '
        'DniTxt
        '
        Me.DniTxt.Location = New System.Drawing.Point(122, 52)
        Me.DniTxt.Name = "DniTxt"
        Me.DniTxt.Size = New System.Drawing.Size(100, 20)
        Me.DniTxt.TabIndex = 2
        '
        'SexoCmb
        '
        Me.SexoCmb.FormattingEnabled = True
        Me.SexoCmb.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.SexoCmb.Location = New System.Drawing.Point(122, 104)
        Me.SexoCmb.Name = "SexoCmb"
        Me.SexoCmb.Size = New System.Drawing.Size(119, 21)
        Me.SexoCmb.TabIndex = 3
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(166, 181)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(75, 23)
        Me.AceptarBtn.TabIndex = 4
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(257, 181)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelarBtn.TabIndex = 4
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 261)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.SexoCmb)
        Me.Controls.Add(Me.DniTxt)
        Me.Controls.Add(Me.FechaDeNacimientoDtp)
        Me.Controls.Add(Me.NombreyApellidoTxt)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NombreyApellidoTxt As TextBox
    Friend WithEvents FechaDeNacimientoDtp As DateTimePicker
    Friend WithEvents DniTxt As TextBox
    Friend WithEvents SexoCmb As ComboBox
    Friend WithEvents AceptarBtn As Button
    Friend WithEvents CancelarBtn As Button
End Class
