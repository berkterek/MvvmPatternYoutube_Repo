using UnityEngine;

public class PlayerUpgradeViewModelSample2 : MonoBehaviour,IUpgradeViewModelSample2
{
    [SerializeField] PlayerModelSample2 _model;
    
    public string TitleName => _model.PlayerSo.name;
    public int LevelValue => _model.PlayerSo.LevelValue;
    public int ScoreValue => _model.PlayerSo.ScoreValue;
    
    public string LevelIncrease()
    {
        _model.PlayerSo.LevelValue++;
        return _model.PlayerSo.LevelValue.ToString();
    }

    public string ScoreIncrease()
    {
        _model.PlayerSo.ScoreValue++;
        return _model.PlayerSo.ScoreValue.ToString();
    }
}

public interface IUpgradeViewModelSample2
{
    string TitleName { get; }
    int LevelValue { get; }
    int ScoreValue { get; }

    string LevelIncrease();
    string ScoreIncrease();
}
