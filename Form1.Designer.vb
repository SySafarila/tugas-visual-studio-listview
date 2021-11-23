<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textNim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textNama = New System.Windows.Forms.TextBox()
        Me.textProdi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'textNim
        '
        Me.textNim.Location = New System.Drawing.Point(65, 6)
        Me.textNim.Name = "textNim"
        Me.textNim.Size = New System.Drawing.Size(100, 20)
        Me.textNim.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAMA"
        '
        'textNama
        '
        Me.textNama.Location = New System.Drawing.Point(65, 40)
        Me.textNama.Name = "textNama"
        Me.textNama.Size = New System.Drawing.Size(100, 20)
        Me.textNama.TabIndex = 3
        '
        'textProdi
        '
        Me.textProdi.Location = New System.Drawing.Point(65, 77)
        Me.textProdi.Name = "textProdi"
        Me.textProdi.Size = New System.Drawing.Size(100, 20)
        Me.textProdi.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PRODI"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(65, 123)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'list
        '
        Me.list.HideSelection = False
        Me.list.Location = New System.Drawing.Point(15, 176)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(335, 115)
        Me.list.TabIndex = 7
        Me.list.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.textProdi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textNim)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textNim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textNama As TextBox
    Friend WithEvents textProdi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents list As ListView
End Class
