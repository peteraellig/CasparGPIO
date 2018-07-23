<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CASPARCG_GPIO
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer_GPI_1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_GPI_2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4_clear_CG_return = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ri_message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ri_number = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label_connected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPI8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GPIO_PORT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.button_save = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Botton_Save_GPIO = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.button_settings = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GPI_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ri_data = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_GPI_1
        '
        Me.Timer_GPI_1.Enabled = True
        Me.Timer_GPI_1.Interval = 50
        '
        'Timer_GPI_2
        '
        Me.Timer_GPI_2.Enabled = True
        Me.Timer_GPI_2.Interval = 50
        '
        'Timer4_clear_CG_return
        '
        Me.Timer4_clear_CG_return.Enabled = True
        Me.Timer4_clear_CG_return.Interval = 5000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Label_connected, Me.GPI1, Me.GPI2, Me.GPI3, Me.GPI4, Me.GPI5, Me.GPI6, Me.GPI7, Me.GPI8, Me.ToolStripStatusLabel3, Me.GPIO_PORT, Me.GPI_Status, Me.ri_message, Me.ri_number, Me.ri_data})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1268, 28)
        Me.StatusStrip1.TabIndex = 679
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ri_message
        '
        Me.ri_message.AutoSize = False
        Me.ri_message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ri_message.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ri_message.Name = "ri_message"
        Me.ri_message.Size = New System.Drawing.Size(220, 23)
        Me.ri_message.Text = "ri_message"
        '
        'ri_number
        '
        Me.ri_number.AutoSize = False
        Me.ri_number.Name = "ri_number"
        Me.ri_number.Size = New System.Drawing.Size(61, 23)
        Me.ri_number.Text = "ri_number"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(90, 23)
        Me.ToolStripStatusLabel1.Text = "Caspar Status:"
        '
        'Label_connected
        '
        Me.Label_connected.AutoSize = False
        Me.Label_connected.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Label_connected.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.Label_connected.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.Label_connected.Name = "Label_connected"
        Me.Label_connected.Size = New System.Drawing.Size(130, 23)
        Me.Label_connected.Text = "Label_connected"
        '
        'GPI1
        '
        Me.GPI1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI1.Name = "GPI1"
        Me.GPI1.Size = New System.Drawing.Size(35, 23)
        Me.GPI1.Text = "GPI1"
        '
        'GPI2
        '
        Me.GPI2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI2.Name = "GPI2"
        Me.GPI2.Size = New System.Drawing.Size(35, 23)
        Me.GPI2.Text = "GPI2"
        '
        'GPI3
        '
        Me.GPI3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI3.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI3.Name = "GPI3"
        Me.GPI3.Size = New System.Drawing.Size(35, 23)
        Me.GPI3.Text = "GPI3"
        '
        'GPI4
        '
        Me.GPI4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI4.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI4.Name = "GPI4"
        Me.GPI4.Size = New System.Drawing.Size(35, 23)
        Me.GPI4.Text = "GPI4"
        '
        'GPI5
        '
        Me.GPI5.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI5.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI5.Name = "GPI5"
        Me.GPI5.Size = New System.Drawing.Size(35, 23)
        Me.GPI5.Text = "GPI5"
        '
        'GPI6
        '
        Me.GPI6.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI6.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI6.Name = "GPI6"
        Me.GPI6.Size = New System.Drawing.Size(35, 23)
        Me.GPI6.Text = "GPI6"
        '
        'GPI7
        '
        Me.GPI7.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI7.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI7.Name = "GPI7"
        Me.GPI7.Size = New System.Drawing.Size(35, 23)
        Me.GPI7.Text = "GPI7"
        '
        'GPI8
        '
        Me.GPI8.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI8.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.GPI8.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.GPI8.Name = "GPI8"
        Me.GPI8.Size = New System.Drawing.Size(35, 23)
        Me.GPI8.Text = "GPI8"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(59, 23)
        Me.ToolStripStatusLabel3.Text = "GPI_Port:"
        '
        'GPIO_PORT
        '
        Me.GPIO_PORT.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPIO_PORT.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.GPIO_PORT.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.GPIO_PORT.Name = "GPIO_PORT"
        Me.GPIO_PORT.Size = New System.Drawing.Size(17, 23)
        Me.GPIO_PORT.Text = "1"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(198, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(854, 31)
        Me.TextBox1.TabIndex = 680
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1074, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 31)
        Me.Button1.TabIndex = 681
        Me.Button1.Text = "Test GPI1 Command"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 683
        Me.Label1.Text = "GPI1 command"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 25)
        Me.Label2.TabIndex = 686
        Me.Label2.Text = "GPI2 command"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1074, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 31)
        Me.Button2.TabIndex = 685
        Me.Button2.Text = "Test GPI2 Command"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(198, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(854, 31)
        Me.TextBox2.TabIndex = 684
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 689
        Me.Label3.Text = "GPI3command"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1074, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 31)
        Me.Button3.TabIndex = 688
        Me.Button3.Text = "Test GPI3 Command"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(198, 115)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(854, 31)
        Me.TextBox3.TabIndex = 687
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 25)
        Me.Label4.TabIndex = 692
        Me.Label4.Text = "GPI4 command"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1074, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 31)
        Me.Button4.TabIndex = 691
        Me.Button4.Text = "Test GPI4 Command"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(198, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(854, 31)
        Me.TextBox4.TabIndex = 690
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 25)
        Me.Label5.TabIndex = 695
        Me.Label5.Text = "GPI5 command"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1074, 189)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 31)
        Me.Button5.TabIndex = 694
        Me.Button5.Text = "Test GPI5 Command"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(198, 189)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(854, 31)
        Me.TextBox5.TabIndex = 693
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 25)
        Me.Label6.TabIndex = 698
        Me.Label6.Text = "GPI6 command"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1074, 226)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(133, 31)
        Me.Button6.TabIndex = 697
        Me.Button6.Text = "Test GPI6 Command"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(198, 226)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(854, 31)
        Me.TextBox6.TabIndex = 696
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 25)
        Me.Label7.TabIndex = 701
        Me.Label7.Text = "GPI7 command"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1074, 263)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(133, 31)
        Me.Button7.TabIndex = 700
        Me.Button7.Text = "Test GPI7 Command"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(198, 263)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(854, 31)
        Me.TextBox7.TabIndex = 699
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 25)
        Me.Label8.TabIndex = 704
        Me.Label8.Text = "GPI8 command"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1074, 300)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(133, 31)
        Me.Button8.TabIndex = 703
        Me.Button8.Text = "Test GPI8 Command"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(198, 300)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(854, 31)
        Me.TextBox8.TabIndex = 702
        '
        'button_save
        '
        Me.button_save.Location = New System.Drawing.Point(1074, 337)
        Me.button_save.Name = "button_save"
        Me.button_save.Size = New System.Drawing.Size(133, 75)
        Me.button_save.TabIndex = 705
        Me.button_save.Text = "SAVE"
        Me.ToolTip1.SetToolTip(Me.button_save, "Saves the 8 GPIO command lines")
        Me.button_save.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(347, 425)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(71, 31)
        Me.TextBox9.TabIndex = 707
        Me.TextBox9.Text = "1"
        Me.TextBox9.Visible = False
        '
        'Botton_Save_GPIO
        '
        Me.Botton_Save_GPIO.Location = New System.Drawing.Point(120, 421)
        Me.Botton_Save_GPIO.Name = "Botton_Save_GPIO"
        Me.Botton_Save_GPIO.Size = New System.Drawing.Size(76, 75)
        Me.Botton_Save_GPIO.TabIndex = 708
        Me.Botton_Save_GPIO.Text = "SAVE settings"
        Me.Botton_Save_GPIO.UseVisualStyleBackColor = True
        Me.Botton_Save_GPIO.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(233, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 709
        Me.Label9.Text = "GPI USB Port:"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(204, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 20)
        Me.Label10.TabIndex = 710
        Me.Label10.Text = "Caspar IP Adress:"
        Me.Label10.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(347, 465)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(236, 31)
        Me.TextBox10.TabIndex = 711
        Me.TextBox10.Text = "localhost"
        Me.TextBox10.Visible = False
        '
        'button_settings
        '
        Me.button_settings.Location = New System.Drawing.Point(39, 421)
        Me.button_settings.Name = "button_settings"
        Me.button_settings.Size = New System.Drawing.Size(75, 75)
        Me.button_settings.TabIndex = 712
        Me.button_settings.Text = "settings"
        Me.ToolTip1.SetToolTip(Me.button_settings, "sets usb port from GPIO Interface and Caspar Server IP")
        Me.button_settings.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1074, 465)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(133, 41)
        Me.Button9.TabIndex = 713
        Me.Button9.Text = "EXIT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GPI_Status
        '
        Me.GPI_Status.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GPI_Status.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.GPI_Status.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.GPI_Status.Name = "GPI_Status"
        Me.GPI_Status.Size = New System.Drawing.Size(66, 23)
        Me.GPI_Status.Text = "GPI_Status"
        '
        'ri_data
        '
        Me.ri_data.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.ri_data.Name = "ri_data"
        Me.ri_data.Size = New System.Drawing.Size(42, 23)
        Me.ri_data.Text = "ri_data"
        '
        'CASPARCG_GPIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 538)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.button_settings)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Botton_Save_GPIO)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.button_save)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "CASPARCG_GPIO"
        Me.Text = "Caspar CG GPIO"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_GPI_1 As Timer
    Friend WithEvents Timer_GPI_2 As Timer
    Friend WithEvents Timer4_clear_CG_return As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ri_message As ToolStripStatusLabel
    Friend WithEvents ri_number As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label_connected As ToolStripStatusLabel
    Friend WithEvents GPI1 As ToolStripStatusLabel
    Friend WithEvents GPI2 As ToolStripStatusLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GPI3 As ToolStripStatusLabel
    Friend WithEvents GPI4 As ToolStripStatusLabel
    Friend WithEvents GPI5 As ToolStripStatusLabel
    Friend WithEvents GPI6 As ToolStripStatusLabel
    Friend WithEvents GPI7 As ToolStripStatusLabel
    Friend WithEvents GPI8 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents button_save As Button
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents GPIO_PORT As ToolStripStatusLabel
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Botton_Save_GPIO As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents button_settings As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents GPI_Status As ToolStripStatusLabel
    Friend WithEvents ri_data As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
End Class
