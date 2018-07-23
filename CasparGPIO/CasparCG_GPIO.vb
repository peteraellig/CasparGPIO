Option Explicit On
Imports System.IO
Imports System.IO.Ports
Imports Casparobjects
Imports System.Xml


Public Class CASPARCG_GPIO

    'for Didi Kunz library
    Private _Caspar As CasparCG = New CasparCG()

    'variables for caspar ip and channels
    'variables for xml init file
    Public channel(10) As String
    Public xmltextfield(100) As String
    Public xmlnumfield(100) As Single
    Public xmlcolor(100) As String
    Public xmlchecked(100) As Boolean
    Dim IP As String
    Public kanal As Integer

    Dim connected As Integer = 0
    Dim ri As ReturnInfo

    'variable for filename of the initial settings (ip, color, channel)
    Public Shared filename As String = "C:\CasparGPIO\CasparGPIO_Data.xml"
    Public directory As String = "C:\CasparGPIO"

    Dim COMPort As New SerialPort
    Dim gpi1_pressed As Boolean = False
    Dim gpi2_pressed As Boolean = False
    Dim gpi3_pressed As Boolean = False
    Dim gpi4_pressed As Boolean = False
    Dim gpi5_pressed As Boolean = False
    Dim gpi6_pressed As Boolean = False
    Dim gpi7_pressed As Boolean = False
    Dim gpi8_pressed As Boolean = False
    Dim COMPort_NR As String


    Private Sub CASPARCG_GPIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill_xlm_variables()
        Read_Init()
        Connect_to_caspar()

        ' open com port for GPI Interface
        Open_COMPort()
        'set application info
        Me.Text = My.Application.Info.Title & " " & My.Application.Info.Version.ToString '+ " - " & My.Application.Info.Description
    End Sub

    Sub Fill_xlm_variables()
        'could not find another way as filling all variables with empty values, to avoid errors, replacing data with empty fields
        For i = 1 To 10
            channel(i) = "not used"
        Next
        For i = 1 To 100
            xmltextfield(i) = "not used"
            xmlnumfield(i) = 0
            xmlcolor(i) = "not used"
            xmlchecked(i) = False
        Next

        ' example data variables are filled for first time creating new xml file
        xmltextfield(1) = "PLAY 1-10 AMB CUT 0 Linear RIGHT LOOP"
        xmltextfield(2) = "PLAY 1-11 AMB CUT 0 Linear RIGHT LOOP"
        xmltextfield(3) = "clear 1"
        xmltextfield(4) = "stop 1-10"
        xmltextfield(5) = "stop 1-11"
        xmltextfield(6) = "blablabla"
        xmltextfield(7) = ""
        xmltextfield(8) = ""
        'textfield 9 is usb port from gpio interface
        xmltextfield(9) = "1"
        'textfield 10 is IP adress from caspar server
        xmltextfield(10) = "localhost"
    End Sub

    Sub Read_Init()
        ' checks directory
        If (Not System.IO.Directory.Exists(directory)) Then
            System.IO.Directory.CreateDirectory(directory)
        End If

        'if file not exits, create empty file
        If (Not System.IO.File.Exists(filename)) Then
            My.Computer.FileSystem.WriteAllText(filename, " ", True)
            IP = "localhost"
            channel(1) = "1"
            'System.Windows.Forms.MessageBox.Show("No Record has been Found")
            Write_Init()
        End If

        'fills all variables textfield out of Datafile
        Try
            Dim Contactlist As XDocument = XDocument.Load(filename)

            For Each contact As XElement In Contactlist...<GPIO>
                IP = contact.Element("IP")
                For i = 1 To 10
                    channel(i) = contact.Element("channel" + Trim(i))
                Next

                For i = 1 To 100
                    xmltextfield(i) = (contact.Element("textfield" + Trim(i)))
                    xmlnumfield(i) = contact.Element("numfield" + Trim(i))
                    xmlcolor(i) = contact.Element("color" + Trim(i))
                    xmlchecked(i) = contact.Element("checked" + Trim(i))
                Next
            Next
        Catch ex As System.IO.IOException
            MessageBox.Show("File nicht vorhanden")
        Catch ex As NullReferenceException
            MessageBox.Show("NullReferenceException: " & ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        Catch ex As Exception
        End Try
        Set_labels()
    End Sub

    Sub Set_labels()
        For i = 1 To 100
            If Trim(xmltextfield(i)) = "not used" Then xmltextfield(i) = ""
        Next

        TextBox1.Text = xmltextfield(1)
        TextBox2.Text = xmltextfield(2)
        TextBox3.Text = xmltextfield(3)
        TextBox4.Text = xmltextfield(4)
        TextBox5.Text = xmltextfield(5)
        TextBox6.Text = xmltextfield(6)
        TextBox7.Text = xmltextfield(7)
        TextBox8.Text = xmltextfield(8)

        TextBox9.Text = xmlnumfield(1)

        TextBox10.Text = IP

        COMPort_NR = xmlnumfield(1)
        GPIO_PORT.Text = COMPort_NR

        ri_data.Text = ""
        ri_number.Text = ""
        ri_message.Text = ""
    End Sub

    Sub Write_Init()
        'actually only needed to write a new database file, if it not exist
        Dim settings As New XmlWriterSettings()
        settings.Indent = True
        ' Initialize the XmlWriter.
        Dim XmlWrt As XmlWriter = XmlWriter.Create(filename, settings)
        With XmlWrt
            ' Write the Xml declaration.
            .WriteStartDocument()
            ' Write a comment.
            .WriteComment("XML Database.")
            .WriteComment("for Caspar GPIO, structure of this database is a generic one, used also for other programs")
            ' Write the root element.
            .WriteStartElement("Data")
            ' Start Caspar Dataset
            .WriteStartElement("GPIO")

            .WriteComment("IP for Caspar Server")
            .WriteStartElement("IP")
            .WriteString(IP.ToString())
            .WriteEndElement()

            .WriteComment("Channel Numbers for 10 Channels")
            For i = 1 To 10
                .WriteStartElement("channel" + Trim(Str(i)))
                .WriteString(channel(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("Numbers (for example buttons, names etc.")
            For i = 1 To 100
                If Trim(xmltextfield(i)) = "" Then xmltextfield(i) = "not used"
                .WriteStartElement("textfield" + Trim(Str(i)))
                .WriteString(xmltextfield(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("Numbers (for example xy-pos etc.")
            For i = 1 To 100
                .WriteStartElement("numfield" + Trim(Str(i)))
                .WriteString(xmlnumfield(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("colors (for example buttons, fonts etc.) ")
            For i = 1 To 100
                .WriteStartElement("color" + Trim(Str(i)))
                .WriteString(xmlcolor(i).ToString())
                .WriteEndElement()
            Next
            .WriteComment("Boolean (for example checkbox=true etc.) ")
            For i = 1 To 100
                .WriteStartElement("checked" + Trim(Str(i)))
                .WriteString(xmlchecked(i).ToString())
                .WriteEndElement()
            Next
            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()
        End With
        Set_labels()
    End Sub

    Sub Connect_to_caspar()
        'connect to caspar.....
        If connected = 0 Then
            Try
                _Caspar.Connect(IP)
                Label_connected.Text = "connected"
                Label_connected.BackColor = Color.LightGreen
                Label_connected.ForeColor = Color.Black
                connected = 1
                'if error (caspar not startet or not reachable)
            Catch ex As Exception
                MsgBox("Caspar starten")
                Label_connected.Text = "not connected"
                Label_connected.BackColor = Color.Red
                Label_connected.ForeColor = Color.White
            End Try
        End If
    End Sub

    Private Sub Label_connected_Click(sender As Object, e As EventArgs) Handles Label_connected.Click
        'connects or disconnects caspar with click of the connected-status-field in the BOTTOM STATUSBAR
        If connected = 1 Then
            _Caspar.Disconnect()
            connected = 0
            Label_connected.Text = "not connected"
            Label_connected.BackColor = Color.Red
            Label_connected.ForeColor = Color.White
        Else
            _Caspar.Connect(IP)
            connected = 1
            Label_connected.Text = "connected"
            Label_connected.BackColor = Color.LightGreen
            Label_connected.ForeColor = Color.Black
        End If
    End Sub

    Sub Return_CG(Caspar_Command)
        ' can display a return information from Caspar

        ' first the variable ri as ReturnInfo has to be declared in the main declarations: Dim ri As ReturnInfo
        ' this sub,  Return_CG(Caspar_Command), takes the caspar string and returns errors as message box
        ' example: Return_CG(_Caspar.CG_Add(channel1, 20, "handball/hb_lineup", tmpl, True))

        ' if you dont want return infos, just use the caspar command allone
        ' example: _Caspar.CG_Add(channel1, 20, "handball/hb_lineup", tmpl, True)

        ri = Caspar_Command
        'ri returns ri.Message, ri.Data, ri.Nubmer

        'bottom statusbar display 
        ri_message.Text = ri.Message
        ri_data.Text = ri.Data
        ri_number.Text = ri.Number

        'errors will call up a messagebox
        Select Case ri.Number
            Case 100  'Information about an event. ???
            Case 101  'Information about an event. A line of data Is being returned. ???
         'Successful        
            Case 200    'OK	- The command has been executed And several lines of data (seperated by \r\n) are being returned (terminated with an additional \r\n)
            Case 201    'OK	- The command has been executed And data (terminated by \r\n) Is being returned.
            Case 202    'OK	- The command has been executed.
         '400 ERROR	- Command Not understood
            Case 400
                MsgBox("400 ERROR	- Command Not understood")
            Case 401
                MsgBox("401 [command] ERROR	- Illegal video_channel")
            Case 402
                MsgBox("402 [command] ERROR	- Parameter missing")
            Case 403
                MsgBox("403 [command] ERROR	- Illegal parameter")
            Case 404
                MsgBox("404 [command] ERROR	- Media file Not found")
        'Server Error
            Case 500
                MsgBox("500 FAILED	- Internal server error")
            Case 501
                MsgBox("501 [command] FAILED	- Internal server error")
            Case 502
                MsgBox("502 [command] FAILED	- Media file unreadable")
        End Select
    End Sub

    Sub Open_COMPort()
        ' Close the serial port before exiting
        If (COMPort.IsOpen) Then
            COMPort.Close()
        End If

        'gpi com port open
        COMPort.PortName = "COM" + COMPort_NR
        GPI_Status.BackColor = Color.Silver
        GPI_Status.ForeColor = Color.Black
        GPI_Status.Text = "COM Port " + COMPort_NR + " for GPI Interface"
        On Error Resume Next
        COMPort.Open()

        If Err.Number > 0 Then
            GPI_Status.BackColor = Color.Red
            GPI_Status.ForeColor = Color.White
            GPI_Status.Text = "Could not open COM Port " + COMPort_NR + " for GPI Interface"
            On Error GoTo 0
        End If
    End Sub

    Sub Gpi1_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 0 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 0" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the gpi1_pressed value grants, that if the key is pressed the desired function only runs one time
                If gpi1_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI1.BackColor = color.RED
                    GPI1.Text = ("GPI1=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button1.PerformClick()
                    '____________________here ends the caspar event___________________________
                    gpi1_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI1.BackColor = Color.White
                GPI1.Text = ("GPI1=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                gpi1_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Sub Gpi2_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 1 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 1" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the gpi2_ressed value grants, that if the key is pressed the desired function only runs one time
                If gpi2_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI2.BackColor = Color.Red
                    GPI2.Text = ("GPI2=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button2.PerformClick()
                    '____________________here ends the caspar event___________________________
                    gpi2_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI2.BackColor = Color.White
                GPI2.Text = ("GPI2=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                gpi2_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Sub Gpi3_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 0 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 0" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the GPI3_pressed value grants, that if the key is pressed the desired function only runs one time
                If gpi3_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI3.BackColor = Color.Red
                    GPI3.Text = ("GPI3=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button3.PerformClick()
                    '____________________here ends the caspar event___________________________
                    gpi3_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI3.BackColor = Color.White
                GPI3.Text = ("GPI3=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                gpi3_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Sub GPI4_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 0 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 0" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the GPI4_pressed value grants, that if the key is pressed the desired function only runs one time
                If gpi4_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI4.BackColor = Color.Red
                    GPI4.Text = ("GPI4=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button1.PerformClick()
                    '____________________here ends the caspar event___________________________
                    gpi4_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI4.BackColor = Color.White
                GPI4.Text = ("GPI4=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                gpi4_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Sub GPI5_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 0 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 0" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the GPI5_pressed value grants, that if the key is pressed the desired function only runs one time
                If GPI5_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI5.BackColor = Color.Red
                    GPI5.Text = ("GPI5=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button1.PerformClick()
                    '____________________here ends the caspar event___________________________
                    GPI5_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI5.BackColor = Color.White
                GPI5.Text = ("GPI5=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                GPI5_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Sub GPI6_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 0 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 0" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the GPI6_pressed value grants, that if the key is pressed the desired function only runs one time
                If GPI6_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI6.BackColor = Color.Red
                    GPI6.Text = ("GPI6=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button1.PerformClick()
                    '____________________here ends the caspar event___________________________
                    GPI6_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI6.BackColor = Color.White
                GPI6.Text = ("GPI6=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                GPI6_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Sub GPI7_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 0 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 0" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the GPI7_pressed value grants, that if the key is pressed the desired function only runs one time
                If GPI7_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI7.BackColor = Color.Red
                    GPI7.Text = ("GPI7=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button1.PerformClick()
                    '____________________here ends the caspar event___________________________
                    GPI7_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI7.BackColor = Color.White
                GPI7.Text = ("GPI7=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                GPI7_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Sub GPI8_status()
        'this function is triggered every 50 miliseconds from a timer, Timer_GPI_1
        'the 50 miliseconds from the timer helps to debounce the button
        'if your button is cheap and bounces, then add "System.Threading.Thread.Sleep(50)" in the section 'all in here runs if the button is pressed

        'variable to read GPI data from comport
        Dim readData As String

        'checks if comport is open
        If COMPort.IsOpen Then
            'Discard any existing data from the receive buffer. This is an important step
            COMPort.DiscardInBuffer()
            'command to read GPI 0 (0-7), then add a return (CHR$13) to send it to the comport
            COMPort.Write("gpio read 0" + Chr(13))
            'wait 10 miliseconds , COMports are not that fast :-)
            System.Threading.Thread.Sleep(10)
            'store return value in readData
            readData = COMPort.ReadExisting
            '0 = pressed, 1 = released

            If Mid(readData, 14, 1) = "0" Then
                'the GPI8_pressed value grants, that if the key is pressed the desired function only runs one time
                If GPI8_pressed = False Then
                    'all in here runs if the button is pressed
                    GPI8.BackColor = Color.Red
                    GPI8.Text = ("GPI8=" + Mid(readData, 14, 1))
                    '____________________here comes the caspar event___________________________
                    Button1.PerformClick()
                    '____________________here ends the caspar event___________________________
                    GPI8_pressed = True '(rising pulse)
                End If
            Else
                'all in here runs if the button is released
                GPI8.BackColor = Color.White
                GPI8.Text = ("GPI8=" + Mid(readData, 14, 1))
                '____________________here comes the caspar event___________________________

                '____________________here ends the caspar event___________________________
                GPI8_pressed = False ' (decreasing pulse)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox1.Text) > "" Then Return_CG(_Caspar.Execute(TextBox1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox2.Text) > "" Then Return_CG(_Caspar.Execute(TextBox2.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox3.Text) > "" Then Return_CG(_Caspar.Execute(TextBox3.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox4.Text) > "" Then Return_CG(_Caspar.Execute(TextBox4.Text))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox5.Text) > "" Then Return_CG(_Caspar.Execute(TextBox5.Text))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox6.Text) > "" Then Return_CG(_Caspar.Execute(TextBox6.Text))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox7.Text) > "" Then Return_CG(_Caspar.Execute(TextBox7.Text))
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Dim tmpl As Template = New Template
        If Trim(TextBox8.Text) > "" Then Return_CG(_Caspar.Execute(TextBox8.Text))
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles button_save.Click
        For i = 1 To 8
            xmltextfield(i) = Controls.Item("TextBox" + Trim(Str(i))).Text
        Next

        Write_Init()
    End Sub

    Private Sub Botton_Save_GPIO_Click(sender As Object, e As EventArgs) Handles Botton_Save_GPIO.Click
        xmlnumfield(1) = Trim(TextBox9.Text)
        IP = Trim(TextBox10.Text)
        Write_Init()
        GPIO_PORT.Text = Trim(TextBox9.Text)
        Label9.Visible = False
        Label10.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        Botton_Save_GPIO.Visible = False
        button_settings.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles button_settings.Click
        Label9.Visible = True
        Label10.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        Botton_Save_GPIO.Visible = True
        button_settings.Visible = False
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        If MessageBox.Show("EXIT ?", "EXIT", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub Timer4_clear_CG_return_Tick(sender As Object, e As EventArgs) Handles Timer4_clear_CG_return.Tick
        Timer4_clear_CG_return.Interval = 5000
        ri_data.Text = ""
        ri_number.Text = ""
        ri_message.Text = ""
    End Sub

    Private Sub Timer_GPI_1_Tick(sender As Object, e As EventArgs) Handles Timer_GPI_1.Tick
        'timer for calling the status of GPI 1 input
        Gpi1_status()
        Gpi2_status()
        Gpi3_status()
        GPI4_status()
        GPI5_status()
        GPI6_status()
        GPI7_status()
        GPI8_status()
    End Sub

    Private Sub Timer_GPI_2_Tick(sender As Object, e As EventArgs) Handles Timer_GPI_2.Tick
        'timer for calling the status of GPI 1 input
        'Gpi2_status()
    End Sub
End Class
