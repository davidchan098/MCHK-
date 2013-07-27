
Public Class JVMLauncher
  
  Public Arguments As New List(Of String)
  Public SearchPaths As New List(Of String)
  Public Properties As New Dictionary(Of String, String)
  Public MaxMemory As Integer = -1, InitialMemory As Integer = -1
  Public MainClass As String = "", isJarFile As Boolean = False
  
  Public Sub New()
    
  End Sub
  
  Public Function PrepareProcess() As Process
    Dim P As New Process()
    Dim par As String = ""
    If MaxMemory >= 0 Then par &= " -Xmx" & MaxMemory & "M"
    par &= " -Xms" & InitialMemory & "M"
    
    For Each prop As KeyValuePair(Of String, String) In Properties
      par &= " -D" & prop.Key & "=" & prop.Value
    Next
    
    If SearchPaths.Count > 0 Then
      par &= " -cp"
      For Each path As String In SearchPaths
        par &= path & ";"
      Next
      par = par.TrimEnd(";")
    End If
    
    If isJarFile Then par &= " -jar"
    par &= MainClass
    
    For Each Arg As String In Arguments
      par &= " " & Arg
    Next
    
    P.StartInfo.FileName = "java"
    P.StartInfo.Arguments = par.Trim()
    
    Return P
  End Function
  
  
End Class
