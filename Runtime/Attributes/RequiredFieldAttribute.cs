using System;
using UnityEngine;

namespace CustomAttributes.Runtime.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal sealed class RequiredFieldAttribute : PropertyAttribute { }
}