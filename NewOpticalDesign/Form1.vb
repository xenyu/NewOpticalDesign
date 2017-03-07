Imports System
Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ImportForm As HotspotFitting = New HotspotFitting
        ImportForm.MdiParent = Me
        ImportForm.StartPosition = FormStartPosition.CenterScreen
        ImportForm.Show()
        Cursor = Cursors.Arrow
    End Sub

End Class
