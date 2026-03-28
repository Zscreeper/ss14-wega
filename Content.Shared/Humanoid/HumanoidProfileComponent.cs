using Content.Shared.Corvax.TTS;
using Content.Shared.Humanoid.Prototypes;
using Content.Shared.Preferences;
using Content.Shared.Speech.Synthesis;
using Robust.Shared.Enums;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Humanoid;

/// <summary>
/// Dictates what species and age this character "looks like"
/// </summary>
[NetworkedComponent, RegisterComponent, AutoGenerateComponentState(true)]
[Access(typeof(HumanoidProfileSystem))]
public sealed partial class HumanoidProfileComponent : Component
{
    [DataField, AutoNetworkedField]
    public Gender Gender;

    [DataField, AutoNetworkedField]
    public Sex Sex;

    [DataField, AutoNetworkedField]
    public int Age = 18;

    [DataField, AutoNetworkedField]
    public ProtoId<SpeciesPrototype> Species = HumanoidCharacterProfile.DefaultSpecies;

    // Corvax-Wega-start
    [DataField, AutoNetworkedField]
    public Status Status = Status.No;

    [DataField, AutoNetworkedField]
    public float Height = 175.0f;

    [DataField("barkvoice")]
    public ProtoId<BarkPrototype> BarkVoice { get; set; } = SharedHumanoidAppearanceSystem.DefaultBarkVoice;
    // Corvax-Wega-end

    // Corvax-TTS-Start
    [DataField("voice")]
    public ProtoId<TTSVoicePrototype> Voice { get; set; } = HumanoidProfileSystem.DefaultVoice;
    // Corvax-TTS-End
}
