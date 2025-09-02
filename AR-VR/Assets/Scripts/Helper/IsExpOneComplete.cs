using UnityEngine;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

public class IsExpOneComplete : MonoBehaviour
{
    bool result = false;

    [SerializeField] private Transform batteryOutputSocketTransform;
    [SerializeField] private Transform batteryInputSocketTransform;
    private WirePoint batteryOutputSocketWirePoint;
    private WirePoint batteryInputSocketWirePoint;

    [SerializeField] private Transform bulbInputSocketTransform;
    [SerializeField] private Transform bulbOutputSocketTransform;
    private WirePoint bulbInputSocketWirePoint;
    private WirePoint bulbOutputSocketWirePoint;

    [SerializeField] private Transform rightSwitchInputSocketTransform;
    [SerializeField] private Transform rightSwitchUpOutputSocketTransform;
    [SerializeField] private Transform rightSwitchDownOutputSocketTransform;
    private WirePoint rightSwitchInputSocketWirePoint;
    private WirePoint rightSwitchUpOutputSocketWirePoint;
    private WirePoint rightSwitchDownOutputSocketWirePoint;

    [SerializeField] private Transform leftSwitchUpInputSocketTransform;
    [SerializeField] private Transform leftSwitchDownInputSocketTransform;
    [SerializeField] private Transform leftSwitchOutputSocketTransform;
    private WirePoint leftSwitchUpInputSocketWirePoint;
    private WirePoint leftSwitchDownInputSocketWirePoint;
    private WirePoint leftSwitchOutputSocketWirePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Battery
        batteryInputSocketWirePoint = batteryInputSocketTransform.GetComponent<WirePoint>();
        batteryOutputSocketWirePoint = batteryOutputSocketTransform.GetComponent<WirePoint>();

        // Bulb
        bulbInputSocketWirePoint = bulbInputSocketTransform.GetComponent<WirePoint>();
        bulbOutputSocketWirePoint = bulbOutputSocketTransform.GetComponent<WirePoint>();

        // Right switch
        rightSwitchInputSocketWirePoint = rightSwitchInputSocketTransform.GetComponent<WirePoint>();
        rightSwitchUpOutputSocketWirePoint = rightSwitchUpOutputSocketTransform.GetComponent<WirePoint>();
        rightSwitchDownOutputSocketWirePoint = rightSwitchDownOutputSocketTransform.GetComponent<WirePoint>();

        // Left switch
        leftSwitchUpInputSocketWirePoint = leftSwitchUpInputSocketTransform.GetComponent<WirePoint>();
        leftSwitchDownInputSocketWirePoint = leftSwitchDownInputSocketTransform.GetComponent<WirePoint>();
        leftSwitchOutputSocketWirePoint = leftSwitchOutputSocketTransform.GetComponent<WirePoint>();
    }

    // Update is called once per frame
    void Update()
    {

        result = batteryOutputSocketWirePoint.HasConnection(bulbInputSocketTransform) &&
                 bulbOutputSocketWirePoint.HasConnection(rightSwitchInputSocketTransform) &&
                 rightSwitchUpOutputSocketWirePoint.HasConnection(leftSwitchUpInputSocketTransform) &&
                 rightSwitchDownOutputSocketWirePoint.HasConnection(leftSwitchDownInputSocketTransform) &&
                 leftSwitchOutputSocketWirePoint.HasConnection(batteryInputSocketTransform);
        
        if (result)
        {
            PlaceOnPlane.stopwatchRunning = false;
            SaveTimeToFile(PlaceOnPlane.stopwatchTime);
        }

    }

    private void SaveTimeToFile(float timeTaken)
    {
        string path = Path.Combine(UnityEngine.Application.persistentDataPath, "experiment_one_time.txt");
        string content = timeTaken.ToString("F2");

        File.WriteAllText(path, content);

        Debug.Log("Time saved at: " + path);
    }
}
