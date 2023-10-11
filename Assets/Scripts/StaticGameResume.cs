using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameResume {
    public static List<Question> askedQuestions = new List<Question> {
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
