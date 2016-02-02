Public Class Player
    Dim id As Integer
    Dim symbol As Bitmap

    Sub New(i As Integer, b As Bitmap)
        id = i
        symbol = b
        's As Char
        'symbol = s

        Console.WriteLine("Object Created")

    End Sub

    Public Function GetId()
        Return id
    End Function

    Public Function GetSymbol()
        Return symbol

    End Function










End Class
