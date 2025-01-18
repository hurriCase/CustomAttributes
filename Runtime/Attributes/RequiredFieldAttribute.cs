using System;
using UnityEngine;

namespace CustomAttributes.Runtime.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class RequiredFieldAttribute : PropertyAttribute { }
}