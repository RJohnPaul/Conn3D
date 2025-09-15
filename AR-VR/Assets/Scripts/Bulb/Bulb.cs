using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Bulb : MonoBehaviour
{
    [SerializeField] private GameObject bulbGameObject;

    private Material bulbMaterial; // Reference to the Light component

    private WirePoint inputWirePoint; // WirePoint Class object of input wire point
    private WirePoint outputWirePoint; // WirePoint Class object of output wire point

    [SerializeField] private Transform inputWirePointTransform;
    [SerializeField] private Transform outputWirePointTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Material[] materials = bulbGameObject.GetComponentInChildren<Renderer>().materials;

        for(int i = 0; i < materials.Length; i++)
        {
            Debug.Log($"{materials[i].name}, {i}");
        }

        bulbMaterial = materials[0];

        bulbMaterial.EnableKeyword("_EMISSION");

        // Instantiate both objects based on hierarchial order
        inputWirePoint = inputWirePointTransform.GetComponent<WirePoint>();
        outputWirePoint = outputWirePointTransform.GetComponent<WirePoint>();
    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(inputWirePoint.wirePointVoltage);

        HashSet<Transform> visited = new HashSet<Transform>();

        if (inputWirePoint.wirePointVoltage != -1 && Battery.completeCircuitComponents.Contains(outputWirePointTransform.GetInstanceID()))
        {
            // Debug.Log(Battery.completeCircuitComponents.Contains(outputWirePointTransform.GetInstanceID()));
            TurnOnLight();
        }
        else
        {
            // Debug.Log(Battery.completeCircuitComponents.Contains(outputWirePointTransform.GetInstanceID()));
            TurnOffLight();
        }

        outputWirePoint.wirePointVoltage = inputWirePoint.wirePointVoltage;
        outputWirePoint.wirePointCurrent = inputWirePoint.wirePointCurrent;
    }

    void TurnOnLight()
    {
        bulbMaterial.EnableKeyword("_EMISSION");
        bulbMaterial.color = Color.yellow;
    }

    void TurnOffLight()
    {
        bulbMaterial.DisableKeyword("_EMISSION");
        bulbMaterial.color = Color.white;
    }
}
