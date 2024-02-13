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
        btnLoadObjectDemo = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' btnLoadObjectDemo
        ' 
        btnLoadObjectDemo.Location = New Point(102, 272)
        btnLoadObjectDemo.Name = "btnLoadObjectDemo"
        btnLoadObjectDemo.Size = New Size(262, 94)
        btnLoadObjectDemo.TabIndex = 0
        btnLoadObjectDemo.Text = "Load Object Demo"
        btnLoadObjectDemo.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(456, 272)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(258, 91)
        btnExit.TabIndex = 1
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnLoadObjectDemo)
        Name = "Form1"
        Text = "Welcoming Form"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLoadObjectDemo As Button
    Friend WithEvents btnExit As Button

End Class
