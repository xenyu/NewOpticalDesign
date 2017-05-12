Imports System
Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub HotspotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotspotToolStripMenuItem.Click
        If Label1.Text = "true" Then Exit Sub

        Dim ImportForm As HotspotFitting = New HotspotFitting
        ImportForm.MdiParent = Me
        ImportForm.WindowState = FormWindowState.Maximized
        ImportForm.StartPosition = FormStartPosition.CenterScreen
        ImportForm.Show()
        Cursor = Cursors.Arrow
        Label1.Text = "true"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
