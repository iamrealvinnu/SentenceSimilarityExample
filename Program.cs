using System;

class Program
{
    static void Main(string[] args)
    {
        var sampleData = new MLModel1.ModelInput()
        {
            Sentence1 = "I love coffee",
            Sentence2 = "The sky is blue",
        };

        var result = MLModel1.Predict(sampleData);
        Console.WriteLine($"Predicted Similarity Score: {result.Score}");
        Console.ReadLine();
    }
}
