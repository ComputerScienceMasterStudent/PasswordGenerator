Imports System.Text
Module Module1


    Function GeneratePassword(ByVal len As Integer)
        Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+{}|:<>?"
        Dim password As New StringBuilder
        Dim rand As New Random
        Dim i As Integer
        For i = 1 To len
            Dim index As Integer = rand.Next(0, alphabet.Length)
            password.Append(alphabet.ElementAt(index))
        Next
        Return password.ToString()
    End Function

    Sub Main()
        Dim passwordLength As Integer = 16
        Console.WriteLine("The password is:")
        Console.WriteLine(GeneratePassword(passwordLength))
        Console.ReadKey()
    End Sub

End Module
