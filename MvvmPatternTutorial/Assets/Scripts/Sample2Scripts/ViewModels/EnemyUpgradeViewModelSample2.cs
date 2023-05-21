using UnityEngine;

public class EnemyUpgradeViewModelSample2 : MonoBehaviour,IUpgradeViewModelSample2
{
    [SerializeField] EnemyModelSample2 _model;

    public string TitleName => _model.EnemySo.name;
    public int LevelValue => _model.EnemySo.LevelValue;
    public int ScoreValue => _model.EnemySo.ScoreValue;
    
    public string LevelIncrease()
    {
        _model.EnemySo.LevelValue++;
        return _model.EnemySo.LevelValue.ToString();
    }

    public string ScoreIncrease()
    {
        _model.EnemySo.ScoreValue++;
        return _model.EnemySo.ScoreValue.ToString();
    }
}