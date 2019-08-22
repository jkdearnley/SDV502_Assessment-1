Public Class Form

    Public Function Adult_Before_5(quantity As Integer, person As String, time As Decimal) As Double
        Dim initialPrice As Decimal = 14.5
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Adult" And time < 5 Then
            Return total_price
        End If
    End Function

    Public Function Adult_After_5(quantity As Integer, person As String, time As Integer) As Double
        Dim initialPrice As Decimal = 17.5
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Adult" And time >= 5 Then
            Return total_price
        End If
    End Function

    Public Function Adult_Tuesday(quantity As Integer, person As String, day As String) As Double
        Dim initialPrice As Decimal = 13.0
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Adult" And day = "Tuesday" Then
            Return total_price
        End If
    End Function

    Public Function Child_Under16(quantity As Integer, person As String) As Double
        Dim initialPrice As Decimal = 12.0
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Child" Then
            Return total_price
        End If
    End Function

    Public Function Senior(quantity As Integer, person As String) As Double
        Dim initialPrice As Decimal = 12.5
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Senior" Then
            Return total_price
        End If
    End Function

    Public Function Student(quantity As Integer, person As String) As Double
        Dim initialPrice As Decimal = 14.0
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Student" Then
            Return total_price
        End If
    End Function

    Public Function Family_Pass(quantity As Integer, person As String) As Double
        Dim initialPrice As Decimal = 46.0
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Family" Then
            Return total_price
        End If
    End Function

    Public Function Chick_Flick_Thursday(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim initialPrice As Decimal = 21.5
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Adult" And day = "Chick Flick Thursday" And time >= 5 Then
            Return total_price
        End If
    End Function

    Public Function Kids_And_Carers(quantity As Integer, person As String, day As String, holiday As Boolean) As Double
        Dim initialPrice As Decimal = 12.0
        Dim total_price As Decimal = initialPrice * quantity
        If quantity > 0 And quantity <= 10 And person = "Child" And day = "Wednesday" Then
            Return total_price
        End If
    End Function

    Private Sub Cinemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
