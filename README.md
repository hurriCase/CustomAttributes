# Unity Custom Attributes Package

Custom attributes for Unity Inspector to improve field validation and display.

## Attributes

### InspectorReadOnly
Makes a field visible but not editable in the Inspector:

```csharp
public class PlayerStats : MonoBehaviour 
{
    [InspectorReadOnly] 
    public int currentLevel;  // Visible but can't be changed in Inspector
}
```

Use when you want to:
- Show runtime values in Inspector
- Prevent accidental editing of fields
- Display calculated values

### RequiredField
Marks fields that must be assigned in the Inspector:

```csharp
public class WeaponController : MonoBehaviour 
{
    [RequiredField] 
    private AudioSource audioSource;  // Shows error if not assigned

    [RequiredField]
    private GameObject[] waypoints;   // Shows error if array is empty
}
```

Features:
- Shows error message in Inspector for null references
- Shows error message for empty arrays
- Runtime validation on scene load
- Links error messages to specific components

## Runtime Validation

The RequiredFieldsValidator automatically checks all required fields when the scene loads:

```
Error: Field audioSource is required. (UnityEngine.MonoBehaviour)
```

This helps catch missing references before they cause runtime errors.

## Editor Integration

Both attributes are fully integrated with Unity's Inspector window and provide:
- Custom property drawers
- Error messages in Inspector
- Runtime validation warnings
- Support for arrays and object references

## Best Practices

1. Use RequiredField for dependencies:
```csharp
public class Gun : MonoBehaviour 
{
    [RequiredField]
    private ParticleSystem muzzleFlash;  // Core component
    
    public float damage = 10f;           // Optional value
}
```

2. Use InspectorReadOnly for debug values:
```csharp
public class PlayerHealth : MonoBehaviour 
{
    [InspectorReadOnly]
    public float currentHealth;  // Show but don't edit
    
    public float maxHealth = 100f;  // Configurable
}
```

3. Check console on scene load for required field warnings

4. Consider using RequiredField for:
- References to other components
- Essential GameObjects
- Required ScriptableObjects
- Core prefab references

5. Consider using InspectorReadOnly for:
- Runtime state
- Calculated values
- Debug information
- Generated IDs or keys