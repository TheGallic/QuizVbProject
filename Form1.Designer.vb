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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxDifficult = New System.Windows.Forms.ComboBox()
        Me.LblSCore = New System.Windows.Forms.Label()
        Me.LblSteps = New System.Windows.Forms.Label()
        Me.RtbQuestion = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.BtnValidate = New System.Windows.Forms.Button()
        Me.RbA = New System.Windows.Forms.RadioButton()
        Me.RbB = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbD = New System.Windows.Forms.RadioButton()
        Me.RbC = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisissez la difficulté"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Etapes"
        '
        'CbxDifficult
        '
        Me.CbxDifficult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxDifficult.FormattingEnabled = True
        Me.CbxDifficult.Items.AddRange(New Object() {"Facile", "Normal", "Difficile", "Expert"})
        Me.CbxDifficult.Location = New System.Drawing.Point(12, 33)
        Me.CbxDifficult.Name = "CbxDifficult"
        Me.CbxDifficult.Size = New System.Drawing.Size(162, 29)
        Me.CbxDifficult.TabIndex = 4
        '
        'LblSCore
        '
        Me.LblSCore.AutoSize = True
        Me.LblSCore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblSCore.Location = New System.Drawing.Point(214, 41)
        Me.LblSCore.Name = "LblSCore"
        Me.LblSCore.Size = New System.Drawing.Size(109, 21)
        Me.LblSCore.TabIndex = 5
        Me.LblSCore.Text = "Score: 0 sur 0"
        '
        'LblSteps
        '
        Me.LblSteps.AutoSize = True
        Me.LblSteps.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblSteps.Location = New System.Drawing.Point(348, 41)
        Me.LblSteps.Name = "LblSteps"
        Me.LblSteps.Size = New System.Drawing.Size(119, 21)
        Me.LblSteps.TabIndex = 6
        Me.LblSteps.Text = "Etape: 0 sur 10"
        '
        'RtbQuestion
        '
        Me.RtbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RtbQuestion.ForeColor = System.Drawing.Color.DarkGreen
        Me.RtbQuestion.Location = New System.Drawing.Point(12, 142)
        Me.RtbQuestion.Name = "RtbQuestion"
        Me.RtbQuestion.ReadOnly = True
        Me.RtbQuestion.Size = New System.Drawing.Size(348, 197)
        Me.RtbQuestion.TabIndex = 7
        Me.RtbQuestion.Text = "En attente d'une nouvelle partie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Questions"
        '
        'BtnPlay
        '
        Me.BtnPlay.Location = New System.Drawing.Point(140, 371)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(220, 32)
        Me.BtnPlay.TabIndex = 9
        Me.BtnPlay.Text = "Jouer"
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'BtnValidate
        '
        Me.BtnValidate.Enabled = False
        Me.BtnValidate.Location = New System.Drawing.Point(414, 371)
        Me.BtnValidate.Name = "BtnValidate"
        Me.BtnValidate.Size = New System.Drawing.Size(220, 32)
        Me.BtnValidate.TabIndex = 10
        Me.BtnValidate.Text = "Valider la réponse"
        Me.BtnValidate.UseVisualStyleBackColor = True
        '
        'RbA
        '
        Me.RbA.AutoSize = True
        Me.RbA.Checked = True
        Me.RbA.Location = New System.Drawing.Point(6, 28)
        Me.RbA.Name = "RbA"
        Me.RbA.Size = New System.Drawing.Size(102, 25)
        Me.RbA.TabIndex = 11
        Me.RbA.TabStop = True
        Me.RbA.Text = "Réponse A"
        Me.RbA.UseVisualStyleBackColor = True
        '
        'RbB
        '
        Me.RbB.AutoSize = True
        Me.RbB.Location = New System.Drawing.Point(6, 59)
        Me.RbB.Name = "RbB"
        Me.RbB.Size = New System.Drawing.Size(101, 25)
        Me.RbB.TabIndex = 12
        Me.RbB.Text = "Réponse B"
        Me.RbB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbD)
        Me.GroupBox1.Controls.Add(Me.RbC)
        Me.GroupBox1.Controls.Add(Me.RbA)
        Me.GroupBox1.Controls.Add(Me.RbB)
        Me.GroupBox1.Location = New System.Drawing.Point(366, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 188)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Réponses"
        '
        'RbD
        '
        Me.RbD.AutoSize = True
        Me.RbD.Location = New System.Drawing.Point(6, 121)
        Me.RbD.Name = "RbD"
        Me.RbD.Size = New System.Drawing.Size(103, 25)
        Me.RbD.TabIndex = 14
        Me.RbD.Text = "Réponse D"
        Me.RbD.UseVisualStyleBackColor = True
        '
        'RbC
        '
        Me.RbC.AutoSize = True
        Me.RbC.Location = New System.Drawing.Point(6, 90)
        Me.RbC.Name = "RbC"
        Me.RbC.Size = New System.Drawing.Size(102, 25)
        Me.RbC.TabIndex = 13
        Me.RbC.Text = "Réponse C"
        Me.RbC.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 439)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnValidate)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RtbQuestion)
        Me.Controls.Add(Me.LblSteps)
        Me.Controls.Add(Me.LblSCore)
        Me.Controls.Add(Me.CbxDifficult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu Quiz"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxDifficult As ComboBox
    Friend WithEvents LblSCore As Label
    Friend WithEvents LblSteps As Label
    Friend WithEvents RtbQuestion As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnPlay As Button
    Friend WithEvents BtnValidate As Button
    Friend WithEvents RbA As RadioButton
    Friend WithEvents RbB As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbD As RadioButton
    Friend WithEvents RbC As RadioButton
End Class
