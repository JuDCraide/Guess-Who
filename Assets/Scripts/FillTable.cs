using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.TableUI;

public class FillTable : MonoBehaviour {
    public TableUI Questions;
    public TableUI GuessedCharacter;
    public TableUI CorrectCharacter;
    // Start is called before the first frame update
    void Start() {
        //List<Question> questions = new List<Question>{
        //    new Question("Is your character a WOMAN?", Character.IsWoman),
        //    new Question("Is your character BALD?", Character.IsBald),
        //    new Question("Is your character BLOND?", Character.IsBlond),
        //    new Question("Is your character GINGER?", Character.IsGinger),
        //    new Question("Is your character BRUNETTE?", Character.IsBrunette),
        //    new Question("Does your character has BLACK HAIR?", Character.HasBlackHair),
        //    new Question("Does your character has WHITE HAIR?", Character.HasWhiteHair),
        //    //new Question("Does your character has a HAT?", Character.HasHat),
        //    //new Question("Does your character has GLASSES?", Character.HasGlasses),
        //    //new Question("Does your character has a BEARD?", Character.HasBeard),
        //};

        int rowsCount = StaticGameResume.askedQuestions.Count + 1;

        Questions.Rows = rowsCount;
        GuessedCharacter.Rows = rowsCount;
        CorrectCharacter.Rows = rowsCount;


        if(StaticGameResume.guessedCharacter.id == StaticGameResume.correctCharacter.id) {
            Debug.Log("ACERTO");
            CorrectCharacter.gameObject.SetActive(false);
        }

        GuessedCharacter.GetCell(0, 0).text = StaticGameResume.guessedCharacter.name;
        CorrectCharacter.GetCell(0, 0).text = StaticGameResume.correctCharacter.name;

        for (int i = 1; i < rowsCount; i++) {
            Questions.GetCell(i, 0).text = "   " + StaticGameResume.askedQuestions[i - 1].question;
            GuessedCharacter.GetCell(i, 0).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.guessedCharacter) ? "Yes" : "No");
            CorrectCharacter.GetCell(i, 0).text = "   " + (StaticGameResume.askedQuestions[i - 1].AskQuestion(StaticGameResume.correctCharacter) ? "Yes" : "No");
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
