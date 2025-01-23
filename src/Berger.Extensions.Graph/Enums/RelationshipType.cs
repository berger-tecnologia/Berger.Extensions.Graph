namespace Berger.Extensions.Graph
{
    public enum RelationshipType
    {
        Owns = 1,
        Uses = 2,
        PartOf = 3,
        LinksTo = 4,
        Manages = 5,
        BacksUp = 6,
        Triggers = 7,
        Monitors = 8,
        Supports = 9,
        Contains = 10,
        Consumes = 11,
        DependsOn = 12,
        References = 13,
        RequiredBy = 14,
        BelongsTo = 15,
        ConnectsTo = 16,
        Implements = 17,
        MigratesTo = 18,
        UpgradesTo = 19,
        CompatibleWith = 20
    }
}