using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.TableUI;

public class FillEnd : MonoBehaviour {
    public TMPro.TextMeshProUGUI CongratsMessage;
    public TMPro.TextMeshProUGUI CorrectCharacterText;
    public TMPro.TextMeshProUGUI GuessedCharacterText;
    public GameObject CorrectCharacterImage;
    public GameObject GuessedCharacterImage;
    public TableUI QuestionsTable;

    void Start() {
        int rowsCount = StaticGameResume.askedQuestions.Count + 1;
        QuestionsTable.Rows = rowsCount;

        Color red, green;
        ColorUtility.TryParseHtmlString("#FF3B3E", out red);
        ColorUtility.TryParseHtmlString("#21BC3C", out green);

        QuestionsTable.GetCell(0, 1).text = StaticGameResume.guessedCharacter.name;
        QuestionsTable.GetCell(0, 2).text = StaticGameResume.correctCharacter.name;

        for (int i = 1; i < rowsCount; i++) {
            QuestionsTable.GetCell(i, 0).text = "   " + StaticGameResume.askedQuestions[i - 1].question;
            QuestionsTable.GetCell(i, 1).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.guessedCharacter) ? "Yes" : "No");
            QuestionsTable.GetCell(i, 2).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.correctCharacter) ? "Yes" : "No");
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

        if (StaticGameResume.guessedCharacter.id == StaticGameResume.correctCharacter.id) {
            CongratsMessage.text = "Congratulations you won!";
            CongratsMessage.color = green;
            QuestionsTable.HeaderColor = green;
            QuestionsTable.Columns = 2;
        }
        else {
            CongratsMessage.text = "You guessed wrong! Try again!";
            CongratsMessage.color = red;
            QuestionsTable.HeaderColor = red;
        }
    }

    void Update() {

    }

    public void ReplayGame() {
        SceneManager.LoadScene("SampleScene");
    }
}
