using UnityEngine;
using UnityEngine.Events;

public class Fruit : MonoBehaviour
{
    public FruitsSO fruitType; // The current fruit type of this GameObject.
    public UnityEvent onMerged; // Unity Event to trigger when the fruit merges.
    private bool hasMerged = false; // Track if this fruit has already merged.
    private Renderer Fruitrenderer;
    
    private void Start()
    {
        Fruitrenderer = GetComponent<Renderer>();
        Fruitrenderer.material.color = fruitType.fruitColor; // Assign the color based on the fruit type.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasMerged) // If this fruit has already merged, return to prevent additional merging.
            return;

        Fruit otherFruit = other.GetComponent<Fruit>();

        if (otherFruit != null && otherFruit.fruitType == fruitType)
        {
            MergingRuleSO mergingRule = MergingManager.Instance.GetMergingRule(fruitType, otherFruit.fruitType);

            if (mergingRule != null)
            {
                MergeWith(otherFruit, mergingRule);
            }
        }
    }

    private void MergeWith(Fruit otherFruit, MergingRuleSO mergingRule)
    {
        // Instantiate a new fruit of the merged type.
        GameObject mergedFruitPrefab = mergingRule.mergedFruitType.fruitPrefab;
        Vector3 mergedPosition = (transform.position + otherFruit.transform.position) / 2f;
        GameObject newMergedFruit = Instantiate(mergedFruitPrefab, mergedPosition, Quaternion.identity);

        // Disable the rigidbodies of the original fruits to stop them from falling.
        Rigidbody thisRigidbody = GetComponent<Rigidbody>();
        thisRigidbody.isKinematic = true;
        Rigidbody otherRigidbody = otherFruit.GetComponent<Rigidbody>();
        otherRigidbody.isKinematic = true;

        // Mark both fruits as merged to prevent further merging.
        hasMerged = true;
        otherFruit.hasMerged = true;

        // Destroy the original fruits.
        Destroy(gameObject);
        Destroy(otherFruit.gameObject);

        onMerged.Invoke(); // Trigger Unity Event when merged.
    }
}