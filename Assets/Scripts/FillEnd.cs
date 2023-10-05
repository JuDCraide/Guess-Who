using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.TableUI;

public class FillEnd : MonoBehaviour {
    public TableUI Questions;
    public TableUI GuessedCharacter;
    public TableUI CorrectCharacter;

    public TMPro.TextMeshProUGUI CongratsMessage;
    public TMPro.TextMeshProUGUI CorrectCharacterText;
    public TMPro.TextMeshProUGUI GuessedCharacterText;
    public GameObject CorrectCharacterImage;
    public GameObject GuessedCharacterImage;

    void Start() {
        int rowsCount = StaticGameResume.askedQuestions.Count + 1;

        Questions.Rows = rowsCount;
        GuessedCharacter.Rows = rowsCount;
        CorrectCharacter.Rows = rowsCount;


        if(StaticGameResume.guessedCharacter.id == StaticGameResume.correctCharacter.id) {
            CorrectCharacter.gameObject.SetActive(false);

            CongratsMessage.text = "Congratulations you won!";
        }
        else {
            CongratsMessage.text = "You guessed wrong! Try again!";
        }

        GuessedCharacter.GetCell(0, 0).text = StaticGameResume.guessedCharacter.name;
        CorrectCharacter.GetCell(0, 0).text = StaticGameResume.correctCharacter.name;

        for (int i = 1; i < rowsCount; i++) {
            Questions.GetCell(i, 0).text = "   " + StaticGameResume.askedQuestions[i - 1].question;
            GuessedCharacter.GetCell(i, 0).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.guessedCharacter) ? "Yes" : "No");
            CorrectCharacter.GetCell(i, 0).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.correctCharacter) ? "Yes" : "No");
        }

        CorrectCharacterText.text = "The character was:\n" + StaticGameResume.correctCharacter.name;
        GuessedCharacterText.text = "You guessed:\n" + StaticGameResume.guessedCharacter.name;

        string path = StaticGameResume.guessedCharacter.id.ToString();
        var sprinte = Resources.Load<Sprite>(path);
        Image image = GuessedCharacterImage.GetComponent<Image>();
        image.sprite = sprinte;

        path = StaticGameResume.correctCharacter.id.ToString();
        sprinte = Resources.Load<Sprite>(path);
        image = CorrectCharacterImage.GetComponent<Image>();
        image.sprite = sprinte;
    }

    // Update is called once per frame
    void Update() {

    }
}
