Public Class Form1
    Dim Tamaño = 9
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = True
        Me.MinimizeBox = True
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.BackColor = Color.Gold
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = TextBox1.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Rojo" Then
            Label2.ForeColor = Color.Red
        ElseIf ComboBox1.Text = "Verde" Then
            Label2.ForeColor = Color.Green
        ElseIf ComboBox1.Text = "Azul" Then
            Label2.ForeColor = Color.Blue
        ElseIf ComboBox1.Text = "Dorado" Then
            Label2.ForeColor = Color.Gold
        ElseIf ComboBox1.Text = "Blanco" Then
            Label2.ForeColor = Color.White
        ElseIf ComboBox1.Text = "Purpura" Then
            Label2.ForeColor = Color.Purple
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tamaño = Tamaño + 1
        Label2.Font = New Font(Label2.Font.FontFamily, Tamaño)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Tamaño = Tamaño - 1
        Label2.Font = New Font(Label2.Font.FontFamily, Tamaño)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Value + ProgressBar1.Step
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ProgressBar1.Value > ProgressBar1.Minimum Then
            ProgressBar1.Value = ProgressBar1.Value - ProgressBar1.Step
        End If
    End Sub
End Class