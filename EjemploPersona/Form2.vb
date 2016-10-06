Public Class Form2
    Private oPersona As New Persona()
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        With oPersona
            .NombreyApellido = NombreyApellidoTxt.Text
            .FechaDeNacimiento = FechaDeNacimientoDtp.Value
            .Sexo = SexoCmb.Text
            .DNI = DniTxt.Text
        End With
        Form1.Personas.Add(oPersona)
        Form1.CargarComboPersonas()
        Me.Dispose()
    End Sub

End Class