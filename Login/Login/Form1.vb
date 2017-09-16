Public Class Form1

    Dim cadena As String 'variable global


    Public Sub comprueba()

        Dim usu As New Ususario(Tusuario.Text, TContra.Text)
        'MsgBox(usu.GetDni())
        'MsgBox(usu.GetContraseña())
        'MsgBox(usu.Verifica(usu.GetDni(), usu.GetContraseña()))
        If usu.Verifica(usu.GetDni(), usu.GetContraseña()) Then

            Label1.Visible = True
            Label1.Text = ("Verificando Usuario...")
            PBarra.Visible = True
            Timer1.Enabled = True
            Timer1.Interval = 100
            Button1.Enabled = False


        Else
            Label1.Visible = True
            Label1.Text = ("Verificando Usuario...")
            PBarra2.Visible = True
            Timer2.Enabled = True
            Timer2.Interval = 100
            Button1.Enabled = False

        End If



    End Sub

    Private Sub limpia()
        PBarra.Visible = False
        Tusuario.Clear()
        TContra.Clear()
        LIusu.Visible = False
        LIcontra.Visible = False
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick



        PBarra.Maximum = 100
        PBarra.Minimum = 0
        PBarra.Value = PBarra.Value + 5

        If PBarra.Value = 100 Then

            Ventana.Show()
            PBarra.Value = 0
            Timer1.Enabled = False
            Button1.Enabled = True
            Me.Close()

        End If
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PBarra2.Maximum = 100
        PBarra2.Minimum = 0
        PBarra2.Value = PBarra2.Value + 5

        If PBarra2.Value = 100 Then

            PBarra2.Value = 0
            Timer2.Enabled = False
            Button1.Enabled = True
            Label1.Visible = False
            PBarra2.Visible = False
            Call Form1_Load(sender, e)
            LIusu.Visible = True
            LIcontra.Visible = True
        End If
    End Sub



    '---boton--

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim res As MsgBoxResult
        comprueba()

    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click

        SplashScreen1.Close()
        Me.Close()
    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Tusuario.Text IsNot Nothing And TContra.Text IsNot Nothing Then
            limpia()
        End If


        Tusuario.Focus()
        TContra.Focus()
        'ingresamos el texto que queremos que figure como imagen al agua

        Tusuario.Text = "11223344"
        TContra.Text = "*********"
        'Textbox3.text = "Salario Mensual"

        'cambiamos el color a gris claro

        Tusuario.ForeColor = Color.Silver
        TContra.ForeColor = Color.Silver
        'Textbox3.ForeColor = Color.LightGray


        'Agregamos los eventos para el procedimiento GotfocusTexto

        AddHandler Tusuario.GotFocus, AddressOf GotfocusTexto
        AddHandler TContra.GotFocus, AddressOf GotfocusTexto
        'AddHandler TextBox3.GotFocus, AddressOf GotfocusTexto


        'Agregamos los eventos para el procedimiento LostfocusTexto

        AddHandler Tusuario.LostFocus, AddressOf LostfocusTexto
        AddHandler TContra.LostFocus, AddressOf LostfocusTexto
        'AddHandler TextBox3.LostFocus, AddressOf LostfocusTexto

    End Sub


    Private Sub GotfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
        'capturamos el texto que tenia
        cadena = sender.Text
        'borramos el texto del textbox
        sender.Text = ""
        'ponemos el color de la letra en negro
        sender.ForeColor = Color.Black
    End Sub

    Private Sub LostfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.Text = "" Then 'si salio del textbox sin poner nada
            sender.Text = cadena  'volverle a poner el texto que tenia
            sender.ForeColor = Color.Silver 'y poner la letra en gris
        End If

    End Sub






    'Private Sub GenerarPDF()
    'Dim oDoc As New iTextSharp.text.Document(PageSize.A4, 0, 0, 0, 0)
    'Dim pdfw As iTextSharp.text.pdf.PdfWriter
    'Dim cb As PdfContentByte
    'Dim fuente As iTextSharp.text.pdf.BaseFont
    'Dim NombreArchivo As String = "C:\ejemplo.pdf"
    'Try
    'pdfw = PdfWriter.GetInstance(oDoc, New FileStream(NombreArchivo, _
    'FileMode.Create, FileAccess.Write, FileShare.None))
    'Apertura del documento.
    'oDoc.Open()
    'cb = pdfw.DirectContent
    'Agregamos una pagina.
    'oDoc.NewPage()
    'Iniciamos el flujo de bytes.
    'cb.BeginText()
    'Instanciamos el objeto para la tipo de letra.
    'fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
    'Seteamos el tipo de letra y el tamaño.
    'cb.SetFontAndSize(fuente, 12)
    'Seteamos el color del texto a escribir.
    'cb.SetColorFill(iTextSharp.text.Color.BLACK)
    'Aqui es donde se escribe el texto.
    'Aclaracion: Por alguna razon la coordenada vertical siempre es tomada desde el borde inferior (de ahi que se calcule como "PageSize.A4.Height - 50")
    'cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Ejemplo basico con iTextSharp", 200, PageSize.A4.Height - 50, 0)
    'Fin del flujo de bytes.
    'cb.EndText()
    'Forzamos vaciamiento del buffer.
    'pdfw.Flush()
    'Cerramos el documento.
    'oDoc.Close()
    'Catch ex As Exception
    'Si hubo una excepcion y el archivo existe ...
    'If File.Exists(NombreArchivo) Then
    'Cerramos el documento si esta abierto.
    'Y asi desbloqueamos el archivo para su eliminacion.
    'If oDoc.IsOpen Then oDoc.Close()
    '... lo eliminamos de disco.
    'File.Delete(NombreArchivo)
    'End If
    'Throw New Exception("Error al generar archivo PDF (" &amp; ex.Message &amp; ")")
    'Finally
    'cb = Nothing
    'pdfw = Nothing
    'oDoc = Nothing
    'End Try
    'End Sub


End Class