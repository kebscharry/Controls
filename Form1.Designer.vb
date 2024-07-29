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
        txtInput1 = New TextBox()
        txtInput2 = New TextBox()
        btnClick = New Button()
        lblSum = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtInput1
        ' 
        txtInput1.Location = New Point(101, 42)
        txtInput1.Name = "txtInput1"
        txtInput1.Size = New Size(183, 23)
        txtInput1.TabIndex = 0
        ' 
        ' txtInput2
        ' 
        txtInput2.Location = New Point(101, 85)
        txtInput2.Name = "txtInput2"
        txtInput2.Size = New Size(183, 23)
        txtInput2.TabIndex = 1
        ' 
        ' btnClick
        ' 
        btnClick.BackColor = SystemColors.ButtonHighlight
        btnClick.Location = New Point(106, 237)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(178, 46)
        btnClick.TabIndex = 2
        btnClick.Text = "Click"
        btnClick.UseVisualStyleBackColor = False
        ' 
        ' lblSum
        ' 
        lblSum.AutoSize = True
        lblSum.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSum.Location = New Point(106, 137)
        lblSum.Name = "lblSum"
        lblSum.Size = New Size(44, 17)
        lblSum.TabIndex = 3
        lblSum.Text = "Sum="
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(173, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 17)
        Label1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(216, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblSum)
        Controls.Add(btnClick)
        Controls.Add(txtInput2)
        Controls.Add(txtInput1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents btnClick As Button
    Friend WithEvents lblSum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
