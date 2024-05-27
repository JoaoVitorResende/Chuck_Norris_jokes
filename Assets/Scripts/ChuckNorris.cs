using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChuckNorris : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI jokeText;

    public void NewJoke()
    {
        Joke joke = APIHelper.GetNewJoke();
        jokeText.text = joke.value;
    }
}
