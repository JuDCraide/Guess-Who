using System;

public class Question {
    public string question;
    public Func<Character, bool> function;

    public Question(string question, Func<Character, bool> function) {
        this.question = question;
        this.function = function;
    }

    public bool AskQuestion(Character c) {
        return this.function(c);
    }
}
