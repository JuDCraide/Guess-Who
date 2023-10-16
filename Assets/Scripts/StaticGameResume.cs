using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameResume {
    public static List<Question> askedQuestions = new List<Question> {
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
    };

    public static Animal guessedAnimal = new Animal(1, "Morcego", "Pteropus giganteus", true, true, false, Blood.Endotherms, Eggs.Viviparous, BodyCoverage.Fur, Coelomate.Coelomate, EmbryonicLeaflet.Triploblastic, MouthOrigin.Deuterostome, Symmetry.Bilateral, Skeleton.Endoskeleton, Reproduction.Sexually, Fecundation.Internal);
    public static Animal correctAnimal = new Animal(12, "Água viva", "Chrysaora fuscescens", false, false, false, Blood.None, Eggs.Oviparous, BodyCoverage.None, Coelomate.Acoelomate, EmbryonicLeaflet.Diploblastic, MouthOrigin.None, Symmetry.Radial, Skeleton.None, Reproduction.Both, Fecundation.External);

    public static void setData(List<Question> askedQuestions, Animal guessedAnimal, Animal correctAnimal) {
        StaticGameResume.askedQuestions = askedQuestions;
        StaticGameResume.guessedAnimal = guessedAnimal;
        StaticGameResume.correctAnimal = correctAnimal;
    }

}
