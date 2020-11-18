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

    Private Sub Programa2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Programa2ToolStripMenuItem.Click
        Problema2.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPc.Click
        lblPc.Text = Environ("Kendall-pc")

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        lblUser.Text = Environ("Kendall Guerra")
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class
