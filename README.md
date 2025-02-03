# Sentence Similarity Example using ML.NET

A C# implementation of sentence similarity analysis using ML.NET, leveraging Microsoft's ML.NET Model Builder for accurate text comparison.

## 🎯 Project Overview
This project implements sentence similarity comparison using ML.NET framework. It was developed to explore ML.NET's natural language processing capabilities, specifically focusing on measuring semantic similarity between text sentences.

## 🚀 Features
- Text similarity analysis using ML.NET
- Pre-trained model for immediate use
- Sample dataset with 500 sentence pairs
- Easy-to-use implementation
- Model Builder integration

## 📁 Repository Structure

SentenceSimilarityExample/

├── Source Files

│   ├── Program.cs                    # Main program entry point

│   ├── MLModel1.consumption.cs       # Model consumption logic

│   ├── MLModel1.training.cs          # Model training implementation

│   ├── MLModel1.mbconfig            # Model Builder configuration

│   └── MLModel1.mlnet               # Trained ML.NET model

├── Data

│   └── sentence_similarity_500.csv   # Training dataset

└── Project Files

    ├── SentenceSimilarityExample.csproj
    
    └── SentenceSimilarityExample.sln
    
## 🔧 Prerequisites
- Visual Studio 2022
- .NET 6.0 or later
- ML.NET Model Builder extension for Visual Studio

## 🏃‍♂️ Getting Started

1. **Clone the Repository**
   ```bash
   git clone https://github.com/iamrealvinnu/SentenceSimilarityExample.git
   ```

2. **Open the Solution**
   - Launch Visual Studio 2022
   - Open `SentenceSimilarityExample.sln`

3. **Build and Run**
   - Build the solution (Ctrl + Shift + B)
   - Run the project (F5)

## 💡 Usage Example

// Create ML model

MLModel1.ModelInput sampleData = new MLModel1.ModelInput()

{

    Sentence1 = "First sentence to compare",
    
    Sentence2 = "Second sentence to compare"
    
};

// Make prediction

var result = MLModel1.Predict(sampleData);

## 📚 References
- [Sentence Similarity ML.NET Model Builder](https://devblogs.microsoft.com/dotnet/sentence-similarity-mlnet-model-builder/)
- [ML.NET Documentation](https://learn.microsoft.com/en-us/dotnet/machine-learning/)

## 📝 License
This project is licensed under the MIT License - see the LICENSE file for details.

## 🤝 Contributing
Contributions, issues, and feature requests are welcome! Feel free to check [issues page](https://github.com/iamrealvinnu/SentenceSimilarityExample/issues).

---
Developed using ML.NET
