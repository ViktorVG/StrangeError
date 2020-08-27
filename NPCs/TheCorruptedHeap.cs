using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace TheCorruptedHeap.NPCs
{
    public class MilimorgMod : ModNPC
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The corrupted heap");

            Main.npcFrameCount[npc.type] = 3;
        }


        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 30;
            npc.lifeMax = 70;
            npc.damage = 32;
            npc.defense = 5;
            npc.HitSound = SoundID.NPCHit19;
            npc.DeathSound = SoundID.NPCDeath12;
            aiType = NPCID.Zombie;
            animationType = NPCID.Zombie;
            npc.value = 10f;
            npc.knockBackResist = 1f;
            npc.aiStyle = 3;
            banner = Item.NPCtoBanner(NPCID.Crawdad);
            bannerItem = Item.BannerToItem(banner);
            
        }


        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {

            return 0.70f;
        }
        
        public override void NPCLoot()
        {
            Item.NewItem(npc.position, ItemID.RottenChunk, 2);



        }

    }




}