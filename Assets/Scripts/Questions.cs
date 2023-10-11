using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Questions : MonoBehaviour {
    public List<Question> questions;
    public List<Animal> animals;
    public Animal chooseAnimal;
    public Question curentQuestion;
    public int curentQuestionIndex;
    public List<Question> askedQuestions;

    public TMPro.TextMeshProUGUI questionNumber;
    public TMPro.TextMeshProUGUI questionText;

    public AnsweredQuestions answers;

    public GameObject guessImage;
    public TMPro.TextMeshProUGUI guessText;
    public Button guessButton;


    void Start() {

        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int i = 0; i < animals.Count; i++) {
            Animal tmp = animals[i];
            int r = Random.Range(i, animals.Count);
            animals[i] = animals[r];
            animals[r] = tmp;
        }

        Animal.ClearOpenAnimalList();
        animals[0].InitializeAnimal(1, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[1].InitializeAnimal(2, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[2].InitializeAnimal(3, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[3].InitializeAnimal(4, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[4].InitializeAnimal(5, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[5].InitializeAnimal(6, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[6].InitializeAnimal(7, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[7].InitializeAnimal(8, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[8].InitializeAnimal(9, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[9].InitializeAnimal(10, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[10].InitializeAnimal(11, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[11].InitializeAnimal(12, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[12].InitializeAnimal(13, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[13].InitializeAnimal(14, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[14].InitializeAnimal(15, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[15].InitializeAnimal(16, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[16].InitializeAnimal(17, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[17].InitializeAnimal(18, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[18].InitializeAnimal(19, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[19].InitializeAnimal(20, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[20].InitializeAnimal(21, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[21].InitializeAnimal(22, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[22].InitializeAnimal(23, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
        animals[23].InitializeAnimal(24, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);

        int randomindex = Random.Range(0, animals.Count);
        chooseAnimal = animals[randomindex];

        questions = new List<Question>{
            new Question("Does your animal have Intracellular Digestion?", Animal.IntracellularDigestion),
            new Question("Is your animal a Vertebrate?", Animal.Vertebrate),
            new Question("Does your animal have Blood?", Animal.Blood),
            new Question("Can your animal Lay Eggs?", Animal.LayEggs),
            new Question("Can your animal Fly?", Animal.Fly),
            new Question("Does your animal has Fur?", Animal.Fur),
            new Question("Is your animal a Acoelomate?", Animal.CoelomateAcoelomate),
            new Question("Is your animal a Pseudocoelomate?", Animal.CoelomatePseudocoelomate),
            new Question("Is your animal a Coelomate?", Animal.CoelomateCoelomate),
            new Question("Is your animal a Driblastic?", Animal.EmbryonicLeafletDriblastic),
            new Question("Is your animal a Triblastic?", Animal.EmbryonicLeafletTriblastic),
            //new Question("Is your animal not ?", Animal.EmbryonicLeafletNone),
            new Question("Is your animal a Protostome?", Animal.MouthOriginProtostome),
            new Question("Is your animal a Deuterostome?", Animal.MouthOriginDeuterostome),
            //new Question("Is your animal a Coelomate?", Animal.MouthOriginNone),
            new Question("Is your animal a Radially Symmetrical?", Animal.SymmetryRadial),
            new Question("Is your animal a Bilaterally Symmetrical?", Animal.SymmetryBilateral),
            //new Question("Is your animal a Coelomate?", Animal.SymmetryNone),
            new Question("Does your animal have an Incomplete Digestive System?", Animal.DigestiveSystemIncomplete),
            new Question("Does your animal have a Complete Digestive System?", Animal.DigestiveSystemComplete),
            //new Question("Is your animal a Coelomate?", Animal.DigestiveSystemNone),
            new Question("Does your animal have a Exoskeleton?", Animal.SkeletonExoskeleton),
            new Question("Does your animal have a Endoskeleton?", Animal.SkeletonEndoskeleton),
            new Question("Does your animal have a Shell?", Animal.SkeletonShell),
            //new Question("Is your animal a Coelomate?", Animal.SkeletonNone),
            new Question("Does your animal Reproduce Sexually?", Animal.ReproductionSexually),
            new Question("Does your animal Reproduce Asexually?", Animal.ReproductionAsexually),
            new Question("Is your animal a Fecundation Internal?", Animal.FecundationInternal),
            new Question("Is your animal a Fecundation External?", Animal.FecundationExternal),
            // new Question("Is your animal a Coelomate?", Animal.HabitatAquatic),
            // new Question("Is your animal a Coelomate?", Animal.HabitatTerrestrial),
            // new Question("Is your animal a Coelomate?", Animal.HabitatBoth),            
        };
        askedQuestions = new List<Question>();
        curentQuestionIndex = 0;

        this.UpdateQuestionText();
    }

    void Update() {
        if (Animal.openAnimals.Count == 1) {
            this.ShowFinishGame();
        }
        else {
            this.HideFinishGame();
        }
    }
    public void ShowFinishGame() {
        int finalAnimalId = Animal.openAnimals[0];
        var finalAnimal = animals[finalAnimalId - 1];
        guessText.SetText("Do you want to choose " + finalAnimal.name + " as your final guess?");
        string path = finalAnimalId.ToString();
        var sprinte = Resources.Load<Sprite>(path);
        Image image = this.guessImage.GetComponent<Image>();
        image.sprite = sprinte;

        guessImage.SetActive(true);
        guessText.gameObject.SetActive(true);
        guessButton.gameObject.SetActive(true);
    }

    public void HideFinishGame() {
        guessImage.SetActive(false);
        guessText.gameObject.SetActive(false);
        guessButton.gameObject.SetActive(false);
    }

    public void FinishGame() {
        int finalAnimalId = Animal.openAnimals[0];
        var finalAnimal = animals[finalAnimalId - 1];
        StaticGameResume.setData(askedQuestions, finalAnimal, chooseAnimal);
        SceneManager.LoadScene("End");
    }

    public void UpdateQuestionText() {
        if (askedQuestions.Count >= 10) {
            questionNumber.SetText("You already asked 10 questions.");
            questionText.SetText("You can not ask any more questions!");

            var buttons = GameObject.FindObjectsOfType<Button>();
            foreach (Button button in buttons) {
                if (button.name != "GuessButton") {
                    button.interactable = false;
                }
            }
        }
        else {
            curentQuestion = questions[curentQuestionIndex];
            questionNumber.SetText("Question " + (curentQuestionIndex + 1));
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
        bool answer = curentQuestion.AskQuestion(chooseAnimal);
        answers.AddAnsware(curentQuestion, answer);

        questions.Remove(curentQuestion);
        askedQuestions.Add(curentQuestion);
        curentQuestionIndex = 0;
        this.UpdateQuestionText();
    }

}
