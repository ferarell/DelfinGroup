Public Class MessageLayoutBE

	Private _IdMessageLayout as Int32
	Public Property IdMessageLayout() as Int32
		Get
		Return _IdMessageLayout
	End Get

	Set(ByVal value as Int32)
		_IdMessageLayout = value
	End Set
	End Property

	Private _IdMessageStructure as Int32
	Public Property IdMessageStructure() as Int32
		Get
		Return _IdMessageStructure
	End Get

	Set(ByVal value as Int32)
		_IdMessageStructure = value
	End Set
	End Property

	Private _IdInputConfiguration as Int32
	Public Property IdInputConfiguration() as Int32
		Get
		Return _IdInputConfiguration
	End Get

	Set(ByVal value as Int32)
		_IdInputConfiguration = value
	End Set
	End Property

    Private _MessageText As Byte
    Public Property MessageText() As Byte
        Get
            Return _MessageText
        End Get

        Set(ByVal value As Byte)
            _MessageText = value
        End Set
    End Property

    Private _ValidFrom as DateTime
	Public Property ValidFrom() as DateTime
		Get
		Return _ValidFrom
	End Get

	Set(ByVal value as DateTime)
		_ValidFrom = value
	End Set
	End Property

	Private _ValidTo as DateTime
	Public Property ValidTo() as DateTime
		Get
		Return _ValidTo
	End Get

	Set(ByVal value as DateTime)
		_ValidTo = value
	End Set
	End Property

	Private _UserCreate as String
	Public Property UserCreate() as String
		Get
		Return _UserCreate
	End Get

	Set(ByVal value as String)
		_UserCreate = value
	End Set
	End Property

	Private _DateCreate as DateTime
	Public Property DateCreate() as DateTime
		Get
		Return _DateCreate
	End Get

	Set(ByVal value as DateTime)
		_DateCreate = value
	End Set
	End Property

	Private _UserUpdate as String
	Public Property UserUpdate() as String
		Get
		Return _UserUpdate
	End Get

	Set(ByVal value as String)
		_UserUpdate = value
	End Set
	End Property

	Private _DateUpdate as DateTime
	Public Property DateUpdate() as DateTime
		Get
		Return _DateUpdate
	End Get

	Set(ByVal value as DateTime)
		_DateUpdate = value
	End Set
	End Property

End Class
