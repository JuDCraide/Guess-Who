using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameResume {
    public static List<Question> askedQuestions = new List<Question> {
        new Question("Does your animal have Intracellular Digestion?", Animal.IntracellularDigestion),
        new Question("Is your animal a Vertebrate?", Animal.Vertebrate),
        new Question("Does your animal have Blood?", Animal.Blood),
        new Question("Can your animal Lay Eggs?", Animal.LayEggs),
        new Question("Can your animal Fly?", Animal.Fly),
        new Question("Does your animal has Fur?", Animal.Fur),
        new Question("Is your animal a Acoelomate?", Animal.CoelomateAcoelomate),
        new Question("Is your animal a Pseudocoelomate?", Animal.CoelomatePseudocoelomate),
        new Question("Is your animal a Coelomate?", Animal.CoelomateCoelomate),
    };
    public static Animal guessedAnimal = new Animal(1, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);
    public static Animal correctAnimal = new Animal(3, "Humano", false, true, true, false, false, true, Coelomate.Coelomate,EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral,DigestiveSystem.Complete,Skeleton.Endoskeleton,Reproduction.Sexually,Fecundation.Internal);



    public static void setData(List<Question> askedQuestions, Animal guessedAnimal, Animal correctAnimal) {
        StaticGameResume.askedQuestions = askedQuestions;
        StaticGameResume.guessedAnimal = guessedAnimal;
        StaticGameResume.correctAnimal = correctAnimal;
    }

}
