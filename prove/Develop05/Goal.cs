using System;

[Serializable]
public class Goal
{
    public string _goalName;
    public int _goalType;
    public int _goalDuration;
    public int _goalProgress;
    public bool _complete;
    public int _scoreGain;
    public int _incrementBonus;
    public int _score;

    public void IsComplete()
    {
        if (_goalProgress == _goalDuration)
        {
            _complete = true;
        }
        else
        {
            _complete = false;
        }
    }
    
}