using System;

public class Question {
    public string question;
    public Func<Animal, bool> function;

    public Question(string question, Func<Animal, bool> function) {
        this.question = question;
        this.function = function;
    }

    public bool AskQuestion(Animal c) {
        return this.function(c);
    }
}
