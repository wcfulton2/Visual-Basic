Public Class Flipper
    Private droppedLeftBoolean As Boolean = False

    ReadOnly Property droppedLeft() As Boolean      ' example: If Flipper1.droppedLeft then...
        Get
            Return droppedLeftBoolean   'do flip before reading
        End Get
    End Property

    Public Sub flip()                               ' example: Flipper1.flip()
        droppedLeftBoolean = Not droppedLeftBoolean
        Dot.ImageIndex = 1 - Dot.ImageIndex 'alternate dot color
    End Sub

    Public Sub reset()                              ' example: Flipper1.reset()
        Dot.ImageIndex = 0              'reset image to yellow dot
        droppedLeftBoolean = False      'default direction
    End Sub

End Class
