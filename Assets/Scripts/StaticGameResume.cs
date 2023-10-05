using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameResume {
    public static List<Question> askedQuestions = new List<Question> {
            new Question("Is your character a WOMAN?", Character.IsWoman),
            new Question("Is your character BALD?", Character.IsBald),
            new Question("Is your character BLOND?", Character.IsBlond),
            new Question("Is your character GINGER?", Character.IsGinger),
            new Question("Is your character BRUNETTE?", Character.IsBrunette),
            new Question("Does your character has BLACK HAIR?", Character.HasBlackHair),
            new Question("Does your character has WHITE HAIR?", Character.HasWhiteHair),
            new Question("Does your character has a HAT?", Character.HasHat),
            new Question("Does your character has GLASSES?", Character.HasGlasses),
            new Question("Does your character has a BEARD?", Character.HasBeard),
        };
    public static Character guessedCharacter = new Character(1, "Alex", false, false, false, false, true, false, false, false, false, Hair.black);
    public static Character correctCharacter = new Character(3, "Anita", true, false, false, false, false, false, true, false, true, Hair.blond);



    public static void setData(List<Question> askedQuestions, Character guessedCharacter, Character correctCharacter) {
        StaticGameResume.askedQuestions = askedQuestions;
        StaticGameResume.guessedCharacter = guessedCharacter;
        StaticGameResume.correctCharacter = correctCharacter;
    }

}
