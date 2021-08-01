Public Class Class1
    '*****************************************************
    '   DB接続管理
    '*****************************************************
    ''' <summary>
    ''' DBへ追加更新し条件表示を行う
    ''' </summary>
    ''' <param name="strSQL">SQL文</param>
    ''' <param name="optDgv">DataGrid</param>
    Public Sub pDB_Setuzoku(ByVal strSQL As String, ByVal optDgv As DataGridView)
        '接続用変数の定義
        'ADO.NETの仕組みを使います。
        Dim strConnectSQL As String
        Dim SQLDS As New DataSet()

        strConnectSQL = System.Configuration.ConfigurationManager.ConnectionStrings(
                        "DB設定").ConnectionString

        Try

            Dim SQLDA As New MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, strConnectSQL)

            'データセットに格納します。
            SQLDA.Fill(SQLDS, "table")

            'データグリッドビューのデータソースを設定
            optDgv.DataSource = SQLDS.Tables("table")

        Catch ex As Exception
            MessageBox.Show("DB内エラーです。以下を確認して下さい。" + vbNewLine + ex.Message)
        End Try



    End Sub
End Class
