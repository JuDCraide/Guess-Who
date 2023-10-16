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
            var cell1  = QuestionsTable.GetCell(i, 1);
            cell1.text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.guessedAnimal) ? "Sim" : "Não");
            cell1.alignment = TextAlignmentOptions.Midline;
            var cell2  = QuestionsTable.GetCell(i, 2);
            cell2.text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.correctAnimal) ? "Sim" : "Não");
            cell2.alignment = TextAlignmentOptions.Midline;
        }

        CorrectAnimalText.text = "O animal era:\n" + StaticGameResume.correctAnimal.name + "\n(" + StaticGameResume.correctAnimal.scientificName +")";
        GuessedAnimalText.text = "Você adivinhou:\n" + StaticGameResume.guessedAnimal.name + "\n(" + StaticGameResume.guessedAnimal.scientificName + ")"; ;

        string path = StaticGameResume.guessedAnimal.id.ToString();
        var sprinte = Resources.Load<Sprite>(path);
        Image image = GuessedAnimalImage.GetComponent<Image>();
        image.sprite = sprinte;

        path = StaticGameResume.correctAnimal.id.ToString();
        sprinte = Resources.Load<Sprite>(path);
        image = CorrectAnimalImage.GetComponent<Image>();
        image.sprite = sprinte;

        if (StaticGameResume.guessedAnimal.id == StaticGameResume.correctAnimal.id) {
            CongratsMessage.text = "Parabéns você ganhou!";
            CongratsMessage.color = green;
            QuestionsTable.HeaderColor = green;
            QuestionsTable.Columns = 2;
        }
        else {
            CongratsMessage.text = "Que pena, você errou!\nTente novamente!";
            CongratsMessage.color = red;
            QuestionsTable.HeaderColor = red;
        }

        if (rowsCount == 1) {
            QuestionsTable.Rows = 2;
            QuestionsTable.GetCell(1, 0).text = "Nenhuma pergunta foi feita.";
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
