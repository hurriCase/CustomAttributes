using UnityEngine;

namespace CustomAttributes.Runtime.Attributes
{
    /// <summary>
    /// Attribute that makes a field read-only in the Unity Inspector.
    /// Can be applied to any serialized field to prevent editing while still showing the value.
    /// </summary>
    /// <remarks>
    /// Usage: [InspectorReadOnly] private string myField;
    /// </remarks>
    internal sealed class InspectorReadOnlyAttribute : PropertyAttribute { }
}