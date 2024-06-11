using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedesk_Console.Models
{
    public partial class AllPokemons
    {
        public long? count { get; set; }
        public object? next { get; set; }
        public object? previous { get; set; }
        public Result[]? results { get; set; }
    }

    public partial class Result
    {
        public string? name { get; set; }
        public Uri? url { get; set; }
    }
    public  class Pokemon
    {
        public Ability[]? abilities { get; set; }
        public long? base_experience { get; set; }
        public Cries? cries { get; set; }
        public Species[]? forms { get; set; }
        public GameIndex[]? game_indices { get; set; }
        public long? height { get; set; }
        public object[]? held_items { get; set; }
        public long? id { get; set; }
        public bool? is_default { get; set; }
        public Uri? location_area_encounters { get; set; }
        public Move[]? moves { get; set; }
        public string? name { get; set; }
        public long? order { get; set; }
        public object[]? past_abilities { get; set; }
        public object[]? past_types { get; set; }
        public Species? species { get; set; }
        public Sprites? sprites { get; set; }
        public Stat[]? stats { get; set; }
        public TypeElement[]? types { get; set; }
        public long? weight { get; set; }
    }

    public  class Ability
    {
        public Species? ability { get; set; }
        public bool? is_hidden { get; set; }
        public long? slot { get; set; }
    }

    public  class Species
    {
        public string? name { get; set; }
        public Uri? url { get; set; }
    }

    public  class Cries
    {
        public Uri? latest { get; set; }
        public Uri? legacy { get; set; }
    }

    public  class GameIndex
    {
        public long? game_index { get; set; }
        public Species? version { get; set; }
    }

    public  class Move
    {
        public Species? move { get; set; }
        public VersionGroupDetail[]? version_group_details { get; set; }
    }

    public  class VersionGroupDetail
    {
        public long? level_learned_at { get; set; }
        public Species? move_learn_method { get; set; }
        public Species? version_group { get; set; }
    }

    public  class GenerationV
    {
        public Sprites? blackwhite { get; set; }
    }

    public  class GenerationIv
    {
        public Sprites? diamondpearl { get; set; }
        public Sprites? heartgoldsoulsilver { get; set; }
        public Sprites? platinum { get; set; }
    }

    public  class Versions
    {
        public GenerationI? generationi { get; set; }
        public GenerationIi? generationii { get; set; }
        public GenerationIii? generationiii { get; set; }
        public GenerationIv? generationiv { get; set; }
        public GenerationV? generationv { get; set; }
        public Dictionary<string, Home>? generationvi { get; set; }
        public GenerationVii? generationvii { get; set; }
        public GenerationViii? generationviii { get; set; }
    }

    public  class Other
    {
        public DreamWorld? dream_world { get; set; }
        public Home? home { get; set; }
        public OfficialArtwork? officialartwork { get; set; }
        public Sprites? showdown { get; set; }
    }

    public  class Sprites
    {
        public Uri? back_default { get; set; }
        public object? back_female { get; set; }
        public Uri? back_shiny { get; set; }
        public object? back_shiny_female { get; set; }
        public Uri? front_default { get; set; }
        public object? front_female { get; set; }
        public Uri? front_shiny { get; set; }
        public object? front_shiny_female { get; set; }
        public Other? other { get; set; }
        public Versions? versions { get; set; }
        public Sprites? animated { get; set; }
    }

    public  class GenerationI
    {
        public RedBlue? redblue { get; set; }
        public RedBlue? yellow { get; set; }
    }

    public  class RedBlue
    {
        public Uri? back_default { get; set; }
        public Uri? back_gray { get; set; }
        public Uri? back_transparent { get; set; }
        public Uri? front_default { get; set; }
        public Uri? front_gray { get; set; }
        public Uri? front_transparent { get; set; }
    }

    public  class GenerationIi
    {
        public Crystal? crystal { get; set; }
        public Gold? gold { get; set; }
        public Gold? silver { get; set; }
    }

    public  class Crystal
    {
        public Uri? back_default { get; set; }
        public Uri? back_shiny { get; set; }
        public Uri? back_shiny_transparent { get; set; }
        public Uri? back_transparent { get; set; }
        public Uri? front_default { get; set; }
        public Uri? front_shiny { get; set; }
        public Uri? front_shiny_transparent { get; set; }
        public Uri? front_transparent { get; set; }
    }

    public  class Gold
    {
        public Uri? back_default { get; set; }
        public Uri? back_shiny { get; set; }
        public Uri? front_default { get; set; }
        public Uri? front_shiny { get; set; }
        public Uri? front_transparent { get; set; }
    }

    public  class GenerationIii
    {
        public OfficialArtwork? emerald { get; set; }
        public Gold? fireredleafgreen { get; set; }
        public Gold? rubysapphire { get; set; }
    }

    public  class OfficialArtwork
    {
        public Uri? front_default { get; set; }
        public Uri? front_shiny { get; set; }
    }

    public  class Home
    {
        public Uri? front_default { get; set; }
        public object? front_female { get; set; }
        public Uri? front_shiny { get; set; }
        public object? front_shiny_female { get; set; }
    }

    public  class GenerationVii
    {
        public DreamWorld? icons { get; set; }
        public Home? ultrasunultramoon { get; set; }
    }

    public  class DreamWorld
    {
        public Uri? front_default { get; set; }
        public object? front_female { get; set; }
    }

    public  class GenerationViii
    {
        public DreamWorld? icons { get; set; }
    }

    public  class Stat
    {
        public long? base_stat { get; set; }
        public long? effort { get; set; }
        public Species? stat { get; set; }
    }

    public  class TypeElement
    {
        public long? slot { get; set; }
        public Species? type { get; set; }
    }


}
