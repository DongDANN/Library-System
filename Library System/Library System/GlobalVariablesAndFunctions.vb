Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Module GlobalVariablesAndFunctions
    Public loggedInUsername As String
    Public forgotPasswordUsername As String

    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=librarydb;User ID=Ronald;Password=123")
    Public cmd As New SqlCommand
    Public sd As New SqlDataAdapter
    Public dt As New DataTable

End Module