using System;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField] Transform outputWirePointTransform;
    [SerializeField] Transform inputWirePointTransfrom;
    private WirePoint outputWirePoint;
    private WirePoint inputWirePoint;

    public static float voltage = 0;
    public static float equivalentResistance;

    public static HashSet<int> completeCircuitComponents = new HashSet<int>();
    private static Dictionary<int, Transform> idToTransform = new Dictionary<int, Transform>();

    void Start()
    {
        outputWirePoint = outputWirePointTransform.GetComponent<WirePoint>();
        inputWirePoint = inputWirePointTransfrom.GetComponent<WirePoint>();

        voltage = outputWirePoint.wirePointVoltage;
    }

    void Update()
    {
        completeCircuitComponents = new HashSet<int>();
        idToTransform.Clear();

        HashSet<int> visited = new HashSet<int>();
        getCompletedCircuitComponents(outputWirePointTransform, inputWirePointTransfrom, visited);

        if (completeCircuitComponents.Contains(outputWirePointTransform.GetInstanceID()))
        {
            HashSet<int> visited1 = new HashSet<int>();
            float resultantResistance = getEquivalentResistance(outputWirePointTransform, inputWirePointTransfrom, visited1, 0);
            equivalentResistance = resultantResistance;
        }
        else
        {
            equivalentResistance = float.PositiveInfinity;
        }

        outputWirePoint.wirePointCurrent = outputWirePoint.wirePointVoltage / equivalentResistance;
    }

    float getEquivalentResistance(Transform ithNode, Transform target, HashSet<int> visited, float resistanceSoFar)
    {
        int ithID = ithNode.GetInstanceID();
        int targetID = target.GetInstanceID();
        idToTransform[ithID] = ithNode;
        idToTransform[targetID] = target;

        if (ithID == targetID)
        {
            return resistanceSoFar + ithNode.GetComponent<WirePoint>().wirePointResistance;
        }

        if (visited.Contains(ithID)) return float.PositiveInfinity;
        visited.Add(ithID);

        WirePoint wirePoint = ithNode.GetComponent<WirePoint>();
        resistanceSoFar += wirePoint.wirePointResistance;

        if (wirePoint.preLinked)
        {
            return getEquivalentResistance(wirePoint.nextPreLinkedConnection, target, visited, resistanceSoFar);
        }

        if (ithNode.transform.parent.name.StartsWith("TwoWayWire"))
        {
            var result = BFS(ithNode);
            return getEquivalentResistance(result.Item1, target, visited, resistanceSoFar + result.Item2);
        }

        return getEquivalentResistance(wirePoint.GetFirstConnection(), target, visited, resistanceSoFar);
    }

    public static Tuple<Transform, float> BFS(Transform doubleChildedRoot)
    {
        int rootID = doubleChildedRoot.GetInstanceID();
        idToTransform[rootID] = doubleChildedRoot;

        float[] resistances = new float[2];
        var bfsQueue = new Queue<Tuple<Transform, int>>();
        WirePoint rootWire = doubleChildedRoot.GetComponent<WirePoint>();
        List<Transform> nextConnections = rootWire.GetAllConnections() ?? new List<Transform>();

        if (nextConnections.Count == 1)
            return Tuple.Create(nextConnections[0], 0f);

        if (nextConnections.Count > 1)
        {
            foreach (var conn in nextConnections)
                idToTransform[conn.GetInstanceID()] = conn;

            if (completeCircuitComponents.Contains(nextConnections[0].GetInstanceID()))
                bfsQueue.Enqueue(Tuple.Create(nextConnections[0], 0));
            else
                return Tuple.Create(nextConnections[1], 0f);

            if (completeCircuitComponents.Contains(nextConnections[1].GetInstanceID()))
                bfsQueue.Enqueue(Tuple.Create(nextConnections[1], 1));
            else
                return Tuple.Create(nextConnections[0], 0f);
        }

        HashSet<int> visited = new HashSet<int> { rootID };

        while (bfsQueue.Count > 0)
        {
            var (node, resistanceIdx) = bfsQueue.Dequeue();
            int nodeID = node.GetInstanceID();
            idToTransform[nodeID] = node;

            if (visited.Contains(nodeID))
            {
                float r0 = resistances[0], r1 = resistances[1];
                float equivalent = (r0 * r1) / (r0 + r1);
                return Tuple.Create(node, equivalent);
            }

            visited.Add(nodeID);
            WirePoint nodeWire = node.GetComponent<WirePoint>();

            resistances[resistanceIdx] += nodeWire.wirePointResistance;

            Transform next = nodeWire.preLinked
                ? nodeWire.nextPreLinkedConnection
                : nodeWire.GetFirstConnection();

            if (next != null)
            {
                idToTransform[next.GetInstanceID()] = next;
                bfsQueue.Enqueue(Tuple.Create(next, resistanceIdx));
            }
        }

        return Tuple.Create(nextConnections[0], 0f);
    }

    void getCompletedCircuitComponents(Transform ithNode, Transform target, HashSet<int> visited)
    {
        int ithID = ithNode.GetInstanceID();
        int targetID = target.GetInstanceID();
        idToTransform[ithID] = ithNode;
        idToTransform[targetID] = target;

        if (ithID == targetID)
        {
            visited.Add(targetID);
            completeCircuitComponents.UnionWith(visited);
            return;
        }

        if (visited.Contains(ithID) || ithNode == null)
            return;

        visited.Add(ithID);
        WirePoint wirePoint = ithNode.GetComponent<WirePoint>();

        if (wirePoint.preLinked)
        {
            getCompletedCircuitComponents(wirePoint.nextPreLinkedConnection, target, visited);
        }
        else if (ithNode.transform.parent.name.StartsWith("TwoWayWire"))
        {
            foreach (Transform next in wirePoint.GetAllConnections())
            {
                if (next == null) continue;
                HashSet<int> visitedCopy = new HashSet<int>(visited);
                idToTransform[next.GetInstanceID()] = next;
                getCompletedCircuitComponents(next, target, visitedCopy);
            }
        }
        else
        {
            Transform next = wirePoint.GetFirstConnection();
            if (next != null)
            {
                idToTransform[next.GetInstanceID()] = next;
                getCompletedCircuitComponents(next, target, visited);
            }
        }
    }

    // Optional access method for other scripts (like Bulb.cs)
    public static bool IsTransformInCompleteCircuit(Transform t)
    {
        return completeCircuitComponents.Contains(t.GetInstanceID());
    }
}