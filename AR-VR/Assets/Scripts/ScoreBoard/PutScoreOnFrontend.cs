using System.IO;
using TMPro;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class PutScoreOnFrontend : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;

    private string fileName1 = "experiment_one_time.txt";
    private string fileName2 = "experiment_two_time.txt";

    void Start()
    {
        DisplayScoresFromFiles();
    }

    /// <summary>
    /// Reads the saved experiment times and updates the UI text
    /// </summary>
    public void DisplayScoresFromFiles()
    {
        string filePath1 = Path.Combine(UnityEngine.Application.persistentDataPath, fileName1);
        string filePath2 = Path.Combine(UnityEngine.Application.persistentDataPath, fileName2);

        string content1 = File.Exists(filePath1) ? File.ReadAllText(filePath1) : "No score recorded";
        string content2 = File.Exists(filePath2) ? File.ReadAllText(filePath2) : "No score recorded";

        // Display both scores in the TextMeshProUGUI
        scoreText.text = $"Experiment 1: {content1}\nExperiment 2: {content2}";
    }
}
