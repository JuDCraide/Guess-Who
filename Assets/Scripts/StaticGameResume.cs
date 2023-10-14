using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameResume {
    public static List<Question> askedQuestions = new List<Question> {
        new Question("Is your animal a Bilaterally Symmetrical?", Animal.SymmetryBilateral),
        new Question("Does your animal have an Incomplete Digestive System?", Animal.DigestiveSystemIncomplete),
        new Question("Does your animal have a Complete Digestive System?", Animal.DigestiveSystemComplete),
        new Question("Does your animal have a Exoskeleton?", Animal.SkeletonExoskeleton),
        new Question("Does your animal have a Endoskeleton?", Animal.SkeletonEndoskeleton),
        new Question("Does your animal have a Shell?", Animal.SkeletonShell),
        new Question("Does your animal Reproduce Sexually?", Animal.ReproductionSexually),
        new Question("Does your animal Reproduce Asexually?", Animal.ReproductionAsexually),
        new Question("Is your animal a Fecundation Internal?", Animal.FecundationInternal),
        new Question("Is your animal a Fecundation External?", Animal.FecundationExternal),     
    };
    
    public static Animal guessedAnimal = new Animal(1, "Human", "SN", true, false, Blood.Endotherms, Eggs.None, BodyCoverage.Fur, Coelomate.Coelomate, EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, DigestiveSystem.Complete, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
    public static Animal correctAnimal = new Animal(3, "Human", "SN", true, false, Blood.Endotherms, Eggs.None, BodyCoverage.Fur, Coelomate.Coelomate, EmbryonicLeaflet.Triblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, DigestiveSystem.Complete, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);

    public static void setData(List<Question> askedQuestions, Animal guessedAnimal, Animal correctAnimal) {
        StaticGameResume.askedQuestions = askedQuestions;
        StaticGameResume.guessedAnimal = guessedAnimal;
        StaticGameResume.correctAnimal = correctAnimal;
    }

}
