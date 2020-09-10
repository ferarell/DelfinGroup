
Public Class EntidadesSunat
    Public Property Id() As String
        Get
            Return m_Id
        End Get
        Set
            m_Id = Value
        End Set
    End Property
    Private m_Id As String
    Public Property Quantity() As String
        Get
            Return m_Quantity
        End Get
        Set
            m_Quantity = Value
        End Set
    End Property
    Private m_Quantity As String

    Public Property Ammount() As String
        Get
            Return m_Ammount
        End Get
        Set
            m_Ammount = Value
        End Set
    End Property
    Private m_Ammount As String

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set
            m_Description = Value
        End Set
    End Property
    Private m_Description As String
End Class
