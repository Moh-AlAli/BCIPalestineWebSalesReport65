

Public Class Scrfromcust

    Private i As Integer
    Private j As Integer
    'Private os As New Session
    'Private adblink As DBLink

    Private Sub Butcan_Click(sender As Object, e As EventArgs) Handles Butcan.Click
        Close()
        Salessearch.bffind.Visible = True
    End Sub

    Private Sub fromcust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'os.Init("", "XX", "XX0001", "60A")
            'os.OpenWin("", "", "", SalesItem.compid, System.DateTime.Now, 0)
            ''os.Open("ADMIN", "ADMIN", SalesItem.compid, System.DateTime.Now, 0)
            'dblink = os.OpenDBLink(DBLinkType.Company, DBLinkFlags.ReadOnly)


            'Dim arv As AccpacView
            'arv = SalesItem.xdbcom.OpenView2("AR0024")
            'Dim arcusds As DataSet = New DataSet("AR")
            'Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            'Dim name As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            'Dim id As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
            '    row("IDCUST") = cid
            '    row("NAMECUST") = cn
            '    arcusds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim arcusds As New DataSet
            Dim c As New Clsfunct

            arcusds = c.customer("", OPCompany.compid)
            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "IDCUST"
            icl.Name = "clidc"
            icl.HeaderText = "Customer Number"
            icl.Width = 150
            DGfcus.Columns.Add(icl)
            Dim ncl As New DataGridViewTextBoxColumn
            ncl.DataPropertyName = "NAMECUST"
            ncl.Name = "colnc"
            ncl.HeaderText = "Customer Name"
            ncl.Width = 190
            DGfcus.Columns.Add(ncl)
            DGfcus.DataSource = arcusds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButSel_Click(sender As Object, e As EventArgs) Handles ButSel.Click
        Try



            'Dim arv As AccpacView
            'arv = custstatement.xdbcom.OpenView2("AR0024")
            Dim searfil As String = ""
   If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = " Where NAMECUST Like N'%" + Txtname.Text + "%' And IDCUST Like N'%" + Txtcusno.Text + "%' "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = " Where NAMECUST like N'%" + Txtname.Text + "%' "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = " Where IDCUST like N'%" + Txtcusno.Text + "%' "
            End If

            'arv.Browse(searfil, True)
            Dim arcusds As New DataSet
            Dim c As New Clsfunct

            arcusds = c.customer(searfil, OPCompany.compid)

            'Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            'Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
            '    row("IDCUST") = cid
            '    row("NAMECUST") = cn
            '    arcusds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop

            Dim dt As DataTable = arcusds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            Salessearch.txtfrmcus.Text = dt.Rows(i)(0)
            Salessearch.bffind.Visible = True
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DGfcus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGfcus.CellContentClick

        Try



            'Dim arv As AccpacView
            'arv = custstatement.xdbcom.OpenView2("AR0024")
            Dim searfil As String = ""

            If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = " Where NAMECUST Like N'%" + Txtname.Text + "%' And IDCUST Like N'%" + Txtcusno.Text + "%' "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = " Where NAMECUST like N'%" + Txtname.Text + "%' "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = " Where IDCUST like N'%" + Txtcusno.Text + "%' "
            End If

            'arv.Browse(searfil, True)
            Dim arcusds As New DataSet
            Dim c As New Clsfunct

            arcusds = c.customer(searfil, OPCompany.compid)

            'Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            'Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
            '    row("IDCUST") = cid
            '    row("NAMECUST") = cn
            '    arcusds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim dt As DataTable = arcusds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex()
            j = DGfcus.CurrentCell.ColumnIndex
            Salessearch.txtfrmcus.Text = dt.Rows(i)(0)
            Salessearch.bffind.Visible = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tocust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salessearch.btfind.Visible = True
    End Sub

    Private Sub Txtcusno_TextChanged(sender As Object, e As EventArgs) Handles Txtcusno.TextChanged
        Try


            'Dim arv As AccpacView
            'arv = custstatement.xdbcom.OpenView2("AR0024")
            Dim searfil As String = ""
   If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = " Where NAMECUST Like N'%" + Txtname.Text + "%' And IDCUST Like N'%" + Txtcusno.Text + "%' "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = " Where NAMECUST like N'%" + Txtname.Text + "%' "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = " Where IDCUST like N'%" + Txtcusno.Text + "%' "
            End If
            'arv.Browse(searfil, True)
            Dim arcusds As New DataSet
            Dim c As New Clsfunct

            arcusds = c.customer(searfil, OPCompany.compid)

            'Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            'Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
            '    row("IDCUST") = cid
            '    row("NAMECUST") = cn
            '    arcusds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            DGfcus.DataSource = arcusds.Tables(0)
            '   End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Txtname_TextChanged(sender As Object, e As EventArgs) Handles Txtname.TextChanged

        Try



            'Dim arv As AccpacView
            'arv = custstatement.xdbcom.OpenView2("AR0024")
            Dim searfil As String = ""

              If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = " Where NAMECUST Like N'%" + Txtname.Text + "%' And IDCUST Like N'%" + Txtcusno.Text + "%' "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = " Where NAMECUST like N'%" + Txtname.Text + "%' "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = " Where IDCUST like N'%" + Txtcusno.Text + "%' "
            End If
            'arv.Browse(searfil, True)
            Dim arcusds As New DataSet
            Dim c As New Clsfunct

            arcusds = c.customer(searfil, OPCompany.compid)

            'Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            'Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
            '    row("IDCUST") = cid
            '    row("NAMECUST") = cn
            '    arcusds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            DGfcus.DataSource = arcusds.Tables(0)
            '    End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Txtname_MouseLeave(sender As Object, e As EventArgs) Handles Txtname.MouseLeave
        Try



            'Dim arv As AccpacView
            'arv = custstatement.xdbcom.OpenView2("AR0024")
            Dim searfil As String = ""

          If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = " Where NAMECUST Like N'%" + Txtname.Text + "%' And IDCUST Like N'%" + Txtcusno.Text + "%' "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = " Where NAMECUST like N'%" + Txtname.Text + "%' "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = " Where IDCUST like N'%" + Txtcusno.Text + "%' "
            End If
            'arv.Browse(searfil, True)
            Dim arcusds As New DataSet
            Dim c As New Clsfunct

            arcusds = c.customer(searfil, OPCompany.compid)

            'Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            'Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
            '    row("IDCUST") = cid
            '    row("NAMECUST") = cn
            '    arcusds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            DGfcus.DataSource = arcusds.Tables(0)
            '    End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Txtcusno_MouseLeave(sender As Object, e As EventArgs) Handles Txtcusno.MouseLeave
        Try
            ' If Txtcusno.Text <> Nothing Then


            'Dim arv As AccpacView
            'arv = custstatement.xdbcom.OpenView2("AR0024")
            Dim searfil As String = ""
   If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = " Where NAMECUST Like N'%" + Txtname.Text + "%' And IDCUST Like N'%" + Txtcusno.Text + "%' "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = " Where NAMECUST like N'%" + Txtname.Text + "%' "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = " Where IDCUST like N'%" + Txtcusno.Text + "%' "
            End If
            'arv.Browse(searfil, True)
            Dim arcusds As New DataSet
            Dim c As New Clsfunct

            arcusds = c.customer(searfil, OPCompany.compid)

            'Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            'Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
            '    row("IDCUST") = cid
            '    row("NAMECUST") = cn
            '    arcusds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            DGfcus.DataSource = arcusds.Tables(0)
            '    End If
        Catch ex As Exception
        End Try

    End Sub
End Class