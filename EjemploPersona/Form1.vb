Public Class Form1
    Private Enum Direccion
        Arriba
        Abajo
        Izquierda
        Derecha
    End Enum
    Private oPersona As Persona
    Friend Personas As New List(Of Persona)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(PersonasCmb.SelectedItem.DecirNombre())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboPersonas()
    End Sub

    Friend Sub CargarComboPersonas()
        With PersonasCmb
            .Items.Clear()
            For Each ObjPers In Personas
                .Items.Add(ObjPers)
            Next
            .DisplayMember = "NombreyApellido"
        End With
    End Sub

    Private Sub AgregarCmd_Click(sender As Object, e As EventArgs) Handles AgregarCmd.Click
        Form2.ShowDialog()
    End Sub

    Private Sub EdadBtn_Click(sender As Object, e As EventArgs) Handles EdadBtn.Click
        MsgBox(oPersona.Edad())
    End Sub

    Private Sub PersonasCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PersonasCmb.SelectedIndexChanged
        oPersona = PersonasCmb.SelectedItem
    End Sub

    Private Sub SexoBtn_Click(sender As Object, e As EventArgs) Handles SexoBtn.Click
        MsgBox(oPersona.Sexo)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Rand As New Random()

        MsgBox(Rand.Next(Direccion.Arriba, Direccion.Derecha))
    End Sub
End Class
