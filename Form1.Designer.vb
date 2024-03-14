<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        ResultLabel = New Label()
        ExitButton = New Button()
        SolveButton = New Button()
        TextBoxC = New TextBox()
        TextBoxB = New TextBox()
        TextBoxA = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(ExitButton)
        GroupBox1.Controls.Add(SolveButton)
        GroupBox1.Controls.Add(TextBoxC)
        GroupBox1.Controls.Add(TextBoxB)
        GroupBox1.Controls.Add(TextBoxA)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(384, 321)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ax^2 + Bx + С = 0"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ResultLabel)
        GroupBox2.Location = New Point(6, 158)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(372, 124)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Решение"
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Location = New Point(6, 19)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(120, 60)
        ResultLabel.TabIndex = 0
        ResultLabel.Text = "Дискриминант D=73" & vbCrLf & vbCrLf & "  x1=1,386001" & vbCrLf & "  x2=2,886001"
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(303, 288)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 23)
        ExitButton.TabIndex = 2
        ExitButton.Text = "Выход"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' SolveButton
        ' 
        SolveButton.Location = New Point(257, 105)
        SolveButton.Name = "SolveButton"
        SolveButton.Size = New Size(75, 23)
        SolveButton.TabIndex = 2
        SolveButton.Text = "Решить"
        SolveButton.UseVisualStyleBackColor = True
        ' 
        ' TextBoxC
        ' 
        TextBoxC.Location = New Point(113, 102)
        TextBoxC.Name = "TextBoxC"
        TextBoxC.Size = New Size(126, 23)
        TextBoxC.TabIndex = 1
        TextBoxC.Text = "-8"
        ' 
        ' TextBoxB
        ' 
        TextBoxB.Location = New Point(113, 70)
        TextBoxB.Name = "TextBoxB"
        TextBoxB.Size = New Size(126, 23)
        TextBoxB.TabIndex = 1
        TextBoxB.Text = "3"
        ' 
        ' TextBoxA
        ' 
        TextBoxA.Location = New Point(113, 40)
        TextBoxA.Name = "TextBoxA"
        TextBoxA.Size = New Size(126, 23)
        TextBoxA.TabIndex = 1
        TextBoxA.Text = "2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 0
        Label3.Text = "Коэффицент C"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 15)
        Label2.TabIndex = 0
        Label2.Text = "Коэффицент B"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 0
        Label1.Text = "Коэффицент A"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 345)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Решение квадратных уравнений"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SolveButton As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ExitButton As Button

End Class
