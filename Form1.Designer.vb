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
        ComboBox1 = New ComboBox()
        Button3 = New Button()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        Button5 = New Button()
        Button6 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        Button1.Text = "Cambiar Texto"
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
        Button2.Location = New Point(226, 71)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 44)
        Button2.TabIndex = 4
        Button2.Text = "Cambiar Color"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Rojo", "Azul", "Dorado", "Verde", "Purpura", "Blanco"})
        ComboBox1.Location = New Point(226, 131)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(130, 23)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Color"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(399, 71)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 44)
        Button3.TabIndex = 7
        Button3.Text = "Cambiar Tamaño +"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(399, 119)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 44)
        Button4.TabIndex = 8
        Button4.Text = "Cambiar Tamaño -"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.veggeta_
        PictureBox1.Location = New Point(480, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(489, 960)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(178, 244)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(178, 42)
        ProgressBar1.Step = 1
        ProgressBar1.TabIndex = 10
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(97, 225)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 38)
        Button5.TabIndex = 11
        Button5.Text = "Aumentar Progeso"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(97, 269)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 38)
        Button6.TabIndex = 12
        Button6.Text = "Disminuir Progeso"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1009, 988)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Formulario"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
