
using Lecture14;

Question GetQuestion(string rawQuestion)
{
    string[] lineParts = rawQuestion.Split('|');

    Question question = new Question();
    question.Text = lineParts[0];

    char correct = lineParts[1][0];
    int correctIndex = correct - 'A';

    Answer[] answers = new Answer[lineParts.Length - 2];
    for (int i = 0; i < answers.Length; i++)
    {
        Answer newAnswer = new Answer();
        newAnswer.Text = lineParts[i + 2];
        if (i == correctIndex)
        {
            newAnswer.IsCorrect = true;
            question.CorrectAnswer = newAnswer;
        }

        answers[i] = newAnswer;
    }

    question.Answers = answers;

    return question;
}

bool AskQuestion(Question question)
{
    Console.WriteLine(question.Text);
    Console.WriteLine();

    for (int i = 0; i < question.Answers.Length; i++)
    {
        Answer answer = question.Answers[i];
        Console.Write(i + 1);
        Console.Write("): ");
        Console.WriteLine(answer.Text);
    }

    string response = Console.ReadLine();
    int responseNumber = int.Parse(response) - 1;
    Answer responseAnswer = question.Answers[responseNumber];

    if (responseAnswer.IsCorrect)
    {
        Console.WriteLine("Spravne");
        Console.ReadLine();
        return false;
    }

    Console.WriteLine("Spatne, spravne bylo:");
    Console.WriteLine(question.CorrectAnswer.Text);
    Console.ReadLine();

    return true;
}


string[] rawData = File.ReadAllLines("questions.data");

Question[] questions = new Question[rawData.Length];
for (int i = 0; i < rawData.Length; i++)
{
    string raw = rawData[i];
    questions[i] = GetQuestion(raw);
}



foreach (Question question in questions)
{
    AskQuestion(question);
}

Console.WriteLine("End");

