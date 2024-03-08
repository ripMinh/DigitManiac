using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Guessscripy : MonoBehaviour
{
    [SerializeField]
    private TMP_Text message;

    [SerializeField]
    private TMP_InputField userInput;

    [SerializeField]
    private Button GuessBtn;
    [SerializeField]
    private int counter = 3;
    
    public int result;
    private int inputNumber = 0;

    int minNumber;
    int maxNumber;
    void Start()
    {
        minNumber = Random.Range(0, 25);
        maxNumber = Random.Range(30, 55);
        StartGame();
    }
    void Update()
    {

    }
    #region CUSTOM FUNCTIONS
    public void StartGame()
    {
        message.text = $"I have picked a number from {minNumber} to {maxNumber}.\n" +
            "Can you guess the number?\n" +
            "Type your answer in the input field below and click the button to submit. You don't click u gay.";
        result = GetRandomNumber();

    }

    private int GetRandomNumber()
    {
        int result = Random.Range(minNumber, maxNumber);
        return result;
    }

    //When the button is clicked, start the game function

    public void OnGuessButtonClicked()
    {

        if (counter == 0)
        {
            message.text = "You ran out of guesses u gay." + $"The number I was thinking of is {result} hah gay";
            Application.Quit();
        }
        else {
            string input = userInput.GetComponent<TMP_InputField>().text;
            inputNumber = int.Parse(input);
            if (inputNumber < result)
            {
                message.text = "INCREASE THE NUMBER U GAY";
                counter--;
            }
            else if  (inputNumber > result)
            {
                message.text = "DECREASE THE NUMBER U GAY";
                counter--;
            }
            else
            {
                message.text = "U GUESSED THE RIGHT NUMBER.\nHAH U GOT LUCKY UR NOT GAY THIS TIME";
            }
        }
    }
}

#endregion