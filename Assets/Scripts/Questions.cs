using System.Collections.Generic;
using UnityEngine;


public class Questions : MonoBehaviour {
    public List<Question> questions;
    public List<Character> characters;
    private Character chooseCharacter;
    public Question curentQuestion;
    public int curentQuestionIndex;

    public TMPro.TextMeshProUGUI questionNumber;
    public TMPro.TextMeshProUGUI questionText;

    // Start is called before the first frame update
    void Start() {

        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int i = 0; i < characters.Count; i++) {
            Character tmp = characters[i];
            int r = Random.Range(i, characters.Count);
            characters[i] = characters[r];
            characters[r] = tmp;
        }

        characters[1 - 1].InitializeCharacter(1, "Alex", false, false, false, false, true, false, false, false, false, Hair.black);
        characters[2 - 1].InitializeCharacter(2, "Alfred", false, false, false, false, true, false, true, false, false, Hair.ginger);
        characters[3 - 1].InitializeCharacter(3, "Anita", true, false, false, false, false, false, true, false, true, Hair.blond);
        characters[4 - 1].InitializeCharacter(4, "Anne", true, false, false, false, false, false, false, true, false, Hair.black);
        characters[5 - 1].InitializeCharacter(5, "Bernard", false, false, true, false, false, false, false, true, false, Hair.brunette);
        characters[6 - 1].InitializeCharacter(6, "Bill", false, false, false, true, false, false, false, false, true, Hair.ginger);
        characters[7 - 1].InitializeCharacter(7, "Charles", false, false, false, false, false, false, false, false, false, Hair.blond);
        characters[8 - 1].InitializeCharacter(8, "Claire", true, true, true, false, false, false, false, false, false, Hair.ginger);
        characters[9 - 1].InitializeCharacter(9, "David", false, false, false, true, false, false, false, false, true, Hair.blond);
        characters[10 - 1].InitializeCharacter(10, "Eric", false, false, true, false, false, false, false, false, false, Hair.blond);
        characters[11 - 1].InitializeCharacter(11, "Frans", false, false, false, false, false, false, false, false, false, Hair.ginger);
        characters[12 - 1].InitializeCharacter(12, "George", false, false, true, false, false, false, false, false, false, Hair.white);
        characters[13 - 1].InitializeCharacter(13, "Herman", false, false, false, false, false, false, false, true, false, Hair.ginger);
        characters[14 - 1].InitializeCharacter(14, "Joe", false, true, false, false, false, false, false, false, false, Hair.blond);
        characters[15 - 1].InitializeCharacter(15, "Maria", true, false, true, false, false, false, false, false, false, Hair.brunette);
        characters[16 - 1].InitializeCharacter(16, "Max", false, false, false, false, true, false, false, true, false, Hair.black);
        characters[17 - 1].InitializeCharacter(17, "Paul", false, true, false, false, false, false, false, true, false, Hair.white);
        characters[18 - 1].InitializeCharacter(18, "Peter", false, false, false, false, false, false, true, true, false, Hair.white);
        characters[19 - 1].InitializeCharacter(19, "Philip", false, false, false, true, false, false, false, false, true, Hair.black);
        characters[20 - 1].InitializeCharacter(20, "Richard", false, false, false, true, true, true, false, false, false, Hair.brunette);
        characters[21 - 1].InitializeCharacter(21, "Robert", false, false, false, false, false, false, true, true, true, Hair.brunette);
        characters[22 - 1].InitializeCharacter(22, "Sam", false, true, false, false, false, true, false, false, false, Hair.white);
        characters[23 - 1].InitializeCharacter(23, "Susan", true, false, false, false, false, false, false, false, true, Hair.white);
        characters[24 - 1].InitializeCharacter(24, "Tom", false, true, false, false, false, true, true, false, false, Hair.black);

        int randomindex = Random.Range(0, characters.Count);
        chooseCharacter = characters[randomindex];

        questions = new List<Question>{
            new Question("Is your character a WOMAN?", chooseCharacter.IsWoman),
            new Question("Is your character a BLOND?", chooseCharacter.IsBlond),
            new Question("Is your character a GINGER?", chooseCharacter.IsGinger),
            new Question("Is your character a BRUNETTE?", chooseCharacter.IsBrunette),
            new Question("Is your character a BALD?", chooseCharacter.IsBald),
            new Question("Does your character has HAT?", chooseCharacter.HasHat),
            new Question("Does your character has GLASSES?", chooseCharacter.HasGlasses),
            new Question("Does your character has BEARD?", chooseCharacter.HasBeard),
            new Question("Does your character has MUSTACHE?", chooseCharacter.HasMustache),
            new Question("Does your character has BLUE EYES?", chooseCharacter.HasBlueEyes),
            new Question("Does your character has BIG NOSE?", chooseCharacter.HasBigNose),
            new Question("Does your character has PINK CHEEKS?", chooseCharacter.HasPinkCheeks),
            new Question("Does your character has BLACK HAIR?", chooseCharacter.HasBlackHair),
            new Question("Does your character has WHITE HAIR?", chooseCharacter.HasWhiteHair),
        };

        curentQuestionIndex = 0;
        curentQuestion = questions[curentQuestionIndex];
        this.UpdateQuestionText();

        //Debug.Log(chooseCharacter.name);
        //Debug.Log(questions[4].question);
        //Debug.Log(questions[4].AskQuestion());
    }

    // Update is called once per frame
    void Update() {

    }

    public void UpdateQuestionText() {
        questionNumber.SetText("Question " + curentQuestionIndex);
        questionText.SetText(curentQuestion.question);
    }

    public void NextQuestion() {
        curentQuestionIndex++;
        if (curentQuestionIndex >= questions.Count) {
            curentQuestionIndex = 0;
        }
        curentQuestion = questions[curentQuestionIndex];
        // Debug.Log(curentQuestionIndex);
        this.UpdateQuestionText();
    }

    public void PreviousQuestion() {
        curentQuestionIndex--;
        if (curentQuestionIndex <= -1) {
            curentQuestionIndex = questions.Count - 1;
        }
        curentQuestion = questions[curentQuestionIndex];
        // Debug.Log(curentQuestionIndex);
        this.UpdateQuestionText();
    }


    public void AskQuestion() {
        //Debug.Log(questions.Count);
        curentQuestion.AskQuestion();
        questions.Remove(curentQuestion);
        curentQuestionIndex = 0;
        curentQuestion = questions[curentQuestionIndex];
        //Debug.Log(questions.Count);
        this.UpdateQuestionText();
    }

}
