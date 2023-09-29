using System;

public class Question {
    public string question;
    public Func<bool> function;

    public Question(string question, Func<bool> function) {
        this.question = question;
        this.function = function;
    }

    public bool AskQuestion() {
        return this.function();
    }
}
