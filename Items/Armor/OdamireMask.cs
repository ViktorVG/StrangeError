using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]

    public class OdamireMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odamire mask"); //название объекта в игре
            Tooltip.SetDefault("The feather was found on the ground and repainted in ruby color");
            

        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.value = Item.sellPrice(silver: 30, copper: 5);
            item.rare = 2;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OdamireBreastplate") && legs.type == mod.ItemType("OdamireLeggings");


        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% don't lose ammunition";
            player.AddBuff(BuffID.AmmoReservation, 1);


        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "OdamireOre", 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

    }

}