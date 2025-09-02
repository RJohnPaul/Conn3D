using System.IO;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
public class IsExperimentTwoComplete : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void SaveTimeToFile(float timeTaken)
    {
        string path = Path.Combine(UnityEngine.Application.persistentDataPath, "experiment_two_time.txt");
        string content = timeTaken.ToString("F2");

        File.WriteAllText(path, content);

        Debug.Log("Time saved at: " + path);
    }
}
