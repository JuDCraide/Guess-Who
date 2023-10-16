using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameResume {
    public static List<Question> askedQuestions = new List<Question> {
        new Question("Is your animal a Bilaterally Symmetrical?", Animal.SymmetryBilateral),
        new Question("Does your animal have a Exoskeleton?", Animal.SkeletonExoskeleton),
        new Question("Does your animal have a Endoskeleton?", Animal.SkeletonEndoskeleton),
        new Question("Does your animal have a Shell?", Animal.BodyCoverageShell),
        new Question("Does your animal Reproduce Sexually?", Animal.ReproductionSexually),
        new Question("Does your animal Reproduce Asexually?", Animal.ReproductionAsexually),
        new Question("Is your animal a Fecundation Internal?", Animal.FecundationInternal),
        new Question("Is your animal a Fecundation External?", Animal.FecundationExternal),
    };

    public static Animal guessedAnimal = new Animal(1, "Morcego", "Pteropus giganteus", true, true, false, Blood.Endotherms, Eggs.Viviparous, BodyCoverage.Fur, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
    public static Animal correctAnimal = new Animal(12, "�gua viva", "Chrysaora fuscescens", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Acoelomate, EmbryonicLeaflet.Diploblastic, MouthOrigin.None, Symmetry.Radial, Skeleton.None, Reproduction.Both, Fecundation.External);

    public static void setData(List<Question> askedQuestions, Animal guessedAnimal, Animal correctAnimal) {
        StaticGameResume.askedQuestions = askedQuestions;
        StaticGameResume.guessedAnimal = guessedAnimal;
        StaticGameResume.correctAnimal = correctAnimal;
    }

}
