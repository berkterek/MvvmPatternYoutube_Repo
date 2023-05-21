using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy",menuName = "Terek Gaming/Enemy Data")]
public class EnemySO : ScriptableObject
{
    [SerializeField] int _levelValue = 1;
    [SerializeField] int _scoreValue = 0;
    
    void OnEnable()
    {
        _levelValue = 1;
        _scoreValue = 0;
    }

    public int LevelValue
    {
        get => _levelValue;
        set => _levelValue = value;
    }

    public int ScoreValue
    {
        get => _scoreValue;
        set => _scoreValue = value;
    } 
}