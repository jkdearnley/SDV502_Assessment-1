Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CinemaVBApp

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub Adult_Before_5_Test()
        Dim form1 As Form = New Form
        Dim adult_before_5 = form1.Adult_Before_5(1, "Adult", 4)

        Assert.AreEqual(14.5, adult_before_5)
    End Sub

End Class

<TestClass()> Public Class UnitTest2

    <TestMethod()> Public Sub Adult_After_5_Test()
        Dim form1 As Form = New Form
        Dim adult_after_5 = form1.Adult_After_5(1, "Adult", 6)

        Assert.AreEqual(17.5, adult_after_5)
    End Sub

End Class

<TestClass()> Public Class UnitTest3

    <TestMethod()> Public Sub Adult_Tuesday_Test()
        Dim form1 As Form = New Form
        Dim adult_tuesday = form1.Adult_Tuesday(1, "Adult", "Tuesday")

        Assert.AreEqual(13.0, adult_tuesday)
    End Sub

End Class


<TestClass()> Public Class UnitTest4

    <TestMethod()> Public Sub Child_Under16_Test()
        Dim form1 As Form = New Form
        Dim child_under16 = form1.Child_Under16(1, "Child")

        Assert.AreEqual(12.0, child_under16)
    End Sub

End Class

<TestClass()> Public Class UnitTest5

    <TestMethod()> Public Sub Senior_Test()
        Dim form1 As Form = New Form
        Dim senior = form1.Senior(1, "Senior")

        Assert.AreEqual(12.5, senior)
    End Sub

End Class

<TestClass()> Public Class UnitTest6

    <TestMethod()> Public Sub Student_Test()
        Dim form1 As Form = New Form
        Dim student = form1.Student(1, "Student")

        Assert.AreEqual(14.0, student)
    End Sub

End Class

<TestClass()> Public Class UnitTest7

    <TestMethod()> Public Sub Family_Test()
        Dim form1 As Form = New Form
        Dim family = form1.Family_Pass(1, "Family")

        Assert.AreEqual(46.0, family)
    End Sub

End Class

<TestClass()> Public Class UnitTest8

    <TestMethod()> Public Sub Chick_Flick_Thursday_Test()
        Dim form1 As Form = New Form
        Dim chick_flick_thursday = form1.Chick_Flick_Thursday(1, "Adult", "Chick Flick Thursday", 5)

        Assert.AreEqual(21.5, chick_flick_thursday)
    End Sub

End Class

<TestClass()> Public Class UnitTest9

    <TestMethod()> Public Sub Kids_And_Carers_Test()
        Dim form1 As Form = New Form
        Dim kids_and_carers = form1.Kids_And_Carers(1, "Child", "Wednesday", True)

        Assert.AreEqual(12.0, kids_and_carers)
    End Sub

End Class