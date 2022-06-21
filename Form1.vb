Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class Form1

    Private stepsNBR As Integer = 0
    Private countSteps As Integer = 0
    Private countAnswer As Integer = 0
    Private gameDifficult As String = Nothing
    Private gameResponse As String = Nothing
    Private playerScore As Integer = 0
    Private nbrOfQuestions As Integer = 0
    Private memoryRead As New List(Of Integer)
    Private AllAnswers As New List(Of String)
    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        If CbxDifficult.SelectedItem = "" Then
            MessageBox.Show("Vous devez sélectionner une difficulté")
        Else
            stepsNBR = 0
            playerScore = 0
            AllAnswers.Clear()
            memoryRead.Clear()
            CbxDifficult.Enabled = False
            BtnValidate.Enabled = True
            BtnPlay.Enabled = False

            startGame()
        End If
    End Sub

    Private Sub BtnValidate_Click(sender As Object, e As EventArgs) Handles BtnValidate.Click
        Dim thisReponse As String = ""
        'On regarde quel radio bouton est cocher puis on va chercher la reponse correspondante
        If RbA.Checked = True Then
            thisReponse = AllAnswers.ElementAt(0)
        ElseIf RbB.Checked = True Then
            thisReponse = AllAnswers.ElementAt(1)
        ElseIf RbC.Checked = True Then
            thisReponse = AllAnswers.ElementAt(2)
        ElseIf RbD.Checked = True Then
            thisReponse = AllAnswers.ElementAt(3)
        End If
        'On ajoute +1 au score si la condition est vrai
        If getReponse(thisReponse) = True Then
            playerScore += 1
        End If

        'On reinitialise certain elements
        AllAnswers.Clear()
        stepsNBR += 1
        startGame()
    End Sub

    Public Sub startGame()
        'On efface les anciennes valeurs
        GameReset()

        'On defini le niveau de  difficulté
        gameDifficult = CbxDifficult.SelectedItem
        'On lit le fichier contenant les informations du quizz
        proceedFile()

        'On met a jour le score
        LblSCore.Text = "Score: " & playerScore & " sur " & getNbrOfQuestions()
        LblSteps.Text = "Etapes: " & stepsNBR & " sur " & getNbrOfQuestions()

        'Si la partie est finie on reinitialise
        If stepsNBR = nbrOfQuestions Then
            BtnPlay.Enabled = True
            BtnValidate.Enabled = False
            CbxDifficult.Enabled = True
            GameReset()
            RtbQuestion.Text = "En attente d'une nouvelle partie"
            countSteps = 0
            countAnswer = 0

            'Si le joueur a le score maximum
            If playerScore = stepsNBR Then
                MessageBox.Show("Félicitation, vous avez fait un score parfait!!")
            Else
                MessageBox.Show("Vous pouvez vous améliorer!!")
            End If
        End If
    End Sub

    Public Sub proceedFile()
        ' Correspond au nombre de lignes dans le fichier quizz
        Dim NbrLine As Integer = 35 - 1
        Dim myNumber As Integer = 0
        'On genere un nombre aléatoire qui correspondra au numéro de la ligne à lire
        Dim random As Random = New Random()
        myNumber = random.Next(0, NbrLine)
        'On verifie que le nombre n'a pas déjà été trouver, pour evité de relire la meme question
        If memoryRead.Contains(myNumber) = True Then
            While memoryRead.Contains(myNumber) = True
                myNumber = random.Next(0, NbrLine)
            End While
        End If

        'On ajoute le nombre aléatoire a la collections des ligne déjà lu
        memoryRead.Add(myNumber)

        'On lit le fichier a la ligne generer par la fonction random
        Dim thisLine As String
        Dim splitLine() As String = Nothing
        Dim thisQuestion As String
        Dim thisAnswers As String
        Dim lines As Integer = 0
        Dim monStringReader As New StringReader(My.Resources.Resource1.Quizz)
        'On lit le fichier texte du quiz
        While monStringReader.Peek <> -1
            monStringReader.ReadLine()
            If lines = myNumber Then
                thisLine = monStringReader.ReadLine()
                Exit While
            End If

            lines += 1
        End While

        'On decoupe la ligne de texte en question et réponses
        splitLine = thisLine.Split("=")
        thisQuestion = splitLine(0)
        thisAnswers = splitLine(1)
        RtbQuestion.Text = thisQuestion

        'On redecoupe pour obtenir les réponses
        Dim theRest() As String = Nothing
        theRest = thisAnswers.Split(";")

        Dim answerA As String = theRest(0)
        AllAnswers.Add(answerA)
        RbA.Text = answerA.Substring(2, answerA.Length - 2)

        Dim answerB As String = theRest(1)
        AllAnswers.Add(answerB)
        RbB.Text = answerB.Substring(2, answerB.Length - 2)

        If theRest.Length = 2 Then
            RbC.Enabled = False
            RbD.Enabled = False
        ElseIf theRest.Length = 3 Then
            Dim answerC As String = theRest(2)
            AllAnswers.Add(answerC)
            RbC.Text = answerC.Substring(2, answerC.Length - 2)
            RbC.Enabled = True
            RbD.Enabled = False
        ElseIf theRest.Length = 4 Then
            Dim answerC As String = theRest(2)
            AllAnswers.Add(answerC)
            RbC.Text = answerC.Substring(2, answerC.Length - 2)
            RbC.Enabled = True

            Dim answerD As String = theRest(3)
            AllAnswers.Add(answerD)
            RbD.Text = answerD.Substring(2, answerD.Length - 2)
            RbD.Enabled = True
        End If

        monStringReader.Close()
    End Sub


    Public Sub GameReset()
        'On efface les anciennes valeurs
        RbA.Checked = True
        RbA.Text = "Réponse A"
        RbB.Text = "Réponse B"
        RbC.Text = "Réponse C"
        RbD.Text = "Réponse D"
    End Sub

    'Renvoie le nombres de questions suivant la difficulté
    Public Function getNbrOfQuestions()
        If gameDifficult = "Facile" Then
            nbrOfQuestions = 10
        ElseIf gameDifficult = "Normal" Then
            nbrOfQuestions = 15
        ElseIf gameDifficult = "Difficile" Then
            nbrOfQuestions = 20
        ElseIf gameDifficult = "Expert" Then
            nbrOfQuestions = 30
        End If
        Return nbrOfQuestions
    End Function
    'On decoupe pour séparer la valeur de la reponse et la réponse
    Public Function getReponse(thisReponse As String) As Boolean
        gameResponse = thisReponse.Substring(0, 1)
        If gameResponse.Contains("1") = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
