using UnityEngine;

[CreateAssetMenu(fileName = "FruitsSO", menuName = "Fruit/Fruit Type")]
public class FruitsSO : ScriptableObject
{
    public string fruitName;
    public Sprite fruitSprite;
    public float fruitSize;
    public GameObject fruitPrefab;
    public Color fruitColor;
}
