Public Class NewClass
    Private LEDnum As Integer
    Private Grid As Double, PitchGrid As Integer, EdgeGrid As Integer
    'Private _value As Integer

    Public Property GetPitchGrid(ByVal BLUwidth As Double, ByVal LEDpitch As Double, ByVal count As Integer) As Integer
        Get
            Grid = CDbl(BLUwidth / count)
            PitchGrid = CInt(LEDpitch / Grid)

            Return PitchGrid
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property GetEdgeGrid(ByVal BLUwidth As Double, ByVal LEDpitch As Double, ByVal LEDnum As Integer, ByVal count As Integer) As Integer
        Get
            Grid = CDbl(BLUwidth / count)
            EdgeGrid = CInt((BLUwidth - ((LEDnum - 1) * LEDpitch)) / Grid / 2)

            Return EdgeGrid
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    'Public Property maxvalueY_X(ByVal index As Integer) As Single
    '    Get
    '        'GetMaxValueY(index)
    '        'Return Y_Xvalue
    '    End Get
    '    Set(ByVal value As Single)
    '        '_value = CInt(value)
    '    End Set
    'End Property

    'Public Property maxvalueY_Y(ByVal index As Integer) As Single
    '    Get
    '        'GetMaxValueY(index)
    '        'Return Y_Yvalue
    '    End Get
    '    Set(ByVal value As Single)
    '        '_value = CInt(value)
    '    End Set
    'End Property

    'Public Property colorCalculate(ByVal Dvalue As Single) As String
    '    Get
    '        '    Return GetColorRGB(Dvalue)
    '    End Get
    '    Set(ByVal value As String)
    '        '    _value = CInt(value)
    '    End Set
    'End Property



    'Private Sub GetMaxValueY()

    'End Sub

    'Public Sub Cellclick()

    'End Sub

    'Public Sub drawDensity()

    'End Sub

    'Public Sub drawColorBar()

    'End Sub

    'Public Sub densityPlusMinus()

    'End Sub
End Class
