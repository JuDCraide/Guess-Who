using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.TableUI;
using TMPro;

public class FillEnd : MonoBehaviour {
    public TextMeshProUGUI CongratsMessage;
    public TextMeshProUGUI CorrectAnimalText;
    public TextMeshProUGUI GuessedAnimalText;
    public GameObject CorrectAnimalImage;
    public GameObject GuessedAnimalImage;
    public TableUI QuestionsTable;

    void Start() {
        int rowsCount = StaticGameResume.askedQuestions.Count + 1;        
        QuestionsTable.Rows = rowsCount;

        Color red, green;
        ColorUtility.TryParseHtmlString("#FF3B3E", out red);
        ColorUtility.TryParseHtmlString("#21BC3C", out green);

        QuestionsTable.GetCell(0, 1).text = StaticGameResume.guessedAnimal.name;
        QuestionsTable.GetCell(0, 2).text = StaticGameResume.correctAnimal.name;

        for (int i = 1; i < rowsCount; i++) {
            QuestionsTable.GetCell(i, 0).text = "   " + StaticGameResume.askedQuestions[i - 1].question;
            QuestionsTable.GetCell(i, 1).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.guessedAnimal) ? "Yes" : "No");
            QuestionsTable.GetCell(i, 2).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.correctAnimal) ? "Yes" : "No");
        }

        CorrectAnimalText.text = "The Animal was:\n" + StaticGameResume.correctAnimal.name;
        GuessedAnimalText.text = "You guessed:\n" + StaticGameResume.guessedAnimal.name;

        string path = StaticGameResume.guessedAnimal.id.ToString();
        var sprinte = Resources.Load<Sprite>(path);
        Image image = GuessedAnimalImage.GetComponent<Image>();
        image.sprite = sprinte;

        path = StaticGameResume.correctAnimal.id.ToString();
        sprinte = Resources.Load<Sprite>(path);
        image = CorrectAnimalImage.GetComponent<Image>();
        image.sprite = sprinte;

        if (StaticGameResume.guessedAnimal.id == StaticGameResume.correctAnimal.id) {
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

        if(rowsCount==1){
            QuestionsTable.Rows = 2;
            QuestionsTable.GetCell(1, 0).text = "No question was asked!";
            QuestionsTable.GetCell(1, 0).alignment = TextAlignmentOptions.Midline;
            QuestionsTable.GetCell(1, 1).text = "";
            QuestionsTable.GetCell(1, 2).text = "";
        }
    }

    void Update() {

    }

    public void ReplayGame() {
        SceneManager.LoadScene("SampleScene");
    }
}
