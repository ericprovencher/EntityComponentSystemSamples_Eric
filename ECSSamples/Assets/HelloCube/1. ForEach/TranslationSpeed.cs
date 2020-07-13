using Unity.Entities;
using Unity.Mathematics;

// ReSharper disable once InconsistentNaming
[GenerateAuthoringComponent]
public struct TranslationSpeed : IComponentData
{
    public float3 Value;
}