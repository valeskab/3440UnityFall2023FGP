using UnityEngine;

[CreateAssetMenu(menuName = "ScoreSO")]
public class ScoreSO : ScriptableObject
{
    public string fruitName; // Name of the fruit.
    public int scoreValue; // Score value for this fruit type.
}