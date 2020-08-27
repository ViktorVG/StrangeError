using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace MilimorgMod.Buffs
{
    public class ChaosFire : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Chaos Fire");
            Description.SetDefault("You are so saturated with chaos that it even begins to tear your body apart!");
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen -= 7;
            Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("ChaosDust"));
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 10;
            player.meleeDamage -= 0.10f;
            Dust.NewDust(player.position, player.width, player.height, mod.DustType("ChaosDust"));


        }

    }
}