Public Class clsPreferences

#Region "Declarations"
    Private colred As Boolean
    Private colGreen As Boolean
    Private colBlue As Boolean
    Private colBlack As Boolean
    Private colWhite As Boolean
    Private tickSpeed As Integer
    Private m_autoSpeedEnabled As Boolean
    Private m_autoSpeedNewSettings As Boolean
    Private m_autoSpeedLowValue As Integer
    Private m_autoSpeedHighValue As Integer
    Private m_autoSpeedTimeSpan As Integer
    Private m_autoSpeedCounter As Long
    Private m_autoSpeedOriginalCount As Long
    Private m_autoShutDownEnabled As Boolean
    Private m_autoShutDownTime As DateTime
#End Region

#Region "properties"

    Public Property autoShutDownEnabled() As Boolean

        Get
            Return m_autoShutDownEnabled
        End Get
        Set(ByVal value As Boolean)
            m_autoShutDownEnabled = value
        End Set

    End Property

    Public Property autoShutDownTime() As DateTime

        Get
            Return m_autoShutDownTime
        End Get
        Set(ByVal value As DateTime)
            m_autoShutDownTime = value
        End Set

    End Property


    Public Property autoSpeedOriginalCount() As Long

        Get
            Return m_autoSpeedOriginalCount
        End Get
        Set(ByVal value As Long)
            m_autoSpeedOriginalCount = value
        End Set

    End Property


    Public Property autoSpeedCounter() As Long

        Get
            Return m_autoSpeedCounter
        End Get
        Set(ByVal value As Long)
            m_autoSpeedCounter = value
        End Set

    End Property

    Public Property autoSpeedTimeSpan() As Integer

        Get
            Return m_autoSpeedTimeSpan
        End Get
        Set(ByVal value As Integer)
            m_autoSpeedTimeSpan = value
        End Set

    End Property

    Public Property autoSpeedHighValue() As Integer

        Get
            Return m_autoSpeedHighValue
        End Get
        Set(ByVal value As Integer)
            m_autoSpeedHighValue = value
        End Set

    End Property

    Public Property autoSpeedLowValue() As Integer

        Get
            Return m_autoSpeedLowValue
        End Get
        Set(ByVal value As Integer)
            m_autoSpeedLowValue = value
        End Set

    End Property

    Public Property autoSpeedEnabled() As Boolean

        Get
            Return m_autoSpeedEnabled
        End Get
        Set(ByVal value As Boolean)
            m_autoSpeedEnabled = value
        End Set

    End Property

    Public Property autoSpeedNewSettings() As Boolean

        Get
            Return m_autoSpeedNewSettings
        End Get
        Set(ByVal value As Boolean)
            m_autoSpeedNewSettings = value
        End Set

    End Property

    Public Property useRed() As Boolean

        Get
            Return colred
        End Get
        Set(ByVal value As Boolean)
            colred = value
        End Set

    End Property

    Public Property useGreen() As Boolean

        Get
            Return colGreen
        End Get
        Set(ByVal value As Boolean)
            colGreen = value
        End Set

    End Property

    Public Property useBlue() As Boolean

        Get
            Return colBlue
        End Get
        Set(ByVal value As Boolean)
            colBlue = value
        End Set

    End Property

    Public Property useBlack() As Boolean

        Get
            Return colBlack
        End Get
        Set(ByVal value As Boolean)
            colBlack = value
        End Set

    End Property

    Public Property useWhite() As Boolean

        Get
            Return colWhite
        End Get
        Set(ByVal value As Boolean)
            colWhite = value
        End Set

    End Property

    Public Property flashSpeed() As Integer

        Get
            Return tickSpeed
        End Get
        Set(ByVal value As Integer)
            tickSpeed = value
        End Set

    End Property
#End Region

    Public Sub InitialiseMe() 'set defaults
        clearClass()


    End Sub

    Private Sub clearClass()
        useRed = True
        useGreen = True
        useBlue = True
        useBlack = False
        useWhite = False

        flashSpeed = 100

        autoSpeedEnabled = False
        autoSpeedHighValue = 0
        autoSpeedLowValue = 0
        autoSpeedNewSettings = False
        autoSpeedTimeSpan = 0

        autoShutDownEnabled = False
    End Sub

End Class
