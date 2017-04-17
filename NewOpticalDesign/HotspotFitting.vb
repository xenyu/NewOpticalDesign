Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.ComponentModel
Imports System.Text
Imports System.Threading

Public Class HotspotFitting

    Public UploadOpenFileDialog As OpenFileDialog = New OpenFileDialog
    Public dt As DataTable = New DataTable()
    Public dt1 As DataTable = New DataTable()
    Private nc As New NewClass()
    
    Private Sub HotspotFitting_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThreadPool.SetMinThreads(2, 5)
        ThreadPool.SetMaxThreads(4, 10)
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        UploadOpenFileDialog.InitialDirectory = "" & getInitialDirectory() & ""
        UploadOpenFileDialog.Filter = "CSV Files (*.csv)|*.csv" '只能上傳csv檔
        UploadOpenFileDialog.RestoreDirectory = True
        UploadOpenFileDialog.FilterIndex = 2

        If UploadOpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ImportdataTextBox.Text = UploadOpenFileDialog.FileName

            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf goinput))
        End If
    End Sub

    Private Sub goinput()
        Try
            dt.Clear()
            '如果data table裡有資料，將data table裡的欄位去除
            If dt.Columns.Count > 0 Then
                For b = 0 To dt.Columns.Count - 1
                    dt.Columns.RemoveAt(0)
                Next
            End If

            '將載入的檔案分行放進query裡
            Dim query = From line In File.ReadAllLines(UploadOpenFileDialog.FileName) _
                                             Let record = line.Split(CChar("vbCrLf")) _
                                             Select line

            Dim dtcount As Integer = 0

            For Each row In query
                Dim nArray() As String = row.Split(CChar(","))
                Dim count As Integer = nArray.Count
                Dim Newrow As DataRow = dt.NewRow

                For i = 0 To count - 1
                    If dtcount = 0 Then
                        dt.Columns.Add("" & i + 1 & "", GetType(Double)) '新增data table欄位
                        dt1.Columns.Add("" & i + 1 & "", GetType(Double))
                    End If

                    Newrow(i) = Math.Round(CDbl(nArray(i)), 2)
                Next

                dt.Rows.Add(Newrow) '新增一行資料
                dtcount = dtcount + 1

                Dim mi As MyInvoke = New MyInvoke(AddressOf DisplayDataGridView)
                Invoke(mi)
            Next

            Resample()
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Delegate Sub MyInvoke()
    Private Sub DisplayDataGridView() '

    End Sub

    Private Sub ReSampleButton_Click(sender As Object, e As EventArgs) Handles ReSampleButton.Click
        If dt.Rows.Count > 0 Then
            Resample()
        End If
    End Sub

    Private Sub Resample() '重新選取總顯示行數
        Dim newdt As DataTable = dt.Clone() '複製新dt
        Dim rows As DataRow() = dt.Select("1=1") '選取所有資料

        For j = 0 To CInt(rowTextBox.Text) - 1
            newdt.ImportRow(DirectCast(rows(j), DataRow)) '將資料載入新dt
        Next

        DataGridView1.DataSource = newdt
        DataGridView1.CurrentRow.Selected = False

        For Each col In DataGridView1.Columns
            col.sortmode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    '點選資料行時，顯示該行的曲線圖
    Private Sub DataGridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseUp
        Chart1.Series.Clear()
        Dim count As Integer = 1

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim series1 As Series = New Series("Series" & count & "", 1000)

            Select Case row.Index '設定選擇那行，會有不同顏色
                Case 0
                    series1.Color = Color.Red
                Case 1
                    series1.Color = Color.Orange
                Case 2
                    series1.Color = Color.YellowGreen
                Case 3
                    series1.Color = Color.Green
                Case 4
                    series1.Color = Color.Blue
                Case 5
                    series1.Color = Color.DarkBlue
                Case 6
                    series1.Color = Color.Purple
                Case 7
                    series1.Color = Color.Gray
                Case Else
                    series1.Color = Color.Cyan
            End Select

            series1.ChartType = SeriesChartType.Spline
            series1.BorderWidth = 2

            For i = 1 To DataGridView1.Columns.Count '列出曲線上每一點
                series1.Points.AddXY(i, DataGridView1.Rows(row.Index).Cells(i - 1).Value)
            Next

            Chart1.Series.Add(series1) '畫線
            count = count + 1
        Next
    End Sub

    'Upper Fitting
    Private Sub FittingButton1_Click(sender As Object, e As EventArgs) Handles FittingButton1.Click
        Try
            Check()

            '計算取hotspot的位置
            If CheckBox1.Checked = True Then '選擇亮LED在前，跳到fitline1
                Chart1.Series.Clear()
                DataGridView1_MouseUp(sender, e)

                Dim series2 As Series = New Series("Fitting", 1000)
                series2.ChartType = SeriesChartType.Spline
                series2.BorderWidth = 2
                series2.Color = Color.Chartreuse

                fitline1(DataGridView1.SelectedRows(0).Index, "upper")

                For j = 0 To DataGridView1.Columns.Count - 1
                    series2.Points.AddXY(j, dt1(0)(j))
                Next

                Chart1.Series.Add(series2)
                dt1.Clear()
            Else '選擇亮在LED間，跳到fitline2
                Chart1.Series.Clear()
                DataGridView1_MouseUp(sender, e)

                Dim series2 As Series = New Series("Fitting", 1000)
                series2.ChartType = SeriesChartType.Spline
                series2.BorderWidth = 2
                series2.Color = Color.Chartreuse

                fitline2(DataGridView1.SelectedRows(0).Index, "upper")

                For j = 1 To DataGridView1.Columns.Count
                    series2.Points.AddXY(j, dt1(0)(j - 1))
                Next

                Chart1.Series.Add(series2)
                dt1.Clear()
            End If

            Dim button As Button = FittingButton1
            changecolor(button, 1) '點選後變更按鈕的顏色
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    'middle fitting
    Private Sub FittingButton2_Click(sender As Object, e As EventArgs) Handles FittingButton2.Click
        Try
            Chart1.Series.Clear()
            DataGridView1_MouseUp(sender, e)
            Dim series2 As Series = New Series("Fitting", 1000)
            series2.ChartType = SeriesChartType.Spline
            series2.BorderWidth = 2
            series2.Color = Color.LightSeaGreen

            fitmiddle(DataGridView1.SelectedRows(0).Index)

            For j = 1 To DataGridView1.Columns.Count
                series2.Points.AddXY(j, dt1(0)(j - 1))
            Next

            Chart1.Series.Add(series2)
            dt1.Clear()

            Dim button As Button = FittingButton2
            changecolor(button, 2) '點選後變更按鈕的顏色
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    'lower fitting
    Private Sub FittingButton3_Click(sender As Object, e As EventArgs) Handles FittingButton3.Click
        Try
            Check()

            If CheckBox1.Checked = True Then '選擇亮LED在前，跳到fitline1
                Chart1.Series.Clear()
                DataGridView1_MouseUp(sender, e)

                Dim series2 As Series = New Series("Fitting", 1000)
                series2.ChartType = SeriesChartType.Spline
                series2.BorderWidth = 2
                series2.Color = Color.DarkOliveGreen

                fitline1(DataGridView1.SelectedRows(0).Index, "lower")

                For j = 0 To DataGridView1.Columns.Count - 1
                    series2.Points.AddXY(j, dt1(0)(j))
                Next

                Chart1.Series.Add(series2)
                dt1.Clear()
            Else '選擇亮在LED間，跳到fitline2
                Chart1.Series.Clear()
                DataGridView1_MouseUp(sender, e)

                Dim series2 As Series = New Series("Fitting", 1000)
                series2.ChartType = SeriesChartType.Spline
                series2.BorderWidth = 2
                series2.Color = Color.DarkOliveGreen

                fitline2(DataGridView1.SelectedRows(0).Index, "lower")

                For j = 1 To DataGridView1.Columns.Count
                    series2.Points.AddXY(j, dt1(0)(j - 1))
                Next

                Chart1.Series.Add(series2)
                dt1.Clear()
            End If

            Dim button As Button = FittingButton3
            changecolor(button, 3) '點選後變更按鈕的顏色
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TrackbarValueTextBox.Text = TrackBar1.Value '使用者選擇曲線平滑度
    End Sub

    Private Sub fitline1(ByVal row As Integer, ByVal category As String)
        Try
            Dim info As Integer
            Dim s As spline1dinterpolant = New XAlglib.spline1dinterpolant()
            Dim rep As spline1dfitreport = New XAlglib.spline1dfitreport()
            Dim rho As Double = TrackBar1.Value

            Dim pitchGrid As Integer = nc.GetPitchGrid(CDbl(BluwidthTextBox.Text), CDbl(LEDpitchTextBox.Text), DataGridView1.Columns.Count)
            Dim edgeGrid As Integer = nc.GetEdgeGrid(CDbl(BluwidthTextBox.Text), CDbl(LEDpitchTextBox.Text), CDbl(LEDnumberTextBox.Text), DataGridView1.Columns.Count)

            Dim stage As Integer = 1
            Dim count As Integer = CInt(LEDnumberTextBox.Text)
            Dim x(count + 3) As Double, y(count + 3) As Double

            x(0) = CDbl(0)
            y(0) = CDbl(DataGridView1.Rows(row).Cells(0).Value)

            For i = 1 To count + 3
                Select Case i
                    Case 1
                        x(i) = CDbl(i)
                        y(i) = CDbl(DataGridView1.Rows(row).Cells(i - 1).Value)
                    Case 2
                        x(i) = CDbl(i)
                        y(i) = CDbl(DataGridView1.Rows(row).Cells(i - 1).Value)
                        stage = stage + edgeGrid - 1
                    Case count + 2
                        x(count + 2) = CDbl(DataGridView1.Columns.Count - 1)
                        y(count + 2) = CDbl(DataGridView1.Rows(row).Cells(DataGridView1.Columns.Count - 2).Value)
                    Case count + 3
                        x(count + 3) = CDbl(DataGridView1.Columns.Count)
                        y(count + 3) = CDbl(DataGridView1.Rows(row).Cells(DataGridView1.Columns.Count - 1).Value)
                    Case Else
                        Dim max As Double = 0
                        Dim min As Double = 100
                        Dim pos As Integer = 0

                        For m = stage - 2 To stage + 2
                            If max < CDbl(DataGridView1.Rows(row).Cells(m).Value) Then
                                max = CDbl(DataGridView1.Rows(row).Cells(m).Value)
                                pos = m
                            End If

                            If min > CDbl(DataGridView1.Rows(row).Cells(m).Value) Then
                                min = CDbl(DataGridView1.Rows(row).Cells(m).Value)
                                pos = m
                            End If
                        Next m

                        Select Case category
                            Case "upper"
                                x(i) = pos
                                y(i) = max
                            Case "lower"
                                x(i) = pos
                                y(i) = min
                        End Select
                        stage = stage + pitchGrid
                End Select
            Next

            XAlglib.spline1dfitpenalized(x, y, 50, rho, info, s, rep)
            Dim Newrow As DataRow = dt1.NewRow

            For j = 1 To DataGridView1.Columns.Count
                Newrow(j - 1) = CDbl(XAlglib.spline1dcalc(s, j))
            Next

            dt1.Rows.Add(Newrow)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub fitline2(ByVal row As Integer, ByVal category As String)
        Try
            Dim info As Integer
            Dim s As spline1dinterpolant = New XAlglib.spline1dinterpolant()
            Dim rep As spline1dfitreport = New XAlglib.spline1dfitreport()
            Dim rho As Double = TrackBar1.Value

            Dim pitchGrid As Integer = nc.GetPitchGrid(CDbl(BluwidthTextBox.Text), CDbl(LEDpitchTextBox.Text), DataGridView1.Columns.Count)
            Dim edgeGrid As Integer = nc.GetEdgeGrid(CDbl(BluwidthTextBox.Text), CDbl(LEDpitchTextBox.Text), CDbl(LEDnumberTextBox.Text), DataGridView1.Columns.Count)

            Dim stage As Integer = 1
            Dim count As Integer = CInt(LEDnumberTextBox.Text)
            Dim x(count + 5) As Double, y(count + 5) As Double

            x(0) = CDbl(0)
            y(0) = CDbl(DataGridView1.Rows(row).Cells(0).Value)

            For i = 1 To count + 5
                Select Case i
                    Case 1
                        x(i) = CDbl(i)
                        y(i) = CDbl(DataGridView1.Rows(row).Cells(i - 1).Value)
                    Case 2
                        x(i) = CDbl(i)
                        y(i) = CDbl(DataGridView1.Rows(row).Cells(i - 1).Value)
                        stage = stage + (edgeGrid / 2) - 1
                    Case 3
                        x(i) = CDbl(i)
                        y(i) = CDbl(DataGridView1.Rows(row).Cells(i - 1).Value)
                        stage = stage + edgeGrid - 1
                    Case count + 4
                        x(count + 4) = CDbl(DataGridView1.Columns.Count - 1)
                        y(count + 4) = CDbl(DataGridView1.Rows(row).Cells(DataGridView1.Columns.Count - 2).Value)
                    Case count + 5
                        x(count + 5) = CDbl(DataGridView1.Columns.Count)
                        y(count + 5) = CDbl(DataGridView1.Rows(row).Cells(DataGridView1.Columns.Count - 1).Value)
                    Case Else
                        Dim max As Double = 0
                        Dim min As Double = 100
                        Dim pos As Integer = 0

                        For m = stage - 2 To stage + 2
                            If max < CDbl(DataGridView1.Rows(row).Cells(m).Value) Then
                                max = CDbl(DataGridView1.Rows(row).Cells(m).Value)
                                pos = m
                            End If

                            If min > CDbl(DataGridView1.Rows(row).Cells(m).Value) Then
                                min = CDbl(DataGridView1.Rows(row).Cells(m).Value)
                                pos = m
                            End If
                        Next m

                        Select Case category
                            Case "upper"
                                x(i) = pos
                                y(i) = max
                            Case "lower"
                                x(i) = pos
                                y(i) = min
                        End Select
                        stage = stage + pitchGrid
                End Select
            Next

            XAlglib.spline1dfitpenalized(x, y, 50, rho, info, s, rep)
            Dim Newrow As DataRow = dt1.NewRow

            For j = 1 To DataGridView1.Columns.Count
                Newrow(j - 1) = CDbl(XAlglib.spline1dcalc(s, j))
            Next

            dt1.Rows.Add(Newrow)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub fitmiddle(ByVal row As Integer)
        Try
            Dim x(DataGridView1.Columns.Count) As Double, y(DataGridView1.Columns.Count) As Double
            Dim info As Integer
            Dim s As spline1dinterpolant = New XAlglib.spline1dinterpolant()
            Dim rep As spline1dfitreport = New XAlglib.spline1dfitreport()
            Dim rho As Double = TrackBar1.Value

            x(0) = CDbl(0)
            y(0) = CDbl(DataGridView1.Rows(row).Cells(0).Value)

            For i = 1 To DataGridView1.Columns.Count
                x(i) = CDbl(i)
                y(i) = CDbl(DataGridView1.Rows(row).Cells(i - 1).Value)
            Next

            XAlglib.spline1dfitpenalized(x, y, 50, rho, info, s, rep)
            Dim Newrow As DataRow = dt1.NewRow

            For j = 1 To DataGridView1.Columns.Count
                Newrow(j - 1) = CDbl(XAlglib.spline1dcalc(s, j))
            Next

            dt1.Rows.Add(Newrow)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Function getInitialDirectory() As String
        Dim _dirname As String = Nothing
        Dim major As Integer = System.Environment.OSVersion.Version.Major
        Dim minor As Integer = System.Environment.OSVersion.Version.Minor

        If major = 5 And minor = 1 Then 'this shows that user's computer is XP
            _dirname = "C:\Documents and Settings\" & Environment.UserName & "\桌面"
        ElseIf major = 6 And minor = 1 Then 'this shows that user's computer is WIN7
            _dirname = "C:\Users\" & Environment.UserName & "\Desktop"
        End If

        Return _dirname
    End Function

    Public Sub changecolor(ByVal button As Button, ByVal num As Integer)
        Select Case num
            Case 1
                FittingButton2.BackColor = SystemColors.Control
                FittingButton2.ForeColor = Color.Black
                FittingButton3.BackColor = SystemColors.Control
                FittingButton3.ForeColor = Color.Black
            Case 2
                FittingButton1.BackColor = SystemColors.Control
                FittingButton1.ForeColor = Color.Black
                FittingButton3.BackColor = SystemColors.Control
                FittingButton3.ForeColor = Color.Black
            Case 3
                FittingButton1.BackColor = SystemColors.Control
                FittingButton1.ForeColor = Color.Black
                FittingButton2.BackColor = SystemColors.Control
                FittingButton2.ForeColor = Color.Black
        End Select

        button.BackColor = Color.Red
        button.ForeColor = Color.White
        controlLabel.Text = num
        OutputAddPButton.Enabled = True
        OutputMinusPButton.Enabled = True
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        CheckBox2.Checked = False
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        CheckBox1.Checked = False
    End Sub

    Private Sub Check()
        If BluwidthTextBox.Text = "" Then
            MessageBox.Show("請填入BLUwidth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If LEDnumberTextBox.Text = "" Then
            MessageBox.Show("請填入LEDnumber", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If LEDpitchTextBox.Text = "" Then
            MessageBox.Show("請填入LEDpitch", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim count As Integer = DataGridView1.Columns.Count
        If count = 0 Then
            MessageBox.Show("請先輸入光學數據", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub

    Private Sub OutputAddPButton_Click(sender As Object, e As EventArgs) Handles OutputAddPButton.Click
        Dim SaveFileDialog As SaveFileDialog = New SaveFileDialog
        SaveFileDialog.InitialDirectory = "" & getInitialDirectory() & "" '設定開啟檔案格式
        SaveFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        SaveFileDialog.RestoreDirectory = True
        SaveFileDialog.FilterIndex = 2

        If SaveFileDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim sw As StreamWriter = New StreamWriter(SaveFileDialog.FileName.Insert(SaveFileDialog.FileName.Length - 4, "+"), False, System.Text.Encoding.Default)
           
            For m = 0 To DataGridView1.Rows.Count - 1
                Select Case controlLabel.Text
                    Case 1

                    Case 2
                        fitmiddle(m)
                    Case 3


                End Select

                For n = 0 To DataGridView1.Columns.Count - 1
                    sw.Write(Format((dt1(0)(n) / DataGridView1.Rows(m).Cells(n).Value), "#.####") & ",")



                    'Dim value As Double = Format((dt1(0)(n) / DataGridView1.Rows(m).Cells(n).Value), "#.####")
                Next
                dt1.Clear()
            Next
            sw.Flush()
            sw.Close()
            sw.Dispose()
        End If
    End Sub

    Private Sub OutputMinusPButton_Click(sender As Object, e As EventArgs) Handles OutputMinusPButton.Click
        Dim SaveFileDialog As SaveFileDialog = New SaveFileDialog
        SaveFileDialog.InitialDirectory = "" & getInitialDirectory() & "" '設定開啟檔案格式
        SaveFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        SaveFileDialog.RestoreDirectory = True
        SaveFileDialog.FilterIndex = 2

        If SaveFileDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim sw As StreamWriter = New StreamWriter(SaveFileDialog.FileName.Insert(SaveFileDialog.FileName.Length - 4, "-"), False, System.Text.Encoding.Default)
            
            For m = 0 To DataGridView1.Rows.Count - 1
                Select Case controlLabel.Text
                    Case 1

                    Case 2
                        fitmiddle(m)
                    Case 3

                End Select

                For n = 0 To DataGridView1.Columns.Count - 1
                    'sw.Write(Format((dt1(0)(n) / DataGridView1.Rows(m).Cells(n).Value), "#.####") & ",")

                    Dim value As Double = Format((dt1(0)(n) / DataGridView1.Rows(m).Cells(n).Value), "#.####")
                    If n = DataGridView1.Columns.Count - 1 Then
                        If value < 1 Then
                            sw.Write(1 + (1 - value) & vbCrLf)
                        Else
                            sw.Write(1 & vbCrLf)
                        End If
                    Else
                        If value < 1 Then
                            sw.Write(1 + (1 - value) & ",")
                        Else
                            sw.Write(1 & ",")
                        End If
                    End If
                Next
                dt1.Clear()
            Next
            sw.Flush()
            sw.Close()
            sw.Dispose()
        End If
    End Sub
End Class