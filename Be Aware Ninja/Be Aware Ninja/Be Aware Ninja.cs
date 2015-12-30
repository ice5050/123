using System; using System.Linq; using Ensage; using Ensage.Common; using SharpDX;   namespace Be_Aware_Ninja {     class Be_Aware_Ninja     {         private static Hero me;         private static System.Collections.Generic.List<Ensage.Hero> enemies;         private static SideMessage informationmessage;         static void Main(string[] args)         {             Game.OnUpdate += Tick;             PrintSuccess(string.Format("> Be Aware Loaded!"));         }         public static void Tick(EventArgs args)         {             if (!Game.IsInGame || Game.IsPaused || Game.IsWatchingGame)                 return;             me = ObjectMgr.LocalHero;             if (me == null)                 return;             enemies = ObjectMgr.GetEntities<Hero>().Where(x => me.Team != x.Team   && !x.IsIllusion && x.IsAlive).ToList();             if (enemies == null)                 return;             foreach (var v in enemies)             {                 string index;                 if (v.Modifiers.Any(x => x.Name == "modifier_mirana_moonlight_shadow") && Utils.SleepCheck("mirana")) //mirana                 {                     MessageCreator("mirana", "mirana_invis");
                    Utils.Sleep(1500, "mirana");                 }                 if (v.Modifiers.Any(x => x.Name == "modifier_alchemist_unstable_concoction") && Utils.SleepCheck("alch")) //alch                 {                     MessageCreator("alchemist", "alchemist_unstable_concoction");
                    Utils.Sleep(1500, "alch");                 }                 if (v.Modifiers.Any(x => x.Name == "modifier_morphling_replicate_timer") && Utils.SleepCheck("morph")) //morph                 {                     MessageCreator("morphling", "morphling_replicate");
                    Utils.Sleep(1500, "morph");                 }
                if (v.Modifiers.Any(x => x.Name == "modifier_ember_spirit_fire_remnant") && Utils.SleepCheck("ember")) // emberRe                 {
                    MessageCreator("ember_spirit", "ember_spirit_fire_remnant");
                    Utils.Sleep(1500, "ember");                 }                 if (v.Modifiers.Any(x => x.Name == "modifier_bloodseeker_thirst_speed") && Utils.SleepCheck("bloodseeker")) //bloodseeker                 {                     MessageCreator("bloodseeker", "bloodseeker_thirst");
                    Utils.Sleep(1500, "bloodseeker");                 }
                if (v.Spellbook.SpellR.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_Invoker && Utils.SleepCheck("invoker")) //invoker                 {
                    MessageCreator("invoker", "invoker_sun_strike");
                    Utils.Sleep(1500, "invoker");                 }
              
                               if (v.Modifiers.Any(x => x.Name == "modifier_item_invisibility_edge_windwalk") && Utils.SleepCheck("shadowblade")) //shadow blade                 {                     index = v.Name.Remove(0, 14);                     MessageItemCreator(index, "invis_sword");
                    Utils.Sleep(1000, "shadowblade");                 }                 if (v.Modifiers.Any(x => x.Name == "modifier_item_silver_edge_windwalk") && Utils.SleepCheck("silveredge")) // silver edge                 {                     index = v.Name.Remove(0, 14);                     MessageItemCreator(index, "silver_edge");
                    Utils.Sleep(1000, "silveredge");                 }                 if (v.Modifiers.Any(x => x.Name == "modifier_clinkz_wind_walk") && Utils.SleepCheck("clinkz")) // Clinkz                 {                     MessageCreator("clinkz", "clinkz_wind_walk");
                    Utils.Sleep(5000, "clinkz");                 }                 if (v.Modifiers.Any(x => x.Name == "modifier_teleporting") && v.ClassID == ClassID.CDOTA_Unit_Hero_Wisp && Utils.SleepCheck("wisp")) // IO                 {                     MessageCreator("wisp", "wisp_relocate");
                    Utils.Sleep(1500, "wisp");                 }                 if (v.Modifiers.Any(x => x.Name == "modifier_bounty_hunter_wind_walk") && Utils.SleepCheck("bounty")) // BOUNTY                 {                     MessageCreator("bounty_hunter", "bounty_hunter_wind_walk");
                    Utils.Sleep(1500, "bounty");
                   
                  }                                if (v.Modifiers.Any(x => x.Name == "modifier_nyx_assassin_vendetta") && Utils.SleepCheck("nyx")) // NYX ASSASSIN                 {                     MessageCreator("nyx_assassin", "nyx_assassin_vendetta");
                    Utils.Sleep(1500, "nyx");                 }
                if (v.Modifiers.Any(x => x.Name == "modifier_teleporting") && v.ClassID == ClassID.CDOTA_Unit_Hero_Furion && Utils.SleepCheck("furion")) // furion                 {                     MessageCreator("furion", "furion_teleportation");                     Utils.Sleep(1500, "furion");                 }                 if (v.Spellbook.SpellR.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_Furion && Utils.SleepCheck("Nature Ult")) // furion ULT                 {                     MessageCreator("furion", "nature_wrath_of_nature");                     Utils.Sleep(2300, "Nature Ult");                 }
                if (v.Spellbook.SpellR.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_AncientApparition && Utils.SleepCheck("ancient_apparition")) // aaRE
                {
                    MessageCreator("ancient_apparition", "ancient_apparition_ice_blast_release");
                    Utils.Sleep(1500, "ancient_apparition");
                }
                if (v.Modifiers.Any(x => x.Name == "modifier_spirit_breaker_charge_of_darkness") && Utils.SleepCheck("breaker")) //baraRE
                {
                    MessageCreator("spirit_breaker", "spirit_breaker_charge_of_darkness");
                    Utils.Sleep(1500, "breaker");
                }
                
                if (v.Spellbook.SpellR.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_Sniper && Utils.SleepCheck("sniper")) // snRE
                {
                    MessageCreator("sniper", "sniper_assassinate");
                    Utils.Sleep(4000, "sniper");
                }
                if (v.Spellbook.SpellR.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_Chen && Utils.SleepCheck("chen")) //chenRE
                {
                    MessageCreator("chen", "chen_hand_of_god");
                    Utils.Sleep(1500, "chen");
                }
                if (v.Modifiers.Any(x => x.Name == "modifier_alchemist_chemical_rage") && Utils.SleepCheck("alchemist")) // alchRE
                {
                    MessageCreator("alchemist", "alchemist_chemical_rage");
                    Utils.Sleep(10000, "alchemist");
                }
                if (v.Spellbook.SpellR.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_Enigma && Utils.SleepCheck("enigma")) // enigRE
                {
                    MessageCreator("enigma", "enigma_black_hole");
                    Utils.Sleep(4000, "enigma");
                }
                if (v.Spellbook.SpellW.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_Lina && Utils.SleepCheck("lina")) // linaRE
                {
                    MessageCreator("lina", "lina_light_strike_array");
                    Utils.Sleep(1000, "lina");
                }

             if (v.Spellbook.SpellW.IsInAbilityPhase  && v.ClassID == ClassID.CDOTA_Unit_Hero_Tusk && Utils.SleepCheck("tusk")) // TuskRE
                              {
                  MessageCreator("tusk", "tusk_snowball");
                  Utils.Sleep(1500, "tusk");
               }
          //   if (v.Spellbook.SpellR.IsInAbilityPhase && v.ClassID == ClassID.CDOTA_Unit_Hero_Rubick && Utils.SleepCheck("rubick")) // linaRE
             //{
          //      if(v.Spellbook.SpellD.IsStolen){
                  
             //     v.Spellbook.(x => x.Name == "modifier_teleporting");
            //     M("rubick", x );
              //   Utils.Sleep(1500, "rubick");
               //   }
             }              }                      
       
                 static void MessageCreator(string saitama, string onepunch)         {             informationmessage = new SideMessage("Skills", new Vector2(180, 50));             informationmessage.AddElement(new Vector2(10, 10), new Vector2(54, 30), Drawing.GetTexture("ensage_ui/heroes_horizontal/" + saitama));             informationmessage.AddElement(new Vector2(70, 12), new Vector2(62, 31), Drawing.GetTexture("ensage_ui/other/arrow_usual"));             informationmessage.AddElement(new Vector2(140, 10), new Vector2(30, 30), Drawing.GetTexture("ensage_ui/spellicons/"+onepunch));             informationmessage.CreateMessage();         }         static void MessageItemCreator(string saitama, string punch)         {             informationmessage = new SideMessage("Items", new Vector2(180, 48));             informationmessage.AddElement(new Vector2(006, 06), new Vector2(72, 36), Drawing.GetTexture("ensage_ui/heroes_horizontal/" + saitama));             informationmessage.AddElement(new Vector2(078, 12), new Vector2(64, 32), Drawing.GetTexture("ensage_ui/other/arrow_usual"));             informationmessage.AddElement(new Vector2(142, 06), new Vector2(72, 36), Drawing.GetTexture("ensage_ui/items/" + punch));             informationmessage.CreateMessage();         }         private static void PrintSuccess(string text, params object[] arguments)         {             PrintEncolored(text, ConsoleColor.Green, arguments);         }         private static void PrintEncolored(string text, ConsoleColor color, params object[] arguments)         {             var clr = Console.ForegroundColor;             Console.ForegroundColor = color;             Console.WriteLine(text, arguments);             Console.ForegroundColor = clr;         }     } } 
