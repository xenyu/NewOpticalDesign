Public Class NewClass
    Private _value As String, textvalue As String, returnvalue As String
    Private dialog As DialogResult

    Public Property Dialog_Value(ByVal title As String, ByVal promptText As String, ByVal newvalue As String) As DialogResult
        Get
            InputBox(title, promptText, newvalue)
            Return returnvalue
        End Get
        Set(ByVal value As DialogResult)
            _value = value
        End Set
    End Property

    Public ReadOnly Property Textbox_Value() As Double
        Get
            Return textvalue
        End Get
    End Property

    Public Sub InputBox(title As String, promptText As String, ByRef value As String)
        Dim form As New Form()
        Dim label As New Label()
        Dim textBox As New TextBox()
        Dim buttonOk As New Button()
        Dim buttonCancel As New Button()

        form.Text = title
        label.Text = promptText
        textBox.Text = value

        buttonOk.Text = "OK"
        buttonCancel.Text = "Cancel"
        buttonOk.DialogResult = DialogResult.OK
        buttonCancel.DialogResult = DialogResult.Cancel

        label.SetBounds(9, 15, 200, 13)
        textBox.SetBounds(185, 13, 160, 20)
        buttonOk.SetBounds(228, 72, 75, 30)
        buttonCancel.SetBounds(309, 72, 75, 30)

        label.AutoSize = True
        textBox.Anchor = textBox.Anchor Or AnchorStyles.Right
        buttonOk.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        buttonCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right

        label.Font = New Font("cambria", 11)
        textBox.Font = New Font("cambria", 11)
        buttonOk.Font = New Font("cambria", 11)
        buttonCancel.Font = New Font("cambria", 11)

        form.ClientSize = New Size(396, 107)
        form.Controls.AddRange(New Control() {label, textBox, buttonOk, buttonCancel})
        form.ClientSize = New Size(Math.Max(300, label.Right + 10), form.ClientSize.Height)
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.StartPosition = FormStartPosition.CenterScreen
        form.MinimizeBox = False
        form.MaximizeBox = False
        form.AcceptButton = buttonOk
        form.CancelButton = buttonCancel

        Dim dialogResult__1 As DialogResult = form.ShowDialog()

        If textBox.Text = "" Then
            MessageBox.Show("請輸入數值", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            textvalue = textBox.Text
        End If

        returnvalue = dialogResult__1
    End Sub
End Class
