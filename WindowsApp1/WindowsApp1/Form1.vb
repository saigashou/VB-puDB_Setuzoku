Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pClass1 As Class1 = New Class1
        Dim strSQL As String = "select * from Table"
        pClass1.pDB_Setuzoku(strSQL, Me.DataGridView1)
    End Sub
End Class
