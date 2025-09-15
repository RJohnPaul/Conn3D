using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;
using UnityEngine.EventSystems;
using TMPro;

/// <summary>
/// For tutorial video, see this YouTube channel: <seealso href="https://www.youtube.com/@xiennastudio">YouTube channel</seealso>
/// How to use this script:
/// - Add ARPlaneManager to XROrigin GameObject.
/// - Add ARRaycastManager to XROrigin GameObject.
/// - Add the <see cref="PressInputBase"/> script to Unity.
/// - Attach this script to XROrigin GameObject.
/// - Add the prefab that will be spawned to the <see cref="placedPrefab"/>
/// - Create a new input system called TouchControls that has the <Pointer>/press as the binding. 
/// 
/// Touch to place the <see cref="placedPrefab"/> object on the touch position.
/// Will only placed the object if the touch position is on detected trackables.
/// Move the existing spawned object on the touch position.
/// Using Unity new input system with the input system created using script <see cref="PressInputBase"/>.
/// </summary>
[HelpURL("https://youtu.be/HkNVp04GOEI")]
[RequireComponent(typeof(ARRaycastManager))]
public class PlaceOnPlane : PressInputBase
{
    [SerializeField] public TextMeshProUGUI placeText;

    public static float xRotation = -90;

    /// <summary>
    /// The prefab that will be instantiated on touch.
    /// </summary>
    [SerializeField]
    [Tooltip("Instantiates this prefab on a plane at the touch location.")]
    GameObject placedPrefab;

    /// <summary>
    /// The instantiated object.
    /// </summary>
    GameObject spawnedObject;

    /// <summary>
    /// If there is prefab is placed.
    /// </summary>
    bool prefabPlaced;

    ARRaycastManager aRRaycastManager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public static Vector3 initialScale = Vector3.one;

    public static float stopwatchTime = 0f;
    public static bool stopwatchRunning = false;

    protected override void Awake()
    {
        base.Awake();
        aRRaycastManager = GetComponent<ARRaycastManager>();
    }

    protected override void OnPress(Vector3 position)
    {
        if (IsPointerOverUIObject()) return;

        if (aRRaycastManager.Raycast(position, hits, TrackableType.PlaneWithinPolygon) && !prefabPlaced)
        {
            var hitPose = hits[0].pose;

            // Keep the prefab's original rotation.
            Quaternion initialRotation = Quaternion.Euler(xRotation, 0f, 0f);

            if (spawnedObject == null)
            {
                // Instantiate the object with its initial rotation.
                spawnedObject = Instantiate(placedPrefab, hitPose.position + new Vector3(0, 0.1f, 0), initialRotation);

                stopwatchTime = 0f;
                stopwatchRunning = true;
                if (placeText != null)
                {
                    placeText.text = "00:00.00";
                }

                // Scale down to 50%.
                spawnedObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                initialScale = spawnedObject.transform.localScale;
            }

            prefabPlaced = true;
        }
    }
    private bool IsPointerOverUIObject()
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };

        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, results);

        return results.Count > 0; // If there's any UI element under the pointer
    }

    private void Update()
    {
        if (stopwatchRunning)
        {
            stopwatchTime += Time.deltaTime;
            UpdateStopwatchUI();
        }
    }

    private void UpdateStopwatchUI()
    {
        if (placeText == null) return;

        int minutes = Mathf.FloorToInt(stopwatchTime / 60f);
        int seconds = Mathf.FloorToInt(stopwatchTime % 60f);
        int millis = Mathf.FloorToInt((stopwatchTime * 100f) % 100f);

        placeText.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, millis);
    }
}
