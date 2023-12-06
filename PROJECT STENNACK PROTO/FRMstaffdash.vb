Public Class FRMstaffdash


    Private Sub FRMstaffdash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentMonth As String = DateTime.Now.ToString("MMMM")      'finds the current month
        lblstaffheading2.Text = $"Month: {currentMonth}"      'displays current month in the label 
    End Sub
End Class