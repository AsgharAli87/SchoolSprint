using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] // Required for Unity serialization
public class UnitHealth
{
    // Fields
    public int _currenthealth;
    public int _maxhealth;
    public UnityEvent onDied;

    // Properties
    public int Health
    {
        get { return _currenthealth; }
        set
        {
            _currenthealth = Mathf.Clamp(value, 0, _maxhealth); // Ensures health stays in bounds
        }
    }

    public int MaxHealth
    {
        get { return _maxhealth; }
        set
        {
            if (value > 0)
            {
                _maxhealth = value;
                if (_currenthealth > _maxhealth)
                {
                    _currenthealth = _maxhealth; // Adjust current health if max is reduced
                }
            }
        }
    }

    // Constructor
    public UnitHealth(int health, int maxHealth)
    {
        _maxhealth = maxHealth > 0 ? maxHealth : 100; // Ensure maxHealth is positive
        _currenthealth = Mathf.Clamp(health, 0, _maxhealth); // Clamp current health between 0 and maxHealth
    }

    // Methods
    public void Dmgunit(int dmgAmount)
    {
        if (dmgAmount > 0)
        {
            _currenthealth -= dmgAmount; // Reduce health by damage amount
            if (_currenthealth <= 0)
            {
                _currenthealth = 0;
                onDied.Invoke(); // Call the death event
            }
        }

    }


    public void Healunit(int healAmount)
    {
        if (healAmount > 0)
        {
            _currenthealth += healAmount; // Increase health by heal amount
            if (_currenthealth > _maxhealth)
            {
                _currenthealth = _maxhealth; // Cap health at maxHealth
            }
        }
    }
}
