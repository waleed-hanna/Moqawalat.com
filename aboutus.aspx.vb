
Partial Class About_Us
    Inherits System.Web.UI.Page
    Dim CountryIDD As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim txt As HtmlInputText = DirectCast(Master.FindControl("txtName"), HtmlInputText)
        If txt.Value = "" Then
            Dim CountryI As String = Convert.ToString(Session("CountryID"))
            txt.Value = CountryI
        End If
        Dim txtlan As HtmlInputText = DirectCast(Master.FindControl("txtLang"), HtmlInputText)
        If txtlan.Value = "" Then
            Dim Langid As String = Convert.ToString(Session("LangID"))
            txtlan.Value = Langid
        End If
        Dim Languageid As String
        Languageid = txtlan.Value
        If Languageid = "1" Then
            Session("LangID") = 1
        End If
        If Languageid = "2" Then
            Session("LangID") = 2
        End If

        Dim countryid As String
        countryid = txt.Value
        If countryid = "1" Then
            Session("CountryID") = 1
        End If
        If countryid = "2" Then
            Session("CountryID") = 2
        End If
        If countryid = "3" Then
            Session("CountryID") = 3
        End If
        If countryid = "4" Then
            Session("CountryID") = 4
        End If
        If countryid = "5" Then
            Session("CountryID") = 5
        End If
        If countryid = "" Then
            Session("CountryID") = 1
        End If
        CountryIDD = Convert.ToString(Session("CountryID"))
        If Not Page.IsPostBack Then
            Dim str As String = File.ReadAllText(Server.MapPath("includes/aboutus.asp"))
            'str = Replace(str, "src=""", "src=""" & System.Configuration.ConfigurationManager.AppSettings("virtualPathCMS") & "")
            ltl.Text = str

        End If
    End Sub
End Class
