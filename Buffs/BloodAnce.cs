using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace MilimorgMod.Buffs
{
    public class BloodAnce : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blood Ance");
            Description.SetDefault("You were poisoned! Your skin starts to decompose faster because of strange pimples!");
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen -= 7;
            Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("CryDust"));
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 10;
            player.meleeDamage -= 0.10f;
            Dust.NewDust(player.position, player.width, player.height, mod.DustType("CryDust"));


        }

    }
}