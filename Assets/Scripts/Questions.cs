using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour {
    public List<Question> questions;
    public List<Character> characters;
    public Character chooseCharacter;
    public Question curentQuestion;
    public int curentQuestionIndex = 0;
    public int askedQuestions = 0;

    public TMPro.TextMeshProUGUI questionNumber;
    public TMPro.TextMeshProUGUI questionText;

    public AnsweredQuestions answers;

    // Start is called before the first frame update
    void Start() {

        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int i = 0; i < characters.Count; i++) {
            Character tmp = characters[i];
            int r = Random.Range(i, characters.Count);
            characters[i] = characters[r];
            characters[r] = tmp;
        }

        characters[0].InitializeCharacter(1, "Alex", false, false, false, false, true, false, false, false, false, Hair.black);
        characters[1].InitializeCharacter(2, "Alfred", false, false, false, false, true, false, true, false, false, Hair.ginger);
        characters[2].InitializeCharacter(3, "Anita", true, false, false, false, false, false, true, false, true, Hair.blond);
        characters[3].InitializeCharacter(4, "Anne", true, false, false, false, false, false, false, true, false, Hair.black);
        characters[4].InitializeCharacter(5, "Bernard", false, false, true, false, false, false, false, true, false, Hair.brunette);
        characters[5].InitializeCharacter(6, "Bill", false, false, false, true, false, false, false, false, true, Hair.ginger);
        characters[6].InitializeCharacter(7, "Charles", false, false, false, false, false, false, false, false, false, Hair.blond);
        characters[7].InitializeCharacter(8, "Claire", true, true, true, false, false, false, false, false, false, Hair.ginger);
        characters[8].InitializeCharacter(9, "David", false, false, false, true, false, false, false, false, true, Hair.blond);
        characters[9].InitializeCharacter(10, "Eric", false, false, true, false, false, false, false, false, false, Hair.blond);
        characters[10].InitializeCharacter(11, "Frans", false, false, false, false, false, false, false, false, false, Hair.ginger);
        characters[11].InitializeCharacter(12, "George", false, false, true, false, false, false, false, false, false, Hair.white);
        characters[12].InitializeCharacter(13, "Herman", false, false, false, false, false, false, false, true, false, Hair.ginger);
        characters[13].InitializeCharacter(14, "Joe", false, true, false, false, false, false, false, false, false, Hair.blond);
        characters[14].InitializeCharacter(15, "Maria", true, false, true, false, false, false, false, false, false, Hair.brunette);
        characters[15].InitializeCharacter(16, "Max", false, false, false, false, true, false, false, true, false, Hair.black);
        characters[16].InitializeCharacter(17, "Paul", false, true, false, false, false, false, false, true, false, Hair.white);
        characters[17].InitializeCharacter(18, "Peter", false, false, false, false, false, false, true, true, false, Hair.white);
        characters[18].InitializeCharacter(19, "Philip", false, false, false, true, false, false, false, false, true, Hair.black);
        characters[19].InitializeCharacter(20, "Richard", false, false, false, true, true, true, false, false, false, Hair.brunette);
        characters[20].InitializeCharacter(21, "Robert", false, false, false, false, false, false, true, true, true, Hair.brunette);
        characters[21].InitializeCharacter(22, "Sam", false, true, false, false, false, true, false, false, false, Hair.white);
        characters[22].InitializeCharacter(23, "Susan", true, false, false, false, false, false, false, false, true, Hair.white);
        characters[23].InitializeCharacter(24, "Tom", false, true, false, false, false, true, true, false, false, Hair.black);

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

        this.UpdateQuestionText();

    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(Character.openCharacters.Count);
        if (Character.openCharacters.Count == 1) {
            Debug.Log("Make guess");
        }
    }

    public void UpdateQuestionText() {
        if (askedQuestions >= 12) {
            questionNumber.SetText("You already asked 12 questions.");
            questionText.SetText("You can not ask any more questions!");

            var buttons = GameObject.FindObjectsOfType<Button>();
            foreach (Button button in buttons) {
                button.interactable = false;
            }
        }
        else {
            curentQuestion = questions[curentQuestionIndex];
            questionNumber.SetText("Question " + curentQuestionIndex + 1);
            questionText.SetText(curentQuestion.question);
        }
    }

    public void NextQuestion() {
        curentQuestionIndex++;
        if (curentQuestionIndex >= questions.Count) {
            curentQuestionIndex = 0;
        }
        this.UpdateQuestionText();
    }

    public void PreviousQuestion() {
        curentQuestionIndex--;
        if (curentQuestionIndex <= -1) {
            curentQuestionIndex = questions.Count - 1;
        }
        this.UpdateQuestionText();
    }


    public void AskQuestion() {
        bool answer = curentQuestion.AskQuestion();
        answers.AddAnsware(curentQuestion, answer);

        questions.Remove(curentQuestion);
        askedQuestions++;
        curentQuestionIndex = 0;
        this.UpdateQuestionText();
    }

}
