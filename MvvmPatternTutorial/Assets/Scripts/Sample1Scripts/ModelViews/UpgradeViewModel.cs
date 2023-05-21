using UnityEngine;

public class UpgradeViewModel : MonoBehaviour
{
    PlayerUpgradeModel _model;

    public string TitleName => _model.TitleName;
    public int LevelValue => _model.LevelValue;
    public int ScoreValue => _model.ScoreValue;
    
    void Awake()
    {
        _model = new PlayerUpgradeModel()
        {
            TitleName = "Player",
            LevelValue = 1,
            ScoreValue = 0
        };
    }

    public string LevelIncrease()
    {
        _model.LevelValue++;
        return _model.LevelValue.ToString();
    }

    public string ScoreIncrease()
    {
        _model.ScoreValue++;
        return _model.ScoreValue.ToString();
    }
}
