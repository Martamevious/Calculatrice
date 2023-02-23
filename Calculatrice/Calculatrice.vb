Public Class Calculatrice
    Dim a As Double
    Dim b As Double
    Dim OP As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Clear()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        a = (TextBox1.Text)
        TextBox1.Clear()
        OP = "+"

    End Sub

    Private Sub ButtonSous_Click(sender As Object, e As EventArgs) Handles ButtonSous.Click
        a = (TextBox1.Text)
        TextBox1.Clear()
        OP = "-"
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        a = (TextBox1.Text)
        TextBox1.Clear()
        OP = "*"
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        a = (TextBox1.Text)
        TextBox1.Clear()
        OP = "/"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        a = (TextBox1.Text)
        TextBox1.Clear()
        OP = "^"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        a = (TextBox1.Text)
        TextBox1.Clear()
        OP = "%"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click



        If OP = "-" Then
            b = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = a - b
        ElseIf OP = "+" Then
            b = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = a + b
        ElseIf OP = "/" Then
            b = Convert.ToString(TextBox1.Text)
            TextBox1.Text = a / b
        ElseIf OP = "*" Then
            b = (TextBox1.Text)
            TextBox1.Text = Convert.ToDouble(a) * Convert.ToDouble(b)
        ElseIf OP = "%" Then
            b = 0
            TextBox1.Text = a / 100
        ElseIf OP = "^" Then
            TextBox1.Text = a * a
        Else
            MessageBox.Show("Choisissez un opérateur")
        End If


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text + "."
    End Sub
End Class
