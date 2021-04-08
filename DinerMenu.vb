
Public Class DinerForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        'This simply closes the window
        'You can press escape and it will activate this sub
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        'When the user clicks on the soup button this will appear in the label
        DisplayLabel.Text = ("Soup of the Day: Cave soup") & vbNewLine & 'This works like the enter button in word
                ("This soup is created using only the finest") & vbNewLine &
        ("ingredients, found exclusivily in caves.")
        'This Button was set to my Accept button so press enter to automatically select it
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        'When the user clicks on the Salad button this will appear in the label
        DisplayLabel.Text = ("Special of the Day: Carrot Salad") & vbNewLine &
                ("created using only the finest farmer") & vbNewLine &
        ("grown carrots And nothing else.")

    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        'When the user clicks on the fish button this will appear in the label
        DisplayLabel.Text = ("Fish Special: Fish Bowl") & vbNewLine &
                ("This Dish contains three types of the") & vbNewLine &
                ("finest fish on a bed of three diffrent types of rice.")

    End Sub
End Class

