using System.Collections.Generic;
using System.Media;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]

    public class OdamireLeggings : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odamire leggings"); //название объекта в игре
            Tooltip.SetDefault("Your legs are protected by the power of odamire!" +
                "+5% increased movement speed");
            
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(silver: 22, copper: 5);
            item.width = 22;
            item.height = 18;
            item.rare = 2;
            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "OdamireOre", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }







    }




}