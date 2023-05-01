using Newtonsoft.Json;

namespace DotaPredictor.DataBuilder.Models;

public class HeroResponse
{
    [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; } = "";

        [JsonProperty("primary_attr")]
        public string? PrimaryAttr { get; set; }

        [JsonProperty("attack_type")]
        public string? AttackType { get; set; }

        [JsonProperty("roles")]
        public List<string>? Roles { get; set; }

        [JsonProperty("img")]
        public string? Img { get; set; }

        [JsonProperty("icon")]
        public string? Icon { get; set; }

        [JsonProperty("base_health")]
        public int? BaseHealth { get; set; }

        [JsonProperty("base_health_regen")]
        public double? BaseHealthRegen { get; set; }

        [JsonProperty("base_mana")]
        public int? BaseMana { get; set; }

        [JsonProperty("base_mana_regen")]
        public double? BaseManaRegen { get; set; }

        [JsonProperty("base_armor")]
        public double? BaseArmor { get; set; }

        [JsonProperty("base_mr")]
        public int? BaseMr { get; set; }

        [JsonProperty("base_attack_min")]
        public int? BaseAttackMin { get; set; }

        [JsonProperty("base_attack_max")]
        public int? BaseAttackMax { get; set; }

        [JsonProperty("base_str")]
        public int? BaseStr { get; set; }

        [JsonProperty("base_agi")]
        public int? BaseAgi { get; set; }

        [JsonProperty("base_int")]
        public int? BaseInt { get; set; }

        [JsonProperty("str_gain")]
        public double? StrGain { get; set; }

        [JsonProperty("agi_gain")]
        public double? AgiGain { get; set; }

        [JsonProperty("int_gain")]
        public double? IntGain { get; set; }

        [JsonProperty("attack_range")]
        public int? AttackRange { get; set; }

        [JsonProperty("projectile_speed")]
        public int? ProjectileSpeed { get; set; }

        [JsonProperty("attack_rate")]
        public double? AttackRate { get; set; }

        [JsonProperty("base_attack_time")]
        public int? BaseAttackTime { get; set; }

        [JsonProperty("attack_point")]
        public double? AttackPoint { get; set; }

        [JsonProperty("move_speed")]
        public int? MoveSpeed { get; set; }

        [JsonProperty("turn_rate")]
        public double? TurnRate { get; set; }

        [JsonProperty("cm_enabled")]
        public bool? CmEnabled { get; set; }

        [JsonProperty("legs")]
        public int? Legs { get; set; }

        [JsonProperty("day_vision")]
        public int? DayVision { get; set; }

        [JsonProperty("night_vision")]
        public int? NightVision { get; set; }

        [JsonProperty("hero_id")]
        public int? HeroId { get; set; }

        [JsonProperty("turbo_picks")]
        public int? TurboPicks { get; set; }

        [JsonProperty("turbo_wins")]
        public int? TurboWins { get; set; }

        [JsonProperty("pro_ban")]
        public int? ProBan { get; set; }

        [JsonProperty("pro_win")]
        public int? ProWin { get; set; }

        [JsonProperty("pro_pick")]
        public int? ProPick { get; set; }

        [JsonProperty("1_pick")]
        public int? _1Pick { get; set; }

        [JsonProperty("1_win")]
        public int? _1Win { get; set; }

        [JsonProperty("2_pick")]
        public int? _2Pick { get; set; }

        [JsonProperty("2_win")]
        public int? _2Win { get; set; }

        [JsonProperty("3_pick")]
        public int? _3Pick { get; set; }

        [JsonProperty("3_win")]
        public int? _3Win { get; set; }

        [JsonProperty("4_pick")]
        public int? _4Pick { get; set; }

        [JsonProperty("4_win")]
        public int? _4Win { get; set; }

        [JsonProperty("5_pick")]
        public int? _5Pick { get; set; }

        [JsonProperty("5_win")]
        public int? _5Win { get; set; }

        [JsonProperty("6_pick")]
        public int? _6Pick { get; set; }

        [JsonProperty("6_win")]
        public int? _6Win { get; set; }

        [JsonProperty("7_pick")]
        public int? _7Pick { get; set; }

        [JsonProperty("7_win")]
        public int? _7Win { get; set; }

        [JsonProperty("8_pick")]
        public int? _8Pick { get; set; }

        [JsonProperty("8_win")]
        public int? _8Win { get; set; }

        [JsonProperty("null_pick")]
        public int? NullPick { get; set; }

        [JsonProperty("null_win")]
        public int? NullWin { get; set; }
}
