public class Quiz
{
    private string question;
    private string[] options;
    private int correctAnswer;

    public Quiz(string question, string[] options, int correctAnswer)
    {
        this.question = question;
        this.options = options;
        this.correctAnswer = correctAnswer;
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(question);
        foreach (string option in options)
        {
            Console.WriteLine(option);
        }
    }

    public bool CheckAnswer(int userAnswer)
    {
        return userAnswer == correctAnswer;
    }

    public static void Main(string[] args)
    {
        Quiz[] quizzes = new Quiz[]
        {
            new Quiz("Question 1 ?", new string[] { "1. Option 1", "2. Option 2", "3. Option 3" }, 1),
            new Quiz("Question 2 ?", new string[] { "1. Option 1", "2. Option 2", "3. Option 3" }, 2)
        };

        int score = 0;

        foreach (var quiz in quizzes)
        {
            quiz.DisplayQuestion();
            Console.Write("Entrez le numéro de votre réponse : ");
            if (int.TryParse(Console.ReadLine(), out int userAnswer))
            {
                if (quiz.CheckAnswer(userAnswer))
                {
                    Console.WriteLine("Correct !");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un numéro.");
            }
        }

        Console.WriteLine($"Votre score final est : {score}/{quizzes.Length}");
    }
}