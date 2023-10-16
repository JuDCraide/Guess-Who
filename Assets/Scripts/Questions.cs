using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public List<Question> questions;
    public List<Animal> animals;
    public Animal chooseAnimal;
    public Question currentQuestion;
    public int currentQuestionIndex;
    public List<Question> askedQuestions;

    public TMPro.TextMeshProUGUI questionNumber;
    public TMPro.TextMeshProUGUI questionText;

    public AnsweredQuestions answers;

    public GameObject guessImage;
    public TMPro.TextMeshProUGUI guessText;
    public Button guessButton;


    void Start()
    {

        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int i = 0; i < animals.Count; i++)
        {
            Animal tmp = animals[i];
            int r = Random.Range(i, animals.Count);
            animals[i] = animals[r];
            animals[r] = tmp;
        }

        Animal.ClearOpenAnimalList();
        animals[0].InitializeAnimal(1, "Morcego", "Pteropus giganteus", true, true, false, Blood.Endotherms, Eggs.Viviparous, BodyCoverage.Fur, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[1].InitializeAnimal(2, "Ornitorrinco", "Ornithorhynchus anatinus", true, false, false, Blood.Endotherms, Eggs.Oviparous, BodyCoverage.Fur, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[2].InitializeAnimal(3, "Tartaruga", "Trachemys dorbigni", true, false, false, Blood.Ectotherms, Eggs.Oviparous, BodyCoverage.Scales, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Both, Reproduction.Sexually, Fecundation.Internal);
        animals[3].InitializeAnimal(4, "Caracol", "Cornu aspersum", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.Shell, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.None, Reproduction.Sexually, Fecundation.Internal);
        animals[4].InitializeAnimal(5, "Peixe palhaço", "Amphiprion ocellaris", true, false, false, Blood.Ectotherms, Eggs.Oviparous, BodyCoverage.Scales, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.External);
        animals[5].InitializeAnimal(6, "Pomba", "Columba livia", true, true, false, Blood.Endotherms, Eggs.Oviparous, BodyCoverage.Feathers, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[6].InitializeAnimal(7, "Gorila", "Gorilla gorilla gorilla", true, false, false, Blood.Endotherms, Eggs.Viviparous, BodyCoverage.Fur, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[7].InitializeAnimal(8, "Borboleta", "Limenitis archippus", false, true, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.Exoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[8].InitializeAnimal(9, "Escorpião", "Heterometrus laoticus", false, false, true, Blood.None, Eggs.Viviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.Exoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[9].InitializeAnimal(10, "Sapo", "Litoria chloris", true, false, false, Blood.Ectotherms, Eggs.Oviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.External);
        animals[10].InitializeAnimal(11, "Esponja", "Aplysina fistularis", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Acoelomate, EmbryonicLeaflet.None, MouthOrigin.None, Symmetry.Radial, Skeleton.None, Reproduction.Both, Fecundation.External);
        animals[11].InitializeAnimal(12, "Água viva", "Chrysaora fuscescens", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Acoelomate, EmbryonicLeaflet.Diploblastic, MouthOrigin.None, Symmetry.Radial, Skeleton.None, Reproduction.Both, Fecundation.External);
        animals[12].InitializeAnimal(13, "Polvo", "Octopus vulgaris", false, false, true, Blood.Ectotherms, Eggs.Oviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.None, Reproduction.Sexually, Fecundation.Internal);
        animals[13].InitializeAnimal(14, "Estrela do mar", "Asterias rubens", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.External);
        animals[14].InitializeAnimal(15, "Platelminto dividido", "Pseudoceros dimidiatus", false, false, false, Blood.Ectotherms, Eggs.Oviparous, BodyCoverage.None, Coelomate.Acoelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.None, Reproduction.Both, Fecundation.Internal);
        animals[15].InitializeAnimal(16, "Lombriga", "Ascaris lumbricoides", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Pseudocoelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.None, Symmetry.Bilateral, Skeleton.None, Reproduction.Sexually, Fecundation.Internal);
        animals[16].InitializeAnimal(17, "Minhoca", "Lumbricus terrestris", false, false, false, Blood.Endotherms, Eggs.Oviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.None, Reproduction.Sexually, Fecundation.Internal);
        animals[17].InitializeAnimal(18, "Formiga", "Camponotus sp.", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.Exoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[18].InitializeAnimal(19, "Baleia", "Megaptera novaeangliae", true, false, false, Blood.Endotherms, Eggs.Oviparous, BodyCoverage.None, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[19].InitializeAnimal(20, "Tubarão", "Carcharodon carcharias", true, false, false, Blood.Ectotherms, Eggs.Ovoviviparous, BodyCoverage.Scales, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[20].InitializeAnimal(21, "Ostra", "Crassostrea gigas", false, false, false, Blood.Endotherms, Eggs.Oviparous, BodyCoverage.Shell, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.Exoskeleton, Reproduction.Sexually, Fecundation.External);
        animals[21].InitializeAnimal(22, "Pinguim", "Aptenodytes forsteri", true, false, false, Blood.Endotherms, Eggs.Oviparous, BodyCoverage.Feathers, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[22].InitializeAnimal(23, "Cobra", "Crotalus durissus", true, false, true, Blood.Ectotherms, Eggs.Ovoviviparous, BodyCoverage.Scales, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
        animals[23].InitializeAnimal(24, "Caranguejo Eremita", "Neohelice granulata", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.Shell, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Protostome, Symmetry.Bilateral, Skeleton.Exoskeleton, Reproduction.Sexually, Fecundation.Internal);

        int randomIndex = Random.Range(0, animals.Count);
        chooseAnimal = animals[randomIndex];

        questions = new List<Question>{
            new Question("Seu animal pode Voar?", Animal.Fly),
            new Question("Seu animal é Venenoso?", Animal.Venomous),
            new Question("Seu animal é Endotermo (Sangue Quente)?", Animal.BloodEndotherms),
            new Question("Seu animal é Ectotermo (Sangue Frio)?", Animal.BloodEctotherms),
            new Question("Seu animal é Ovíparo?", Animal.EggsOviparous),
            new Question("Seu animal é Ovovivíparo?", Animal.EggsOvoviviparous),
            new Question("Seu animal é Vivíparo?", Animal.EggsViviparous),
            new Question("Seu animal tem Pelos?", Animal.BodyCoverageFur),
            new Question("Seu animal tem Penas?", Animal.BodyCoverageFeathers),
            new Question("Seu animal tem Escamas?", Animal.BodyCoverageScales),
            new Question("Seu animal tem Concha?", Animal.BodyCoverageShell),
            new Question("Seu animal é Acelomado?", Animal.CoelomateAcoelomate),
            new Question("Seu animal é Pseudocelomado?", Animal.CoelomatePseudocoelomate),
            new Question("Seu animal é Celomado?", Animal.CoelomateCoelomate),
            new Question("Seu animal é Diblástico?", Animal.EmbryonicLeafletDiploblastic),
            new Question("Seu animal é Triblástico?", Animal.EmbryonicLeafletTriploblastic),
            new Question("Seu animal é Protostômio?", Animal.MouthOriginProtostome),
            new Question("Seu animal é Deuterostômio?", Animal.MouthOriginDeuterostome),
            new Question("Seu animal tem Simetria Radial?", Animal.SymmetryRadial),
            new Question("Seu animal tem Simetria Bilateral?", Animal.SymmetryBilateral),
            new Question("Seu animal tem um Exoesqueleto?", Animal.SkeletonExoskeleton),
            new Question("Seu animal tem um Endosqueleto?", Animal.SkeletonEndoskeleton),
            new Question("Seu animal faz Reprodução Sexuada?", Animal.ReproductionSexually),
            new Question("Seu animal faz Reprodução Assexuada?", Animal.ReproductionAsexually),
            new Question("Seu animal tem Fecundação Interna?", Animal.FecundationInternal),
            new Question("Seu animal tem Fecundação Externa?", Animal.FecundationExternal),
            new Question("Seu animal é Vertebrado?", Animal.Vertebrate),
        };
        askedQuestions = new List<Question>();
        currentQuestionIndex = 0;

        this.UpdateQuestionText();
    }

    void Update()
    {
        if (Animal.openAnimals.Count == 1)
        {
            this.ShowFinishGame();
        }
        else
        {
            this.HideFinishGame();
        }
    }
    public void ShowFinishGame()
    {
        int finalAnimalId = Animal.openAnimals[0];
        var finalAnimal = animals[finalAnimalId - 1];
        guessText.SetText("Você quer adivinhar " + finalAnimal.name + ", como escolha final?");
        string path = finalAnimalId.ToString();
        var sprite = Resources.Load<Sprite>(path);
        Image image = this.guessImage.GetComponent<Image>();
        image.sprite = sprite;

        guessImage.SetActive(true);
        guessText.gameObject.SetActive(true);
        guessButton.gameObject.SetActive(true);
    }

    public void HideFinishGame()
    {
        guessImage.SetActive(false);
        guessText.gameObject.SetActive(false);
        guessButton.gameObject.SetActive(false);
    }

    public void FinishGame()
    {
        int finalAnimalId = Animal.openAnimals[0];
        var finalAnimal = animals[finalAnimalId - 1];
        StaticGameResume.setData(askedQuestions, finalAnimal, chooseAnimal);
        SceneManager.LoadScene("End");
    }

    public void UpdateQuestionText()
    {
        if (askedQuestions.Count >= 10)
        {
            questionNumber.SetText("Você já fez 10 perguntas.");
            questionText.SetText("Você não pode fazer mais perguntas!");

            var buttons = GameObject.FindObjectsOfType<Button>();
            foreach (Button button in buttons)
            {
                if (button.name != "GuessButton")
                {
                    button.interactable = false;
                }
            }
        }
        else
        {
            currentQuestion = questions[currentQuestionIndex];
            questionNumber.SetText("Pergunta " + (currentQuestionIndex + 1));
            questionText.SetText(currentQuestion.question);
        }
    }

    public void NextQuestion()
    {
        currentQuestionIndex++;
        if (currentQuestionIndex >= questions.Count)
        {
            currentQuestionIndex = 0;
        }
        this.UpdateQuestionText();
    }

    public void PreviousQuestion()
    {
        currentQuestionIndex--;
        if (currentQuestionIndex <= -1)
        {
            currentQuestionIndex = questions.Count - 1;
        }
        this.UpdateQuestionText();
    }


    public void AskQuestion()
    {
        bool answer = currentQuestion.AskQuestion(chooseAnimal);
        answers.AddAnswer(currentQuestion, answer);

        questions.Remove(currentQuestion);
        askedQuestions.Add(currentQuestion);
        currentQuestionIndex = 0;
        this.UpdateQuestionText();
    }

}
