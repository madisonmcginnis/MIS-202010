﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Beginner.Models
{
    public class PokemonInfo
    {
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public List<Form> forms { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public int height { get; set; }
        public List<HeldItem> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability
    {
        public Ability2 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndice
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionDetail
    {
        public int rarity { get; set; }
        public Version2 version { get; set; }
    }

    public class HeldItem
    {
        public Item item { get; set; }
        public List<VersionDetail> version_details { get; set; }
    }

    public class Move2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
        public VersionGroup version_group { get; set; }
    }

    public class Move
    {
        public Move2 move { get; set; }
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class DreamWorld
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
    }

    public class Other
    {
        public DreamWorld dream_world { get; set; }
        public OfficialArtwork OfficialArtwork { get; set; }
    }

    public class RedBlue
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
    }

    public class Yellow
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
    }

    public class GenerationI
    {
        [JsonProperty("red-blue")]
        public RedBlue RedBlue { get; set; }
        public Yellow Yellow { get; set; }
    }

    public class Crystal
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class Gold
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class Silver
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class GenerationII
    {
        public Crystal Crystal { get; set; }
        public Gold Gold { get; set; }
        public Silver Silver { get; set; }
    }

    public class Emerald
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class FireredLeafgreen
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class RubySaphire
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class GenerationIII
    {
        public Emerald Emerald { get; set; }
        public FireredLeafgreen FireredLeafgreen { get; set; }
        public RubySaphire RubySaphire { get; set; }
    }

    public class DiamondPearl
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class Platinum
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class GenerationIV
    {
        public DiamondPearl DiamondPearl { get; set;}
        public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }
        public Platinum Platinum { get; set; }
    }

    public class Animated
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class BlackWhite
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
        public Animated animated { get; set; }
    }

    public class GenerationV
    {
        public BlackWhite BlackWhite { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class XY
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class GenerationVI
    {
        public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }
        public XY XY { get; set; }
    }

    public class Icons
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
    }

    public class UltraSunUltraMoon
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class GenerationVII
    {
        public Icons Icons { get; set; }
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
    }

    public class Icons2
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
    }

    public class GenerationVIII
    {
        public Icons2 Icons { get; set; }
    }

    public class Versions
    {
        public GenerationI GenerationI { get; set; }
        public GenerationII GenerationII { get; set; }
        public GenerationIII GenerationIII { get; set; }
        public GenerationIV GenerationIV { get; set; }
        public GenerationV GenerationV { get; set; }
        public GenerationVI GenerationVI { get; set; }
        public GenerationVII GenerationVII { get; set; }
        public GenerationVIII GenerationVIII { get; set; }
    }

    public class Sprites
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
        public Other other { get; set; }
        public Versions versions { get; set; }
    }

    public class StatInfo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stats2
    {
        public int base_start { get; set; }
        public int effort { get; set; }
        public StatInfo StatInfo { get; set; }
    }

    public class Stat
    {
        public List<Stats2> Stats { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type2 Types { get; set; }
    }
}