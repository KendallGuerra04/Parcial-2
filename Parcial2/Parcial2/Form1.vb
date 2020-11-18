Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim condición As Integer
        condición = MsgBox("¿Desea Salir?", vbYesNo)
        If condición = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub Programa1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Programa1ToolStripMenuItem.Click
        Problema1.Show()
        Me.Hide()
    End Sub
End Class
