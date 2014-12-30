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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Letter1 = New System.Windows.Forms.Label()
        Me.Letter2 = New System.Windows.Forms.Label()
        Me.Letter3 = New System.Windows.Forms.Label()
        Me.Letter4 = New System.Windows.Forms.Label()
        Me.Letter5 = New System.Windows.Forms.Label()
        Me.Letter6 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Button()
        Me.Line2 = New System.Windows.Forms.Button()
        Me.Line3 = New System.Windows.Forms.Button()
        Me.Line4 = New System.Windows.Forms.Button()
        Me.Line5 = New System.Windows.Forms.Button()
        Me.Line6 = New System.Windows.Forms.Button()
        Me.WrongGuessesLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.guessButton1 = New System.Windows.Forms.Button()
        Me.Credit1 = New System.Windows.Forms.Label()
        Me.Credit2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.Location = New System.Drawing.Point(157, 43)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(106, 43)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.TabStop = False
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Letter1
        '
        Me.Letter1.AutoSize = True
        Me.Letter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Letter1.Location = New System.Drawing.Point(61, 115)
        Me.Letter1.Name = "Letter1"
        Me.Letter1.Size = New System.Drawing.Size(30, 29)
        Me.Letter1.TabIndex = 1
        Me.Letter1.Text = "A"
        '
        'Letter2
        '
        Me.Letter2.AutoSize = True
        Me.Letter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Letter2.Location = New System.Drawing.Point(115, 115)
        Me.Letter2.Name = "Letter2"
        Me.Letter2.Size = New System.Drawing.Size(30, 29)
        Me.Letter2.TabIndex = 2
        Me.Letter2.Text = "A"
        '
        'Letter3
        '
        Me.Letter3.AutoSize = True
        Me.Letter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Letter3.Location = New System.Drawing.Point(166, 115)
        Me.Letter3.Name = "Letter3"
        Me.Letter3.Size = New System.Drawing.Size(30, 29)
        Me.Letter3.TabIndex = 3
        Me.Letter3.Text = "A"
        '
        'Letter4
        '
        Me.Letter4.AutoSize = True
        Me.Letter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Letter4.Location = New System.Drawing.Point(221, 115)
        Me.Letter4.Name = "Letter4"
        Me.Letter4.Size = New System.Drawing.Size(30, 29)
        Me.Letter4.TabIndex = 4
        Me.Letter4.Text = "A"
        '
        'Letter5
        '
        Me.Letter5.AutoSize = True
        Me.Letter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Letter5.Location = New System.Drawing.Point(273, 115)
        Me.Letter5.Name = "Letter5"
        Me.Letter5.Size = New System.Drawing.Size(30, 29)
        Me.Letter5.TabIndex = 5
        Me.Letter5.Text = "A"
        '
        'Letter6
        '
        Me.Letter6.AutoSize = True
        Me.Letter6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Letter6.Location = New System.Drawing.Point(326, 115)
        Me.Letter6.Name = "Letter6"
        Me.Letter6.Size = New System.Drawing.Size(30, 29)
        Me.Letter6.TabIndex = 6
        Me.Letter6.Text = "A"
        '
        'Line1
        '
        Me.Line1.Enabled = False
        Me.Line1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line1.Location = New System.Drawing.Point(52, 147)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(48, 2)
        Me.Line1.TabIndex = 7
        Me.Line1.TabStop = False
        Me.Line1.Text = "Button2"
        Me.Line1.UseVisualStyleBackColor = True
        '
        'Line2
        '
        Me.Line2.Enabled = False
        Me.Line2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line2.Location = New System.Drawing.Point(106, 147)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(48, 2)
        Me.Line2.TabIndex = 8
        Me.Line2.TabStop = False
        Me.Line2.Text = "Button3"
        Me.Line2.UseVisualStyleBackColor = True
        '
        'Line3
        '
        Me.Line3.Enabled = False
        Me.Line3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line3.Location = New System.Drawing.Point(158, 147)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(48, 2)
        Me.Line3.TabIndex = 9
        Me.Line3.TabStop = False
        Me.Line3.Text = "Button4"
        Me.Line3.UseVisualStyleBackColor = True
        '
        'Line4
        '
        Me.Line4.Enabled = False
        Me.Line4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line4.Location = New System.Drawing.Point(212, 147)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(48, 2)
        Me.Line4.TabIndex = 10
        Me.Line4.TabStop = False
        Me.Line4.Text = "Button5"
        Me.Line4.UseVisualStyleBackColor = True
        '
        'Line5
        '
        Me.Line5.Enabled = False
        Me.Line5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line5.Location = New System.Drawing.Point(265, 147)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(48, 2)
        Me.Line5.TabIndex = 11
        Me.Line5.TabStop = False
        Me.Line5.Text = "Button6"
        Me.Line5.UseVisualStyleBackColor = True
        '
        'Line6
        '
        Me.Line6.Enabled = False
        Me.Line6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line6.Location = New System.Drawing.Point(319, 147)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(48, 2)
        Me.Line6.TabIndex = 12
        Me.Line6.TabStop = False
        Me.Line6.Text = "Button7"
        Me.Line6.UseVisualStyleBackColor = True
        '
        'WrongGuessesLabel
        '
        Me.WrongGuessesLabel.AutoSize = True
        Me.WrongGuessesLabel.Location = New System.Drawing.Point(13, 477)
        Me.WrongGuessesLabel.Name = "WrongGuessesLabel"
        Me.WrongGuessesLabel.Size = New System.Drawing.Size(89, 13)
        Me.WrongGuessesLabel.TabIndex = 13
        Me.WrongGuessesLabel.Text = "Wrong Guesses: "
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"CAT", "DOG", "HOUSE", "CAR", "PAINT", "HORSE", "SIX", "SEVEN", "ONE", "GRAPH", "OPTION", "ERROR", "ROUGH", "BLESS", "SNAKE", "KITTY", "LITTER", "PHONE", "ZEBRA", "GRANT", "LASER", "GROUND", "GLASS", "BOOZE", "SMACK"})
        Me.ListBox1.Location = New System.Drawing.Point(292, 189)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 14
        Me.ListBox1.TabStop = False
        Me.ListBox1.UseTabStops = False
        Me.ListBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 290)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "Enter Guess Here"
        '
        'guessButton1
        '
        Me.guessButton1.Location = New System.Drawing.Point(331, 470)
        Me.guessButton1.Name = "guessButton1"
        Me.guessButton1.Size = New System.Drawing.Size(80, 19)
        Me.guessButton1.TabIndex = 16
        Me.guessButton1.TabStop = False
        Me.guessButton1.Text = "Guess"
        Me.guessButton1.UseVisualStyleBackColor = True
        '
        'Credit1
        '
        Me.Credit1.AutoSize = True
        Me.Credit1.Location = New System.Drawing.Point(13, 9)
        Me.Credit1.Name = "Credit1"
        Me.Credit1.Size = New System.Drawing.Size(68, 13)
        Me.Credit1.TabIndex = 17
        Me.Credit1.Text = "Place Holder"
        Me.Credit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Credit2
        '
        Me.Credit2.AutoSize = True
        Me.Credit2.Location = New System.Drawing.Point(13, 43)
        Me.Credit2.Name = "Credit2"
        Me.Credit2.Size = New System.Drawing.Size(68, 13)
        Me.Credit2.TabIndex = 18
        Me.Credit2.Text = "Place Holder"
        Me.Credit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 502)
        Me.Controls.Add(Me.Credit2)
        Me.Controls.Add(Me.Credit1)
        Me.Controls.Add(Me.guessButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.WrongGuessesLabel)
        Me.Controls.Add(Me.Line6)
        Me.Controls.Add(Me.Line5)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Letter6)
        Me.Controls.Add(Me.Letter5)
        Me.Controls.Add(Me.Letter4)
        Me.Controls.Add(Me.Letter3)
        Me.Controls.Add(Me.Letter2)
        Me.Controls.Add(Me.Letter1)
        Me.Controls.Add(Me.PlayButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "SWN Hangman"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents Letter1 As System.Windows.Forms.Label
    Friend WithEvents Letter2 As System.Windows.Forms.Label
    Friend WithEvents Letter3 As System.Windows.Forms.Label
    Friend WithEvents Letter4 As System.Windows.Forms.Label
    Friend WithEvents Letter5 As System.Windows.Forms.Label
    Friend WithEvents Letter6 As System.Windows.Forms.Label
    Friend WithEvents Line1 As System.Windows.Forms.Button
    Friend WithEvents Line2 As System.Windows.Forms.Button
    Friend WithEvents Line3 As System.Windows.Forms.Button
    Friend WithEvents Line4 As System.Windows.Forms.Button
    Friend WithEvents Line5 As System.Windows.Forms.Button
    Friend WithEvents Line6 As System.Windows.Forms.Button
    Friend WithEvents WrongGuessesLabel As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents guessButton1 As System.Windows.Forms.Button
    Public WithEvents Credit1 As System.Windows.Forms.Label
    Public WithEvents Credit2 As System.Windows.Forms.Label

End Class
