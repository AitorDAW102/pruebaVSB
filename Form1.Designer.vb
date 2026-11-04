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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 22F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(35, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 35)
        Label1.TabIndex = 0
        Label1.Text = "TEST BOTONES"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(35, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(130, 23)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Valor Inicial"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(35, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 44)
        Button1.TabIndex = 2
        Button1.Text = "CambiarLabel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.MistyRose
        Label2.Location = New Point(80, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(13, 15)
        Label2.TabIndex = 3
        Label2.Text = "a"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(222, 71)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 44)
        Button2.TabIndex = 4
        Button2.Text = "CambiarLabel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(222, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(130, 23)
        TextBox2.TabIndex = 5
        TextBox2.Text = "Valor Inicial"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(784, 361)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
End Class
