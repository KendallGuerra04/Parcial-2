Public Class Problema2
    Dim sum As Double
    Dim var As Integer
    Dim total As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtcalif.Text = "" Then
            MsgBox("Debe ingresar un nombre para poder agregar un elemento", vbQuestion + vbOKOnly, "Datos incompletos")
            Exit Sub
        End If

        lstcalif.Items.Add(txtcalif.Text)
        txtcalif.Text = ""
        var += 1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim I As Integer
        Dim o As Integer

        sum = 0

        For I = 0 To lstcalif.Items.Count - 1
            sum = sum + lstcalif.Items(I)
        Next I
        txtsum.Text = sum


        total = sum / var
        txtprom.Text = total

        For o = 0 To lstcalif.Items.Count - 1
            If lstcalif.Items(o) > total Then
                lstmayprom.Items.Add(lstcalif.Items(o))
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lstcalif.Items.Clear()
        lstmayprom.Items.Clear()
        txtsum.Text = ""
        txtprom.Text = ""
    End Sub
End Class